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


namespace Vendor.CorrectionForms
{
    public partial class frm_Erie_FixRounding : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        clsParcers oParcer = new clsParcers();

        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.fixErieRoundings sData, string sToken)
        {
            string sURL_Location = Globals.Url15;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(sURL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //client.DefaultRequestHeaders.Add("X-CAIL-REST-API-KEY", ClsModel.clsStaticShared.sAppToken.ToString());
                //client.DefaultRequestHeaders.Add("token", sToken);


                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PutAsJsonAsync("api/" + sAPI, sData);
                return oResponse;
            }

        }



        public frm_Erie_FixRounding()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.txtFileName.Text = oFunc.getFileName(this.txtFileName.Text);
        }

        DataTable oDTRawData = new DataTable();
        private void btnLoadDatagrid_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetFileName(this.txtFileName.Text);
            string pathName = this.txtFileName.Text.Replace(fileName, "").ToString();

            oDTRawData = oFunc.getDataFromCSV(this.txtFileName.Text, fileName, pathName).Tables[0];
            this.dgFileImport.DataSource = oDTRawData;

        }

        DataTable oDTTaxRoll = new DataTable();
        private void getTaxRollTotals()
        {
            //string url = Globals.Url15 + "/api/Org_ErieRounding_GetBillTotals/" + this.cboDatabase.Text + "/" + this.txtFiscalYear.Text + "/" + this.txtFiscalSubYear.Text;
            string url = "http://localhost:7093//api/Org_ErieRounding_GetBillTotals/" + this.cboDatabase.Text + "/" + this.txtFiscalYear.Text + "/" + this.txtFiscalSubYear.Text;
            oDTTaxRoll = oFunc.getData_V15(url, "", "").Tables[0];
        }

        private TTModels.clsOriginal.eriePrinterRecords getPrinterRecords()
        {
            TTModels.clsOriginal.eriePrinterRecords oRecs = new TTModels.clsOriginal.eriePrinterRecords();
            for (int i = 0; i < oDTTaxRoll.Rows.Count; i++)
            {
                TTModels.clsOriginal.eriePrinterRecord oRec = new TTModels.clsOriginal.eriePrinterRecord();
                oRec = oParcer.eriePrinterFile(oDTRawData.Rows[i]);
                oRecs.Add(oRec);
            }
            return oRecs;
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            TTModels.clsOriginal.eriePrinterRecords oRaws = new TTModels.clsOriginal.eriePrinterRecords();
            //MessageBox.Show(this.cboDatabase.Text);
            getTaxRollTotals();
            oRaws = getPrinterRecords();

            TTModels.clsOriginal.fixErieRoundings oRecs = new TTModels.clsOriginal.fixErieRoundings();

            int changeCounter = 0;
            for (int i = 0; i < oDTTaxRoll.Rows.Count; i++)
            {
                if (Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumPaid"].ToString()) == 0 && Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumDiscount"].ToString()) > 0)
                {
                    changeCounter++;

                    foreach (TTModels.clsOriginal.eriePrinterRecord data in oRaws)
                    {
                        decimal discountAdjustment = 0;
                        decimal penaltyAdjustment  = 0;
                        string parcelNumber = oDTTaxRoll.Rows[i]["litemStrParcelNumber"].ToString();
                        Boolean bAdjustment = false;

                        #region "Check Discount"
                        if (data.parcelNumber == oDTTaxRoll.Rows[i]["litemStrParcelNumber"].ToString())
                        {
                            if (Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumDiscount"].ToString()) != data.discountAmount)
                            {
                                discountAdjustment = data.discountAmount - Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumDiscount"].ToString());
                                bAdjustment = true;
                                string messageInfo = "";
                                messageInfo += "Tax Tracker:" + Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumDiscount"].ToString()) + "\n";
                                messageInfo += "Adjust: " + discountAdjustment.ToString() + "\n";
                                messageInfo += "New: " + (discountAdjustment + Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumDiscount"].ToString())).ToString() + "\n";
                                messageInfo += "File: " + data.discountAmount.ToString();
                                //MessageBox.Show(messageInfo);
                            }
                        }
                        #endregion

                        #region "Check Penalty"
                        if (data.parcelNumber == oDTTaxRoll.Rows[i]["litemStrParcelNumber"].ToString())
                        {
                            if (Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumPenalty"].ToString()) != data.penaltyAmount)
                            {
                                penaltyAdjustment = data.penaltyAmount - Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumDiscount"].ToString());
                                bAdjustment = true;
                                string messageInfo = "";
                                messageInfo += "Tax Tracker:" + Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumDiscount"].ToString()) + "\n";
                                messageInfo += "Adjust: " + penaltyAdjustment.ToString() + "\n";
                                messageInfo += "New: " + (penaltyAdjustment + Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumDiscount"].ToString())).ToString() + "\n";
                                messageInfo += "File: " + data.penaltyAmount.ToString();
                                //MessageBox.Show(messageInfo);
                            }
                        }
                        #endregion

                        #region "Build Adjustment Class"
                        if (bAdjustment)
                        {
                            if (radSchool.Checked)
                            {
                                TTModels.clsOriginal.fixErieRounding oRec = new TTModels.clsOriginal.fixErieRounding()
                                {
                                    parcelNumber = parcelNumber,
                                    discountCorrection = discountAdjustment,
                                    penaltyCorrection = penaltyAdjustment,
                                    fiscalSubYear = this.txtFiscalSubYear.Text,
                                    fiscalYear = this.txtFiscalYear.Text,
                                    taxTypeID = 3
                                };
                                oRecs.Add(oRec);
                            }
                            else
                            {
                                TTModels.clsOriginal.fixErieRounding oRec2 = new TTModels.clsOriginal.fixErieRounding()
                                {
                                    parcelNumber = parcelNumber,
                                    discountCorrection = discountAdjustment,
                                    penaltyCorrection = penaltyAdjustment,
                                    fiscalSubYear = this.txtFiscalSubYear.Text,
                                    fiscalYear = this.txtFiscalYear.Text,
                                    taxTypeID = 1
                                };
                                oRecs.Add(oRec2);
                            }
                        }
                        #endregion



                    }

                }
            }

            MessageBox.Show("Changing " + oRecs.Count.ToString() + " Records.");

            HttpResponseMessage oResult = new HttpResponseMessage();
            oResult = await RunAsync("PUT", "Org_FixRounding/" + this.cboDatabase.Text, oRecs, "");
            if (oResult.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(oResult.RequestMessage.ToString());
            }
            else
            {
                MessageBox.Show("Complete");
            }


        }
    
    }
}
