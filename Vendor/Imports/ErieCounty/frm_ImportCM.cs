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
    public partial class frm_ImportCM : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        public frm_ImportCM()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.txtFileName.Text = oFunc.getFileName(this.txtFileName.Text);
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            this.txtFileName2.Text = oFunc.getFileName(this.txtFileName2.Text);
        }

        private Classes.clsParcers.erieNormalCMs loadCountyClass()
        {
            Classes.clsParcers.erieNormalCMs dataRecs = new Classes.clsParcers.erieNormalCMs();
            for (int i = 0; i < this.dgFileImport.Rows.Count; i++)
            {
                Classes.clsParcers.erieNormalCM dataRec = new Classes.clsParcers.erieNormalCM()
                {
                    Code                      = this.dgFileImport.Rows[i].Cells[0].Value.ToString(),
                    district                  = this.dgFileImport.Rows[i].Cells[1].Value.ToString(),
                    schoolDistrict            = this.dgFileImport.Rows[i].Cells[2].Value.ToString(),
                    parcelNumber              = this.dgFileImport.Rows[i].Cells[3].Value.ToString(),
                    ownerName1                = this.dgFileImport.Rows[i].Cells[4].Value.ToString(),
                    ownerName2                = this.dgFileImport.Rows[i].Cells[5].Value.ToString(),
                    address1                  = this.dgFileImport.Rows[i].Cells[6].Value.ToString(),
                    address2                  = this.dgFileImport.Rows[i].Cells[7].Value.ToString(),
                    address3                  = this.dgFileImport.Rows[i].Cells[8].Value.ToString(),
                    location                  = this.dgFileImport.Rows[i].Cells[9].Value.ToString(),
                    legal1                    = this.dgFileImport.Rows[i].Cells[10].Value.ToString(),
                    legal2                    = this.dgFileImport.Rows[i].Cells[11].Value.ToString(),
                    currLand                  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[12].Value.ToString()),
                    currBuilding              = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[13].Value.ToString()),
                    currTotal                 = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[14].Value.ToString()),
                    taxCode                   = this.dgFileImport.Rows[i].Cells[15].Value.ToString(),
                    acres                     = this.dgFileImport.Rows[i].Cells[16].Value.ToString(),
                    taxTotal                  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[17].Value.ToString()),
                    hydTotal                  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[18].Value.ToString()),
                    ltsTotal                  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[19].Value.ToString()),
                    swrTotal                  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[20].Value.ToString()),
                    countyTax                 = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[21].Value.ToString()),
                    muniTax                   = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[22].Value.ToString()),
                    schoolTax                 = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[23].Value.ToString()),
                    libTax                    = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[24].Value.ToString()),
                    countyMills               = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[25].Value.ToString()),
                    muniMills                 = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[26].Value.ToString()),
                    schoolMills               = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[27].Value.ToString()),
                    libMills                  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[28].Value.ToString()),
                    book                      = this.dgFileImport.Rows[i].Cells[29].Value.ToString(),
                    page                      = this.dgFileImport.Rows[i].Cells[30].Value.ToString(),
                    LUC                       = this.dgFileImport.Rows[i].Cells[31].Value.ToString(),
                    cleanGreen                = this.dgFileImport.Rows[i].Cells[32].Value.ToString(),
                    lertaFlag                 = this.dgFileImport.Rows[i].Cells[33].Value.ToString(),
                    fairLand                  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[34].Value.ToString()),
                    fairBuilding              = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[35].Value.ToString()),
                    fairTotal                 = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[36].Value.ToString()),
                    lertaBuilding             = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[37].Value.ToString()),
                    _countyHomestead          = this.dgFileImport.Rows[i].Cells[38].Value.ToString(),
                    _countyFarmstead          = this.dgFileImport.Rows[i].Cells[39].Value.ToString(),
                    _muniHomestead            = this.dgFileImport.Rows[i].Cells[40].Value.ToString(),
                    _muniFarmstead            = this.dgFileImport.Rows[i].Cells[41].Value.ToString(),
                    _schoolHomestead          = this.dgFileImport.Rows[i].Cells[42].Value.ToString(),
                    _schoolFarmstead          = this.dgFileImport.Rows[i].Cells[43].Value.ToString(),
                    countyAssessLessExclusion = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[44].Value.ToString()),
                    muniAssessLessExclusion   = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[45].Value.ToString()),
                    schoolAssessLessExclusion = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[46].Value.ToString()),
                    origCountyTax             = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[47].Value.ToString()),
                    origMuniTax               = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[48].Value.ToString()),
                    origSchoolTax             = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[49].Value.ToString()),
                    countyHomesteadExclusion  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[50].Value.ToString()),
                    muniHomesteadExclusion    = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[51].Value.ToString()),
                    schoolHomesteadExclusion  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[52].Value.ToString()),
                    countyFarmesteadExclusion = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[53].Value.ToString()),
                    muniFarmsteadExclusion    = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[54].Value.ToString()),
                    schoolFarmsteadExclusion  = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[55].Value.ToString()),
                    homesteadEligible         = this.dgFileImport.Rows[i].Cells[56].Value.ToString(),
                    farmsteadEligible         = this.dgFileImport.Rows[i].Cells[57].Value.ToString()
                };
                dataRecs.Add(dataRec);
            }
            return dataRecs;
        }
        private TTModels.clsOriginal.eriePrinterRecords loadPrinterClass()
        {
            TTModels.clsOriginal.eriePrinterRecords dataRecs = new TTModels.clsOriginal.eriePrinterRecords();
            for (int i = 0; i < this.dgFileImport2.Rows.Count; i++)
            {
                TTModels.clsOriginal.eriePrinterRecord dataRec = new TTModels.clsOriginal.eriePrinterRecord()
                {
                    parcelNumber = this.dgFileImport2.Rows[i].Cells[1].Value.ToString(),
                    discountAmount = Convert.ToDecimal(this.dgFileImport2.Rows[i].Cells[26].Value.ToString()),
                    penaltyAmount = Convert.ToDecimal(this.dgFileImport2.Rows[i].Cells[27].Value.ToString())
                };
                dataRecs.Add(dataRec);
            }
            return dataRecs;
        }

        Classes.clsParcers.erieNormalCMs countyRecs = new Classes.clsParcers.erieNormalCMs();
        TTModels.clsOriginal.eriePrinterRecords printerRecs = new TTModels.clsOriginal.eriePrinterRecords();
        private void btnLoadDatagrid_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string fileName = System.IO.Path.GetFileName(this.txtFileName2.Text);
            string pathName = this.txtFileName2.Text.Replace(fileName, "").ToString();

            DataTable oDTRawData2 = new DataTable();
            oDTRawData2 = oFunc.getDataFromCSV(this.txtFileName2.Text, fileName, pathName).Tables[0];
            this.dgFileImport2.DataSource = oDTRawData2;
            printerRecs = loadPrinterClass();

            fileName = System.IO.Path.GetFileName(this.txtFileName.Text);
            pathName = this.txtFileName.Text.Replace(fileName, "").ToString();
            DataTable oDTRawData = new DataTable();
            oDTRawData = oFunc.getDataFromCSV(this.txtFileName.Text, fileName, pathName).Tables[0];
            this.dgFileImport.DataSource = oDTRawData;
            countyRecs = loadCountyClass();
            Cursor = Cursors.Default;

            MessageBox.Show("Load Complete");

        }

        private TTModels.clsOriginal.tblStartingFigures loadStartingFigures(string environ)
        {
            string URI = ""; DataSet oDS = new DataSet();
            URI += "http://208.109.186.146:100/api/WebServices/" + environ + "/qry_Importing_GetTaxRollTotals";
            URI += "/litemStrFiscalYear/" + this.txtFiscalYear.Text;
            URI += "/litemStrFiscalSubYear/" + this.txtFiscalSubYear.Text;
            oDS = oFunc.getData_V15(URI, TTModels.clsStatic.applicationToken, System.Guid.Empty.ToString());

            TTModels.clsOriginal.tblStartingFigures startingfigureDatas = new TTModels.clsOriginal.tblStartingFigures();
            for (int i = 0; i < oDS.Tables[0].Rows.Count; i++)
            {
                TTModels.clsOriginal.tblStartingFigure startingfigureData = new TTModels.clsOriginal.tblStartingFigure()
                {
                    keyStartingFigureID = 0,
                    sfigAssessmentTotal = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumAssessmentTotal"].ToString()),
                    sfigDiscountAmount = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumDiscount"].ToString()),
                    sfigFaceAmount = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumFace"].ToString()),
                    sfigPenaltyAmount = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumPenalty"].ToString()),
                    sfigFiscalSubYear = oDS.Tables[0].Rows[i]["litemStrFiscalSubYear"].ToString(),
                    sfigFiscalYear = oDS.Tables[0].Rows[i]["litemStrFiscalYear"].ToString(),
                    sfigTaxableTotal = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumTaxableTotal"].ToString()),
                    sfigTaxTypeID = Convert.ToInt32(oDS.Tables[0].Rows[i]["litemIntTaxTypeID"].ToString())
                };
                startingfigureDatas.Add(startingfigureData);
            }
            return startingfigureDatas;
        }

        private TTModels.clsOriginal.tblPaymentPeriods loadPaymentPeriods
            ( DateTime discS, DateTime discE, DateTime faceS, DateTime faceE, DateTime penlS, DateTime penlE)
        {
            TTModels.clsOriginal.tblPaymentPeriods dataRecs = new TTModels.clsOriginal.tblPaymentPeriods();
            if (this.chkCounty.Checked)
            {
                TTModels.clsOriginal.tblPaymentPeriod countyRec = new TTModels.clsOriginal.tblPaymentPeriod()
                {
                    keyPaymentPeriodsID = 0,
                    payPeriodDateDiscountEnd = discE,
                    payPeriodDateDiscountStart = discS,
                    payPeriodDateFaceEnd = faceE,
                    payPeriodDateFaceStart = faceS,
                    payPeriodDatePenaltyEnd = penlE,
                    payPeriodDatePenaltyStart = penlS,
                    payPeriodDiscountPercent = 0.02M,
                    payPeriodFiscalSubYear = this.txtFiscalSubYear.Text,
                    payPeriodFiscalYear = this.txtFiscalYear.Text,
                    payPeriodInstallmentNumber = 0,
                    payPeriodIntReference = 0,
                    payPeriodPenaltyPercent = 0.10M,
                    payPeriodTaxTypeID = Convert.ToInt32(this.txtCountyID.Text)
                };
                dataRecs.Add(countyRec);
            }
            if (this.chkMuni.Checked)
            {
                TTModels.clsOriginal.tblPaymentPeriod muniRec = new TTModels.clsOriginal.tblPaymentPeriod()
                {
                    keyPaymentPeriodsID = 0,
                    payPeriodDateDiscountEnd = discE,
                    payPeriodDateDiscountStart = discS,
                    payPeriodDateFaceEnd = faceE,
                    payPeriodDateFaceStart = faceS,
                    payPeriodDatePenaltyEnd = penlE,
                    payPeriodDatePenaltyStart = penlS,
                    payPeriodDiscountPercent = 0.02M,
                    payPeriodFiscalSubYear = this.txtFiscalSubYear.Text,
                    payPeriodFiscalYear = this.txtFiscalYear.Text,
                    payPeriodInstallmentNumber = 0,
                    payPeriodIntReference = 0,
                    payPeriodPenaltyPercent = 0.10M,
                    payPeriodTaxTypeID = Convert.ToInt32(this.txtMuniID.Text)
                };
                dataRecs.Add(muniRec);
            }
            if (this.chkMuniReduction.Checked)
            {
                TTModels.clsOriginal.tblPaymentPeriod muniReductionRec = new TTModels.clsOriginal.tblPaymentPeriod()
                {
                    keyPaymentPeriodsID = 0,
                    payPeriodDateDiscountEnd = discE,
                    payPeriodDateDiscountStart = discS,
                    payPeriodDateFaceEnd = faceE,
                    payPeriodDateFaceStart = faceS,
                    payPeriodDatePenaltyEnd = penlE,
                    payPeriodDatePenaltyStart = penlS,
                    payPeriodDiscountPercent = 0.02M,
                    payPeriodFiscalSubYear = this.txtFiscalSubYear.Text,
                    payPeriodFiscalYear = this.txtFiscalYear.Text,
                    payPeriodInstallmentNumber = 0,
                    payPeriodIntReference = 0,
                    payPeriodPenaltyPercent = 0.10M,
                    payPeriodTaxTypeID = Convert.ToInt32(this.txtMuniReductionID.Text)
                };
                dataRecs.Add(muniReductionRec);
            }
            if (this.chkLibrary.Checked)
            {
                TTModels.clsOriginal.tblPaymentPeriod libReductionRec = new TTModels.clsOriginal.tblPaymentPeriod()
                {
                    keyPaymentPeriodsID = 0,
                    payPeriodDateDiscountEnd = discE,
                    payPeriodDateDiscountStart = discS,
                    payPeriodDateFaceEnd = faceE,
                    payPeriodDateFaceStart = faceS,
                    payPeriodDatePenaltyEnd = penlE,
                    payPeriodDatePenaltyStart = penlS,
                    payPeriodDiscountPercent = 0.02M,
                    payPeriodFiscalSubYear = this.txtFiscalSubYear.Text,
                    payPeriodFiscalYear = this.txtFiscalYear.Text,
                    payPeriodInstallmentNumber = 0,
                    payPeriodIntReference = 0,
                    payPeriodPenaltyPercent = 0.10M,
                    payPeriodTaxTypeID = Convert.ToInt32(this.txtLibraryID.Text)
                };
                dataRecs.Add(libReductionRec);
            }
            return dataRecs;
        }

        TTModels.clsOriginal.tblOwnerInformations ownerRecs = new TTModels.clsOriginal.tblOwnerInformations();
        private void processOwners(Classes.clsParcers.erieNormalCMs inDatas)
        {
            foreach (Classes.clsParcers.erieNormalCM inData in inDatas)
            {
                string address = "";
                address = inData.address1;
                if (inData.address2.Trim() != "") { address += "\n" + inData.address2; }
                if (inData.address3.Trim() != "") { address += "\n" + inData.address3; }
                TTModels.clsOriginal.tblOwnerInformation dataRec = new TTModels.clsOriginal.tblOwnerInformation()
                {
                    keyOwnerID = 0,
                    ownerBolCurrent = true,
                    ownerDateEffectiveDate = this.dtDiscStart.Value,
                    ownerDateLastUpdated = DateTime.Now,
                    ownerMemoBillingAddress = address,
                    ownerStrBillingZipCode = "",
                    ownerStrOwnerName1 = inData.ownerName1,
                    ownerStrOwnerName2 = inData.ownerName2,
                    ownerStrParcelNumber = inData.parcelNumber
                };
                ownerRecs.Add(dataRec);
            }



        }

        #region "RunAsync"
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
                if (sMethod == "POST") { oResponse = await client.PostAsJsonAsync("api/" + sAPI, sData); }
                if (sMethod == "PUT")  { oResponse = await client.PutAsJsonAsync("api/" + sAPI, sData); }
                return oResponse;
            }

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
        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblPaymentPeriods sData, string sToken)
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
        #endregion

        #region "Build Line Items"
        public TTModels.clsOriginal.tblLineItemTax buildLineItems(Classes.clsParcers.erieNormalCM dataIn, int taxTypeID, decimal taxTypeRate, int billNumber)
        {
            decimal amtFace = 0; decimal amtDisc = 0; decimal amtPenl = 0;
            if (taxTypeID == 1) { amtFace = dataIn.countyTax; }
            if (taxTypeID == 2) { amtFace = dataIn.origMuniTax; }
            if (taxTypeID == 6) { amtFace = dataIn.origMuniTax; } // validate this with Cameron's Data
            if (taxTypeID == 9) { amtFace = dataIn.libTax; }

            decimal dPerc = 0;

            dPerc = 0.98M; amtDisc = amtFace * dPerc;
            dPerc = 1.1M;  amtPenl = amtFace * dPerc;
            amtDisc = Math.Round(amtDisc, 2);
            amtPenl = Math.Round(amtPenl, 2);

            if (taxTypeID == 6)
            {
                amtDisc = (-1) * amtDisc;
                amtFace = (-1) * amtFace;
                amtPenl = (-1) * amtPenl;
            }

            TTModels.clsOriginal.tblLineItemTax dataRec = new TTModels.clsOriginal.tblLineItemTax()
            {
                keyLineItemID = 0,
                litemAmountPaid = 0,
                litemBolCloseOut = false,
                litemBolInterim = false,
                litemBolSelectedRow = false,
                litemCurrAssessedBuilding = dataIn.fairBuilding,
                litemCurrAssessedLand = dataIn.fairLand,
                litemCurrAssessedMineral = 0,
                litemCurrAssessedTotal = dataIn.fairTotal,
                litemCurrBuilding = dataIn.currBuilding,
                litemCurrLand = dataIn.currLand,
                litemCurrTotal = dataIn.currTotal,
                litemCurrMineral = 0,
                litemCurrPrevBuilding = 0,
                litemCurrPrevLand = 0,
                litemCurrPrevMineral = 0,
                litemCurrPrevTotal = 0,
                litemCurrTaxAmountDiscount = amtDisc,
                litemCurrTaxAmountFace = amtFace,
                litemCurrTaxAmountPenalty = amtPenl,
                litemDateEffectiveDate = Convert.ToDateTime(this.dtDiscStart.Value.ToString("MM/dd/yyyy")),
                litemDateInterimDate = DateTime.MaxValue,
                litemDateLastUpdatedDate = DateTime.Now,
                litemDblRate = taxTypeRate,
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
                litemStrBarCodeValue = dataIn.parcelNumber,
                litemStrBillNumber = billNumber.ToString("000000"),
                litemStrFiscalSubYear = this.txtFiscalSubYear.Text,
                litemStrFiscalYear = this.txtFiscalYear.Text,
                litemStrParcelNumber = dataIn.parcelNumber
            };
            return dataRec;
        }
        #endregion

        #region "Build Printer Correction Records"

        DataTable oDTTaxRoll = new DataTable();
        private void getTaxRollTotals()
        {
            environ = "TTrackerErie" + this.cboDistrict.Text.Substring(0, 2);
            if (this.cboDistrict.Text.Substring(0, 2) == "CC") { environ = "TTrackerErieCoC"; }
            if (this.cboDistrict.Text.Substring(0, 2) == "NE") { environ = "TTrackerErieNEB"; }
            if (this.cboDistrict.Text.Substring(0, 2) == "UC") { environ = "TTrackerErieUCB"; }
            string URI = Globals.Url15 + "/api/Org_ErieRounding_GetBillTotals/" + environ + "/" + this.txtFiscalYear.Text + "/" + this.txtFiscalSubYear.Text;
            oDTTaxRoll = oFunc.getData_V15(URI, "", "").Tables[0];
        }
        private TTModels.clsOriginal.fixErieRoundings fixRounding()
        {
            TTModels.clsOriginal.fixErieRoundings dataRecs = new TTModels.clsOriginal.fixErieRoundings();
            int changeCounter = 0;
            getTaxRollTotals();


            for (int i = 0; i < oDTTaxRoll.Rows.Count; i++)
            {
                if (Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumPaid"].ToString()) == 0 && Convert.ToDecimal(oDTTaxRoll.Rows[i]["SumDiscount"].ToString()) > 0)
                {
                    changeCounter++;

                    foreach (TTModels.clsOriginal.eriePrinterRecord data in printerRecs)
                    {
                        decimal discountAdjustment = 0;
                        decimal penaltyAdjustment = 0;
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
                            TTModels.clsOriginal.fixErieRounding oRec = new TTModels.clsOriginal.fixErieRounding()
                            {
                                discountCorrection = discountAdjustment,
                                fiscalSubYear = this.txtFiscalSubYear.Text,
                                fiscalYear = this.txtFiscalYear.Text,
                                parcelNumber = data.parcelNumber,
                                penaltyCorrection = penaltyAdjustment,
                                taxTypeID = 1
                            };
                            dataRecs.Add(oRec);
                        }
                        #endregion

                    }

                }
            }

            return dataRecs;
        }
        
        #endregion

        #region "Handle the Parcel Information"
        DataTable oDTListOfExisingParcels = new DataTable();
        private void getListOfParcels()
        {
            environ = "TTrackerErie" + this.cboDistrict.Text.Substring(0, 2);
            if (this.cboDistrict.Text.Substring(0, 2) == "CC") { environ = "TTrackerErieCoC"; }
            if (this.cboDistrict.Text.Substring(0, 2) == "NE") { environ = "TTrackerErieNEB"; }
            if (this.cboDistrict.Text.Substring(0, 2) == "UC") { environ = "TTrackerErieUCB"; }
            string URI = ""; DataSet oDS = new DataSet();
            URI += "http://208.109.186.146:100/api/WebServices/" + environ + "/_qry_Importing_ListOfParcels";
            try
            {
                oDTListOfExisingParcels = oFunc.getData_V15(URI, TTModels.clsStatic.applicationToken, System.Guid.Empty.ToString()).Tables[0];
            }
            catch { }

        }
        private Boolean checkForParcel(string parcelNumber)
        {
            Boolean bFound = false;

            for (int i = 0; i < oDTListOfExisingParcels.Rows.Count; i++)
            {
                if (oDTListOfExisingParcels.Rows[i]["parcelStrNumber"].ToString() == parcelNumber)
                {
                    bFound = true;
                    i = oDTListOfExisingParcels.Rows.Count;
                }
            }

            return bFound;
        }

        private TTModels.clsOriginal.tblLineItemTax loadStreetLight(Classes.clsParcers.erieNormalCM dataIn, int billNumber)
        {
            TTModels.clsOriginal.tblLineItemTax dataRec = new TTModels.clsOriginal.tblLineItemTax();
            for (int i = 0; i < this.dgFileImport2.Rows.Count; i++)
            {
                if (this.dgFileImport2.Rows[i].Cells[2].Value.ToString() == dataIn.parcelNumber)
                {
                    if (Convert.ToDecimal(this.dgFileImport2.Rows[i].Cells[33].Value.ToString()) > 0)
                    {
                        decimal percPenalty = 1.1M;
                        decimal amtFace = Convert.ToDecimal(this.dgFileImport2.Rows[i].Cells[33].Value.ToString());
                        decimal amtDisc = amtFace;
                        decimal amtPenl = Math.Round((amtFace * percPenalty), 2);
                        dataRec.keyLineItemID = 0;
                        dataRec.litemAmountPaid = 0;
                        dataRec.litemBolCloseOut = false;
                        dataRec.litemBolInterim = false;
                        dataRec.litemBolSelectedRow = false;
                        dataRec.litemCurrAssessedBuilding = dataIn.fairBuilding;
                        dataRec.litemCurrAssessedLand = dataIn.fairLand;
                        dataRec.litemCurrAssessedMineral = 0;
                        dataRec.litemCurrAssessedTotal = dataIn.fairTotal;
                        dataRec.litemCurrBuilding = dataIn.currBuilding;
                        dataRec.litemCurrLand = dataIn.currLand;
                        dataRec.litemCurrTotal = dataIn.currTotal;
                        dataRec.litemCurrMineral = 0;
                        dataRec.litemCurrPrevBuilding = 0;
                        dataRec.litemCurrPrevLand = 0;
                        dataRec.litemCurrPrevMineral = 0;
                        dataRec.litemCurrPrevTotal = 0;
                        dataRec.litemCurrTaxAmountDiscount = amtDisc;
                        dataRec.litemCurrTaxAmountFace = amtFace;
                        dataRec.litemCurrTaxAmountPenalty = amtPenl;
                        dataRec.litemDateEffectiveDate = Convert.ToDateTime(this.dtDiscStart.Value.ToString("MM/dd/yyyy"));
                        dataRec.litemDateInterimDate = DateTime.MaxValue;
                        dataRec.litemDateLastUpdatedDate = DateTime.Now;
                        dataRec.litemDblRate = 0;
                        dataRec.litemIntInstallmentNumber = 0;
                        dataRec.litemIntInterimMonths = 12;
                        dataRec.litemIntPaymentPeriodID = 0;
                        dataRec.litemIntPaymentStatusID = 0;
                        dataRec.litemIntPaymentTypeID = 0;
                        dataRec.litemIntReceiptNumber = 0;
                        dataRec.litemIntRemittalID = 0;
                        dataRec.litemIntTaxTypeID = 5;
                        dataRec.litemMemoNotes = "";
                        dataRec.litemPaymentID = 0;
                        dataRec.litemStrBarCodeValue = dataIn.parcelNumber;
                        dataRec.litemStrBillNumber = billNumber.ToString("000000");
                        dataRec.litemStrFiscalSubYear = this.txtFiscalSubYear.Text;
                        dataRec.litemStrFiscalYear = this.txtFiscalYear.Text;
                        dataRec.litemStrParcelNumber = dataIn.parcelNumber;
                        i = this.dgFileImport2.Rows.Count;
                    }
                }
            }
            return dataRec;
        }


        private TTModels.clsOriginal.tblParcelInformation loadNewParcel(Classes.clsParcers.erieNormalCM dataIn)
        {
            if (!checkForParcel(dataIn.parcelNumber))
            {
                TTModels.clsOriginal.tblParcelInformation dataRec = new TTModels.clsOriginal.tblParcelInformation()
                {
                    keyParcelID = 0,
                    parcelMemoLegal = dataIn.legal1 + "\n" + dataIn.legal2,
                    parcelMemoLocation = dataIn.location,
                    parcelMemoNotes = "",
                    parcelStrAcres = dataIn.acres,
                    parcelStrBook = dataIn.book,
                    parcelStrCleanAndGreen = dataIn.cleanGreen,
                    parcelStrCode = dataIn.Code,
                    parcelStrControlNumber = dataIn.parcelNumber,
                    parcelStrDistrict = dataIn.district,
                    parcelStrFarmsteadValue = dataIn.farmsteadEligible,
                    parcelStrHomesteadValue = dataIn.homesteadEligible,
                    parcelStrNumber = dataIn.parcelNumber,
                    parcelStrPage = dataIn.page,
                    parcelStrSchoolDistrict = dataIn.schoolDistrict,
                    parcelStrTaxCode = dataIn.taxCode
                };
                return dataRec;
            }
            else
            {
                return null;
            }
        }
        private TTModels.clsOriginal.tblParcelInformation loadExistingParcel(Classes.clsParcers.erieNormalCM dataIn)
        {
            if (checkForParcel(dataIn.parcelNumber))
            {
                TTModels.clsOriginal.tblParcelInformation dataRec = new TTModels.clsOriginal.tblParcelInformation()
                {
                    keyParcelID = 0,
                    parcelMemoLegal = dataIn.legal1 + "\n" + dataIn.legal2,
                    parcelMemoLocation = dataIn.location,
                    parcelMemoNotes = "",
                    parcelStrAcres = dataIn.acres,
                    parcelStrBook = dataIn.book,
                    parcelStrCleanAndGreen = dataIn.cleanGreen,
                    parcelStrCode = dataIn.Code,
                    parcelStrControlNumber = dataIn.parcelNumber,
                    parcelStrDistrict = dataIn.district,
                    parcelStrFarmsteadValue = dataIn.farmsteadEligible,
                    parcelStrHomesteadValue = dataIn.homesteadEligible,
                    parcelStrNumber = dataIn.parcelNumber,
                    parcelStrPage = dataIn.page,
                    parcelStrSchoolDistrict = dataIn.schoolDistrict,
                    parcelStrTaxCode = dataIn.taxCode
                };
                return dataRec;
            }
            else
            {
                return null;
            }
        }
        #endregion

        string environ = "";
        private async void btnImport_Click(object sender, EventArgs e)
        {
            getListOfParcels();
            environ = "TTrackerErie" + this.cboDistrict.Text.Substring(0, 2);
            if (this.cboDistrict.Text.Substring(0, 2) == "CC") { environ = "TTrackerErieCoC"; }
            if (this.cboDistrict.Text.Substring(0, 2) == "NE") { environ = "TTrackerErieNEB"; }
            if (this.cboDistrict.Text.Substring(0, 2) == "UC") { environ = "TTrackerErieUCB"; }
            DateTime dateDiscountStart = Convert.ToDateTime(dtDiscStart.Value.ToString("MM/dd/yyyy"));
            DateTime dateDiscountEnd   = Convert.ToDateTime(dtDiscEnd.Value.ToString("MM/dd/yyyy"));
            DateTime dateFaceStart     = Convert.ToDateTime(dtFaceStart.Value.ToString("MM/dd/yyyy"));
            DateTime dateFaceEnd       = Convert.ToDateTime(dtFaceEnd.Value.ToString("MM/dd/yyyy"));
            DateTime datePenaltyStart  = Convert.ToDateTime(dtPenlStart.Value.ToString("MM/dd/yyyy"));
            DateTime datePenaltyEnd    = Convert.ToDateTime(dtPenlEnd.Value.ToString("MM/dd/yyyy"));

            HttpResponseMessage webResponse = new HttpResponseMessage();



            #region "Process Owners"
            //processOwners(countyRecs);
            this.lblProgress.Text = "Process API ... tblOwnerInformation";
            this.Refresh();

            int ownerCntr = 0; int ownerTotalCntr = 0;
            foreach (Classes.clsParcers.erieNormalCM inData in countyRecs)
            {
                ownerCntr++; ownerTotalCntr++;
                string address = "";
                address = inData.address1;
                if (inData.address2.Trim() != "") { address += "\n" + inData.address2; }
                if (inData.address3.Trim() != "") { address += "\n" + inData.address3; }
                TTModels.clsOriginal.tblOwnerInformation dataRec = new TTModels.clsOriginal.tblOwnerInformation()
                {
                    keyOwnerID = 0,
                    ownerBolCurrent = true,
                    ownerDateEffectiveDate = this.dtDiscStart.Value,
                    ownerDateLastUpdated = DateTime.Now,
                    ownerMemoBillingAddress = address,
                    ownerStrBillingZipCode = "",
                    ownerStrOwnerName1 = inData.ownerName1,
                    ownerStrOwnerName2 = inData.ownerName2,
                    ownerStrParcelNumber = inData.parcelNumber
                };
                ownerRecs.Add(dataRec);
                if (ownerCntr > 50)
                {
                    this.lblProgress.Text = ownerTotalCntr.ToString("000000"); this.Refresh();
                    webResponse = await RunAsync("POST", environ + "/Importing/tblOwnerInformation", ownerRecs, System.Guid.NewGuid().ToString());
                    ownerRecs.Clear();
                    ownerCntr = 0;
                }
            }
            if (ownerCntr > 0)
            {
                webResponse = await RunAsync("POST", environ + "/Importing/tblOwnerInformation", ownerRecs, System.Guid.NewGuid().ToString());
                ownerRecs.Clear();
                ownerCntr = 0;
            }





            //MessageBox.Show("Owners\n\n" + webResponse.ToString());

            #endregion

            #region "Process New Parcels"
            int iRecCounter = 0;
            TTModels.clsOriginal.tblParcelInformations parcelDatas = new TTModels.clsOriginal.tblParcelInformations();
            foreach (Classes.clsParcers.erieNormalCM countyRec in countyRecs)
            {

                TTModels.clsOriginal.tblParcelInformation parcelData = new TTModels.clsOriginal.tblParcelInformation();
                parcelData = loadNewParcel(countyRec);

                if (parcelData != null)
                {
                    iRecCounter += 1;
                    parcelDatas.Add(parcelData);
                }

                //Perform the insert
                if (iRecCounter > 1000)
                {
                    webResponse = await RunAsync("POST", environ + "/Importing/tblParcelInformation", parcelDatas, System.Guid.NewGuid().ToString());
                    //MessageBox.Show("New Parcels\n\n" + webResponse.ToString());
                    iRecCounter = 0;
                    parcelDatas.Clear();
                }
            }
            if (iRecCounter > 0)
            {
                webResponse = await RunAsync("POST", environ + "/Importing/tblParcelInformation", parcelDatas, System.Guid.NewGuid().ToString());
                //MessageBox.Show("New Parcels\n\n" + webResponse.ToString());
                iRecCounter = 0;
                parcelDatas.Clear();
            }
            #endregion
            #region "Process Existing Parcels"
            iRecCounter = 0;
            parcelDatas.Clear();
            foreach (Classes.clsParcers.erieNormalCM countyRec in countyRecs)
            {

                TTModels.clsOriginal.tblParcelInformation parcelData = new TTModels.clsOriginal.tblParcelInformation();
                parcelData = loadExistingParcel(countyRec);
                if (parcelData != null)
                {
                    iRecCounter += 1;
                    parcelDatas.Add(parcelData);
                }

                //Perform the insert
                if (iRecCounter > 1000)
                {
                    webResponse = await RunAsync("PUT", environ + "/Importing/tblParcelInformation", parcelDatas, System.Guid.NewGuid().ToString());
                    //MessageBox.Show("Existing Parcels\n\n" + webResponse.ToString());
                    iRecCounter = 0;
                    parcelDatas.Clear();
                }
            }
            if (iRecCounter > 0)
            {
                webResponse = await RunAsync("PUT", environ + "/Importing/tblParcelInformation", parcelDatas, System.Guid.NewGuid().ToString());
                //MessageBox.Show("Existing Parcels\n\n" + webResponse.ToString());
                iRecCounter = 0;
                parcelDatas.Clear();
            }
            #endregion


            #region "Process Line Items"
            int billNumber = 0; iRecCounter = 0;
            foreach (Classes.clsParcers.erieNormalCM countyRec in countyRecs)
            {
                iRecCounter++;
                billNumber += 1;
                TTModels.clsOriginal.tblLineItemTaxes lineItems = new TTModels.clsOriginal.tblLineItemTaxes();
                if (this.chkLibrary.Checked)
                {
                    TTModels.clsOriginal.tblLineItemTax libItem = new TTModels.clsOriginal.tblLineItemTax();
                    libItem = buildLineItems(countyRec, Convert.ToInt32(this.txtLibraryID.Text), Convert.ToDecimal(this.txtLibraryRate.Text), billNumber);
                    lineItems.Add(libItem); 
                }
                if (this.chkCounty.Checked)
                {
                    TTModels.clsOriginal.tblLineItemTax countyLineItem = new TTModels.clsOriginal.tblLineItemTax();
                    countyLineItem = buildLineItems(countyRec, Convert.ToInt32(this.txtCountyID.Text), Convert.ToDecimal(this.txtCountyRate.Text), billNumber);
                    lineItems.Add(countyLineItem);
                }
                if (this.chkMuni.Checked)
                {
                    TTModels.clsOriginal.tblLineItemTax muniLineItem = new TTModels.clsOriginal.tblLineItemTax();
                    muniLineItem = buildLineItems(countyRec, Convert.ToInt32(this.txtMuniID.Text), Convert.ToDecimal(this.txtMuniRate.Text), billNumber);
                    lineItems.Add(muniLineItem);
                }
                if (this.chkMuniReduction.Checked)
                {
                    try
                    {
                        if (countyRec.homesteadEligible.Substring(0, 4).ToUpper() == "HOME")
                        {
                            TTModels.clsOriginal.tblLineItemTax muniReductionLineItem = new TTModels.clsOriginal.tblLineItemTax();
                            muniReductionLineItem = buildLineItems(countyRec, Convert.ToInt32(this.txtMuniReductionID.Text), Convert.ToDecimal(this.txtMuniReductionRate.Text), billNumber);
                            lineItems.Add(muniReductionLineItem);
                        }
                    }
                    catch
                    { }
                }

                //Check for Street Lights
                //TTModels.clsOriginal.tblLineItemTax streetLightLineItem = new TTModels.clsOriginal.tblLineItemTax();
                //streetLightLineItem = loadStreetLight(countyRec, billNumber);
                //if (streetLightLineItem != null)
                //{
                //    if (streetLightLineItem.litemCurrTaxAmountFace > 0)
                //    {
                //        lineItems.Add(streetLightLineItem);
                //    }
                //}

                //Perform the insert.
                webResponse = await RunAsync("POST", environ + "/Importing/tblLineItemTaxes", lineItems, System.Guid.NewGuid().ToString());
                int iValue = (iRecCounter * 100) / countyRecs.Count;
                this.lblProgress.Text = billNumber.ToString("000000"); this.pbarProgress.Value = iValue; this.Refresh();
                //MessageBox.Show("Line Items \n\n" + webResponse.ToString());
                lineItems.Clear();
            }
            #endregion

            //Correct For Printer Records
            //TTModels.clsOriginal.fixErieRoundings printCorrectionRecs = new TTModels.clsOriginal.fixErieRoundings();
            //printCorrectionRecs = fixRounding();
            //if (printCorrectionRecs != null)
            //{

            //}


            #region "Payment Periods"
            //TTModels.clsOriginal.tblPaymentPeriods paymentPeriods = new TTModels.clsOriginal.tblPaymentPeriods();
            //paymentPeriods = loadPaymentPeriods(dateDiscountStart, dateDiscountEnd, dateFaceStart, dateFaceEnd, datePenaltyStart, datePenaltyEnd);
            //webResponse = await RunAsync("POST", environ + "/Importing/tblPaymentPeriods", paymentPeriods, System.Guid.NewGuid().ToString());
            //MessageBox.Show("Payment Periods \n\n" + webResponse.ToString());
            #endregion

            #region "Starting Figures"
            TTModels.clsOriginal.tblStartingFigures startingFigRecs = new TTModels.clsOriginal.tblStartingFigures();
            //startingFigRecs = loadStartingFigures(environ);
            //webResponse = await RunAsync("POST", environ + "/Importing/tblStartingFigures", startingFigRecs, System.Guid.NewGuid().ToString());
            //MessageBox.Show("Starting Figures \n\n" + webResponse.ToString());
            #endregion

        }

        private void frm_ImportCM_Load(object sender, EventArgs e)
        {

        }

        private void dtDiscStart_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
