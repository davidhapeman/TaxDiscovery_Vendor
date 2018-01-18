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
    public partial class frm_Bills : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        Classes.clsConversionFunctions oConvFunc = new Classes.clsConversionFunctions();
        string URL = "http://208.109.186.146:100/";
        //string URL = "http://localhost:29471/";

        public frm_Bills()
        {
            InitializeComponent();
        }

        private void frm_Bills_Load(object sender, EventArgs e)
        {
            this.cboDatabase.SelectedIndex = -1;
            this.cboNewDatabase.SelectedIndex = -1;
        }


        private void loadBillData(string fiscalYear, string fiscalSubYear)
        {
            DataSet oDS = new DataSet();
            string url = URL + "/api/Conversion/" + this.cboDatabase.Text + "/BillData/" + fiscalYear + "/" + fiscalSubYear;
            oDS = oFunc.getData_V15(url, "", "");

            this.dgBills.DataSource = oDS.Tables[0];
            this.dgLineItems.DataSource = oDS.Tables[1];
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
        }

        private void loadBillLineItemDataClass(string keyBillID, string parcelNumber, string fiscalYear, string fiscalSubYear, string installmentNum)
        {
            for (int i = 0; i < this.dgLineItems.Rows.Count; i++)
            {
                if (this.dgLineItems.Rows[i].Cells[0].Value.ToString().Trim() == parcelNumber)
                {
                    if (this.dgLineItems.Rows[i].Cells[3].Value.ToString().Trim() == fiscalYear)
                    {
                        if (this.dgLineItems.Rows[i].Cells[4].Value.ToString().Trim() == fiscalSubYear)
                        {
                            if (this.dgLineItems.Rows[i].Cells[2].Value.ToString().Trim() == installmentNum)
                            {
                                TTModels.clsV2Models.tblBillLineItem oRec = new TTModels.clsV2Models.tblBillLineItem()
                                {
                                    keyBillLineItemID        = System.Guid.NewGuid().ToString(),
                                    fkBillID                 = keyBillID,
                                    fkFlowID                 = Convert.ToInt32(this.dgLineItems.Rows[i].Cells[13].Value.ToString()),
                                    fkRemittanceID           = getRemittanceID(this.dgLineItems.Rows[i].Cells[5].Value.ToString()),
                                    fkTaxTypeID              = oConvFunc.getNewTaxTypeID(this.cboDatabase.Text, this.dgLineItems.Rows[i].Cells[6].Value.ToString()),
                                    blitemCurrAmountDiscount = Convert.ToDecimal(this.dgLineItems.Rows[i].Cells[7].Value.ToString()),
                                    blitemCurrAmountFace     = Convert.ToDecimal(this.dgLineItems.Rows[i].Cells[8].Value.ToString()),
                                    blitemCurrAmountPaid     = Convert.ToDecimal(this.dgLineItems.Rows[i].Cells[10].Value.ToString()),
                                    blitemCurrAmountPenalty  = Convert.ToDecimal(this.dgLineItems.Rows[i].Cells[9].Value.ToString()),
                                    blitemDecRate            = Convert.ToDecimal(this.dgLineItems.Rows[i].Cells[12].Value.ToString()),
                                    blitemIntReceiptNumber   = Convert.ToInt32(this.dgLineItems.Rows[i].Cells[11].Value.ToString())
                                };
                                billLineItemDatas.Add(oRec);
                            }
                        }
                    }
                }
            }
        }

        private string getParcelKey(string parcelNumber)
        {
            string keyParcelID = "";
            for (int i = 0; i < dtParcels.Rows.Count; i++)
            {
                if (dtParcels.Rows[i]["parcelStrNumber"].ToString() == parcelNumber)
                {
                    keyParcelID = dtParcels.Rows[i]["keyParcelID"].ToString();
                    i = dtParcels.Rows.Count;
                }
            }
            return keyParcelID;
        }
        private string getTaxRollID(string fy, string fsy)
        {
            string keyTaxRollID = "";
            for (int i = 0; i < dtTaxRolls.Rows.Count; i++)
            {
                if (dtTaxRolls.Rows[i]["taxrollStrFiscalYear"].ToString() == fy)
                {
                    if (dtTaxRolls.Rows[i]["taxrollStrFiscalSubYear"].ToString() == fsy)
                    {
                        keyTaxRollID = dtTaxRolls.Rows[i]["keyTaxRollID"].ToString();
                        i = dtTaxRolls.Rows.Count;
                    }
                }
            }
            return keyTaxRollID;
        }
        TTModels.clsV2Models.tblBills billDatas = new TTModels.clsV2Models.tblBills();

        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblBills sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblBills", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblBillLineItems sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblBillLineItems", sData);
                return oResponse;
            }

        }

        private async void loadBillDataClass(string sHeader)
        {
        }

        private string getRemittanceID(string remittanceNum)
        {
            string keyRemittanceID = System.Guid.Empty.ToString();
            for (int i = 0; i < dtRemittances.Rows.Count; i++)
            {
                if (dtRemittances.Rows[i]["remitIntRemittanceNumber"].ToString() == remittanceNum)
                {
                    keyRemittanceID = dtRemittances.Rows[i]["keyRemittanceID"].ToString();
                }
            }
            return keyRemittanceID;
        }

        TTModels.clsV2Models.tblBillLineItems billLineItemDatas = new TTModels.clsV2Models.tblBillLineItems();
        private async void btnConvert_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            for (int ii = 0; ii < dtTaxRolls.Rows.Count; ii++)
            {
                string fy = dtTaxRolls.Rows[ii]["taxrollStrFiscalYear"].ToString();
                string fsy = dtTaxRolls.Rows[ii]["taxrollStrFiscalSubYear"].ToString();
                this.lblProgress.Text = "Getting data for " + fy + "/" + fsy + " from " + this.cboDatabase.Text; this.Refresh();
                loadBillData(fy, fsy);
                string sHeader = "Processing " + fy + "/" + fsy;
                //loadBillDataClass(sHeader);
                HttpResponseMessage oResult = new HttpResponseMessage();
                for (int i = 0; i < this.dgBills.Rows.Count; i++)
                {
                    #region "Build Bill"
                    string keyBillID = System.Guid.NewGuid().ToString();
                    string parcelNumber = this.dgBills.Rows[i].Cells[0].Value.ToString();
                    string fiscalYear = this.dgBills.Rows[i].Cells[3].Value.ToString();
                    string fiscalSubYear = this.dgBills.Rows[i].Cells[4].Value.ToString();
                    string installmentNumber = this.dgBills.Rows[i].Cells[2].Value.ToString();
                    TTModels.clsV2Models.tblBill rec = new TTModels.clsV2Models.tblBill()
                    {
                        keyBillID = keyBillID,
                        fkParcelID = getParcelKey(parcelNumber),
                        fkTaxRollID = getTaxRollID(fiscalYear, fiscalSubYear),
                        billCurrAssessedLand = Convert.ToDecimal(this.dgBills.Rows[i].Cells[10].Value.ToString()),
                        billCurrAssessedBuilding = Convert.ToDecimal(this.dgBills.Rows[i].Cells[11].Value.ToString()),
                        billCurrAssessedMineral = Convert.ToDecimal(this.dgBills.Rows[i].Cells[12].Value.ToString()),
                        billCurrAssessedTotal = Convert.ToDecimal(this.dgBills.Rows[i].Cells[13].Value.ToString()),
                        billCurrPreviousLand = Convert.ToDecimal(this.dgBills.Rows[i].Cells[14].Value.ToString()),
                        billCurrPreviousBuilding = Convert.ToDecimal(this.dgBills.Rows[i].Cells[15].Value.ToString()),
                        billCurrPreviousMineral = Convert.ToDecimal(this.dgBills.Rows[i].Cells[16].Value.ToString()),
                        billCurrPreviousTotal = Convert.ToDecimal(this.dgBills.Rows[i].Cells[17].Value.ToString()),
                        billCurrTaxableLand = Convert.ToDecimal(this.dgBills.Rows[i].Cells[6].Value.ToString()),
                        billCurrTaxableBuilding = Convert.ToDecimal(this.dgBills.Rows[i].Cells[7].Value.ToString()),
                        billCurrTaxableMineral = Convert.ToDecimal(this.dgBills.Rows[i].Cells[8].Value.ToString()),
                        billCurrTaxableTotal = Convert.ToDecimal(this.dgBills.Rows[i].Cells[9].Value.ToString()),
                        billStrBarcodeValue = this.dgBills.Rows[i].Cells[0].Value.ToString(),
                        billStrNumber = this.dgBills.Rows[i].Cells[1].Value.ToString(),
                        billIntInstallment = Convert.ToInt32(this.dgBills.Rows[i].Cells[2].Value.ToString())

                    };
                    billDatas.Add(rec);
                    #endregion

                    loadBillLineItemDataClass(keyBillID, parcelNumber, fiscalYear, fiscalSubYear, installmentNumber);
                    if (billLineItemDatas.Count > 1000)
                    {
                        oResult = await RunAsync(URL, billLineItemDatas, this.cboNewDatabase.Text.ToString());
                        billLineItemDatas.Clear();
                    }

                    if (i % 100 == 0)
                    {
                        this.lblProgress.Text = sHeader + " Records " + i + " of " + this.dgBills.Rows.Count;
                        this.Refresh();
                        oResult = await RunAsync(URL, billDatas, this.cboNewDatabase.Text.ToString());
                        billDatas.Clear();
                    }
                }
                if (billDatas.Count > 0)
                {
                    this.lblProgress.Text = sHeader + " Records " + this.dgBills.Rows.Count;
                    this.Refresh();
                    oResult = await RunAsync(URL, billDatas, this.cboNewDatabase.Text.ToString());
                    billDatas.Clear();
                }
                if (billLineItemDatas.Count > 0)
                {
                    oResult = await RunAsync(URL, billLineItemDatas, this.cboNewDatabase.Text.ToString());
                    billLineItemDatas.Clear();
                }
            }
            Cursor = Cursors.Default;
            MessageBox.Show("Conversion Complete.");
        }

        DataTable dtParcels = new DataTable();
        DataTable dtTaxRolls = new DataTable();
        DataTable dtRemittances = new DataTable();
        private void loadDatabaseInformation(string tdDatabase)
        {
            Cursor = Cursors.WaitCursor;
            dtParcels.Clear(); dtTaxRolls.Clear();
            DataSet oDS = new DataSet();
            string url = "";

            url = URL + "/api/V2/" + tdDatabase + "/tblTaxRolls";
            dtTaxRolls = oFunc.getData_V15(url, "", "").Tables[0];
            url = URL + "/api/V2/" + tdDatabase + "/tblParcels";
            dtParcels = oFunc.getData_V15(url, "", "").Tables[0];
            url = URL + "/api/V2/" + tdDatabase + "/tblRemittances";
            dtRemittances = oFunc.getData_V15(url, "", "").Tables[0];
            Cursor = Cursors.Default;

        }


        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cboNewDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboNewDatabase.SelectedIndex > -1)
            {
                loadDatabaseInformation(this.cboNewDatabase.Text.ToString().Trim());
            }
        }
    }
}
