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

namespace Vendor.IncidentTracking
{
    public partial class frm_IncidentTracking : Form
    {
        string ENVIRONMENT = "IncidentTracking";
        string USER_TOKEN = System.Guid.NewGuid().ToString();

        IRModels.clsModels irModels = new IRModels.clsModels();
        IRModels.clsFunctions irFunctions = new IRModels.clsFunctions();

        #region "Combobox Load"
        private void loadCategorys()
        {
            DataSet oDS = new DataSet();
            oDS = irFunctions.getCategorys(USER_TOKEN);
            this.cboCategory.DataSource = oDS.Tables[0];
            this.cboCategory.DisplayMember = oDS.Tables[0].Columns["catStrName"].ToString();
            this.cboCategory.ValueMember = oDS.Tables[0].Columns["keyCategoryID"].ToString();
        }
        private void loadCategorys(string fkApplicationID)
        {
            try
            {
                DataSet oDS = new DataSet();
                oDS = irFunctions.getCategorys(USER_TOKEN, fkApplicationID);
                this.cboCategory.DataSource = oDS.Tables[0];
                this.cboCategory.DisplayMember = oDS.Tables[0].Columns["catStrName"].ToString();
                this.cboCategory.ValueMember = oDS.Tables[0].Columns["keyCategoryID"].ToString();
            }
            catch
            { }
        }
        private void loadStatuss()
        {
            DataSet oDS = new DataSet();
            oDS = irFunctions.getStatuss(USER_TOKEN);
            this.cboStatus.DataSource = oDS.Tables[0];
            this.cboStatus.DisplayMember = oDS.Tables[0].Columns["stsStrName"].ToString();
            this.cboStatus.ValueMember = oDS.Tables[0].Columns["keyStatusID"].ToString();
        }
        private void loadPriority()
        {
            DataSet oDS = new DataSet();
            oDS = irFunctions.getPrioritys(USER_TOKEN);
            this.cboPriority.DataSource = oDS.Tables[0];
            this.cboPriority.DisplayMember = oDS.Tables[0].Columns["priorStrName"].ToString();
            this.cboPriority.ValueMember = oDS.Tables[0].Columns["keyPriorityID"].ToString();
        }
        private void loadApplications()
        {
            DataSet oDS = new DataSet();
            oDS = irFunctions.getApplications(USER_TOKEN);
            this.cboApplication.DataSource = oDS.Tables[0];
            this.cboApplication.DisplayMember = oDS.Tables[0].Columns["appStrName"].ToString();
            this.cboApplication.ValueMember = oDS.Tables[0].Columns["keyApplicationID"].ToString();
        }
        private void loadCombobox()
        {
            loadApplications();
            loadStatuss();
            loadCategorys();
            loadPriority();
        }
        #endregion

        public frm_IncidentTracking()
        {
            InitializeComponent();
        }

