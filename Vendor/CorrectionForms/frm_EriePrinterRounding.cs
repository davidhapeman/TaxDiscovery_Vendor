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
    public partial class frm_EriePrinterRounding : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        clsParcers oParcer = new clsParcers();

        public frm_EriePrinterRounding()
        {
            InitializeComponent();
        }

        DataTable oDTTaxTypes = new DataTable();
        private void loadTaxTypes()
        {
            string URI = Globals.Url15 + "/api/Org_ErieRounding_GetTaxTypes/" + this.cboDatabase.Text;
            //string URI = "http://localhost:29471/api/Org_ErieRounding_GetTaxTypes/" + this.cboDatabase.Text;
            oDTTaxTypes = oFunc.getData_V15(URI, "", "").Tables[0];
        }

        DataTable oDTItems = new System.Data.DataTable();
        private void loadTaxItems()
        {
            DataTable oDT = new DataTable();
            string url = Globals.Url15 + "/api/Org_ErieRounding_GetBillItems/" + this.cboDatabase.Text + "/" + this.txtFiscalYear.Text + "/" + this.txtFiscalSubYear.Text + "/" + this.cboTaxTypes.SelectedValue.ToString();
            //string url = "http://localhost:29471/api/Org_ErieRounding_GetBillItems/" + this.cboDatabase.Text + "/" + this.txtFiscalYear.Text + "/" + this.txtFiscalSubYear.Text + "/" + this.cboTaxTypes.SelectedValue.ToString();
            oDTItems = oFunc.getData_V15(url, "", "").Tables[0];
        }


        DataTable oDTTaxRoll = new DataTable();
        private void loadTaxRolls()
        {
            DataTable oDT = new DataTable();
            string url = Globals.Url15 + "/api/Org_ErieRounding_GetBillTotals/" + this.cboDatabase.Text + "/" + this.txtFiscalYear.Text + "/" + this.txtFiscalSubYear.Text;
            //string url = "http://localhost:29471/api/Org_ErieRounding_GetBillTotals/" + this.cboDatabase.Text + "/" + this.txtFiscalYear.Text + "/" + this.txtFiscalSubYear.Text;
            oDTTaxRoll = oFunc.getData_V15(url, "", "").Tables[0];

        }


        private void frm_EriePrinterRounding_Load(object sender, EventArgs e)
        {
            this.btnLoadBills.Enabled = false;
            this.btnTaxTypes.Enabled = false;
        }

        private void loadPrinterData()
        {
            Classes.clsParcers.eriePrinterRecords dataRecs = new Classes.clsParcers.eriePrinterRecords();
            for (int i = 0; i < this.dgFileImport.Rows.Count; i++)
            {
                Classes.clsParcers.eriePrinterRecord dataRec = new Classes.clsParcers.eriePrinterRecord()
                {
                    parcelNumber = this.dgFileImport.Rows[i].Cells[1].Value.ToString(),
                    totalDiscount = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[26].Value.ToString()),
                    totalFace = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[25].Value.ToString()),
                    totalPenalty = Convert.ToDecimal(this.dgFileImport.Rows[i].Cells[27].Value.ToString())
                };
                dataRecs.Add(dataRec);
            }

            this.dgPrinterRecordData.DataSource = dataRecs;
        }

        private void btnLoadBills_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            this.lblProgress.Text = "Loading Printer Data."; this.Refresh();
            loadPrinterData();
            this.lblProgress.Text = "Loading Tax Roll Data."; this.Refresh();
            loadTaxRolls();
            this.lblProgress.Text = "Loading Line Item Data."; this.Refresh();
            loadTaxItems();
            this.dgTaxRolls.DataSource = oDTTaxRoll;
            this.dgLineItems.DataSource = oDTItems;
            Cursor = Cursors.Default;
            
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.txtFileName.Text = oFunc.getFileName(this.txtFileName.Text);
        }

        DataTable oDTRawData = new DataTable();
        private void btnLoadDatagrid_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string fileName = System.IO.Path.GetFileName(this.txtFileName.Text);
            string pathName = this.txtFileName.Text.Replace(fileName, "").ToString();

            oDTRawData = oFunc.getDataFromCSV(this.txtFileName.Text, fileName, pathName).Tables[0];
            this.dgFileImport.DataSource = oDTRawData;
            Cursor = Cursors.Default;
        }

        private void btnTaxTypes_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            loadTaxTypes();
            this.cboTaxTypes.DataSource = oDTTaxTypes;
            this.cboTaxTypes.DisplayMember = oDTTaxTypes.Columns["TaxTypesStrType"].ToString();
            this.cboTaxTypes.ValueMember = oDTTaxTypes.Columns["TaxTypesIntOldID"].ToString();
            this.cboTaxTypes.SelectedIndex = -1;
            Cursor = Cursors.Default;
        }

        private void cboDatabase_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboDatabase.SelectedIndex > -1)
            {
                this.btnTaxTypes.Enabled = true;
            }
        }

        private void cboTaxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cboTaxTypes.SelectedIndex > -1)
            {
                this.btnLoadBills.Enabled = true;
            }
        }



        static async Task<HttpResponseMessage> RunAsync(string sMethod, string sAPI, TTModels.clsOriginal.fixErieRoundings sData, string sToken)
        {
            //string sURL_Location = "http://localhost:29471/";
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
        private async void btnPerformFix_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            TTModels.clsOriginal.fixErieRoundings dataRecs = new TTModels.clsOriginal.fixErieRoundings();
            foreach (Classes.clsDataStructures.erieRoundCorrection inData in correctRecs)
            {
                TTModels.clsOriginal.fixErieRounding dataRec = new TTModels.clsOriginal.fixErieRounding()
                {
                    parcelNumber = inData.parcelNumber,
                    taxTypeID = Convert.ToInt32(this.cboTaxTypes.SelectedValue.ToString()),
                    discountCorrection = inData.ttNewDisc,
                    penaltyCorrection = inData.ttNewPenl,
                    fiscalSubYear = this.txtFiscalSubYear.Text,
                    fiscalYear = this.txtFiscalYear.Text
                };
                dataRecs.Add(dataRec);
            }

            HttpResponseMessage oResult = new HttpResponseMessage();
            oResult = await RunAsync("PUT", "Org_FixRounding/" + this.cboDatabase.Text, dataRecs, "");
            Cursor = Cursors.Default;
            if (oResult.StatusCode != HttpStatusCode.OK)
            {
                MessageBox.Show(oResult.RequestMessage.ToString());
            }
            else
            {
                MessageBox.Show("Complete");
            }



        }
        int iSkipCounter = 0;
        Classes.clsDataStructures.erieRoundCorrections correctRecs = new Classes.clsDataStructures.erieRoundCorrections();
        private void btnLoadCorrections_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            correctRecs.Clear();
            for (int i = 0; i < this.dgTaxRolls.Rows.Count; i++)
            {
                for (int ii = 0; ii < this.dgPrinterRecordData.Rows.Count; ii++)
                {
                    if (this.dgTaxRolls.Rows[i].Cells[0].Value.ToString() == this.dgPrinterRecordData.Rows[ii].Cells[0].Value.ToString())
                    {
                        #region "Checking Data"
                        if (Convert.ToDecimal(dgTaxRolls.Rows[i].Cells[3].Value.ToString()) == 0)
                        {
                            if (Convert.ToDecimal(dgTaxRolls.Rows[i].Cells[1].Value.ToString()) > 0)
                            {
                                
                                string thisParcel = this.dgTaxRolls.Rows[i].Cells[0].Value.ToString();
                                string thisKey = "";
                                decimal thisOrgDisc = Convert.ToDecimal(this.dgTaxRolls.Rows[i].Cells[1].Value.ToString());
                                decimal thisOrgPenl = Convert.ToDecimal(this.dgTaxRolls.Rows[i].Cells[2].Value.ToString());

                                decimal thisPrtDisc = Convert.ToDecimal(this.dgPrinterRecordData.Rows[ii].Cells[1].Value.ToString());
                                decimal thisPrtPenl = Convert.ToDecimal(this.dgPrinterRecordData.Rows[ii].Cells[3].Value.ToString());

                                decimal newAdjDisc = 0; decimal newAdjPenl = 0;
                                if (thisOrgDisc != thisPrtDisc || thisOrgPenl != thisPrtPenl)
                                {
                                    if (thisOrgDisc != thisPrtDisc)
                                    {
                                        newAdjDisc = (thisPrtDisc - thisOrgDisc);
                                        //newAdjDisc = (thisOrgDisc - thisPrtDisc);
                                    }
                                    if (thisOrgPenl != thisPrtPenl)
                                    {
                                        newAdjPenl = (thisPrtPenl - thisOrgPenl);
                                        //newAdjPenl = (thisOrgPenl - thisPrtPenl);
                                    }
                                    decimal ttOrgDiscount = 0; decimal ttOrgPenalty = 0;
                                    decimal ttNewDiscount = 0; decimal ttNewPenalty = 0;
                                    for (int j = 0; j < this.dgLineItems.Rows.Count; j++)
                                    {
                                        if (thisParcel == this.dgLineItems.Rows[j].Cells[1].Value.ToString())
                                        {
                                            thisKey = this.dgLineItems.Rows[j].Cells[0].Value.ToString();
                                            ttOrgDiscount = Convert.ToDecimal(this.dgLineItems.Rows[j].Cells[2].Value.ToString());
                                            ttOrgPenalty = Convert.ToDecimal(this.dgLineItems.Rows[j].Cells[3].Value.ToString());
                                            ttNewDiscount = ttOrgDiscount + newAdjDisc;
                                            ttNewPenalty = ttOrgPenalty + newAdjPenl;
                                            j = this.dgLineItems.Rows.Count;
                                        }
                                    }
                                    
                                    if (newAdjDisc > .05M || newAdjDisc < -.05M || newAdjPenl > .03M || newAdjPenl < -.03M)
                                    {
                                        iSkipCounter++;
                                        //MessageBox.Show("Outside Bounds for parcel " + thisParcel + ". Skipping.");
                                    }
                                    else
                                    {
                                        Classes.clsDataStructures.erieRoundCorrection dataRec = new Classes.clsDataStructures.erieRoundCorrection()
                                        {
                                            keyLineItemID = thisKey,
                                            orgDisc = thisOrgDisc,
                                            orgPenl = thisOrgPenl,
                                            newDisc = thisPrtDisc,
                                            newPenl = thisPrtPenl,
                                            adjDisc = newAdjDisc,
                                            adjPenl = newAdjPenl,
                                            ttNewDisc = ttNewDiscount,
                                            ttNewPenl = ttNewPenalty,
                                            ttOrgDisc = ttOrgDiscount,
                                            ttOrgPenl = ttOrgPenalty,
                                            parcelNumber = thisParcel
                                        };
                                        correctRecs.Add(dataRec);
                                    }


                                }

                            }
                        }
                        #endregion
                        ii = this.dgPrinterRecordData.Rows.Count;
                    }
                }


                if (i % 1000 == 0)
                {
                    this.lblProgress.Text = i + " Records Processed ";
                    this.Refresh();
                }

                //disable when running in prod.
                //if (i > 100) { i = this.dgTaxRolls.Rows.Count; }
            }
            this.dgCorrections.DataSource = correctRecs;
            this.lblNumberRecords.Text = this.dgCorrections.Rows.Count.ToString("###,##0") + " - Skipped: " + iSkipCounter;
            Cursor = Cursors.Default;
        }
    }
}
