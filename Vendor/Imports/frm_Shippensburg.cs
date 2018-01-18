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


namespace Vendor.Imports
{
    public partial class frm_Shippensburg : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();

        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblParcelInformations sData, string sToken)
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
                oResponse = await client.PostAsJsonAsync("api/" + sAPI, sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblLineItemTaxes sData, string sToken)
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
                oResponse = await client.PostAsJsonAsync("api/" + sAPI, sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblOwnerInformations sData, string sToken)
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
                oResponse = await client.PostAsJsonAsync("api/" + sAPI, sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblPaymentPeriod sData, string sToken)
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
                oResponse = await client.PostAsJsonAsync("api/" + sAPI, sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblStartingFigures sData, string sToken)
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
                oResponse = await client.PostAsJsonAsync("api/" + sAPI, sData);
                return oResponse;
            }

        }


        string initialCatalog = "TTrackerSASDBoS";

        public frm_Shippensburg()
        {
            InitializeComponent();
            
        }

        private DataTable getStartingFigures()
        {
            DataTable oDT = new System.Data.DataTable();
            oDT = oFunc.getData_V15(Globals.Url15 + "/api/Org_ImportGetStartingFigures/" + initialCatalog + "/" + this.txtFiscalYear.Text + "/" + this.txtFiscalSubYear.Text, "", "").Tables[0];
            return oDT;
        }

        private void frm_Shippensburg_Load(object sender, EventArgs e)
        {
            this.txtFiscalYear.Text = DateTime.Now.Year.ToString();
            this.dtDiscStart.Value = Convert.ToDateTime(DateTime.Now.ToString("MM/dd/yyyy"));
        }

        private void dtDiscStart_ValueChanged(object sender, EventArgs e)
        {
            this.dtDiscEnd.Value = this.dtDiscStart.Value.AddDays(60);
        }

        private void dtDiscEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dtFaceStart.Value = this.dtDiscEnd.Value.AddDays(1);
        }

        private void dtFaceStart_ValueChanged(object sender, EventArgs e)
        {
            this.dtFaceEnd.Value = this.dtFaceStart.Value.AddDays(60);
        }

        private void dtFaceEnd_ValueChanged(object sender, EventArgs e)
        {
            this.dtPenlStart.Value = this.dtFaceEnd.Value.AddDays(1);
        }

        private void dtPenlStart_ValueChanged(object sender, EventArgs e)
        {
            this.dtPenlEnd.Value = Convert.ToDateTime("12/31/" + DateTime.Now.Year.ToString());
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

        private async void btnImport_Click(object sender, EventArgs e)
        {
            string sectionHeader = ""; int iRowMax = 0; clsParcers oParcer = new clsParcers(); int valueProgress = 0;
            HttpResponseMessage oResult = new HttpResponseMessage();

            #region "Parcel Information"
            sectionHeader = "Loading Parcels .... ";
            TTModels.clsOriginal.tblParcelInformations oParcels = new TTModels.clsOriginal.tblParcelInformations();
            for (int i = 0; i < oDTRawData.Rows.Count; i++)
            {
                if (iRowMax > 50)
                {
                    this.lblProgress.Text = "Loading Parcels Complete ..... " + (i + 1) + " of " + oDTRawData.Rows.Count;
                    valueProgress = (100 * (i + 1)) / oDTRawData.Rows.Count;
                    this.pbarProgress.Value = valueProgress;
                    this.Refresh();

                    oResult = await RunAsync("POST", "Org_ImportParcelInformation/" + initialCatalog, oParcels, "");
                    if (oResult.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(oResult.RequestMessage.ToString());
                    }


                    oParcels.Clear();
                    iRowMax = 0;
                }
                TTModels.clsOriginal.tblParcelInformation oParcel = new TTModels.clsOriginal.tblParcelInformation();
                if (this.chkPCCountyMuni.Checked || this.chkPCSchool.Checked)
                {
                    oParcel = oParcer.shippensburgPerCapita_ParcelInformation(oDTRawData.Rows[i], this.cboSchoolDistrict.Text);
                }
                else
                {
                    oParcel = oParcer.shippensburgRealEstate_ParcelInformation(oDTRawData.Rows[i], this.cboSchoolDistrict.Text);
                }
                oParcels.Add(oParcel);
                iRowMax += 1;
            }

            if (iRowMax > 0)
            {
                oResult = await RunAsync("POST", "Org_ImportParcelInformation/" + initialCatalog, oParcels, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }
            }
            #endregion

            #region "Owner Information"
            sectionHeader = "Loading Owners .... "; iRowMax = 0;
            TTModels.clsOriginal.tblOwnerInformations oOwners = new TTModels.clsOriginal.tblOwnerInformations();
            for (int i = 0; i < oDTRawData.Rows.Count; i++)
            {
                if (iRowMax > 50)
                {
                    this.lblProgress.Text = "Loading Owner Complete ..... " + (i + 1) + " of " + oDTRawData.Rows.Count;
                    valueProgress = (100 * (i + 1)) / oDTRawData.Rows.Count;
                    this.pbarProgress.Value = valueProgress;
                    this.Refresh();

                    oResult = await RunAsync("POST", "Org_ImportOwnerInformation/" + initialCatalog, oOwners, "");
                    if (oResult.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(oResult.RequestMessage.ToString());
                    }


                    oOwners.Clear();
                    iRowMax = 0;
                }
                TTModels.clsOriginal.tblOwnerInformation oOwner = new TTModels.clsOriginal.tblOwnerInformation();
                if (this.chkPCCountyMuni.Checked || this.chkPCSchool.Checked)
                {
                    oOwner = oParcer.shippensburgPerCapita_OwnerInformation(oDTRawData.Rows[i], this.dtDiscStart.Value);
                }
                else
                {
                    oOwner = oParcer.shippensburgRealEstate_OwnerInformation(oDTRawData.Rows[i], this.dtDiscStart.Value);
                }

                oOwners.Add(oOwner);
                iRowMax += 1;
            }

            if (iRowMax > 0)
            {
                oResult = await RunAsync("POST", "Org_ImportOwnerInformation/" + initialCatalog, oOwners, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }
            }
            #endregion  

            #region "Line Item Taxes Information"
            sectionHeader = "Loading Line Item Taxes .... "; iRowMax = 0;
            TTModels.clsOriginal.tblLineItemTaxes oTaxs = new TTModels.clsOriginal.tblLineItemTaxes();
            for (int i = 0; i < oDTRawData.Rows.Count; i++)
            {
                if (iRowMax > 50)
                {
                    this.lblProgress.Text = "Loading Line Item Taxes Complete ..... " + (i + 1) + " of " + oDTRawData.Rows.Count;
                    valueProgress = (100 * (i + 1)) / oDTRawData.Rows.Count;
                    this.pbarProgress.Value = valueProgress;
                    this.Refresh();

                    oResult = await RunAsync("POST", "Org_ImportLineItemTaxes/" + initialCatalog, oTaxs, "");
                    if (oResult.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(oResult.RequestMessage.ToString());
                    }


                    oTaxs.Clear();
                    iRowMax = 0;
                }
                TTModels.clsOriginal.tblLineItemTax oTax = new TTModels.clsOriginal.tblLineItemTax();

                if (this.chkPCSchool.Checked)
                {
                    decimal faceAmount = 0;
                    decimal discAmount = 0;
                    decimal penlAmount = 0;
                    faceAmount = Convert.ToDecimal(oDTRawData.Rows[i][27].ToString());
                    discAmount = Convert.ToDecimal(oDTRawData.Rows[i][28].ToString());
                    penlAmount = Convert.ToDecimal(oDTRawData.Rows[i][29].ToString());

                    oTax = oParcer.shippensburgPerCapita_LineItemTaxes(oDTRawData.Rows[i], Convert.ToInt32(110), Convert.ToDecimal(5), this.txtFiscalYear.Text, this.txtFiscalSubYear.Text, this.dtDiscStart.Value, discAmount, faceAmount, penlAmount);
                    oTaxs.Add(oTax);
                    iRowMax += 1;

                    faceAmount = Convert.ToDecimal(oDTRawData.Rows[i][30].ToString());
                    discAmount = Convert.ToDecimal(oDTRawData.Rows[i][31].ToString());
                    penlAmount = Convert.ToDecimal(oDTRawData.Rows[i][32].ToString());
                    oTax = oParcer.shippensburgPerCapita_LineItemTaxes(oDTRawData.Rows[i], Convert.ToInt32(120), Convert.ToDecimal(5), this.txtFiscalYear.Text, this.txtFiscalSubYear.Text, this.dtDiscStart.Value, discAmount, faceAmount, penlAmount);
                    oTaxs.Add(oTax);
                    iRowMax += 1;
                }

                if (this.chkSchool.Checked)
                {
                    decimal faceAmount = Convert.ToDecimal(oDTRawData.Rows[i][56].ToString()) + Convert.ToDecimal(oDTRawData.Rows[i][68].ToString());
                    decimal discAmount = Convert.ToDecimal(oDTRawData.Rows[i][57].ToString()) + Convert.ToDecimal(oDTRawData.Rows[i][69].ToString());
                    decimal penlAmount = Convert.ToDecimal(oDTRawData.Rows[i][58].ToString()) + Convert.ToDecimal(oDTRawData.Rows[i][70].ToString());

                    oTax = oParcer.shippensburgRealEstate_LineItemTaxes(oDTRawData.Rows[i], Convert.ToInt32(this.txtSchoolID.Text), Convert.ToDecimal(this.txtSchoolMills.Text), this.txtFiscalYear.Text, this.txtFiscalSubYear.Text, this.dtDiscStart.Value, discAmount, faceAmount, penlAmount);
                    oTaxs.Add(oTax);
                    iRowMax += 1;

                    // Check for Reduction
                    if (Convert.ToDecimal(oDTRawData.Rows[i][68]) > 0)
                    {
                        faceAmount = (-1) * Convert.ToDecimal(oDTRawData.Rows[i][68].ToString());
                        discAmount = (-1) * Convert.ToDecimal(oDTRawData.Rows[i][69].ToString());
                        penlAmount = (-1) * Convert.ToDecimal(oDTRawData.Rows[i][70].ToString());
                        oTax = oParcer.shippensburgRealEstate_LineItemTaxes(oDTRawData.Rows[i], 1000, Convert.ToDecimal(this.txtSchoolMills.Text), this.txtFiscalYear.Text, this.txtFiscalSubYear.Text, this.dtDiscStart.Value, discAmount, faceAmount, penlAmount);
                        oTaxs.Add(oTax);
                        iRowMax += 1;
                    }

                }

            }

            if (iRowMax > 0)
            {
                oResult = await RunAsync("POST", "Org_ImportLineItemTaxes/" + initialCatalog, oTaxs, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }
            }
            #endregion

            #region "PaymentPeriods"
            if (this.chkPCSchool.Checked)
            {
                TTModels.clsOriginal.tblPaymentPeriod oPeriod = new TTModels.clsOriginal.tblPaymentPeriod();
                //School PC 1
                oPeriod.keyPaymentPeriodsID = 0;
                oPeriod.payPeriodDateDiscountStart = this.dtDiscStart.Value;
                oPeriod.payPeriodDateDiscountEnd = this.dtDiscEnd.Value;
                oPeriod.payPeriodDateFaceStart = this.dtFaceStart.Value;
                oPeriod.payPeriodDateFaceEnd = this.dtFaceEnd.Value;
                oPeriod.payPeriodDatePenaltyStart = this.dtPenlStart.Value;
                oPeriod.payPeriodDatePenaltyEnd = this.dtPenlEnd.Value;
                oPeriod.payPeriodFiscalYear = this.txtFiscalYear.Text;
                oPeriod.payPeriodFiscalSubYear = this.txtFiscalSubYear.Text;
                oPeriod.payPeriodInstallmentNumber = 0;
                oPeriod.payPeriodIntReference = 0;
                oPeriod.payPeriodTaxTypeID = Convert.ToInt32(110);
                oPeriod.payPeriodDiscountPercent = 2;
                oPeriod.payPeriodPenaltyPercent = 10;
                oPeriod.payPeriodIntReference = 0;
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }

                oPeriod.payPeriodTaxTypeID = Convert.ToInt32(120);
                //School PC 2
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }
            }

            if (this.chkSchool.Checked)
            {
                TTModels.clsOriginal.tblPaymentPeriod oPeriod = new TTModels.clsOriginal.tblPaymentPeriod();

                //School
                oPeriod.keyPaymentPeriodsID = 0;
                oPeriod.payPeriodDateDiscountStart = this.dtDiscStart.Value;
                oPeriod.payPeriodDateDiscountEnd = this.dtDiscEnd.Value;
                oPeriod.payPeriodDateFaceStart = this.dtFaceStart.Value;
                oPeriod.payPeriodDateFaceEnd = this.dtFaceEnd.Value;
                oPeriod.payPeriodDatePenaltyStart = this.dtPenlStart.Value;
                oPeriod.payPeriodDatePenaltyEnd = this.dtPenlEnd.Value;
                oPeriod.payPeriodFiscalYear = this.txtFiscalYear.Text;
                oPeriod.payPeriodFiscalSubYear = this.txtFiscalSubYear.Text;
                oPeriod.payPeriodInstallmentNumber = 0;
                oPeriod.payPeriodIntReference = 0;
                oPeriod.payPeriodTaxTypeID = Convert.ToInt32(this.txtSchoolID.Text);
                oPeriod.payPeriodDiscountPercent = 2;
                oPeriod.payPeriodPenaltyPercent = 2;
                oPeriod.payPeriodIntReference = 0;
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }

                //School Reduction
                oPeriod.payPeriodTaxTypeID = Convert.ToInt32(1000);
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }

                //School Installment 1
                oPeriod.keyPaymentPeriodsID = 0;
                oPeriod.payPeriodDateDiscountStart = this.dtDiscStart.Value.AddDays(-1);
                oPeriod.payPeriodDateDiscountEnd = this.dtDiscStart.Value.AddDays(-2);
                oPeriod.payPeriodDateFaceStart = this.dtDiscStart.Value;
                oPeriod.payPeriodDateFaceEnd = this.dtInstallment1.Value;
                oPeriod.payPeriodDatePenaltyStart = this.dtInstallment1.Value.AddDays(1);
                oPeriod.payPeriodDatePenaltyEnd = this.dtPenlEnd.Value;
                oPeriod.payPeriodInstallmentNumber = 1;
                oPeriod.payPeriodTaxTypeID = Convert.ToInt32(this.txtSchoolID.Text);
                oPeriod.payPeriodDiscountPercent = 0;
                oPeriod.payPeriodPenaltyPercent = 2;
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }

                //School Reduction Installment 1
                oPeriod.payPeriodTaxTypeID = 1000;
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }

                //School Installment 2
                oPeriod.payPeriodDateFaceEnd = this.dtInstallment2.Value;
                oPeriod.payPeriodDatePenaltyStart = this.dtInstallment2.Value.AddDays(1);
                oPeriod.payPeriodInstallmentNumber = 2;
                oPeriod.payPeriodTaxTypeID = Convert.ToInt32(this.txtSchoolID.Text);
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }

                //School Reduction Installment 2
                oPeriod.payPeriodTaxTypeID = 1000;
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }

                //School Installment 3
                oPeriod.payPeriodDateFaceEnd = this.dtInstallment3.Value;
                oPeriod.payPeriodDatePenaltyStart = this.dtInstallment3.Value.AddDays(1);
                oPeriod.payPeriodInstallmentNumber = 3;
                oPeriod.payPeriodTaxTypeID = Convert.ToInt32(this.txtSchoolID.Text);
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }

                //School Reduction Installment 3
                oPeriod.payPeriodTaxTypeID = 1000;
                oResult = await RunAsync("POST", "Org_ImportPaymentPeriods/" + initialCatalog, oPeriod, "");
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.RequestMessage.ToString());
                }

            }
            #endregion

            #region "Starting Figures"
            //Get Starting Figures
            DataTable oDT = new DataTable();
            oDT = getStartingFigures();

            TTModels.clsOriginal.tblStartingFigures oFigures = new TTModels.clsOriginal.tblStartingFigures();
            for (int i = 0; i < oDT.Rows.Count; i++)
            {
                TTModels.clsOriginal.tblStartingFigure oFigure = new TTModels.clsOriginal.tblStartingFigure();
                oFigure.keyStartingFigureID = 0;
                oFigure.sfigAssessmentTotal = 0;
                oFigure.sfigDiscountAmount = Convert.ToDecimal(oDT.Rows[i]["SumDiscount"].ToString());
                oFigure.sfigFaceAmount = Convert.ToDecimal(oDT.Rows[i]["SumFace"].ToString());
                oFigure.sfigPenaltyAmount = Convert.ToDecimal(oDT.Rows[i]["SumPenalty"].ToString());
                oFigure.sfigTaxableTotal = 0;
                oFigure.sfigTaxTypeID =  Convert.ToInt32(oDT.Rows[i]["litemIntTaxTypeID"].ToString());
                oFigure.sfigFiscalYear = this.txtFiscalYear.Text;
                oFigure.sfigFiscalSubYear = this.txtFiscalSubYear.Text;
                oFigures.Add(oFigure);
            }
            oResult = await RunAsync("POST", "Org_ImportStartingFigures/" + initialCatalog, oFigures, "");
            if (oResult.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(oResult.RequestMessage.ToString());
            }

            //Load the class
            //Perform API call
            #endregion

            this.pbarProgress.Value = 100;
            this.lblProgress.Text = "Loading Complete. ";

            MessageBox.Show("Load is Complete");
        }
    }
}