        private void setInfoPanel(ToolStripButton _thisButton)
        {
            this.btnIFAdd.Visible = false;
            this.btnIFChg.Visible = false;
            this.btnIFDel.Visible = false;
            _thisButton.Visible   = true;

            if (_thisButton.Name == "btnIFDel") { this.panelInfo.BackColor = Color.Red; } else { this.panelInfo.BackColor = this.BackColor; }

            this.panelInfo.BringToFront();
        }
        private void resetForm()
        {
            this.lblKeyIncidentID.Text = System.Guid.NewGuid().ToString();
            this.cboApplication.SelectedIndex = -1;
            this.cboCategory.SelectedIndex = -1;
            this.cboPriority.SelectedIndex = -1;
            this.cboStatus.SelectedIndex = -1;

            this.dtAssigned.Value = Convert.ToDateTime("12/30/9990");
            this.dtCreated.Value = Convert.ToDateTime("12/30/9990");
            this.dtNotification.Value = Convert.ToDateTime("12/30/9990");
            this.dtResolved.Value = Convert.ToDateTime("12/30/9990");

            this.txtReporter.Text = "TBD";
            this.txtReporterEmail.Text = "TBD";
            this.txtReporterPhone.Text = "TBD";
            this.txtTitle.Text = "";
            this.txtAssigned.Text = "Hapeman";

            this.rchDescription.Text = "";
            this.rchResolution.Text = "TBD";

            this.chkNotificationOff.Checked = false;
            this.chkWhatsNew.Checked = false;
            
        }
        private void loadList()
        {
            DataSet oDS = new DataSet();
            oDS = irFunctions.getIncidents(USER_TOKEN);
            this.dgList.AutoGenerateColumns = false;
            try
            {
                this.dgList.DataSource = oDS.Tables[0];
            }
            catch { }
        }
        private void loadInfo(string keyIncidentID)
        {
            resetForm();
            this.lblKeyIncidentID.Text = keyIncidentID;
            DataTable oDT = new DataTable(); oDT = irFunctions.getIncidents(USER_TOKEN, keyIncidentID).Tables[0];

            this.chkNotificationOff.Checked = Convert.ToBoolean(oDT.Rows[0]["irBolNotification"].ToString());
            this.chkWhatsNew.Checked = Convert.ToBoolean(oDT.Rows[0]["irBolWhatsNew"].ToString());

            this.txtReporter.Text = oDT.Rows[0]["irStrReporter"].ToString();
            this.txtReporterEmail.Text = oDT.Rows[0]["irStrReporterEmail"].ToString();
            this.txtReporterPhone.Text = oDT.Rows[0]["irStrReporterPhone"].ToString();
            this.txtTitle.Text = oDT.Rows[0]["irStrTitle"].ToString();
            this.txtNumber.Text = oDT.Rows[0]["irIntNumber"].ToString();

            this.rchDescription.Text = oDT.Rows[0]["irStrDescription"].ToString();
            this.rchResolution.Text = oDT.Rows[0]["irStrResolution"].ToString();

            try { this.dtAssigned.Value = Convert.ToDateTime(oDT.Rows[0]["irDateAssigned"].ToString()); } catch { this.dtAssigned.Value = this.dtAssigned.MaxDate; }
            try { this.dtCreated.Value = Convert.ToDateTime(oDT.Rows[0]["irDateCreate"].ToString()); } catch { this.dtCreated.Value = this.dtAssigned.MaxDate; }
            try { this.dtNotification.Value = Convert.ToDateTime(oDT.Rows[0]["irDateNotificationOff"].ToString()); } catch { this.dtNotification.Value = this.dtAssigned.MaxDate; }
            try { this.dtResolved.Value = Convert.ToDateTime(oDT.Rows[0]["irDateResolved"].ToString()); } catch { this.dtResolved.Value = this.dtAssigned.MaxDate; }

            this.cboApplication.SelectedValue = oDT.Rows[0]["fkApplicationID"].ToString();
            this.cboCategory.SelectedValue = oDT.Rows[0]["fkCategoryID"].ToString();
            this.cboPriority.SelectedValue = oDT.Rows[0]["fkPriorityID"].ToString();
            this.cboStatus.SelectedValue = oDT.Rows[0]["fkStatusID"].ToString();

            this.txtClientDB.Text = oDT.Rows[0]["irStrClientDB"].ToString();


        }

        private void frm_IncidentTracking_Load(object sender, EventArgs e)
        {

            loadCombobox();
            loadList();
            this.panelInfo.Left = this.panelList.Left;
            this.panelInfo.Top  = this.panelList.Top;
            this.panelList.BringToFront();
            frm_IncidentTracking_Resize(sender, e);
        }

        #region "Panel List"
        private void btnAdd_Click(object sender, EventArgs e)
        {
            resetForm();
            setInfoPanel(this.btnIFAdd);
        }
        private void btnDel_Click(object sender, EventArgs e)
        {
            string keyIncidentID = this.dgList.Rows[this.dgList.CurrentCell.RowIndex].Cells["keyIncidentID"].Value.ToString();
            loadInfo(keyIncidentID);
            setInfoPanel(this.btnIFDel);
        }
        private void dgList_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string keyIncidentID = this.dgList.Rows[this.dgList.CurrentCell.RowIndex].Cells["keyIncidentID"].Value.ToString();
            loadInfo(keyIncidentID);
            setInfoPanel(this.btnIFChg);
        }
        #endregion

