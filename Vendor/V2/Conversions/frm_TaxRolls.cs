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
    public partial class frm_TaxRolls : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        Classes.clsConversionFunctions oConvFunc = new Classes.clsConversionFunctions();
        string URL = "http://208.109.186.146:100/";
        //string URL = "http://localhost:29471/";


        public frm_TaxRolls()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataSet oDS = new DataSet();
            string url = URL + "/api/Conversion/" + this.cboDatabase.Text + "/TaxRollData";
            oDS = oFunc.getData_V15(url, "", "");


            this.dgTaxRolls.DataSource = oDS.Tables[0];
            this.dgTaxDates.DataSource = oDS.Tables[1];
            this.dgStartingFigures.DataSource = oDS.Tables[2];

        }

        private TTModels.clsV2Models.tblTaxRolls loadTaxRollClass()
        {
            TTModels.clsV2Models.tblTaxRolls oRecs = new TTModels.clsV2Models.tblTaxRolls();
            for (int i = 0; i < this.dgTaxRolls.Rows.Count; i++)
            {
                Boolean bActive = true; Boolean bInterim = true;
                bActive = !Convert.ToBoolean(this.dgTaxRolls.Rows[i].Cells[2].Value.ToString());
                if (this.dgTaxRolls.Rows[i].Cells[2].Value.ToString().Length > 5)
                {
                    if (this.dgTaxRolls.Rows[i].Cells[2].Value.ToString().Substring(0,6).ToUpper() == "NORMAL")
                    {
                        bInterim = false;
                    }
                }


                TTModels.clsV2Models.tblTaxRoll oRec = new TTModels.clsV2Models.tblTaxRoll()
                {
                    keyTaxRollID = System.Guid.NewGuid().ToString(),
                    taxrollBolActive = bActive,
                    taxrollBolInterim = bInterim,
                    taxrollDateEntered = DateTime.Now,
                    taxrollStrFiscalYear = this.dgTaxRolls.Rows[i].Cells[0].Value.ToString().Trim(),
                    taxrollStrFiscalSubYear = this.dgTaxRolls.Rows[i].Cells[1].Value.ToString().Trim()
                };

                oRecs.Add(oRec);
                if (i % 10 == 0)
                {
                    this.lblProgress.Text = "Processing Tax Rolls " + i + " of " + this.dgTaxRolls.Rows.Count;
                    this.Refresh();
                }
            }

            return oRecs;
        }

        private TTModels.clsV2Models.tblTaxRollDates loadTaxRollDatesClass(TTModels.clsV2Models.tblTaxRolls taxRolls)
        {
            TTModels.clsV2Models.tblTaxRollDates oRecs = new TTModels.clsV2Models.tblTaxRollDates();

            for (int i = 0; i < this.dgTaxDates.Rows.Count; i++)
            {
                string thisFY = this.dgTaxDates.Rows[i].Cells[0].Value.ToString().Trim();
                string thisFSY = this.dgTaxDates.Rows[i].Cells[1].Value.ToString().Trim();
                string thisFKey = "";

                foreach (TTModels.clsV2Models.tblTaxRoll taxRoll in taxRolls)
                {
                    if (taxRoll.taxrollStrFiscalYear == thisFY && taxRoll.taxrollStrFiscalSubYear == thisFSY) { thisFKey = taxRoll.keyTaxRollID; }
                }

                TTModels.clsV2Models.tblTaxRollDate oRec = new TTModels.clsV2Models.tblTaxRollDate()
                {
                    keyTaxRollDateID = System.Guid.NewGuid().ToString(),
                    fkTaxRollID = thisFKey,
                    fkTaxTypeID = oConvFunc.getNewTaxTypeID(this.cboDatabase.Text, this.dgTaxDates.Rows[i].Cells[2].Value.ToString()),
                    trdateDateDiscountStart = Convert.ToDateTime(this.dgTaxDates.Rows[i].Cells[4].Value.ToString()),
                    trdateDateDiscountEnd   = Convert.ToDateTime(this.dgTaxDates.Rows[i].Cells[5].Value.ToString()),
                    trdateDateFaceStart     = Convert.ToDateTime(this.dgTaxDates.Rows[i].Cells[6].Value.ToString()),
                    trdateDateFaceEnd       = Convert.ToDateTime(this.dgTaxDates.Rows[i].Cells[7].Value.ToString()),
                    trdateDatePenaltyStart  = Convert.ToDateTime(this.dgTaxDates.Rows[i].Cells[8].Value.ToString()),
                    trdateDatePenaltyEnd    = Convert.ToDateTime(this.dgTaxDates.Rows[i].Cells[9].Value.ToString()),
                    trdateIntInstallment    = Convert.ToInt32(this.dgTaxDates.Rows[i].Cells[3].Value.ToString())
                };

                if (thisFKey == "")
                {
                    MessageBox.Show("No Tax Roll for " + thisFY + " >>> " + thisFSY + " Skipping.");
                }
                else
                {
                    oRecs.Add(oRec);
                }
                if (i % 10 == 0)
                {
                    this.lblProgress.Text = "Processing Tax Dates " + i + " of " + this.dgTaxDates.Rows.Count;
                    this.Refresh();
                }

            }



            return oRecs;
        }

        private TTModels.clsV2Models.tblStartingFigures loadStartingFigureClass(TTModels.clsV2Models.tblTaxRolls taxRolls)
        {
            TTModels.clsV2Models.tblStartingFigures oRecs = new TTModels.clsV2Models.tblStartingFigures();

            for (int i = 0; i < this.dgStartingFigures.Rows.Count; i++)
            {
                string thisFY = this.dgStartingFigures.Rows[i].Cells[1].Value.ToString().Trim();
                string thisFSY = this.dgStartingFigures.Rows[i].Cells[2].Value.ToString().Trim();
                string thisFKey = "";

                foreach (TTModels.clsV2Models.tblTaxRoll taxRoll in taxRolls)
                {
                    if (taxRoll.taxrollStrFiscalYear == thisFY && taxRoll.taxrollStrFiscalSubYear == thisFSY) { thisFKey = taxRoll.keyTaxRollID; }
                }

                decimal disc = 0M; decimal face = 0M; decimal penl = 0M; decimal taxable = 0M; decimal assessed = 0M;
                try { disc     = Convert.ToDecimal(this.dgStartingFigures.Rows[i].Cells[4].Value.ToString()); } catch { }
                try { face     = Convert.ToDecimal(this.dgStartingFigures.Rows[i].Cells[5].Value.ToString()); } catch { }
                try { penl     = Convert.ToDecimal(this.dgStartingFigures.Rows[i].Cells[6].Value.ToString()); } catch { }
                try { assessed = Convert.ToDecimal(this.dgStartingFigures.Rows[i].Cells[8].Value.ToString()); } catch { }
                try { taxable  = Convert.ToDecimal(this.dgStartingFigures.Rows[i].Cells[9].Value.ToString()); } catch { }

                TTModels.clsV2Models.tblStartingFigure oRec = new TTModels.clsV2Models.tblStartingFigure()
                {
                    keyStartingFigureID = System.Guid.NewGuid().ToString(),
                    fkTaxRollID = thisFKey,
                    fkTaxTypeID = oConvFunc.getNewTaxTypeID(this.cboDatabase.Text.ToString(), this.dgStartingFigures.Rows[i].Cells[3].Value.ToString()),
                    sfigCurrAssessment = assessed,
                    sfigCurrDiscount = disc,
                    sfigCurrFace = face,
                    sfigCurrPenalty = penl,
                    sfigCurrTaxable = taxable
                };
                if (i % 10 == 0)
                {
                    this.lblProgress.Text = "Processing Starting Figures " + i + " of " + this.dgStartingFigures.Rows.Count;
                    this.Refresh();
                }
                if (thisFKey == "")
                {
                    MessageBox.Show("No Tax Roll for " + thisFY + " >>> " + thisFSY + " Skipping.");
                }
                else
                {
                    oRecs.Add(oRec);
                }
            }

            return oRecs;
        }

        private void frm_TaxRolls_Load(object sender, EventArgs e)
        {
        }

        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblStartingFigures sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblStartingFigures", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblTaxRolls sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblTaxRolls", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblTaxRollDates sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblTaxRollDates", sData);
                return oResponse;
            }

        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            TTModels.clsV2Models.tblTaxRolls taxRollData = loadTaxRollClass();
            TTModels.clsV2Models.tblTaxRollDates taxRollDateData = loadTaxRollDatesClass(taxRollData);
            TTModels.clsV2Models.tblStartingFigures startFigData = loadStartingFigureClass(taxRollData);

            HttpResponseMessage oResult = new HttpResponseMessage();
            this.lblProgress.Text = "Inserting Tax Rolls"; this.Refresh();
            oResult = await RunAsync(URL, taxRollData, this.cboNewDatabase.Text.ToString());
            MessageBox.Show(oResult.StatusCode.ToString());
            this.lblProgress.Text = "Inserting Tax Dates"; this.Refresh();
            oResult = await RunAsync(URL, taxRollDateData, this.cboNewDatabase.Text.ToString());
            MessageBox.Show(oResult.StatusCode.ToString());
            this.lblProgress.Text = "Inserting Starting Figures"; this.Refresh();
            oResult = await RunAsync(URL, startFigData, this.cboNewDatabase.Text.ToString());
            MessageBox.Show(oResult.StatusCode.ToString());

            MessageBox.Show("Complete");

        }
    }
}
