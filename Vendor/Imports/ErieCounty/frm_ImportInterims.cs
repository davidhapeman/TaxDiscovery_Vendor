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
    public partial class frm_ImportInterims : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        public frm_ImportInterims()
        {
            InitializeComponent();
        }

        private Boolean checkDistrict(string thisEnvironment, string thisParcel)
        {
            Boolean bFound = false;
            switch (thisEnvironment)
            {
                case "TTrackerErie03":
                    if (thisParcel.Substring(0, 2) == "03") { bFound = true; }
                    break;
                case "TTrackerErie25":
                    if (thisParcel.Substring(0, 2) == "25") { bFound = true; }
                    break;
                case "TTrackerErie27":
                    if (thisParcel.Substring(0, 2) == "27") { bFound = true; }
                    break;
                case "TTrackerErie31":
                    if (thisParcel.Substring(0, 2) == "31") { bFound = true; }
                    break;
                case "TTrackerErie33":
                    if (thisParcel.Substring(0, 2) == "33") { bFound = true; }
                    break;
                case "TTrackerErie40":
                    if (thisParcel.Substring(0, 2) == "40") { bFound = true; }
                    break;
                case "TTrackerErieCoC":
                    if (thisParcel.Substring(0, 2) == "05") { bFound = true; }
                    if (thisParcel.Substring(0, 2) == "06") { bFound = true; }
                    if (thisParcel.Substring(0, 2) == "07") { bFound = true; }
                    if (thisParcel.Substring(0, 2) == "08") { bFound = true; }
                    break;
                case "TTrackerErie44":
                    if (thisParcel.Substring(0, 2) == "44") { bFound = true; }
                    break;
                case "TTrackerErieUCB":
                    if (thisParcel.Substring(0, 2) == "41") { bFound = true; }
                    if (thisParcel.Substring(0, 2) == "42") { bFound = true; }
                    break;
                default: break;
            }
            return bFound;
        }

        private string getSchoolDistrict(string districtNumber)
        {
            string schoolDistrict = "";
            switch (districtNumber)
            {
                case "25": schoolDistrict = "Wattsburg Area School District"; break;
                case "27": schoolDistrict = "Harborcreek School District";    break;
                case "31": schoolDistrict = "General McLane School District"; break;
                case "33": schoolDistrict = "Millcreek School District";      break;
                case "40": schoolDistrict = "Ft. Leboeuf School District";    break;
                case "44": schoolDistrict = "Wattsburg Area School District"; break;
                case "03": schoolDistrict = "Corry School District"; break;
                case "05": schoolDistrict = "Corry School District"; break;
                case "06": schoolDistrict = "Corry School District"; break;
                case "07": schoolDistrict = "Corry School District"; break;
                case "08": schoolDistrict = "Corry School District"; break;
                case "41": schoolDistrict = "Union City School District"; break;
                case "42": schoolDistrict = "Union City School District"; break;
                case "43": schoolDistrict = "Union City School District"; break;
            }
            return schoolDistrict;
        }

        private void frm_ImportInterims_Load(object sender, EventArgs e)
        {
            this.dtDiscStart.Value = DateTime.Now;
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.txtFileName.Text = oFunc.getFileName(this.txtFileName.Text);
        }

        private Boolean isValidDistrict(string districtNumber)
        {
            Boolean bValid = false;
            switch (districtNumber)
            {
                case "03": bValid = true; break;
                case "25": bValid = true; break;
                case "27": bValid = true; break;
                case "31": bValid = true; break;
                case "33": bValid = true; break;
                case "40": bValid = true; break;
                case "05": bValid = true; break;
                case "06": bValid = true; break;
                case "07": bValid = true; break;
                case "08": bValid = true; break;
                case "41": bValid = true; break;
                case "42": bValid = true; break;
                case "44": bValid = true; break;
                //case "29": bValid = true; break;

            }
            return bValid;
        }

        Classes.clsParcers.erieInterims rawDatas = new Classes.clsParcers.erieInterims();
        private void loadRawClass(DataTable oDT)
        {
            for (int i = 0; i < oDT.Rows.Count; i++)
            {
                Classes.clsParcers.erieInterim rawData = new Classes.clsParcers.erieInterim()
                {
                    parcelNumber  = oDT.Rows[i][0].ToString(),
                    locationText  = oDT.Rows[i][1].ToString(),
                    parcelClass   = oDT.Rows[i][2].ToString(),
                    LUC           = oDT.Rows[i][3].ToString(),
                    ID            = oDT.Rows[i][4].ToString(),
                    schoolCode    = oDT.Rows[i][5].ToString(),
                    ownerName     = oDT.Rows[i][6].ToString(),
                    ownerAddress1 = oDT.Rows[i][7].ToString(),
                    ownerAddress2 = oDT.Rows[i][8].ToString(),
                    ownerAddress3 = oDT.Rows[i][9].ToString(),
                    bookNumber    = oDT.Rows[i][10].ToString(),
                    pageNumber    = oDT.Rows[i][11].ToString(),
                    cmDate        = oDT.Rows[i][12].ToString(),
                    cmMonths      = oDT.Rows[i][13].ToString(),
                    schoolDate    = oDT.Rows[i][14].ToString(),
                    schoolMonths  = oDT.Rows[i][15].ToString(),
                    btIndr        = oDT.Rows[i][16].ToString(),
                    reasonText    = oDT.Rows[i][17].ToString(),
                    prevLand      = oDT.Rows[i][18].ToString(),
                    prevBuilding  = oDT.Rows[i][19].ToString(),
                    prevTotal     = oDT.Rows[i][20].ToString(),
                    currLand      = oDT.Rows[i][21].ToString(),
                    currBuilding  = oDT.Rows[i][22].ToString(),
                    currTotal     = oDT.Rows[i][23].ToString(),
                    chgLand       = oDT.Rows[i][24].ToString(),
                    chgBuilding   = oDT.Rows[i][25].ToString(),
                    chgTotal      = oDT.Rows[i][26].ToString(),
                    countyFace    = Convert.ToDecimal(oDT.Rows[i][27].ToString()),
                    muniFace      = Convert.ToDecimal(oDT.Rows[i][28].ToString()),
                    schoolFace    = Convert.ToDecimal(oDT.Rows[i][29].ToString())
                };
                if (isValidDistrict(rawData.parcelNumber.Substring(0,2)))
                {
                    rawDatas.Add(rawData);
                }
            }
        }

        DataTable oDTRawData = new DataTable();
        private void btnLoadDatagrid_Click(object sender, EventArgs e)
        {
            string fileName = System.IO.Path.GetFileName(this.txtFileName.Text);
            string pathName = this.txtFileName.Text.Replace(fileName, "").ToString();

            oDTRawData = oFunc.getDataFromCSV(this.txtFileName.Text, fileName, pathName).Tables[0];
            this.dgFileImport.DataSource = oDTRawData;
            loadRawClass(oDTRawData);
            MessageBox.Show("Load Complete");
        }

        #region "Build the Starting Figure Class"
        TTModels.clsOriginal.tblStartingFigures startingfigureDatas = new TTModels.clsOriginal.tblStartingFigures();
        private void buildStartingFigures()
        {
            string URI = ""; DataSet oDS = new DataSet();
            URI += "http://208.109.186.146:100/api/WebServices/" + environ + "/qry_Importing_GetTaxRollTotals";
            URI += "/litemStrFiscalYear/"    + this.txtFiscalYear.Text;
            URI += "/litemStrFiscalSubYear/" + this.txtFiscalSubYear.Text;
            oDS = oFunc.getData_V15(URI, TTModels.clsStatic.applicationToken, System.Guid.Empty.ToString());

            for (int i = 0; i < oDS.Tables[0].Rows.Count; i++)
            {
                TTModels.clsOriginal.tblStartingFigure startingfigureData = new TTModels.clsOriginal.tblStartingFigure()
                {
                    keyStartingFigureID = 0,
                    sfigAssessmentTotal = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumAssessmentTotal"].ToString()),
                    sfigDiscountAmount  = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumDiscount"].ToString()),
                    sfigFaceAmount      = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumFace"].ToString()),
                    sfigPenaltyAmount   = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumPenalty"].ToString()),
                    sfigFiscalSubYear   = oDS.Tables[0].Rows[i]["litemStrFiscalSubYear"].ToString(),
                    sfigFiscalYear      = oDS.Tables[0].Rows[i]["litemStrFiscalYear"].ToString(),
                    sfigTaxableTotal    = Convert.ToDecimal(oDS.Tables[0].Rows[i]["SumTaxableTotal"].ToString()),
                    sfigTaxTypeID       = Convert.ToInt32(oDS.Tables[0].Rows[i]["litemIntTaxTypeID"].ToString())
                };
                startingfigureDatas.Add(startingfigureData);
            }

        }
        #endregion

        #region "Build the Payment Period Classes"
        TTModels.clsOriginal.tblPaymentPeriods payperiodRecs = new TTModels.clsOriginal.tblPaymentPeriods();
        private void buildPaymentPeriods()
        {
            if (this.chkCounty.Checked)
            {
                TTModels.clsOriginal.tblPaymentPeriod payperiodRec = new TTModels.clsOriginal.tblPaymentPeriod();
                payperiodRec.keyPaymentPeriodsID = 0;
                payperiodRec.payPeriodDateDiscountEnd = discEnd;
                payperiodRec.payPeriodDateDiscountStart = discStart;
                payperiodRec.payPeriodDateFaceEnd = faceEnd;
                payperiodRec.payPeriodDateFaceStart = faceStart;
                payperiodRec.payPeriodDatePenaltyEnd = penlEnd;
                payperiodRec.payPeriodDatePenaltyStart = penlStart;
                payperiodRec.payPeriodDiscountPercent = .02M;
                payperiodRec.payPeriodFiscalSubYear = this.txtFiscalSubYear.Text;
                payperiodRec.payPeriodFiscalYear = this.txtFiscalYear.Text;
                payperiodRec.payPeriodInstallmentNumber = 0;
                payperiodRec.payPeriodIntReference = 0;
                payperiodRec.payPeriodPenaltyPercent = .1M;
                payperiodRec.payPeriodTaxTypeID = Convert.ToInt32(this.txtCountyID.Text);
                payperiodRecs.Add(payperiodRec);
            }

            if (this.checkBox1.Checked)
            {
                TTModels.clsOriginal.tblPaymentPeriod payperiodRec2 = new TTModels.clsOriginal.tblPaymentPeriod();
                payperiodRec2.keyPaymentPeriodsID = 0;
                payperiodRec2.payPeriodDateDiscountEnd = discEnd;
                payperiodRec2.payPeriodDateDiscountStart = discStart;
                payperiodRec2.payPeriodDateFaceEnd = faceEnd;
                payperiodRec2.payPeriodDateFaceStart = faceStart;
                payperiodRec2.payPeriodDatePenaltyEnd = penlEnd;
                payperiodRec2.payPeriodDatePenaltyStart = penlStart;
                payperiodRec2.payPeriodDiscountPercent = .02M;
                payperiodRec2.payPeriodFiscalSubYear = this.txtFiscalSubYear.Text;
                payperiodRec2.payPeriodFiscalYear = this.txtFiscalYear.Text;
                payperiodRec2.payPeriodInstallmentNumber = 0;
                payperiodRec2.payPeriodIntReference = 0;
                payperiodRec2.payPeriodPenaltyPercent = .1M;
                payperiodRec2.payPeriodTaxTypeID = Convert.ToInt32(this.txtMuniID.Text);
                payperiodRecs.Add(payperiodRec2);
            }

            if (this.checkBox2.Checked)
            {
                TTModels.clsOriginal.tblPaymentPeriod payperiodRec3 = new TTModels.clsOriginal.tblPaymentPeriod();
                payperiodRec3.keyPaymentPeriodsID = 0;
                payperiodRec3.payPeriodDateDiscountEnd = discEnd;
                payperiodRec3.payPeriodDateDiscountStart = discStart;
                payperiodRec3.payPeriodDateFaceEnd = faceEnd;
                payperiodRec3.payPeriodDateFaceStart = faceStart;
                payperiodRec3.payPeriodDatePenaltyEnd = penlEnd;
                payperiodRec3.payPeriodDatePenaltyStart = penlStart;
                payperiodRec3.payPeriodDiscountPercent = .02M;
                payperiodRec3.payPeriodFiscalSubYear = this.txtFiscalSubYear.Text;
                payperiodRec3.payPeriodFiscalYear = this.txtFiscalYear.Text;
                payperiodRec3.payPeriodInstallmentNumber = 0;
                payperiodRec3.payPeriodIntReference = 0;
                payperiodRec3.payPeriodPenaltyPercent = .1M;
                payperiodRec3.payPeriodTaxTypeID = Convert.ToInt32(this.txtSchoolID.Text);
                payperiodRecs.Add(payperiodRec3);
            }

        }
        #endregion

        #region "Build the Owner Classes"
        TTModels.clsOriginal.tblOwnerInformations ownerRecs = new TTModels.clsOriginal.tblOwnerInformations();
        private void buildOwnerInformation(Classes.clsParcers.erieInterims dataRecs)
        {
            foreach (Classes.clsParcers.erieInterim dataRec in dataRecs)
            {
                string ownerAddress = "";
                ownerAddress = dataRec.ownerAddress1.Trim();
                if (dataRec.ownerAddress2.Trim() != "") { ownerAddress += "\n" + dataRec.ownerAddress2.Trim(); }
                if (dataRec.ownerAddress3.Trim() != "") { ownerAddress += "\n" + dataRec.ownerAddress3.Trim(); }

                if (checkDistrict(environ, dataRec.parcelNumber))
                {
                    TTModels.clsOriginal.tblOwnerInformation ownerRec = new TTModels.clsOriginal.tblOwnerInformation()
                    {
//                        keyOwnerId = 0,
                        ownerBolCurrent         = true,
                        ownerDateEffectiveDate  = discStart,
                        ownerDateLastUpdated    = DateTime.UtcNow,
                        ownerStrOwnerName1      = dataRec.ownerName,
                        ownerStrOwnerName2      = "",
                        ownerStrBillingZipCode  = "",
                        ownerStrParcelNumber    = dataRec.parcelNumber,
                        ownerMemoBillingAddress = ownerAddress
                    };
                    ownerRecs.Add(ownerRec);
                }
            }
        }
        #endregion

        #region "Build the Parcel Classes"
        private Boolean checkForParcel(string parcelNumber)
        {
            Boolean bFound = false;

            string URI = ""; DataSet oDS = new DataSet();
            URI += "http://208.109.186.146:100/api/WebServices/" + environ + "/qry_tblParcelInformation_SelectAll_ForParcel";
            URI += "/inStrParcel/" + parcelNumber.Replace(".","__");
            try
            {
                oDS = oFunc.getData_V15(URI, TTModels.clsStatic.applicationToken, System.Guid.Empty.ToString());
                if (oDS.Tables[0].Rows.Count > 0)
                {
                    bFound = true;
                }
            }
            catch
            {
            }

            return bFound;
        }
        TTModels.clsOriginal.tblParcelInformations parcelRecs = new TTModels.clsOriginal.tblParcelInformations();
        private void buildParcelInformation(Classes.clsParcers.erieInterims rawDatas)
        {
            int i = 0;
            foreach (Classes.clsParcers.erieInterim rawData in rawDatas)
            {
                i += 1;
                int iProgress = Convert.ToInt32(((i * 100) / rawDatas.Count));
                this.pbarProgress.Value = iProgress;
                this.lblProgress.Text = iProgress + " of " + rawDatas.Count + " Complete.";
                this.Refresh();

                if (checkDistrict(environ, rawData.parcelNumber))
                {
                    if (!checkForParcel(rawData.parcelNumber))
                    {
                        TTModels.clsOriginal.tblParcelInformation parcelRec = new TTModels.clsOriginal.tblParcelInformation()
                        {
                            keyParcelID = 0,
                            parcelMemoLegal = "",
                            parcelMemoLocation = rawData.locationText,
                            parcelMemoNotes = "",
                            parcelStrAcres = "",
                            parcelStrBook = rawData.bookNumber,
                            parcelStrCleanAndGreen = "",
                            parcelStrCode = rawData.parcelClass,
                            parcelStrControlNumber = rawData.parcelNumber,
                            parcelStrDistrict = rawData.parcelNumber.Substring(0,2),
                            parcelStrFarmsteadValue = "",
                            parcelStrHomesteadValue = "",
                            parcelStrNumber = rawData.parcelNumber,
                            parcelStrPage = rawData.pageNumber,
                            parcelStrSchoolDistrict = getSchoolDistrict(rawData.parcelNumber.Substring(0,2)),
                            parcelStrTaxCode = rawData.parcelClass
                        };
                        parcelRecs.Add(parcelRec);
                    }
                }
            }
        }
        #endregion

        #region "Build Line Item Taxes"
        private void loadLineItem(Classes.clsParcers.erieInterim dataRec, int billNumber, string indicator)
        {
            TTModels.clsOriginal.tblLineItemTax lineitemRec = new TTModels.clsOriginal.tblLineItemTax();
            lineitemRec.keyLineItemID = 0;
            lineitemRec.litemAmountPaid = 0;
            lineitemRec.litemBolCloseOut = false;
            lineitemRec.litemBolInterim = true;
            lineitemRec.litemBolSelectedRow = false;
            lineitemRec.litemCurrAssessedBuilding = Convert.ToDecimal(dataRec.currBuilding.ToString());
            lineitemRec.litemCurrAssessedLand = Convert.ToDecimal(dataRec.currLand.ToString());
            lineitemRec.litemCurrAssessedMineral = 0;
            lineitemRec.litemCurrAssessedTotal = Convert.ToDecimal(dataRec.currTotal.ToString());
            lineitemRec.litemCurrBuilding = Convert.ToDecimal(dataRec.currBuilding.ToString());
            lineitemRec.litemCurrLand = Convert.ToDecimal(dataRec.currLand.ToString());
            lineitemRec.litemCurrMineral = 0;
            lineitemRec.litemCurrTotal = Convert.ToDecimal(dataRec.currTotal.ToString());
            lineitemRec.litemCurrPrevBuilding = Convert.ToDecimal(dataRec.prevBuilding.ToString());
            lineitemRec.litemCurrPrevLand = Convert.ToDecimal(dataRec.prevLand.ToString());
            lineitemRec.litemCurrPrevMineral = 0;
            lineitemRec.litemCurrPrevTotal = Convert.ToDecimal(dataRec.prevTotal.ToString());
            lineitemRec.litemDateEffectiveDate = Convert.ToDateTime(discStart.ToString());
            lineitemRec.litemDateLastUpdatedDate = DateTime.UtcNow;
            lineitemRec.litemIntInstallmentNumber = 0;
            lineitemRec.litemIntPaymentPeriodID = 0;
            lineitemRec.litemIntPaymentStatusID = 0;
            lineitemRec.litemIntPaymentTypeID = 0;
            lineitemRec.litemIntReceiptNumber = 0;
            lineitemRec.litemIntRemittalID = 0;
            lineitemRec.litemMemoNotes = "";
            lineitemRec.litemPaymentID = 0;
            lineitemRec.litemStrBarCodeValue = dataRec.parcelNumber.ToString();
            lineitemRec.litemStrBillNumber = billNumber.ToString("000000");
            lineitemRec.litemStrFiscalSubYear = this.txtFiscalSubYear.Text;
            lineitemRec.litemStrFiscalYear = this.txtFiscalYear.Text;
            lineitemRec.litemStrParcelNumber = dataRec.parcelNumber;

            decimal amtFace = 0; decimal amtDisc = 0; decimal amtPenl = 0; decimal discPerc = .98M; decimal penlPerc = 1.1M;

            if (indicator == "COUNTY")
            {
                amtFace = dataRec.countyFace; amtDisc = Math.Round((amtFace * discPerc), 2); amtPenl = Math.Round((amtFace * penlPerc), 2);
                if (amtFace != 0)
                {
                    lineitemRec.litemIntTaxTypeID = Convert.ToInt32(this.txtCountyID.Text);
                    lineitemRec.litemCurrTaxAmountDiscount = amtDisc;
                    lineitemRec.litemCurrTaxAmountFace = amtFace;
                    lineitemRec.litemCurrTaxAmountPenalty = amtPenl;
                    lineitemRec.litemIntInterimMonths = Convert.ToInt32(dataRec.cmMonths);
                    lineitemRec.litemDblRate = Convert.ToDecimal(this.txtCountyRate.Text);
                    lineitemRec.litemDateInterimDate = Convert.ToDateTime(dataRec.cmDate);
                    lineitemRecs.Add(lineitemRec);
                }
            }

            if (indicator == "MUNI")
            {
                amtFace = dataRec.muniFace; amtDisc = Math.Round((amtFace * discPerc), 2); amtPenl = Math.Round((amtFace * penlPerc), 2);
                if (amtFace != 0)
                {
                    lineitemRec.litemIntTaxTypeID = Convert.ToInt32(this.txtMuniID.Text);
                    lineitemRec.litemCurrTaxAmountDiscount = amtDisc;
                    lineitemRec.litemCurrTaxAmountFace = amtFace;
                    lineitemRec.litemCurrTaxAmountPenalty = amtPenl;
                    lineitemRec.litemIntInterimMonths = Convert.ToInt32(dataRec.cmMonths);
                    lineitemRec.litemDblRate = Convert.ToDecimal(this.txtMuniRate.Text);
                    lineitemRec.litemDateInterimDate = Convert.ToDateTime(dataRec.cmDate);
                    lineitemRecs.Add(lineitemRec);
                }
            }

            if (indicator == "SCHOOL")
            {
                amtFace = dataRec.schoolFace; amtDisc = Math.Round((amtFace * discPerc), 2); amtPenl = Math.Round((amtFace * penlPerc), 2);
                if (amtFace != 0)
                {
                    lineitemRec.litemIntTaxTypeID = Convert.ToInt32(this.txtSchoolID.Text);
                    lineitemRec.litemCurrTaxAmountDiscount = amtDisc;
                    lineitemRec.litemCurrTaxAmountFace = amtFace;
                    lineitemRec.litemCurrTaxAmountPenalty = amtPenl;
                    lineitemRec.litemIntInterimMonths = Convert.ToInt32(dataRec.schoolMonths);
                    lineitemRec.litemDblRate = Convert.ToDecimal(this.txtSchoolRate.Text);
                    lineitemRec.litemDateInterimDate = Convert.ToDateTime(dataRec.schoolDate);
                    lineitemRecs.Add(lineitemRec);
                }
            }
        }

        TTModels.clsOriginal.tblLineItemTaxes lineitemRecs = new TTModels.clsOriginal.tblLineItemTaxes();
        private void buildLineItems(Classes.clsParcers.erieInterims dataRecs)
        {
            int billNumber = 0;
            foreach (Classes.clsParcers.erieInterim dataRec in dataRecs)
            {
                if (checkDistrict(environ, dataRec.parcelNumber))
                {
                    billNumber += 1;
                    loadLineItem(dataRec, billNumber, "COUNTY");
                    loadLineItem(dataRec, billNumber, "MUNI");
                    loadLineItem(dataRec, billNumber, "SCHOOL");



                    //TTModels.clsOriginal.tblLineItemTax lineitemRec = new TTModels.clsOriginal.tblLineItemTax();
                    //lineitemRec.keyLineItemID             = 0;
                    //lineitemRec.litemAmountPaid           = 0;
                    //lineitemRec.litemBolCloseOut          = false;
                    //lineitemRec.litemBolInterim           = true;
                    //lineitemRec.litemBolSelectedRow       = false;
                    //lineitemRec.litemCurrAssessedBuilding = Convert.ToDecimal(dataRec.currBuilding.ToString());
                    //lineitemRec.litemCurrAssessedLand     = Convert.ToDecimal(dataRec.currLand.ToString());
                    //lineitemRec.litemCurrAssessedMineral  = 0;
                    //lineitemRec.litemCurrAssessedTotal    = Convert.ToDecimal(dataRec.currTotal.ToString());
                    //lineitemRec.litemCurrBuilding         = Convert.ToDecimal(dataRec.currBuilding.ToString());
                    //lineitemRec.litemCurrLand             = Convert.ToDecimal(dataRec.currLand.ToString());
                    //lineitemRec.litemCurrMineral          = 0;
                    //lineitemRec.litemCurrTotal            = Convert.ToDecimal(dataRec.currTotal.ToString());
                    //lineitemRec.litemCurrPrevBuilding     = Convert.ToDecimal(dataRec.prevBuilding.ToString());
                    //lineitemRec.litemCurrPrevLand         = Convert.ToDecimal(dataRec.prevLand.ToString());
                    //lineitemRec.litemCurrPrevMineral      = 0;
                    //lineitemRec.litemCurrPrevTotal        = Convert.ToDecimal(dataRec.prevTotal.ToString());
                    //lineitemRec.litemDateEffectiveDate    = Convert.ToDateTime(discStart.ToString());
                    //lineitemRec.litemDateLastUpdatedDate  = DateTime.UtcNow;
                    //lineitemRec.litemIntInstallmentNumber = 0;
                    //lineitemRec.litemIntPaymentPeriodID   = 0;
                    //lineitemRec.litemIntPaymentStatusID   = 0;
                    //lineitemRec.litemIntPaymentTypeID     = 0;
                    //lineitemRec.litemIntReceiptNumber     = 0;
                    //lineitemRec.litemIntRemittalID        = 0;
                    //lineitemRec.litemMemoNotes            = "";
                    //lineitemRec.litemPaymentID            = 0;
                    //lineitemRec.litemStrBarCodeValue      = dataRec.parcelNumber.ToString();
                    //lineitemRec.litemStrBillNumber        = billNumber.ToString("000000");
                    //lineitemRec.litemStrFiscalSubYear     = this.txtFiscalSubYear.Text;
                    //lineitemRec.litemStrFiscalYear        = this.txtFiscalYear.Text;
                    //lineitemRec.litemStrParcelNumber      = dataRec.parcelNumber;

                    //decimal amtFace = 0; decimal amtDisc = 0; decimal amtPenl = 0; decimal discPerc = .98M; decimal penlPerc = 1.1M;

                    //amtFace = dataRec.countyFace; amtDisc = Math.Round((amtFace * discPerc), 2); amtPenl = Math.Round((amtFace * penlPerc), 2);
                    //if (amtFace != 0)
                    //{
                    //    lineitemRec.litemIntTaxTypeID          = Convert.ToInt32(this.txtCountyID.Text);
                    //    lineitemRec.litemCurrTaxAmountDiscount = amtDisc;
                    //    lineitemRec.litemCurrTaxAmountFace     = amtFace;
                    //    lineitemRec.litemCurrTaxAmountPenalty  = amtPenl;
                    //    lineitemRec.litemIntInterimMonths      = Convert.ToInt32(dataRec.cmMonths);
                    //    lineitemRec.litemDblRate               = Convert.ToDecimal(this.txtCountyRate.Text);
                    //    lineitemRec.litemDateInterimDate       = Convert.ToDateTime(dataRec.cmDate);
                    //    lineitemRecs.Add(lineitemRec);
                    //}

                    //amtFace = dataRec.muniFace; amtDisc = Math.Round((amtFace * discPerc), 2); amtPenl = Math.Round((amtFace * penlPerc), 2);
                    //if (amtFace != 0)
                    //{
                    //    lineitemRec.litemIntTaxTypeID          = Convert.ToInt32(this.txtMuniID.Text);
                    //    lineitemRec.litemCurrTaxAmountDiscount = amtDisc;
                    //    lineitemRec.litemCurrTaxAmountFace     = amtFace;
                    //    lineitemRec.litemCurrTaxAmountPenalty  = amtPenl;
                    //    lineitemRec.litemIntInterimMonths      = Convert.ToInt32(dataRec.cmMonths);
                    //    lineitemRec.litemDblRate               = Convert.ToDecimal(this.txtMuniRate.Text);
                    //    lineitemRec.litemDateInterimDate       = Convert.ToDateTime(dataRec.cmDate);
                    //    lineitemRecs.Add(lineitemRec);
                    //}

                    //amtFace = dataRec.schoolFace; amtDisc = Math.Round((amtFace * discPerc), 2); amtPenl = Math.Round((amtFace * penlPerc), 2);
                    //if (amtFace != 0)
                    //{
                    //    lineitemRec.litemIntTaxTypeID          = Convert.ToInt32(this.txtSchoolID.Text);
                    //    lineitemRec.litemCurrTaxAmountDiscount = amtDisc;
                    //    lineitemRec.litemCurrTaxAmountFace     = amtFace;
                    //    lineitemRec.litemCurrTaxAmountPenalty  = amtPenl;
                    //    lineitemRec.litemIntInterimMonths      = Convert.ToInt32(dataRec.schoolMonths);
                    //    lineitemRec.litemDblRate               = Convert.ToDecimal(this.txtSchoolRate.Text);
                    //    lineitemRec.litemDateInterimDate       = Convert.ToDateTime(dataRec.schoolDate);
                    //    lineitemRecs.Add(lineitemRec);
                    //}

                }
            }
        }

        #endregion

        #region "async commands"
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
        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblLineItemTaxes     sData, string sToken)
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
        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblPaymentPeriods    sData, string sToken)
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
        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.tblStartingFigures   sData, string sToken)
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


        DateTime discStart = new DateTime(); DateTime discEnd = new DateTime();
        DateTime faceStart = new DateTime(); DateTime faceEnd = new DateTime();
        DateTime penlStart = new DateTime(); DateTime penlEnd = new DateTime();
        string environ = "";
        private async void btnImport_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;

            #region "Set up the dates & environment"
            environ = "TTrackerErie" + this.cboDistrict.Text.Substring(0,2);
            if (this.cboDistrict.Text.Substring(0,2) == "CC") { environ = "TTrackerErieCoC"; }
            if (this.cboDistrict.Text.Substring(0, 2) == "UC") { environ = "TTrackerErieUCB"; }
            discStart = Convert.ToDateTime(this.dtDiscStart.Value.ToString("MM/dd/yyyy"));
            discEnd   = Convert.ToDateTime(this.dtDiscEnd.Value.ToString("MM/dd/yyyy"));
            faceStart = Convert.ToDateTime(this.dtFaceStart.Value.ToString("MM/dd/yyyy"));
            faceEnd   = Convert.ToDateTime(this.dtFaceEnd.Value.ToString("MM/dd/yyyy"));
            penlStart = Convert.ToDateTime(this.dtPenlStart.Value.ToString("MM/dd/yyyy"));
            penlEnd   = Convert.ToDateTime(this.dtPenlEnd.Value.ToString("MM/dd/yyyy"));
            #endregion

            #region "Build tblParcelInformation"
            buildParcelInformation(rawDatas);
            #endregion

            #region "Build tblOwnerInformation"
            buildOwnerInformation(rawDatas);
            #endregion

            #region "Build tblPaymentPeriods"
            buildPaymentPeriods();
            #endregion

            #region "Build tblLineItemTaxes"
            buildLineItems(rawDatas);
            #endregion

            HttpResponseMessage webResponse = new HttpResponseMessage();

            this.lblProgress.Text = "Process API ... tblParcelInformation";
            this.Refresh();

            #region "Perform the APIs"
            webResponse = await RunAsync("POST", environ + "/Importing/tblParcelInformation", parcelRecs, System.Guid.NewGuid().ToString());
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                this.lblProgress.Text = "Process API ... tblOwnerInformation";
                this.Refresh();
                webResponse = await RunAsync("POST", environ + "/Importing/tblOwnerInformation", ownerRecs, System.Guid.NewGuid().ToString());
            }
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                this.lblProgress.Text = "Process API ... tblLineItemTaxes";
                this.Refresh();
                webResponse = await RunAsync("POST", environ + "/Importing/tblLineItemTaxes", lineitemRecs, System.Guid.NewGuid().ToString());
            }
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                this.lblProgress.Text = "Process API ... tblPaymentPeriods";
                this.Refresh();
                webResponse = await RunAsync("POST", environ + "/Importing/tblPaymentPeriods", payperiodRecs, System.Guid.NewGuid().ToString());
            }
            #endregion

            #region "Build tblStartingFigures"
            if (webResponse.StatusCode == HttpStatusCode.OK)
            {
                this.lblProgress.Text = "Process API ... tblStartingFigures";
                this.Refresh();
                buildStartingFigures();
                webResponse = await RunAsync("POST", environ + "/Importing/tblStartingFigures", startingfigureDatas, System.Guid.NewGuid().ToString());
                if (webResponse.StatusCode == HttpStatusCode.OK)
                {
                }
            }
            #endregion


            this.lblProgress.Text = "Import Complete.";
            Cursor = Cursors.Default;
            MessageBox.Show("Import Complete for District " + this.cboDistrict.Text);

        }

        #region "Handle Date Changes"
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

        private void dtPenlEnd_ValueChanged(object sender, EventArgs e)
        {

        }
        #endregion  

    }
}
