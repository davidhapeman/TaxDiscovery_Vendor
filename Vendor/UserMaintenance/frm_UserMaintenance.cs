using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net.Http;
using System.Net.Http.Headers;

namespace Vendor.UserMaintenance
{
    public partial class frm_UserMaintenance : Form
    {
        string USER_TOKEN = System.Guid.NewGuid().ToString();
        IRModels.clsFunctions irFunctions = new IRModels.clsFunctions();

        public frm_UserMaintenance()
        {
            InitializeComponent();
        }

        #region "Load Resize"
        private void frm_UserMaintenance_Load(object sender, EventArgs e)
        {
            loadList();

            this.panelInfo.Left = this.panelList.Left;
            this.panelInfo.Top = this.panelList.Top;
            this.panelList.BringToFront();
            frm_UserMaintenance_Resize(sender, e);
        }
        private void frm_UserMaintenance_Resize(object sender, EventArgs e)
        {
            this.panelList.Width  = this.Width  - this.panelList.Left - 25;
            this.panelList.Height = this.Height - this.panelList.Top  - 35;
            this.panelInfo.Width  = this.panelList.Width;
            this.panelInfo.Height = this.panelList.Height;
        }
        private void panelList_Resize(object sender, EventArgs e)
        {
            this.dgList.Width = this.panelList.Width - this.dgList.Left - 25;
            this.dgList.Height = this.panelList.Height - this.dgList.Top - 35;
        }
        #endregion

        #region "Processing Functions"
        private void loadSecurityLevels()
        {
        }
        private void resetForm()
        {
            this.lblKeyTaxTrackerUserID.Text = System.Guid.NewGuid().ToString();
            this.lblKeyUserID.Text = System.Guid.NewGuid().ToString();
            this.panelInfo.BackColor = this.BackColor;

            this.btnIFAdd.Visible = false;
            this.btnIFChg.Visible = false;
            this.btnIFDel.Visible = false;

            this.txtAuthor.Text = "";
            this.txtEmail.Text = "";
            this.txtLogin.Text = "";
            this.txtName.Text = "";
            this.txtPhone.Text = "";
            this.txtSecPhone.Text = "";

            this.chkActive.Checked = false;
            this.chkDJ.Checked = false;
            this.chkGuest.Checked = false;
            this.chkTaxTracker.Checked = false;
            this.chkWebMaster.Checked = false;

            this.cboSecurityLevels.SelectedIndex = -1;

            this.rchAddress.Text = "";
        }
        private void loadList()
        {
            DataSet oDS = irFunctions.getUserList(USER_TOKEN);
            this.dgList.AutoGenerateColumns = false;
            this.dgList.DataSource = oDS.Tables[0];
        }
        private void loadUser(string keyTaxTrackerUserID)
        {
            DataSet oDSTTUser = new DataSet();
            DataSet oDSUser = new DataSet();

            this.lblKeyTaxTrackerUserID.Text = keyTaxTrackerUserID;

            oDSTTUser = irFunctions.getTaxTrackerUser(USER_TOKEN, keyTaxTrackerUserID);

            string keyUserID = oDSTTUser.Tables[0].Rows[0]["fkUserID"].ToString();
            this.lblKeyUserID.Text = keyUserID;

            oDSUser = irFunctions.getUser(USER_TOKEN, keyUserID);

            this.txtAuthor.Text = oDSUser.Tables[0].Rows[0]["userStrAuthor"].ToString();
            this.txtEmail.Text = oDSUser.Tables[0].Rows[0]["userStrEMail"].ToString();
            this.txtLogin.Text = oDSUser.Tables[0].Rows[0]["userStrLogin"].ToString();
            this.txtName.Text = oDSUser.Tables[0].Rows[0]["userStrName"].ToString();
            this.txtPhone.Text = oDSUser.Tables[0].Rows[0]["userStrPhone"].ToString();
            this.txtSecPhone.Text = oDSUser.Tables[0].Rows[0]["userStrSecondaryPhone"].ToString();
            this.rchAddress.Text = oDSUser.Tables[0].Rows[0]["userStrAddress"].ToString();

            this.chkDJ.Checked = Convert.ToBoolean(oDSUser.Tables[0].Rows[0]["userBoolDJ"].ToString());
            this.chkGuest.Checked = Convert.ToBoolean(oDSUser.Tables[0].Rows[0]["userBoolGeneralGuest"].ToString());
            this.chkTaxTracker.Checked = Convert.ToBoolean(oDSUser.Tables[0].Rows[0]["userBoolTaxTracker"].ToString());
            this.chkWebMaster.Checked = Convert.ToBoolean(oDSUser.Tables[0].Rows[0]["userBoolWebMaster"].ToString());

            switch (oDSTTUser.Tables[0].Rows[0]["fkSecurityLevel"].ToString())
            {
                case "0":  this.cboSecurityLevels.SelectedIndex = 0; break;
                case "80": this.cboSecurityLevels.SelectedIndex = 1; break;
                case "99": this.cboSecurityLevels.SelectedIndex = 2; break;
                default: this.cboSecurityLevels.SelectedIndex = -1; break;
            }

            this.dtExpires.Value = Convert.ToDateTime(oDSTTUser.Tables[0].Rows[0]["clientDateExpire"].ToString());
            this.chkActive.Checked = Convert.ToBoolean(oDSTTUser.Tables[0].Rows[0]["clientBolActive"].ToString());
            this.txtDB.Text = oDSTTUser.Tables[0].Rows[0]["clientStrDB"].ToString();

        }
        #endregion

