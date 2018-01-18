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
    public partial class frm_ImportSchool : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
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
                if (sMethod == "PUT") { oResponse = await client.PutAsJsonAsync("api/" + sAPI, sData); }
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

        public frm_ImportSchool()
        {
            InitializeComponent();
        }

        private void frm_ImportSchool_Load(object sender, EventArgs e)
        {
            this.txtFiscalYear.Text = DateTime.Now.Year.ToString();
            this.txtFiscalSubYear.Text = "Normal-S";
            this.dtDiscStart.Value = Convert.ToDateTime("7/1/" + DateTime.Now.Year.ToString());
            this.dtPenlEnd.Value = Convert.ToDateTime("12/31/" + DateTime.Now.Year.ToString());
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.txtFileName.Text = oFunc.getFileName(this.txtFileName.Text);
        }

        private void btnBrowse2_Click(object sender, EventArgs e)
        {
            this.txtFileName2.Text = oFunc.getFileName(this.txtFileName2.Text);
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

        Classes.clsParcers.erieNormalSchools countyRecs = new Classes.clsParcers.erieNormalSchools();
        private Classes.clsParcers.erieNormalSchools loadCountyClass()
        {
            Classes.clsParcers.erieNormalSchools dataRecs = new Classes.clsParcers.erieNormalSchools();
            for (int i = 0; i < this.dgFileImport.Rows.Count; i++)
            {
                Classes.clsParcers.erieNormalSchool dataRec = new Classes.clsParcers.erieNormalSchool();
                dataRec.code = this.dgFileImport.Rows[i].Cells[0].Value.ToString();
                dataRec.district = this.dgFileImport.Rows[i].Cells[1].Value.ToString();
                dataRec.schoolDistrict = this.dgFileImport.Rows[i].Cells[2].Value.ToString();
                dataRec.parcelNumber = this.dgFileImport.Rows[i].Cells[3].Value.ToString();
                dataRec.ownerName1 = this.dgFileImport.Rows[i].Cells[4].Value.ToString();
                dataRec.ownerName2 = this.dgFileImport.Rows[i].Cells[5].Value.ToString();
                dataRec.ownerAddress1 = this.dgFileImport.Rows[i].Cells[6].Value.ToString();
                dataRec.ownerAddress2 = this.dgFileImport.Rows[i].Cells[7].Value.ToString();
                dataRec.ownerAddress3 = this.dgFileImport.Rows[i].Cells[8].Value.ToString();
                dataRec.location = this.dgFileImport.Rows[i].Cells[9].Value.ToString();
                dataRec.legal1 = this.dgFileImport.Rows[i].Cells[10].Value.ToString();
                dataRec.legal2 = this.dgFileImport.Rows[i].Cells[11].Value.ToString();
                dataRec.landTaxable = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[12].Value.ToString());
                dataRec.buildingTaxable = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[13].Value.ToString());
                dataRec.totalTaxable = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[14].Value.ToString());

                dataRec.taxcode = this.dgFileImport.Rows[i].Cells[15].Value.ToString();
                dataRec.acres = this.dgFileImport.Rows[i].Cells[16].Value.ToString();
                dataRec.taxTotal = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[17].Value.ToString());
                dataRec.hydrantTotal = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[18].Value.ToString());
                dataRec.lightTotal = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[19].Value.ToString());
                dataRec.sewerTotal = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[20].Value.ToString());
                dataRec.countyTax = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[21].Value.ToString());
                dataRec.muniTax = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[22].Value.ToString());
                dataRec.schoolTax = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[23].Value.ToString());
                dataRec.libraryTax = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[24].Value.ToString());
                dataRec.countyRate = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[25].Value.ToString());
                dataRec.muniRate = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[26].Value.ToString());
                dataRec.schoolRate = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[27].Value.ToString());
                dataRec.libraryRate = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[28].Value.ToString());

                dataRec.book = this.dgFileImport.Rows[i].Cells[29].Value.ToString();
                dataRec.page = this.dgFileImport.Rows[i].Cells[30].Value.ToString();
                dataRec.LUC = this.dgFileImport.Rows[i].Cells[31].Value.ToString();
                dataRec.cleanGreenFlag = this.dgFileImport.Rows[i].Cells[32].Value.ToString();
                dataRec.lertaFlag = this.dgFileImport.Rows[i].Cells[33].Value.ToString();
                dataRec.landAssessment = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[34].Value.ToString());
                dataRec.buildingAssessment = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[35].Value.ToString());
                dataRec.totalAssessment = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[36].Value.ToString());
                dataRec.lertaBuilding = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[37].Value.ToString());

                dataRec.countyHomestead = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[38].Value.ToString());
                dataRec.countyFarmstead = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[39].Value.ToString());
                dataRec.muniHomestead = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[40].Value.ToString());
                dataRec.muniFarmstead = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[41].Value.ToString());
                dataRec.schoolHomestead = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[42].Value.ToString());
                dataRec.schoolFarmstead = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[43].Value.ToString());
                dataRec.countyLessExclusion = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[44].Value.ToString());
                dataRec.muniLessExclusion = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[45].Value.ToString());
                dataRec.schoolLessExclusion = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[46].Value.ToString());
                dataRec.countyOriginalTax = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[47].Value.ToString());
                dataRec.muniOriginalTax = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[48].Value.ToString());
                dataRec.schoolOriginalTax = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[49].Value.ToString());

                dataRec.countyHomesteadExclusionDollars = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[50].Value.ToString());
                dataRec.muniHomesteadExclusionDollars = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[51].Value.ToString());
                dataRec.schoolHomesteadExclusionDollars = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[52].Value.ToString());
                dataRec.countyFarmsteadExclusionDollars = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[53].Value.ToString());
                dataRec.muniFarmsteadExclusionDollars = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[54].Value.ToString());
                dataRec.schoolFarmsteadExclusionDollars = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[55].Value.ToString());

                dataRec.homesteadEligible = this.dgFileImport.Rows[i].Cells[56].Value.ToString();
                dataRec.farmsteadEligible = this.dgFileImport.Rows[i].Cells[57].Value.ToString();

                dataRecs.Add(dataRec);
            }
            return dataRecs;


        }
        private void btnLoadDatagrid_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string fileName = System.IO.Path.GetFileName(this.txtFileName2.Text);
            string pathName = this.txtFileName2.Text.Replace(fileName, "").ToString();

            DataTable oDTRawData2 = new DataTable(); DataSet oDS2 = new DataSet();
            oDS2 = oFunc.getDataFromCSV(this.txtFileName2.Text, fileName, pathName);
            oDTRawData2 = oFunc.getDataFromCSV(this.txtFileName2.Text, fileName, pathName).Tables[0];
            this.dgFileImport2.DataSource = oDTRawData2;
            //printerRecs = loadPrinterClass();

            fileName = System.IO.Path.GetFileName(this.txtFileName.Text);
            pathName = this.txtFileName.Text.Replace(fileName, "").ToString();
            DataTable oDTRawData = new DataTable();
            oDTRawData = oFunc.getDataFromCSV(this.txtFileName.Text, fileName, pathName).Tables[0];
            this.dgFileImport.DataSource = oDTRawData;
            countyRecs = loadCountyClass();
            Cursor = Cursors.Default;

            MessageBox.Show("Load Complete");
        }

        Classes.clsDataStructures.tblParcelInformations parcelDatas = new Classes.clsDataStructures.tblParcelInformations();
        Classes.clsDataStructures.tblOwnerInformations ownerDatas = new Classes.clsDataStructures.tblOwnerInformations();
        Classes.clsDataStructures.tblLineItemTaxs litemDatas = new Classes.clsDataStructures.tblLineItemTaxs();

        #region "Handle tblParcelInformation"
        DataTable oDTListOfExisingParcels = new DataTable();
        private void getListOfParcels()
        {
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

            try
            {
                for (int i = 0; i < oDTListOfExisingParcels.Rows.Count; i++)
                {
                    if (oDTListOfExisingParcels.Rows[i]["parcelStrNumber"].ToString() == parcelNumber)
                    {
                        bFound = true;
                        i = oDTListOfExisingParcels.Rows.Count;
                    }
                }
            }
            catch { }

            return bFound;
        }
        private TTModels.clsOriginal.tblParcelInformation loadNewParcel(Classes.clsParcers.erieNormalSchool dataIn)
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
                    parcelStrCleanAndGreen = dataIn.cleanGreenFlag,
                    parcelStrCode = dataIn.code,
                    parcelStrControlNumber = dataIn.parcelNumber,
                    parcelStrDistrict = dataIn.district,
                    parcelStrFarmsteadValue = dataIn.farmsteadEligible,
                    parcelStrHomesteadValue = dataIn.homesteadEligible,
                    parcelStrNumber = dataIn.parcelNumber,
                    parcelStrPage = dataIn.page,
                    parcelStrSchoolDistrict = dataIn.schoolDistrict,
                    parcelStrTaxCode = dataIn.taxcode
                };
                return dataRec;
            }
            else
            {
                return null;
            }
        }
        private TTModels.clsOriginal.tblParcelInformation loadExistingParcel(Classes.clsParcers.erieNormalSchool dataIn)
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
                    parcelStrCleanAndGreen = dataIn.cleanGreenFlag,
                    parcelStrCode = dataIn.code,
                    parcelStrControlNumber = dataIn.parcelNumber,
                    parcelStrDistrict = dataIn.district,
                    parcelStrFarmsteadValue = dataIn.farmsteadEligible,
                    parcelStrHomesteadValue = dataIn.homesteadEligible,
                    parcelStrNumber = dataIn.parcelNumber,
                    parcelStrPage = dataIn.page,
                    parcelStrSchoolDistrict = dataIn.schoolDistrict,
                    parcelStrTaxCode = dataIn.taxcode
                };
                return dataRec;
            }
            else
            {
                return null;
            }
        }

        #endregion

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

        string environ = "";
        private async void btnImport_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
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




            #region "Load Parcel Data"
            getListOfParcels();
            #region "Process New Parcels"
            int iRecCounter = 0;
            TTModels.clsOriginal.tblParcelInformations parcelDatas = new TTModels.clsOriginal.tblParcelInformations();
            foreach (Classes.clsParcers.erieNormalSchool countyRec in countyRecs)
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
                    this.lblProgress.Text = "New Parcels " + iRecCounter + " " + webResponse.StatusCode.ToString();
                    this.Refresh();
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
            foreach (Classes.clsParcers.erieNormalSchool countyRec in countyRecs)
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
                    this.lblProgress.Text = "Existing Parcels " + iRecCounter + " " + webResponse.StatusCode.ToString();
                    this.Refresh();
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

            #endregion

            #region "Load Owner Data"
            TTModels.clsOriginal.tblOwnerInformations ownerRecs = new TTModels.clsOriginal.tblOwnerInformations();
            this.lblProgress.Text = "Process API ... tblOwnerInformation";
            this.Refresh();

            int ownerCntr = 0; int ownerTotalCntr = 0;
            foreach (Classes.clsParcers.erieNormalSchool inData in countyRecs)
            {
                ownerCntr++; ownerTotalCntr++;
                string address = "";
                address = inData.ownerAddress1;
                if (inData.ownerAddress2.Trim() != "") { address += "\n" + inData.ownerAddress2; }
                if (inData.ownerAddress3.Trim() != "") { address += "\n" + inData.ownerAddress3; }
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
                if (ownerCntr > 500)
                {
                    this.lblProgress.Text = "Owner Records " + ownerTotalCntr.ToString("000000") + " " + webResponse.StatusCode.ToString(); this.Refresh();
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
            #endregion

            #region "Load LineItem Data"

            int schoolCounter = 0; int billNumber = 0;
            TTModels.clsOriginal.tblLineItemTaxes itemRecs = new TTModels.clsOriginal.tblLineItemTaxes();
            #region "School Line Items"

            decimal amtFace = 0M; decimal amtDisc = 0M; decimal amtPenl = 0;
            foreach (Classes.clsParcers.erieNormalSchool dataRec in countyRecs)
            {
                schoolCounter++; billNumber++;
                #region "School Record"
                amtFace = 0; amtDisc = 0; amtPenl = 0;
                amtFace = dataRec.schoolOriginalTax;
                amtDisc = (amtFace * 0.98M); amtDisc = Math.Round(amtDisc, 2);
                amtPenl = (amtFace * 1.1M); amtPenl = Math.Round(amtPenl, 2); 


                TTModels.clsOriginal.tblLineItemTax itemRec = new TTModels.clsOriginal.tblLineItemTax()
                {
                    litemAmountPaid = 0,
                    litemBolCloseOut = false,
                    litemBolInterim = false,
                    litemBolSelectedRow = false,
                    litemCurrAssessedBuilding = dataRec.buildingAssessment,
                    litemCurrAssessedLand = dataRec.landAssessment,
                    litemCurrAssessedMineral = 0,
                    litemCurrAssessedTotal = dataRec.totalAssessment,
                    litemCurrBuilding = dataRec.buildingTaxable,
                    litemCurrLand = dataRec.landTaxable,
                    litemCurrMineral = 0,
                    litemCurrTotal = dataRec.totalTaxable,
                    litemCurrPrevBuilding = 0,
                    litemCurrPrevLand = 0,
                    litemCurrPrevMineral = 0,
                    litemCurrPrevTotal = 0,
                    litemDateEffectiveDate = Convert.ToDateTime(this.dtDiscStart.Value.ToString("MM/dd/yyyy")),
                    litemDateInterimDate = DateTime.MaxValue,
                    litemDateLastUpdatedDate = DateTime.Now,
                    litemDblRate = Convert.ToDecimal(this.txtSchoolRate.Text),
                    litemIntInstallmentNumber = 0,
                    litemIntInterimMonths = 12,
                    litemIntPaymentPeriodID = 0,
                    litemIntPaymentStatusID = 0,
                    litemIntPaymentTypeID = 0,
                    litemIntReceiptNumber = 0,
                    litemIntRemittalID = 0,
                    litemIntTaxTypeID = Convert.ToInt32(this.txtSchoolID.Text),
                    litemMemoNotes = "Initial Load",
                    litemPaymentID = 0,
                    litemStrBarCodeValue = dataRec.parcelNumber,
                    litemStrBillNumber = billNumber.ToString("000000"),
                    litemStrFiscalSubYear = this.txtFiscalSubYear.Text,
                    litemStrFiscalYear = this.txtFiscalYear.Text,
                    litemStrParcelNumber = dataRec.parcelNumber,
                    litemCurrTaxAmountDiscount = amtDisc,
                    litemCurrTaxAmountFace = amtFace,
                    litemCurrTaxAmountPenalty = amtPenl
                };
                itemRecs.Add(itemRec);
                #endregion

                amtFace = 0; amtDisc = 0; amtPenl = 0;
                #region "Reduction Record"
                if (dataRec.homesteadEligible.Trim() != "")
                {
                    amtFace += (-1M) * Convert.ToDecimal(dataRec.schoolHomesteadExclusionDollars);
                    amtDisc += (amtFace * 0.98M); amtDisc = Math.Round(amtDisc, 2);
                    amtPenl += (amtFace * 1.1M); amtPenl = Math.Round(amtPenl, 2);
                }
                if (dataRec.farmsteadEligible.Trim() != "")
                {
                    amtFace += (-1M) * Convert.ToDecimal(dataRec.schoolFarmsteadExclusionDollars);
                    amtDisc += (amtFace * 0.98M); amtDisc = Math.Round(amtDisc, 2);
                    amtPenl += (amtFace * 1.1M); amtPenl = Math.Round(amtPenl, 2);
                }
                if (amtFace != 0)
                {
                    schoolCounter++;
                    TTModels.clsOriginal.tblLineItemTax itemRec2 = new TTModels.clsOriginal.tblLineItemTax()
                    {
                        litemAmountPaid = 0,
                        litemBolCloseOut = false,
                        litemBolInterim = false,
                        litemBolSelectedRow = false,
                        litemCurrAssessedBuilding = dataRec.buildingAssessment,
                        litemCurrAssessedLand = dataRec.landAssessment,
                        litemCurrAssessedMineral = 0,
                        litemCurrAssessedTotal = dataRec.totalAssessment,
                        litemCurrBuilding = dataRec.buildingTaxable,
                        litemCurrLand = dataRec.landTaxable,
                        litemCurrMineral = 0,
                        litemCurrTotal = dataRec.totalTaxable,
                        litemCurrPrevBuilding = 0,
                        litemCurrPrevLand = 0,
                        litemCurrPrevMineral = 0,
                        litemCurrPrevTotal = 0,
                        litemDateEffectiveDate = Convert.ToDateTime(this.dtDiscStart.Value.ToString("MM/dd/yyyy")),
                        litemDateInterimDate = DateTime.MaxValue,
                        litemDateLastUpdatedDate = DateTime.Now,
                        litemDblRate = 0,
                        litemIntInstallmentNumber = 0,
                        litemIntInterimMonths = 12,
                        litemIntPaymentPeriodID = 0,
                        litemIntPaymentStatusID = 0,
                        litemIntPaymentTypeID = 0,
                        litemIntReceiptNumber = 0,
                        litemIntRemittalID = 0,
                        litemIntTaxTypeID = Convert.ToInt32(this.txtReductionID.Text),
                        litemMemoNotes = "Initial Load",
                        litemPaymentID = 0,
                        litemStrBarCodeValue = dataRec.parcelNumber,
                        litemStrBillNumber = billNumber.ToString("000000"),
                        litemStrFiscalSubYear = this.txtFiscalSubYear.Text,
                        litemStrFiscalYear = this.txtFiscalYear.Text,
                        litemStrParcelNumber = dataRec.parcelNumber,
                        litemCurrTaxAmountDiscount = amtDisc,
                        litemCurrTaxAmountFace = amtFace,
                        litemCurrTaxAmountPenalty = amtPenl
                    };
                    itemRecs.Add(itemRec2);
                }
                #endregion

                #region "Library Record"
                amtFace = 0; amtDisc = 0; amtPenl = 0;
                amtFace = dataRec.libraryTax;
                amtDisc = (amtFace * 0.98M); amtDisc = Math.Round(amtDisc, 2);
                amtPenl = (amtFace * 1.1M); amtPenl = Math.Round(amtPenl, 2);

                if (amtFace != 0)
                {
                    TTModels.clsOriginal.tblLineItemTax itemRec3 = new TTModels.clsOriginal.tblLineItemTax()
                    {
                        litemAmountPaid = 0,
                        litemBolCloseOut = false,
                        litemBolInterim = false,
                        litemBolSelectedRow = false,
                        litemCurrAssessedBuilding = dataRec.buildingAssessment,
                        litemCurrAssessedLand = dataRec.landAssessment,
                        litemCurrAssessedMineral = 0,
                        litemCurrAssessedTotal = dataRec.totalAssessment,
                        litemCurrBuilding = dataRec.buildingTaxable,
                        litemCurrLand = dataRec.landTaxable,
                        litemCurrMineral = 0,
                        litemCurrTotal = dataRec.totalTaxable,
                        litemCurrPrevBuilding = 0,
                        litemCurrPrevLand = 0,
                        litemCurrPrevMineral = 0,
                        litemCurrPrevTotal = 0,
                        litemDateEffectiveDate = Convert.ToDateTime(this.dtDiscStart.Value.ToString("MM/dd/yyyy")),
                        litemDateInterimDate = DateTime.MaxValue,
                        litemDateLastUpdatedDate = DateTime.Now,
                        litemDblRate = Convert.ToDecimal(this.txtLibraryRate.Text),
                        litemIntInstallmentNumber = 0,
                        litemIntInterimMonths = 12,
                        litemIntPaymentPeriodID = 0,
                        litemIntPaymentStatusID = 0,
                        litemIntPaymentTypeID = 0,
                        litemIntReceiptNumber = 0,
                        litemIntRemittalID = 0,
                        litemIntTaxTypeID = Convert.ToInt32(this.txtLibraryID.Text),
                        litemMemoNotes = "Initial Load",
                        litemPaymentID = 0,
                        litemStrBarCodeValue = dataRec.parcelNumber,
                        litemStrBillNumber = billNumber.ToString("000000"),
                        litemStrFiscalSubYear = this.txtFiscalSubYear.Text,
                        litemStrFiscalYear = this.txtFiscalYear.Text,
                        litemStrParcelNumber = dataRec.parcelNumber,
                        litemCurrTaxAmountDiscount = amtDisc,
                        litemCurrTaxAmountFace = amtFace,
                        litemCurrTaxAmountPenalty = amtPenl
                    };
                    itemRecs.Add(itemRec3);
                }
                #endregion



                if (schoolCounter > 500)
                {
                    webResponse = await RunAsync("POST", environ + "/Importing/tblLineItemTaxes", itemRecs, System.Guid.NewGuid().ToString());
                    int iValue = (iRecCounter * 100) / countyRecs.Count;
                    this.lblProgress.Text = "Line Items " + billNumber.ToString("000000") + " " + webResponse.StatusCode.ToString(); this.pbarProgress.Value = iValue; this.Refresh();

                    itemRecs.Clear();
                    schoolCounter = 0;
                }
            }
            if (schoolCounter > 0)
            {
                webResponse = await RunAsync("POST", environ + "/Importing/tblLineItemTaxes", itemRecs, System.Guid.NewGuid().ToString());
                int iValue = (iRecCounter * 100) / countyRecs.Count;
                this.lblProgress.Text = billNumber.ToString("000000"); this.pbarProgress.Value = iValue; this.Refresh();

            }

            #endregion


            #endregion

            #region "Load Payment Period Data"
            TTModels.clsOriginal.tblPaymentPeriods periodDatas = new TTModels.clsOriginal.tblPaymentPeriods();
            for (int i = 0; i < (Convert.ToInt16(this.txtInstallments.Text) + 1); i++)
            {
                TTModels.clsOriginal.tblPaymentPeriod periodData1 = new TTModels.clsOriginal.tblPaymentPeriod()
                {
                    payPeriodDateDiscountEnd = dateDiscountEnd,
                    payPeriodDateDiscountStart = dateDiscountStart,
                    payPeriodDateFaceEnd = dateFaceEnd,
                    payPeriodDateFaceStart = dateFaceStart,
                    payPeriodDatePenaltyEnd = datePenaltyEnd,
                    payPeriodDatePenaltyStart = datePenaltyStart,
                    payPeriodDiscountPercent = .98M,
                    payPeriodFiscalSubYear = this.txtFiscalSubYear.Text,
                    payPeriodFiscalYear = this.txtFiscalYear.Text,
                    payPeriodInstallmentNumber = i,
                    payPeriodIntReference = 0,
                    payPeriodPenaltyPercent = 1.1M,
                    payPeriodTaxTypeID = Convert.ToInt32(this.txtSchoolID.Text)
                };
                TTModels.clsOriginal.tblPaymentPeriod periodData2 = new TTModels.clsOriginal.tblPaymentPeriod()
                {
                    payPeriodDateDiscountEnd = dateDiscountEnd,
                    payPeriodDateDiscountStart = dateDiscountStart,
                    payPeriodDateFaceEnd = dateFaceEnd,
                    payPeriodDateFaceStart = dateFaceStart,
                    payPeriodDatePenaltyEnd = datePenaltyEnd,
                    payPeriodDatePenaltyStart = datePenaltyStart,
                    payPeriodDiscountPercent = .98M,
                    payPeriodFiscalSubYear = this.txtFiscalSubYear.Text,
                    payPeriodFiscalYear = this.txtFiscalYear.Text,
                    payPeriodInstallmentNumber = i,
                    payPeriodIntReference = 0,
                    payPeriodPenaltyPercent = 1.1M,
                    payPeriodTaxTypeID = Convert.ToInt32(this.txtReductionID.Text)
                };
                periodDatas.Add(periodData1);
                periodDatas.Add(periodData2);
            }
            webResponse = await RunAsync("POST", environ + "/Importing/tblPaymentPeriods", periodDatas, System.Guid.NewGuid().ToString());



            #endregion

            #region "Load Starting Figure Data"
            this.lblProgress.Text = "Process API ... tblStartingFigures";
            this.Refresh();
            buildStartingFigures();
            webResponse = await RunAsync("POST", environ + "/Importing/tblStartingFigures", startingfigureDatas, System.Guid.NewGuid().ToString());
            #endregion

            Cursor = Cursors.Default;
            MessageBox.Show("Importing Complete");
        }
    }
}