        #region "Panel Info"

        public static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, IRModels.clsModels.tblIncidents data, string userToken)
        {
            string sURL_Location = TTModels.clsStatic.taxtrackerURL;
            //sURL_Location = "http://localhost:29471/";

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
                        oResponse = await client.PostAsJsonAsync("api/tblIncidents/", data);
                        break;
                    case "PUT":
                        oResponse = await client.PutAsJsonAsync("api/tblIncidents/", data);
                        break;
                    case "DELETE":
                        foreach (IRModels.clsModels.tblIncident thisItem in data)
                        {
                            oResponse = await client.DeleteAsync("api/tblIncidents/" + thisItem.keyIncidentID.ToString());
                        }

                        break;
                }

                return oResponse;
            }

        }

        private async void btnIFAdd_Click(object sender, EventArgs e)
        {
            IRModels.clsModels.tblIncidents dataRecs = new IRModels.clsModels.tblIncidents();
            IRModels.clsModels.tblIncident dataRec = new IRModels.clsModels.tblIncident()
            {
                keyIncidentID = this.lblKeyIncidentID.Text,
                fkApplicationID = Convert.ToInt32(this.cboApplication.SelectedValue.ToString()),
                fkCategoryID = Convert.ToInt32(this.cboCategory.SelectedValue.ToString()),
                fkPriorityID = Convert.ToInt32(this.cboPriority.SelectedValue.ToString()),
                fkStatusID = Convert.ToInt32(this.cboStatus.SelectedValue.ToString()),
                irBolNotification = Convert.ToBoolean(this.chkNotificationOff.Checked),
                irBolWhatsNew = Convert.ToBoolean(this.chkWhatsNew.Checked),
                irDateAssigned = Convert.ToDateTime(this.dtAssigned.Value.ToString()),
                irDateCreate = Convert.ToDateTime(this.dtCreated.Value.ToString()),
                irDateNotificationOff = Convert.ToDateTime(this.dtNotification.Value.ToString()),
                irDateResolved = Convert.ToDateTime(this.dtResolved.Value.ToString()),
                irStrAssigned = this.txtAssigned.Text,
                irStrDescription = this.rchDescription.Text,
                irStrReporter = this.txtReporter.Text,
                irStrReporterEmail = this.txtReporterEmail.Text,
                irStrReporterPhone = this.txtReporterPhone.Text,
                irStrResolution = this.rchResolution.Text,
                irStrTitle = this.txtTitle.Text,
                irStrClientDB = this.txtClientDB.Text,
                irIntNumber = Convert.ToInt32(this.txtNumber.Text)
            };
            dataRecs.Add(dataRec);

            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage = await RunAsync("POST", "", dataRecs, USER_TOKEN);
            if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(responseMessage.ToString());
            }


            resetForm();
            loadList();
            this.panelList.BringToFront();
        }
        private async void btnIFChg_Click(object sender, EventArgs e)
        {

            IRModels.clsModels.tblIncidents dataRecs = new IRModels.clsModels.tblIncidents();
            IRModels.clsModels.tblIncident dataRec = new IRModels.clsModels.tblIncident()
            {
                keyIncidentID = this.lblKeyIncidentID.Text,
                fkApplicationID = Convert.ToInt32(this.cboApplication.SelectedValue.ToString()),
                fkCategoryID = Convert.ToInt32(this.cboCategory.SelectedValue.ToString()),
                fkPriorityID = Convert.ToInt32(this.cboPriority.SelectedValue.ToString()),
                fkStatusID = Convert.ToInt32(this.cboStatus.SelectedValue.ToString()),
                irBolNotification = Convert.ToBoolean(this.chkNotificationOff.Checked),
                irBolWhatsNew = Convert.ToBoolean(this.chkWhatsNew.Checked),
                irDateAssigned = Convert.ToDateTime(this.dtAssigned.Value.ToString()),
                irDateCreate = Convert.ToDateTime(this.dtCreated.Value.ToString()),
                irDateNotificationOff = Convert.ToDateTime(this.dtNotification.Value.ToString()),
                irDateResolved = Convert.ToDateTime(this.dtResolved.Value.ToString()),
                irStrAssigned = this.txtAssigned.Text,
                irStrDescription = this.rchDescription.Text,
                irStrReporter = this.txtReporter.Text,
                irStrReporterEmail = this.txtReporterEmail.Text,
                irStrReporterPhone = this.txtReporterPhone.Text,
                irStrResolution = this.rchResolution.Text,
                irStrTitle = this.txtTitle.Text,
                irStrClientDB = this.txtClientDB.Text,
                irIntNumber = Convert.ToInt32(this.txtNumber.Text)
            };
            dataRecs.Add(dataRec);

            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage = await RunAsync("PUT", "", dataRecs, USER_TOKEN);
            if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(responseMessage.ToString());
            }


            resetForm();
            loadList();
            this.panelList.BringToFront();
        }
        private async void btnIFDel_Click(object sender, EventArgs e)
        {

            IRModels.clsModels.tblIncidents dataRecs = new IRModels.clsModels.tblIncidents();
            IRModels.clsModels.tblIncident dataRec = new IRModels.clsModels.tblIncident()
            {
                keyIncidentID = this.lblKeyIncidentID.Text,
                fkApplicationID = Convert.ToInt32(this.cboApplication.SelectedValue.ToString()),
                fkCategoryID = Convert.ToInt32(this.cboCategory.SelectedValue.ToString()),
                fkPriorityID = Convert.ToInt32(this.cboPriority.SelectedValue.ToString()),
                fkStatusID = Convert.ToInt32(this.cboStatus.SelectedValue.ToString()),
                irBolNotification = Convert.ToBoolean(this.chkNotificationOff.Checked),
                irBolWhatsNew = Convert.ToBoolean(this.chkWhatsNew.Checked),
                irDateAssigned = Convert.ToDateTime(this.dtAssigned.Value.ToString()),
                irDateCreate = Convert.ToDateTime(this.dtCreated.Value.ToString()),
                irDateNotificationOff = Convert.ToDateTime(this.dtNotification.Value.ToString()),
                irDateResolved = Convert.ToDateTime(this.dtResolved.Value.ToString()),
                irStrAssigned = this.txtAssigned.Text,
                irStrDescription = this.rchDescription.Text,
                irStrReporter = this.txtReporter.Text,
                irStrReporterEmail = this.txtReporterEmail.Text,
                irStrReporterPhone = this.txtReporterPhone.Text,
                irStrResolution = this.rchResolution.Text,
                irStrTitle = this.txtTitle.Text
            };
            dataRecs.Add(dataRec);

            HttpResponseMessage responseMessage = new HttpResponseMessage();
            responseMessage = await RunAsync("DELETE", "", dataRecs, USER_TOKEN);
            if (responseMessage.StatusCode != System.Net.HttpStatusCode.OK)
            {
                MessageBox.Show(responseMessage.ToString());
            }


            resetForm();
            loadList();
            this.panelList.BringToFront();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            resetForm();
            this.panelList.BringToFront();
        }
        #endregion

        #region "Resizing"
        private void frm_IncidentTracking_Resize(object sender, EventArgs e)
        {
            this.panelList.Width  = this.Width  - this.panelList.Left - 25;
            this.panelList.Height = this.Height - this.panelList.Top  - 45;
            this.panelInfo.Width  = this.panelList.Width;
            this.panelInfo.Height = this.panelList.Height;
        }
        private void panelList_Resize(object sender, EventArgs e)
        {
            this.dgList.Width  = this.panelList.Width  - this.dgList.Left - 25;
            this.dgList.Height = this.panelList.Height - this.dgList.Top  - 35;
        }
        #endregion

        private void cboApplication_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboApplication.SelectedIndex == -1)
            {
                loadCategorys();
            }
            else
            {
                loadCategorys(this.cboApplication.SelectedValue.ToString());
            }
        }
    }
}
