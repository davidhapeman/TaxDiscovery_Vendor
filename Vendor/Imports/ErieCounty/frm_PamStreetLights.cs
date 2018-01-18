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

namespace Vendor.Imports.ErieCounty
{
    public partial class frm_PamStreetLights : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();

        public frm_PamStreetLights()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.txtFileName.Text = oFunc.getFileName(this.txtFileName.Text);
        }

        private void buildLoadDatagrid()
        {
            string sXML = "";

            for (int i = 0; i < this.dataGridView1.Rows.Count; i++)
            {
                string parcel = "27-";
                string part1 = ""; string part2 = ""; string part3 = "";
                int iStart = 0; int iEnd = 0;

                string tempParcel = this.dataGridView1.Rows[i].Cells[0].Value.ToString();
                tempParcel = tempParcel.Replace(" ", "");

                iEnd = tempParcel.IndexOf("-");
                part1 = tempParcel.Substring(iStart, iEnd);
                tempParcel = tempParcel.Replace(part1 + "-", "");
                part1 = Convert.ToInt32(part1).ToString("000");

                iEnd = tempParcel.IndexOf("-");
                part2 = tempParcel.Substring(iStart, iEnd);
                tempParcel = tempParcel.Replace(part2 + "-", "");
                part2 = Convert.ToDecimal(part2).ToString("000.0");

                part3 = Convert.ToDecimal(tempParcel).ToString("000.00");

                parcel += part1 + "-" + part2 + "-" + part3;

                string taxAmount = this.dataGridView1.Rows[i].Cells[6].Value.ToString();

                sXML += "<row>";
                sXML += "<parcel>" + parcel + "</parcel>";
                sXML += "<taxAmount>" + taxAmount +"</taxAmount>";
                sXML += "</row>";
            }

            sXML = "<rows>" + sXML + "</rows>";
            DataSet oDS = new DataSet();
            oDS.ReadXml(new System.IO.StringReader(sXML));
            this.dataGridView2.DataSource = oDS.Tables[0];
        }

        private void btnLoadDatagrid_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string fileName = System.IO.Path.GetFileName(this.txtFileName.Text);
            string pathName = this.txtFileName.Text.Replace(fileName, "").ToString();

            DataTable oDTRawData2 = new DataTable();
            oDTRawData2 = oFunc.getDataFromCSV(this.txtFileName.Text, fileName, pathName).Tables[0];
            this.dataGridView1.DataSource = oDTRawData2;

            buildLoadDatagrid();
            Cursor = Cursors.Default;

        }

        private void frm_PamStreetLights_Load(object sender, EventArgs e)
        {
            this.dtFaceEnd.Value = Convert.ToDateTime("12/31/" + DateTime.Now.Year.ToString());
            this.dtFaceStart.Value = Convert.ToDateTime("3/1/" + DateTime.Now.Year.ToString());
        }

        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblLineItemTaxes sData, string sToken)
        {
            string sURL_Location = Globals.Url15;
            //sURL_Location = "http://localhost:29471";

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sURL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Add("X-CAIL-REST-API-KEY", ClsModel.clsStaticShared.sAppToken.ToString());
                //client.DefaultRequestHeaders.Add("token", sToken);


                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/" + sAPI, sData);
                return oResponse;
            }

        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DateTime dDiscStart = DateTime.MaxValue; DateTime dDiscEnd = DateTime.MaxValue;
            DateTime dPenlStart = DateTime.MaxValue; DateTime dPenlEnd = DateTime.MaxValue;
            int taxTypeID = 6; string FY = DateTime.Now.Year.ToString(); string FSY = "Normal-SL";

            DateTime dFaceStart = Convert.ToDateTime(this.dtFaceStart.Value.ToString("MM/dd/yyyy"));
            DateTime dFaceEnd   = Convert.ToDateTime(this.dtFaceEnd.Value.ToString("MM/dd/yyyy"));

            TTModels.clsOriginal.tblLineItemTaxes lineItems = new TTModels.clsOriginal.tblLineItemTaxes();
            for (int i = 0; i < this.dataGridView2.Rows.Count; i++)
            {
                TTModels.clsOriginal.tblLineItemTax lineItem = new TTModels.clsOriginal.tblLineItemTax()
                {
                    keyLineItemID = 0,
                    litemAmountPaid = 0,
                    litemBolCloseOut = false,
                    litemBolInterim = false,
                    litemBolSelectedRow = false,
                    litemCurrAssessedBuilding = 0,
                    litemCurrAssessedLand = 0,
                    litemCurrAssessedMineral = 0,
                    litemCurrAssessedTotal = 0,
                    litemCurrBuilding = 0,
                    litemCurrLand = 0,
                    litemCurrMineral = 0,
                    litemCurrPrevBuilding = 0,
                    litemCurrPrevLand = 0,
                    litemCurrPrevMineral = 0,
                    litemCurrPrevTotal = 0,
                    litemCurrTaxAmountDiscount = Convert.ToDecimal(this.dataGridView2.Rows[i].Cells[1].Value.ToString()),
                    litemCurrTaxAmountFace = Convert.ToDecimal(this.dataGridView2.Rows[i].Cells[1].Value.ToString()),
                    litemCurrTaxAmountPenalty = Convert.ToDecimal(this.dataGridView2.Rows[i].Cells[1].Value.ToString()),
                    litemCurrTotal = 0,
                    litemDateEffectiveDate = dFaceStart,
                    litemDateInterimDate = dFaceStart,
                    litemDateLastUpdatedDate = dFaceStart,
                    litemDblRate = 0,
                    litemIntInstallmentNumber = 0,
                    litemIntInterimMonths = 12,
                    litemIntPaymentPeriodID = 0,
                    litemIntPaymentStatusID = 0,
                    litemIntPaymentTypeID = 0,
                    litemIntReceiptNumber = 0,
                    litemIntRemittalID = 0,
                    litemIntTaxTypeID = taxTypeID,
                    litemMemoNotes = "",
                    litemPaymentID = 0,
                    litemStrBarCodeValue = this.dataGridView2.Rows[i].Cells[0].Value.ToString(),
                    litemStrBillNumber = (i+1).ToString("000000"),
                    litemStrFiscalSubYear = FSY,
                    litemStrFiscalYear = FY,
                    litemStrParcelNumber = this.dataGridView2.Rows[i].Cells[0].Value.ToString()
                };
                lineItems.Add(lineItem);
            }

            string environ = "TTrackerErie27";
            HttpResponseMessage webResponse = new HttpResponseMessage();
            webResponse = await RunAsync("POST", environ + "/Importing/tblLineItemTaxes", lineItems, System.Guid.NewGuid().ToString());
            Cursor = Cursors.Default;

            MessageBox.Show("Complete. Add the PaymentPeriods and Starting Figures");


        }
    }
}