        #region "Panel List"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetForm();
            this.btnIFAdd.Visible = true;
            this.panelInfo.BringToFront();
        }
        private void dgList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            resetForm();

            string keyTaxTrackerUserID = this.dgList.Rows[this.dgList.CurrentCell.RowIndex].Cells["keyTaxTrackeruserID"].Value.ToString();
            loadUser(keyTaxTrackerUserID);
            this.btnIFChg.Visible = true;
            this.panelInfo.BringToFront();
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            resetForm();

            string keyTaxTrackerUserID = this.dgList.Rows[this.dgList.CurrentCell.RowIndex].Cells["keyTaxTrackeruserID"].Value.ToString();
            loadUser(keyTaxTrackerUserID);
            this.panelInfo.BackColor = Color.Red;
            this.btnIFDel.Visible = true;
            this.panelInfo.BringToFront();
        }
        #endregion

        #region "Info Panel"
        public static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, IRModels.clsModels.tblUsers data, string userToken)
        {
            string sURL_Location = TTModels.clsStatic.taxtrackerURL;
            sURL_Location = "http://localhost:29471/";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sURL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add(TTModels.clsStatic.applicationHeader, TTModels.clsStatic.applicationToken);
                client.DefaultRequestHeaders.Add("token", userToken);


                HttpResponseMessage oResponse = new HttpResponseMessage();

                switch (sMethod.ToUpper())
                {
                    case "POST":
                        oResponse = await client.PostAsJsonAsync("api/tblUsers/", data);
                        break;
                    case "PUT":
                        oResponse = await client.PutAsJsonAsync("api/tblUsers/", data);
                        break;
                    case "DELETE":
                        foreach (IRModels.clsModels.tblUser thisItem in data)
                        {
                            oResponse = await client.DeleteAsync("api/tblUsers/" + thisItem.keyUserID.ToString());
                        }

                        break;
                }

                return oResponse;
            }

        }
        public static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, IRModels.clsModels.tblTaxTrackerUsers data, string userToken)
        {
            string sURL_Location = TTModels.clsStatic.taxtrackerURL;
            sURL_Location = "http://localhost:29471/";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sURL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add(TTModels.clsStatic.applicationHeader, TTModels.clsStatic.applicationToken);
                client.DefaultRequestHeaders.Add("token", userToken);


                HttpResponseMessage oResponse = new HttpResponseMessage();

                switch (sMethod.ToUpper())
                {
                    case "POST":
                        oResponse = await client.PostAsJsonAsync("api/tblTaxTrackerUsers/", data);
                        break;
                    case "PUT":
                        oResponse = await client.PutAsJsonAsync("api/tblTaxTrackerUsers/", data);
                        break;
                    case "DELETE":
                        foreach (IRModels.clsModels.tblTaxTrackerUser thisItem in data)
                        {
                            oResponse = await client.DeleteAsync("api/tblTaxTrackerUsers/" + thisItem.keyTaxTrackerUserID.ToString());
                        }

                        break;
                }

                return oResponse;
            }

        }

        private async void btnIFAdd_Click(object sender, EventArgs e)
        {
            IRModels.clsModels.tblTaxTrackerUsers dataRecs = new IRModels.clsModels.tblTaxTrackerUsers();
            IRModels.clsModels.tblTaxTrackerUser dataRec = new IRModels.clsModels.tblTaxTrackerUser()
            {
                keyTaxTrackerUserID = this.lblKeyTaxTrackerUserID.Text,
                fkClientID = this.lblKeyUserID.Text,
                fkUserID = this.lblKeyUserID.Text,
                fkSecurityLevel = Convert.ToInt32(this.cboSecurityLevels.Text.Substring(0, 2)),
                clientBolActive = Convert.ToBoolean(this.chkActive.Checked),
                clientDateExpire = Convert.ToDateTime(this.dtExpires.Value),
                clientStrDB = this.txtDB.Text
            };
            dataRecs.Add(dataRec);

            IRModels.clsModels.tblUsers dataRecs2 = new IRModels.clsModels.tblUsers();
            IRModels.clsModels.tblUser dataRec2 = new IRModels.clsModels.tblUser()
            {
                keyUserID               = this.lblKeyUserID.Text,
                userBoolDJ              = Convert.ToBoolean(this.chkDJ.Checked),
                userBoolGeneralGuest    = Convert.ToBoolean(this.chkGuest.Checked),
                userBoolTaxTracker      = Convert.ToBoolean(this.chkTaxTracker.Checked),
                userBoolWebmaster       = Convert.ToBoolean(this.chkWebMaster.Checked),
                userStrAddress          = this.rchAddress.Text,
                userStrAuthor           = this.txtAuthor.Text,
                userStrEmail            = this.txtEmail.Text,
                userStrLogin            = this.txtLogin.Text,
                userStrName             = this.txtName.Text,
                userStrPhone            = this.txtPhone.Text,
                userStrSecondaryPhone   = this.txtSecPhone.Text,
                userStrTaxTrackerFolder = "TaxTrackerPlaceholder"
            };
            dataRecs2.Add(dataRec2);

            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage = await RunAsync("POST", "", dataRecs, USER_TOKEN);
            if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(responseMessage.ToString());
            }
            else
            {
                responseMessage = await RunAsync("POST", "", dataRecs2, USER_TOKEN);
                if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(responseMessage.ToString());
                }
            }


            loadList();
            resetForm();
            this.panelList.BringToFront();
        }
        private async void btnIFChg_Click(object sender, EventArgs e)
        {
            IRModels.clsModels.tblTaxTrackerUsers dataRecs = new IRModels.clsModels.tblTaxTrackerUsers();
            IRModels.clsModels.tblTaxTrackerUser dataRec = new IRModels.clsModels.tblTaxTrackerUser()
            {
                keyTaxTrackerUserID = this.lblKeyTaxTrackerUserID.Text,
                fkClientID = this.lblKeyUserID.Text,
                fkUserID = this.lblKeyUserID.Text,
                fkSecurityLevel = Convert.ToInt32(this.cboSecurityLevels.Text.Substring(0, 2)),
                clientBolActive = Convert.ToBoolean(this.chkActive.Checked),
                clientDateExpire = Convert.ToDateTime(this.dtExpires.Value),
                clientStrDB = this.txtDB.Text
            };
            dataRecs.Add(dataRec);

            IRModels.clsModels.tblUsers dataRecs2 = new IRModels.clsModels.tblUsers();
            IRModels.clsModels.tblUser dataRec2 = new IRModels.clsModels.tblUser()
            {
                keyUserID = this.lblKeyUserID.Text,
                userBoolDJ = Convert.ToBoolean(this.chkDJ.Checked),
                userBoolGeneralGuest = Convert.ToBoolean(this.chkGuest.Checked),
                userBoolTaxTracker = Convert.ToBoolean(this.chkTaxTracker.Checked),
                userBoolWebmaster = Convert.ToBoolean(this.chkWebMaster.Checked),
                userStrAddress = this.rchAddress.Text,
                userStrAuthor = this.txtAuthor.Text,
                userStrEmail = this.txtEmail.Text,
                userStrLogin = this.txtLogin.Text,
                userStrName = this.txtName.Text,
                userStrPhone = this.txtPhone.Text,
                userStrSecondaryPhone = this.txtSecPhone.Text,
                userStrTaxTrackerFolder = "TaxTrackerPlaceholder"
            };
            dataRecs2.Add(dataRec2);

            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage = await RunAsync("PUT", "", dataRecs, USER_TOKEN);
            if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(responseMessage.ToString());
            }
            else
            {
                responseMessage = await RunAsync("PUT", "", dataRecs2, USER_TOKEN);
                if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(responseMessage.ToString());
                }
            }

            loadList();
            resetForm();
            this.panelList.BringToFront();
        }
        private async void btnIFDel_Click(object sender, EventArgs e)
        {
            IRModels.clsModels.tblTaxTrackerUsers dataRecs = new IRModels.clsModels.tblTaxTrackerUsers();
            IRModels.clsModels.tblTaxTrackerUser dataRec = new IRModels.clsModels.tblTaxTrackerUser()
            {
                keyTaxTrackerUserID = this.lblKeyTaxTrackerUserID.Text,
                fkClientID = this.lblKeyUserID.Text,
                fkUserID = this.lblKeyUserID.Text,
                fkSecurityLevel = Convert.ToInt32(this.cboSecurityLevels.Text.Substring(0, 2)),
                clientBolActive = Convert.ToBoolean(this.chkActive.Checked),
                clientDateExpire = Convert.ToDateTime(this.dtExpires.Value),
                clientStrDB = this.txtDB.Text
            };
            dataRecs.Add(dataRec);

            IRModels.clsModels.tblUsers dataRecs2 = new IRModels.clsModels.tblUsers();
            IRModels.clsModels.tblUser dataRec2 = new IRModels.clsModels.tblUser()
            {
                keyUserID = this.lblKeyUserID.Text,
                userBoolDJ = Convert.ToBoolean(this.chkDJ.Checked),
                userBoolGeneralGuest = Convert.ToBoolean(this.chkGuest.Checked),
                userBoolTaxTracker = Convert.ToBoolean(this.chkTaxTracker.Checked),
                userBoolWebmaster = Convert.ToBoolean(this.chkWebMaster.Checked),
                userStrAddress = this.rchAddress.Text,
                userStrAuthor = this.txtAuthor.Text,
                userStrEmail = this.txtEmail.Text,
                userStrLogin = this.txtLogin.Text,
                userStrName = this.txtName.Text,
                userStrPhone = this.txtPhone.Text,
                userStrSecondaryPhone = this.txtSecPhone.Text,
                userStrTaxTrackerFolder = "TaxTrackerPlaceholder"
            };
            dataRecs2.Add(dataRec2);

            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage = await RunAsync("DELETE", "", dataRecs, USER_TOKEN);
            if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(responseMessage.ToString());
            }
            else
            {
                responseMessage = await RunAsync("DELETE", "", dataRecs2, USER_TOKEN);
                if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
                {
                    MessageBox.Show(responseMessage.ToString());
                }
            }

            loadList();
            resetForm();
            this.panelList.BringToFront();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            loadList();
            this.panelList.BringToFront();
        }
        #endregion

    }
}
