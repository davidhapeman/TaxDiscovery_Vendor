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
    public partial class frm_Moneys : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        Classes.clsConversionFunctions oConvFunc = new Classes.clsConversionFunctions();
        string URL = "http://208.109.186.146:100/";
        //string URL = "http://localhost:29471/";

        public frm_Moneys()
        {
            InitializeComponent();
        }

        private void frm_Moneys_Load(object sender, EventArgs e)
        {

        }

        DataTable dtTaxRolls = new DataTable();
        DataTable dtBankAccounts = new DataTable();
        private void loadData(string DB)
        {
            this.lblProgress.Text = "Getting Data From " + DB; this.Refresh();
            Cursor = Cursors.WaitCursor;
            dtBankAccounts.Clear(); dtTaxRolls.Clear();
            DataSet oDS = new DataSet();
            string url = "";

            url = URL + "/api/V2/" + DB + "/tblTaxRolls";
            dtTaxRolls = oFunc.getData_V15(url, "", "").Tables[0];
            url = URL + "/api/V2/" + DB + "/tblBankAccounts";
            dtBankAccounts = oFunc.getData_V15(url, "", "").Tables[0];
            this.dgBankAccounts.DataSource = dtBankAccounts;
            this.dgTaxRolls.DataSource = dtTaxRolls;
            Cursor = Cursors.Default;

        }

        private void cboNewDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboNewDatabase.SelectedIndex > -1)
            {
                loadData(this.cboNewDatabase.Text);
            }
        }

        DataTable dtMoneys = new DataTable();
        DataTable dtLineItems = new DataTable();
        DataTable dtPosting = new DataTable();
        DataTable dtDeposits = new DataTable();
        DataTable dtBills = new DataTable();

        private void loadMoneys(string DB, int min, int max)
        {
            string url = URL + "/api/Conversion/" + DB + "/MoneyData/" + min.ToString() + "/" + max.ToString();

            try { dtMoneys    = oFunc.getData_V15(url, "", "").Tables[0]; } catch { dtMoneys    = null; }
            try { dtLineItems = oFunc.getData_V15(url, "", "").Tables[1]; } catch { dtLineItems = null; }
            try { dtPosting   = oFunc.getData_V15(url, "", "").Tables[2]; } catch { dtPosting   = null; }
            try { dtDeposits  = oFunc.getData_V15(url, "", "").Tables[3]; } catch { }
            try { dtBills     = oFunc.getData_V15(url, "", "").Tables[4]; } catch { dtBills      = null; }


            label2.Text = "0";
            label4.Text = "0";
            label5.Text = "0";

            try
            {

                label2.Text = dtMoneys.Rows.Count.ToString();
                label4.Text = dtLineItems.Rows.Count.ToString();
                label5.Text = dtPosting.Rows.Count.ToString();
            }
            catch { }
            try { this.dgMoneys.Rows.Clear();    } catch { }
            try { this.dgLineItems.Rows.Clear(); } catch { }
            try { this.dgPostings.Rows.Clear();  } catch { }

            try { this.dgMoneys.DataSource  = dtMoneys;    } catch { }
            try { this.dgLineItems.DataSource = dtLineItems; } catch { }
            try { this.dgPostings.DataSource  = dtPosting;   } catch { }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            loadMoneys(this.cboDatabase.Text, 50000, 60000);
            Cursor = Cursors.Default;
        }


        TTModels.clsV2Models.tblPostingItems  postingItems  = new TTModels.clsV2Models.tblPostingItems();
        TTModels.clsV2Models.tblPostingMoneys postingMoneys = new TTModels.clsV2Models.tblPostingMoneys();
        TTModels.clsV2Models.tblPostings      postings      = new TTModels.clsV2Models.tblPostings();
        TTModels.clsV2Models.tblMoneys        moneys        = new TTModels.clsV2Models.tblMoneys();
        TTModels.clsV2Models.tblDeposits      deposits      = new TTModels.clsV2Models.tblDeposits();

        TTModels.clsV2Models.ConvertGetBills convertBills = new TTModels.clsV2Models.ConvertGetBills();

        private void resetClasses()
        {
            postingItems.Clear();
            postingMoneys.Clear();
            postings.Clear();
            moneys.Clear();
        }

        private string getBankAccountID(string bankName, string bankNumber)
        {
            string keyBankAccountID = System.Guid.Empty.ToString();
            for (int i = 0; i < dtBankAccounts.Rows.Count; i++)
            {
                if (bankNumber.Trim() == dtBankAccounts.Rows[i]["bacctStrBankNumber"].ToString().Trim())
                {
                    keyBankAccountID = dtBankAccounts.Rows[i]["keyBankAccountID"].ToString();
                }
            }
            return keyBankAccountID;
        }
        private void buildDeposits()
        {
            for (int i = 0; i < dtDeposits.Rows.Count; i++)
            {
                TTModels.clsV2Models.tblDeposit deposit = new TTModels.clsV2Models.tblDeposit()
                {
                    keyDepositID        = System.Guid.NewGuid().ToString(),
                    fkBankAccountID     = getBankAccountID(dtDeposits.Rows[i]["moneyStrDepositBankName"].ToString(), dtDeposits.Rows[i]["moneyStrDepositBankNumber"].ToString()),
                    fkUserID_EnteredBy  = System.Guid.Empty.ToString(),
                    fkUserID_UpdatedBy  = System.Guid.Empty.ToString(),
                    depositDate         = Convert.ToDateTime(dtDeposits.Rows[i]["moneyDateDepositDate"].ToString()),
                    depositDateEntered  = Convert.ToDateTime(dtDeposits.Rows[i]["moneyDateDepositDate"].ToString()),
                    depositDateUpdated  = Convert.ToDateTime(dtDeposits.Rows[i]["moneyDateDepositDate"].ToString()),
                    depositStrNumber    = dtDeposits.Rows[i]["moneyStrDepositNumber"].ToString(),
                    depositStrSubNumber = dtDeposits.Rows[i]["moneyStrDepositSubNumber"].ToString()
                };
                deposits.Add(deposit);
            }
        }

        private int getMoneyStatus(Boolean bDeposited, Boolean bCleared)
        {
            int keyMoneyStatusID = 1;
            if (bDeposited) { keyMoneyStatusID = 2; }
            if (bCleared) { keyMoneyStatusID = 3; }
            return keyMoneyStatusID;
        }
        private int getMoneyType(string thisType)
        {
            int keyMoneyTypeID = 0;
            switch (thisType)
            {
                case "1": keyMoneyTypeID = 1; break; // Cash
                case "2": keyMoneyTypeID = 2; break; // Check
                case "3": keyMoneyTypeID = 3; break; // Credit Card
                default: break;
            }
            return keyMoneyTypeID;
        }

        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblDeposits sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblDeposits", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblPostings sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblPostings", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblPostingItems sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblPostingItems", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblPostingMoneys sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblPostingMoneys", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblMoneys sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblMoneys", sData);
                return oResponse;
            }

        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            HttpResponseMessage oResult = new HttpResponseMessage();
            int counterRec = 0;
            Cursor = Cursors.WaitCursor;
            int iInterval = 2000; int min = 0; int max = iInterval;
            this.lblProgress.Text = "Getting Data from " + this.cboDatabase.Text + " - " + min.ToString() + " to " + max.ToString(); this.lblMin.Text = min.ToString(); this.lblMax.Text = max.ToString(); this.Refresh();
            loadMoneys(this.cboDatabase.Text, min, max);
            this.lblProgress.Text = "Building Deposits"; this.Refresh();
            buildDeposits();
            resetClasses();
            while (this.dgPostings.Rows.Count > 0)
            {
                #region "Build tblPostings"
                this.lblProgress.Text = "Building tblPostings"; this.Refresh();
                for (int i = 0; i < this.dgPostings.Rows.Count; i++)
                {
                    TTModels.clsV2Models.tblPosting posting = new TTModels.clsV2Models.tblPosting()
                    {
                        keyPostingID = System.Guid.NewGuid().ToString(),
                        fkUserID_EnteredBy = System.Guid.Empty.ToString(),
                        fkUserID_UpdatedBy = System.Guid.Empty.ToString(),
                        postCurrAmount = Convert.ToDecimal(this.dgPostings.Rows[i].Cells[3].Value.ToString()),
                        postDateActual = Convert.ToDateTime(this.dgPostings.Rows[i].Cells[2].Value.ToString()),
                        postDatePostmark = Convert.ToDateTime(this.dgPostings.Rows[i].Cells[1].Value.ToString()),
                        postIntTransactionNumber = Convert.ToInt32(this.dgPostings.Rows[i].Cells[0].Value.ToString())
                    };
                    postings.Add(posting);
                }
                #endregion

                #region "Building tblMoneys"
                this.lblProgress.Text = "Building tblMoneys"; this.Refresh();
                for (int i = 0; i < this.dgMoneys.Rows.Count; i++)
                {
                    string keyMoneyID = System.Guid.NewGuid().ToString();
                    Boolean bDeposited = Convert.ToBoolean(this.dgMoneys.Rows[i].Cells[7].Value.ToString());
                    Boolean bCleared = Convert.ToBoolean(this.dgMoneys.Rows[i].Cells[13].Value.ToString());
                    TTModels.clsV2Models.tblMoney money = new TTModels.clsV2Models.tblMoney();
                    money.keyMoneyID = keyMoneyID;
                    money.moneyCurrAmount = Convert.ToDecimal(this.dgMoneys.Rows[i].Cells[4].Value.ToString());
                    money.moneyDateCleared = Convert.ToDateTime(this.dgMoneys.Rows[i].Cells[14].Value.ToString());
                    money.moneyDateDeposited = Convert.ToDateTime(this.dgMoneys.Rows[i].Cells[8].Value.ToString());
                    money.moneyDateEntered = Convert.ToDateTime(this.dgMoneys.Rows[i].Cells[19].Value.ToString());
                    money.moneyDateUpdated = Convert.ToDateTime(this.dgMoneys.Rows[i].Cells[19].Value.ToString());
                    money.moneyIntPostingIndex = Convert.ToInt32(this.dgMoneys.Rows[i].Cells[2].Value.ToString());
                    money.moneyStrAuthorizationCode = this.dgMoneys.Rows[i].Cells[15].Value.ToString();
                    money.moneyStrCheckCCNumber = this.dgMoneys.Rows[i].Cells[6].Value.ToString();
                    money.moneyStrName = this.dgMoneys.Rows[i].Cells[5].Value.ToString();
                    money.moneyStrNotes = "";
                    money.fkUserID_EnteredBy = System.Guid.Empty.ToString();
                    money.fkUserID_UpdatedBy = System.Guid.Empty.ToString();

                    money.fkMoneyStatusID = getMoneyStatus(bDeposited, bCleared);
                    money.fkMoneyTypeID = getMoneyType(this.dgMoneys.Rows[i].Cells[3].Value.ToString());


                    money.fkPostingID = System.Guid.Empty.ToString();
                    foreach (TTModels.clsV2Models.tblPosting data in postings)
                    {
                        if (data.postIntTransactionNumber.ToString() == money.moneyIntPostingIndex.ToString())
                        {
                            money.fkPostingID = data.keyPostingID;
                        }
                    }

                    money.fkDepositID = System.Guid.Empty.ToString();
                    moneys.Add(money);


                }
                #endregion

                #region "Building Posting Moneys"
                this.lblProgress.Text = "Building tblPostingMoneys"; this.Refresh();
                foreach (TTModels.clsV2Models.tblPosting posting in postings)
                {
                    foreach (TTModels.clsV2Models.tblMoney money in moneys)
                    {
                        if (posting.postIntTransactionNumber == money.moneyIntPostingIndex)
                        {
                            TTModels.clsV2Models.tblPostingMoney postingMoney = new TTModels.clsV2Models.tblPostingMoney()
                            {
                                keyPostingMoneyID = System.Guid.NewGuid().ToString(),
                                fkPostingID = posting.keyPostingID,
                                fkMoneyID = money.keyMoneyID
                            };
                            postingMoneys.Add(postingMoney);
                        }
                    }
                }
                #endregion

                #region "Building Posting Items"

                TTModels.clsV2Models.ConvertGetBillIns dataIns = new TTModels.clsV2Models.ConvertGetBillIns();

                counterRec = 0;
                for (int items = 0; items < dtBills.Rows.Count; items++)
                //for (int items = 0; items < 10; items++)
                {
                    counterRec++;
                    TTModels.clsV2Models.ConvertGetBillIn dataIn = new TTModels.clsV2Models.ConvertGetBillIn()
                    {
                        parcelNumber = dtBills.Rows[items]["litemStrParcelNumber"].ToString(),
                        billNumber = dtBills.Rows[items]["litemStrBillNumber"].ToString(),
                        installmentNumber = Convert.ToInt32(dtBills.Rows[items]["litemIntInstallmentNumber"].ToString()),
                        fiscalYear = dtBills.Rows[items]["litemStrFiscalYear"].ToString(),
                        fiscalSubYear = dtBills.Rows[items]["litemStrFiscalSubYear"].ToString(),
                    };
                    dataIns.Add(dataIn);

                    if (counterRec % 100 == 0)
                    {
                        this.lblProgress.Text = "Getting Bill Rec from " + this.cboNewDatabase.Text + " " + items + " of " + dtBills.Rows.Count; this.Refresh();
                        counterRec = 0;
                        DataSet oDSBillData = specialAPIFunction("", "POST", "Conversion/" + this.cboNewDatabase.Text + "/GetBills", dataIns);
                        for (int bd = 0; bd < oDSBillData.Tables[0].Rows.Count; bd++)
                        {
                            TTModels.clsV2Models.ConvertGetBill convertBill = new TTModels.clsV2Models.ConvertGetBill()
                            {
                                keyBillLineItemID = oDSBillData.Tables[0].Rows[bd]["keyBillLineItemID"].ToString(),
                                parcelNumber = oDSBillData.Tables[0].Rows[bd]["parcelNumber"].ToString(),
                                fiscalYear = oDSBillData.Tables[0].Rows[bd]["fiscalYear"].ToString(),
                                fiscalSubYear = oDSBillData.Tables[0].Rows[bd]["fiscalSubYear"].ToString(),
                                billNumber = oDSBillData.Tables[0].Rows[bd]["billNumber"].ToString(),
                                taxType = Convert.ToInt32(oDSBillData.Tables[0].Rows[bd]["taxType"].ToString()),
                                installmentNumber = Convert.ToInt32(oDSBillData.Tables[0].Rows[bd]["installmentNumber"].ToString())
                            };
                            convertBills.Add(convertBill);
                        }
                        dataIns.Clear();
                    }

                }
                if (counterRec > 0)
                {
                    counterRec = 0;
                    DataSet oDSBillData = specialAPIFunction("", "POST", "Conversion/" + this.cboNewDatabase.Text + "/GetBills", dataIns);
                    for (int bd = 0; bd < oDSBillData.Tables[0].Rows.Count; bd++)
                    {
                        TTModels.clsV2Models.ConvertGetBill convertBill = new TTModels.clsV2Models.ConvertGetBill()
                        {
                            keyBillLineItemID = oDSBillData.Tables[0].Rows[bd]["keyBillLineItemID"].ToString(),
                            parcelNumber = oDSBillData.Tables[0].Rows[bd]["parcelNumber"].ToString(),
                            fiscalYear = oDSBillData.Tables[0].Rows[bd]["fiscalYear"].ToString(),
                            fiscalSubYear = oDSBillData.Tables[0].Rows[bd]["fiscalSubYear"].ToString(),
                            billNumber = oDSBillData.Tables[0].Rows[bd]["billNumber"].ToString(),
                            taxType = Convert.ToInt32(oDSBillData.Tables[0].Rows[bd]["taxType"].ToString()),
                            installmentNumber = Convert.ToInt32(oDSBillData.Tables[0].Rows[bd]["installmentNumber"].ToString())
                        };
                        convertBills.Add(convertBill);
                    }

                }




                #region "Build Posting Line Items
                counterRec = 0;
                foreach (TTModels.clsV2Models.tblPosting pdata in postings)
                {
                    counterRec++;
                    if (counterRec % 10 == 0)
                    {
                        this.lblProgress.Text = "Processing Bill Posting Items: " + counterRec.ToString() + " of " + postings.Count.ToString(); this.Refresh();
                    }
                    for (int items = 0; items < this.dgLineItems.Rows.Count; items++)
                    {

                        string transAction = this.dgLineItems.Rows[items].Cells[17].Value.ToString();

                        if (transAction == pdata.postIntTransactionNumber.ToString())
                        {
                            string bParcel = this.dgLineItems.Rows[items].Cells[1].Value.ToString();
                            string bBill = this.dgLineItems.Rows[items].Cells[30].Value.ToString();
                            string bIns = this.dgLineItems.Rows[items].Cells[37].Value.ToString();
                            string bFY = this.dgLineItems.Rows[items].Cells[28].Value.ToString();
                            string bFSY = this.dgLineItems.Rows[items].Cells[29].Value.ToString();
                            string bTT = this.dgLineItems.Rows[items].Cells[2].Value.ToString();

                            foreach (TTModels.clsV2Models.ConvertGetBill bdata in convertBills)
                            {
                                if (
                                    bParcel == bdata.parcelNumber && bBill == bdata.billNumber && bIns == bdata.installmentNumber.ToString() &&
                                    bFY == bdata.fiscalYear && bFSY == bdata.fiscalSubYear && bTT == bdata.taxType.ToString()
                                    )
                                {
                                    TTModels.clsV2Models.tblPostingItem postingItem = new TTModels.clsV2Models.tblPostingItem()
                                    {
                                        keyPostingItemID = System.Guid.NewGuid().ToString(),
                                        fkBillLineItemID = bdata.keyBillLineItemID,
                                        fkPostingID = pdata.keyPostingID
                                    };
                                    postingItems.Add(postingItem);
                                }
                            }
                        }




                    }

                }
                #endregion




                #endregion

                #region "Put records into new DB"
                this.lblProgress.Text = "Inserting Postings"; this.Refresh();
                oResult = await RunAsync(URL, postings, this.cboNewDatabase.Text.ToString());
                if (oResult.StatusCode != HttpStatusCode.OK) { MessageBox.Show("1- Error:" + oResult.StatusCode.ToString()); }
                else
                {
                    this.lblProgress.Text = "Inserting Posting Items"; this.Refresh();
                    oResult = await RunAsync(URL, postingItems, this.cboNewDatabase.Text.ToString());
                    if (oResult.StatusCode != HttpStatusCode.OK) { MessageBox.Show("2- Error:" + oResult.StatusCode.ToString()); }
                    else
                    {
                        this.lblProgress.Text = "Inserting Posting Moneys"; this.Refresh();
                        oResult = await RunAsync(URL, postingMoneys, this.cboNewDatabase.Text.ToString());
                        if (oResult.StatusCode != HttpStatusCode.OK) { MessageBox.Show("3- Error:" + oResult.StatusCode.ToString()); }
                        else
                        {
                            this.lblProgress.Text = "Inserting Moneys"; this.Refresh();
                            oResult = await RunAsync(URL, moneys, this.cboNewDatabase.Text.ToString());
                            if (oResult.StatusCode != HttpStatusCode.OK) { MessageBox.Show("4- Error:" + oResult.StatusCode.ToString()); }
                        }
                    }
                }
                #endregion


                min += iInterval; max += iInterval;
                this.lblProgress.Text = "Getting Data from " + this.cboDatabase.Text + " - " + min.ToString() + " to " + max.ToString(); this.lblMin.Text = min.ToString(); this.lblMax.Text = max.ToString(); this.Refresh();
                loadMoneys(this.cboDatabase.Text, min, max);
                resetClasses();
            }

            this.lblProgress.Text = "Inserting Deposits"; this.Refresh();
            oResult = await RunAsync(URL, deposits, this.cboNewDatabase.Text.ToString());
            if (oResult.StatusCode != HttpStatusCode.OK) { MessageBox.Show("5- Error:" + oResult.StatusCode.ToString()); }

            Cursor = Cursors.Default;


        }

        public string jsonRequest(TTModels.clsV2Models.ConvertGetBillIns datas)
        {
            string concat = "";
            string jSon = "";

            foreach (TTModels.clsV2Models.ConvertGetBillIn data in datas)
            {
                jSon += concat + " { \"parcelNumber\" : \"" + data.parcelNumber + "\", \"billNumber\" : \"" + data.billNumber + "\", \"fiscalSubYear\" : \"" + data.fiscalSubYear + "\", \"installmentNumber\": \"" + data.installmentNumber + "\", \"fiscalYear\":\"" + data.fiscalYear + "\" }";
                concat = ",";
            }


            jSon = "[" + jSon + "]";

            return jSon;
        }
        public DataSet specialAPIFunction(string environment, string Method, string API, TTModels.clsV2Models.ConvertGetBillIns _passData)
        {
            string URL = "http://208.109.186.146:100/api/" + API;
            //string URL = "http://localhost:29471/api/" + API;
            DataSet oDS = new DataSet();

            var oWebRequest = (HttpWebRequest)WebRequest.Create(URL);
            oWebRequest.Method = HttpMethod.Options.ToString();
            //oWebRequest.Headers.Add("environ", _passGlobals.USER_ENVIRONMENT);
            oWebRequest.ContentType = "application/json";
            oWebRequest.Method = Method;

            string jsonData = jsonRequest(_passData);


            using (var streamWriter = new StreamWriter(oWebRequest.GetRequestStream()))
            {
                streamWriter.Write(jsonData);
            }
            try
            {
                var oWebResponse = (HttpWebResponse)oWebRequest.GetResponse();

                if (oWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    var oReader = new StreamReader(oWebResponse.GetResponseStream());
                    string sData = oReader.ReadToEnd();

                    XmlDocument xmlResponse = (XmlDocument)JsonConvert.DeserializeXmlNode(sData, "Tables");
                    string sXML = xmlResponse.InnerXml.ToString();
                    oDS.ReadXml(new System.IO.StringReader(sXML));
                }
                else
                {
                    string xmlError = "<Errors><Error><Message>" + oWebResponse.StatusCode.ToString() + "</Message></Error></Errors>";
                    oDS.ReadXml(new System.IO.StringReader(xmlError));
                }
            }
            catch (Exception sException)
            {
                string xmlError = "<Errors><Error><Message>" + sException.ToString() + "</Message></Error></Errors>";
                oDS.ReadXml(new System.IO.StringReader(xmlError));
            }

            return oDS;

        }



    }
}
