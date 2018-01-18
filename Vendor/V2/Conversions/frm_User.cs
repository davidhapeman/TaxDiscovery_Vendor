using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Web;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Http.Formatting;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Runtime.Serialization;

namespace Vendor.V2.Conversions
{
    public partial class frm_User : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        Classes.clsConversionFunctions oConvFunc = new Classes.clsConversionFunctions();
        string URL = "http://208.109.186.146:100/";
        //string URL = "http://localhost:29471/";

        public frm_User()
        {
            InitializeComponent();
        }

        TTModels.clsV2Models.tblBankAccounts bankAccounts = new TTModels.clsV2Models.tblBankAccounts();
        TTModels.clsV2Models.tblOffices officeDatas = new TTModels.clsV2Models.tblOffices();
        public void loadUserData()
        {
            DataSet oDS = new DataSet();
            string url = URL + "/api/WebServices/" + this.cboDatabase.Text + "/qry_tblUserInfo_SelectAll";
            oDS = oFunc.getData_V15(url, "", "");
            this.dataGridView1.DataSource = oDS.Tables[0];

            TTModels.clsV2Models.tblOffice data1 = new TTModels.clsV2Models.tblOffice()
            {
                keyOfficeID = System.Guid.NewGuid().ToString(),
                officeStrAddress = this.dataGridView1.Rows[0].Cells[5].Value.ToString(),
                officeStrEmail   = this.dataGridView1.Rows[0].Cells[34].Value.ToString(),
                officeStrFax     = this.dataGridView1.Rows[0].Cells[7].Value.ToString(),
                officeStrHours   = this.dataGridView1.Rows[0].Cells[8].Value.ToString(),
                officeStrPhone   = this.dataGridView1.Rows[0].Cells[6].Value.ToString(),
                officeStrWebAppointment = ""
            };
            officeDatas.Add(data1);

            if (this.dataGridView1.Rows[0].Cells[10].Value.ToString().Trim() != "") { TTModels.clsV2Models.tblBankAccount ba1 = new TTModels.clsV2Models.tblBankAccount() { keyBankAccountID = System.Guid.NewGuid().ToString(), bacctBolActive = true, bacctDateCreated = DateTime.UtcNow, bacctDateExpired = DateTime.MaxValue, bacctStrBankName = this.dataGridView1.Rows[0].Cells[10].Value.ToString(), bacctStrBankNumber = this.dataGridView1.Rows[0].Cells[11].Value.ToString() }; bankAccounts.Add(ba1); }
            if (this.dataGridView1.Rows[0].Cells[12].Value.ToString().Trim() != "") { TTModels.clsV2Models.tblBankAccount ba2 = new TTModels.clsV2Models.tblBankAccount() { keyBankAccountID = System.Guid.NewGuid().ToString(), bacctBolActive = true, bacctDateCreated = DateTime.UtcNow, bacctDateExpired = DateTime.MaxValue, bacctStrBankName = this.dataGridView1.Rows[0].Cells[12].Value.ToString(), bacctStrBankNumber = this.dataGridView1.Rows[0].Cells[13].Value.ToString() }; bankAccounts.Add(ba2); }
            if (this.dataGridView1.Rows[0].Cells[14].Value.ToString().Trim() != "") { TTModels.clsV2Models.tblBankAccount ba3 = new TTModels.clsV2Models.tblBankAccount() { keyBankAccountID = System.Guid.NewGuid().ToString(), bacctBolActive = true, bacctDateCreated = DateTime.UtcNow, bacctDateExpired = DateTime.MaxValue, bacctStrBankName = this.dataGridView1.Rows[0].Cells[14].Value.ToString(), bacctStrBankNumber = this.dataGridView1.Rows[0].Cells[15].Value.ToString() }; bankAccounts.Add(ba3); }
            if (this.dataGridView1.Rows[0].Cells[16].Value.ToString().Trim() != "") { TTModels.clsV2Models.tblBankAccount ba4 = new TTModels.clsV2Models.tblBankAccount() { keyBankAccountID = System.Guid.NewGuid().ToString(), bacctBolActive = true, bacctDateCreated = DateTime.UtcNow, bacctDateExpired = DateTime.MaxValue, bacctStrBankName = this.dataGridView1.Rows[0].Cells[16].Value.ToString(), bacctStrBankNumber = this.dataGridView1.Rows[0].Cells[17].Value.ToString() }; bankAccounts.Add(ba4); }
            if (this.dataGridView1.Rows[0].Cells[18].Value.ToString().Trim() != "") { TTModels.clsV2Models.tblBankAccount ba5 = new TTModels.clsV2Models.tblBankAccount() { keyBankAccountID = System.Guid.NewGuid().ToString(), bacctBolActive = true, bacctDateCreated = DateTime.UtcNow, bacctDateExpired = DateTime.MaxValue, bacctStrBankName = this.dataGridView1.Rows[0].Cells[18].Value.ToString(), bacctStrBankNumber = this.dataGridView1.Rows[0].Cells[19].Value.ToString() }; bankAccounts.Add(ba5); }




        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            loadUserData();
        }

        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblOffices sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblOffices", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblBankAccounts sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblBankAccounts", sData);
                return oResponse;
            }

        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            HttpResponseMessage oResult = new HttpResponseMessage();
            oResult = await RunAsync(URL, officeDatas, this.cboNewDatabase.Text.ToString());
            if (oResult.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Office " + oResult.StatusCode.ToString());
            }
            oResult = await RunAsync(URL, bankAccounts, this.cboNewDatabase.Text.ToString());
            if (oResult.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show("Bank Accounts " + oResult.StatusCode.ToString());
            }
            MessageBox.Show("Complete");
        }
    }
}
