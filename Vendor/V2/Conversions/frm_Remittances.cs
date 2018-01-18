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
    public partial class frm_Remittances : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        Classes.clsConversionFunctions oConvFunc = new Classes.clsConversionFunctions();
        string URL = "http://208.109.186.146:100/";
        //string URL = "http://localhost:29471/";

        public frm_Remittances()
        {
            InitializeComponent();
        }

        private void frm_Remittances_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataSet oDS = new DataSet();
            string url = URL + "/api/WebServices/" + this.cboDatabase.Text + "/qry_tblRemittance_SelectAll";
            oDS = oFunc.getData_V15(url, "", "");

            this.dataGridView1.DataSource = oDS.Tables[0];
        }

        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblRemittances sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblRemittances", sData);
                return oResponse;
            }

        }
        private async void btnConvert_Click(object sender, EventArgs e)
        {
            TTModels.clsV2Models.tblRemittances oRecs = new TTModels.clsV2Models.tblRemittances();
            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                TTModels.clsV2Models.tblRemittance oRec = new TTModels.clsV2Models.tblRemittance()
                {
                    keyRemittanceID = System.Guid.NewGuid().ToString(),
                    fkTaxTypeID = oConvFunc.getNewTaxTypeID(this.cboDatabase.Text.ToString(), this.dataGridView1.Rows[i].Cells[3].Value.ToString()),
                    fkUserID_EnteredBy = System.Guid.Empty.ToString(),
                    remitDateEntered = Convert.ToDateTime(this.dataGridView1.Rows[i].Cells[2].Value.ToString()),
                    remitIntRemittanceNumber = Convert.ToInt32(this.dataGridView1.Rows[i].Cells[1].Value.ToString())
                };
                oRecs.Add(oRec);
            }
            HttpResponseMessage oResult = new HttpResponseMessage();
            this.lblProgress.Text = "Inserting Tax Rolls"; this.Refresh();
            oResult = await RunAsync(URL, oRecs, this.cboNewDatabase.Text.ToString());

            MessageBox.Show("Complete.");
        }
    }
}
