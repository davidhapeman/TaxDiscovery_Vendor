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
    public partial class frm_Parcels : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        Classes.clsConversionFunctions oConvFunc = new Classes.clsConversionFunctions();
        string URL = "http://208.109.186.146:100/";
        //string URL = "http://localhost:29471/";

        public frm_Parcels()
        {
            InitializeComponent();
        }

        private void loadParcels()
        {
            DataSet oDS = new DataSet();
            string url = URL + "/api/Conversion/" + this.cboDatabase.Text + "/ParcelData";
            oDS = oFunc.getData_V15(url, "", "");

            this.dgParcels.DataSource = oDS.Tables[0];
            this.dgParcelNotes.DataSource = oDS.Tables[1];
            this.dgOwners.DataSource = oDS.Tables[2];

        }

        private void frm_Parcels_Load(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            loadParcels();
            Cursor = Cursors.Default;
        }

        private TTModels.clsV2Models.tblParcels loadParcelClass()
        {
            TTModels.clsV2Models.tblParcels oRecs = new TTModels.clsV2Models.tblParcels();

            for (int i = 0; i < this.dgParcels.Rows.Count; i++)
            {
                Boolean bHomestead = false; Boolean bFarmstead = false;
                if (this.dgParcels.Rows[i].Cells[13].Value.ToString().Trim() != "") { bHomestead = true; }
                if (this.dgParcels.Rows[i].Cells[14].Value.ToString().Trim() != "") { bFarmstead = true; }

                TTModels.clsV2Models.tblParcel oRec = new TTModels.clsV2Models.tblParcel()
                {
                    keyParcelID = System.Guid.NewGuid().ToString(),
                    fkSchoolDistrictID = System.Guid.Empty.ToString(),
                    fkUserID_UpdatedBy = System.Guid.Empty.ToString(),
                    parcelBolFarmstead = bFarmstead,
                    parcelBolHomestead = bHomestead,
                    parcelDateCreated = DateTime.UtcNow,
                    parcelDateUpdated = DateTime.UtcNow,
                    parcelStrAcres         = this.dgParcels.Rows[i].Cells[8].Value.ToString(),
                    parcelStrBarCodeValue  = this.dgParcels.Rows[i].Cells[1].Value.ToString(),
                    parcelStrBook          = this.dgParcels.Rows[i].Cells[9].Value.ToString(),
                    parcelStrCleanAndGreen = this.dgParcels.Rows[i].Cells[11].Value.ToString(),
                    parcelStrCode          = this.dgParcels.Rows[i].Cells[2].Value.ToString(),
                    parcelStrControlNumber = this.dgParcels.Rows[i].Cells[15].Value.ToString(),
                    parcelStrDistrict      = this.dgParcels.Rows[i].Cells[3].Value.ToString(),
                    parcelStrLegal         = this.dgParcels.Rows[i].Cells[6].Value.ToString(),
                    parcelStrLocation      = this.dgParcels.Rows[i].Cells[5].Value.ToString(),
                    parcelStrNumber        = this.dgParcels.Rows[i].Cells[1].Value.ToString(),
                    parcelStrPage          = this.dgParcels.Rows[i].Cells[10].Value.ToString(),
                    parcelStrTaxCode       = this.dgParcels.Rows[i].Cells[7].Value.ToString()
                };
                oRecs.Add(oRec);
                if (i % 1000 == 0)
                {
                    this.lblProgress.Text = "Processing Parcels " + i + " of " + this.dgParcels.Rows.Count;
                    this.Refresh();
                }
            }

            return oRecs;
        }

        private TTModels.clsV2Models.tblParcelNotes loadParcelNotesClass(TTModels.clsV2Models.tblParcels parcelData)
        {
            TTModels.clsV2Models.tblParcelNotes oRecs = new TTModels.clsV2Models.tblParcelNotes();
            for (int i = 0; i < this.dgParcelNotes.Rows.Count; i++)
            {
                if (this.dgParcelNotes.Rows[i].Cells[1].Value.ToString().Trim() != "")
                {
                    string thisFKey = "";
                    foreach (TTModels.clsV2Models.tblParcel data in parcelData)
                    {
                        if (data.parcelStrNumber == this.dgParcelNotes.Rows[i].Cells[0].Value.ToString()) { thisFKey = data.keyParcelID; }
                    }

                    TTModels.clsV2Models.tblParcelNote oRec = new TTModels.clsV2Models.tblParcelNote()
                    {
                        keyParcelNoteID = System.Guid.NewGuid().ToString(),
                        fkParcelID = thisFKey,
                        fkUserID_EnteredBy = System.Guid.Empty.ToString(),
                        pnoteDateEntered = DateTime.UtcNow,
                        pnoteStrNote = this.dgParcelNotes.Rows[i].Cells[1].Value.ToString()
                    };

                    if (thisFKey == "")
                    {
                        MessageBox.Show("Notes for parcel '" + this.dgParcels.Rows[i].Cells[0].Value.ToString() + " have no parcel match.  Skipping.");
                    }
                    else
                    {
                        oRecs.Add(oRec);
                    }
                }

                if (i % 1000 == 0)
                {
                    this.lblProgress.Text = "Processing Parcel Notes " + i + " of " + this.dgParcelNotes.Rows.Count;
                    this.Refresh();
                }

            }
            return oRecs;
        }

        private TTModels.clsV2Models.tblParcelOwners loadOwnersClass(TTModels.clsV2Models.tblParcels parcelData)
        {
            TTModels.clsV2Models.tblParcelOwners oRecs = new TTModels.clsV2Models.tblParcelOwners();
            string thisParcel = "??::??"; string thisFKey = "";
            for (int i = 0; i < this.dgOwners.Rows.Count; i++)
            {
                if (thisParcel != this.dgOwners.Rows[i].Cells[1].Value.ToString().Trim())
                {
                    thisParcel = this.dgOwners.Rows[i].Cells[1].Value.ToString().Trim(); thisFKey = "";
                    foreach (TTModels.clsV2Models.tblParcel data in parcelData)
                    {
                        if (data.parcelStrNumber == this.dgOwners.Rows[i].Cells[1].Value.ToString()) { thisFKey = data.keyParcelID; }
                    }
                }
                TTModels.clsV2Models.tblParcelOwner oRec = new TTModels.clsV2Models.tblParcelOwner()
                {
                    keyParcelOwnerID = System.Guid.NewGuid().ToString(),
                    fkParcelID = thisFKey,
                    fkUserID_UpdatedBy = System.Guid.Empty.ToString(),
                    pownerBolCurrent = Convert.ToBoolean(this.dgOwners.Rows[i].Cells[5].Value.ToString()),
                    pownerDateCreated = Convert.ToDateTime(this.dgOwners.Rows[i].Cells[6].Value.ToString()),
                    pownerDateUpdated = Convert.ToDateTime(this.dgOwners.Rows[i].Cells[7].Value.ToString()),
                    pownerStrAddress = this.dgOwners.Rows[i].Cells[4].Value.ToString(),
                    pownerStrName1 = this.dgOwners.Rows[i].Cells[2].Value.ToString(),
                    pownerStrName2 = this.dgOwners.Rows[i].Cells[3].Value.ToString(),
                    pownerStrZip = this.dgOwners.Rows[i].Cells[8].Value.ToString()
                };


                if (thisFKey == "")
                {
                    //MessageBox.Show("Owners for parcel '" + this.dgOwners.Rows[i].Cells[1].Value.ToString() + " have no parcel match.  Skipping.");
                }
                else
                {
                    oRecs.Add(oRec);
                }
                if (i % 1000 == 0)
                {
                    this.lblProgress.Text = "Processing Parcel Owners " + i + " of " + this.dgOwners.Rows.Count;
                    this.Refresh();
                }

            }
            return oRecs;
        }

        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblParcels sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblParcels", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblParcelOwners sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblParcelOwners", sData);
                return oResponse;
            }

        }
        static async Task<HttpResponseMessage> RunAsync(string URL_Location, TTModels.clsV2Models.tblParcelNotes sData, string DB)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(URL_Location);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage oResponse = new HttpResponseMessage();
                oResponse = await client.PostAsJsonAsync("api/V2/" + DB + "/tblParcelNotes", sData);
                return oResponse;
            }

        }

        private async void btnConvert_Click(object sender, EventArgs e)
        {
            
            TTModels.clsV2Models.tblParcels      parcelData      = loadParcelClass();
            TTModels.clsV2Models.tblParcelNotes  parcelNotesData = loadParcelNotesClass(parcelData);
            TTModels.clsV2Models.tblParcelOwners parcelOwnerData = loadOwnersClass(parcelData);

            int counterRec = 0; int totalRec = 0;
            HttpResponseMessage oResult = new HttpResponseMessage();
            this.lblProgress.Text = "Inserting Parcels"; this.Refresh();

            #region "Insert Parcels"
            TTModels.clsV2Models.tblParcels parcelRecs = new TTModels.clsV2Models.tblParcels();
            foreach (TTModels.clsV2Models.tblParcel data in parcelData)
            {
                counterRec++; totalRec++;
                TTModels.clsV2Models.tblParcel parcelRec = new TTModels.clsV2Models.tblParcel()
                {
                    keyParcelID = data.keyParcelID,
                    fkSchoolDistrictID = data.fkSchoolDistrictID,
                    fkUserID_UpdatedBy = data.fkUserID_UpdatedBy,
                    parcelBolFarmstead = data.parcelBolFarmstead,
                    parcelBolHomestead = data.parcelBolHomestead,
                    parcelDateCreated = data.parcelDateCreated,
                    parcelDateUpdated = data.parcelDateUpdated,
                    parcelStrAcres = data.parcelStrAcres,
                    parcelStrBarCodeValue = data.parcelStrBarCodeValue,
                    parcelStrBook = data.parcelStrBook,
                    parcelStrCleanAndGreen = data.parcelStrCleanAndGreen,
                    parcelStrCode = data.parcelStrCode,
                    parcelStrControlNumber = data.parcelStrControlNumber,
                    parcelStrDistrict = data.parcelStrDistrict,
                    parcelStrLegal = data.parcelStrLegal,
                    parcelStrLocation = data.parcelStrLocation,
                    parcelStrNumber = data.parcelStrNumber,
                    parcelStrPage = data.parcelStrPage,
                    parcelStrTaxCode = data.parcelStrTaxCode
                };
                parcelRecs.Add(parcelRec);
                if (counterRec > 100)
                {
                    this.lblProgress.Text = "Inserting Parcels " + totalRec + " of " + parcelData.Count; this.Refresh();
                    oResult = await RunAsync(URL, parcelRecs, this.cboNewDatabase.Text.ToString());
                    if (oResult.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(oResult.StatusCode.ToString());
                    }
                    counterRec = 0;
                    parcelRecs.Clear();
                }
            }
            if (counterRec > 0)
            {
                oResult = await RunAsync(URL, parcelRecs, this.cboNewDatabase.Text.ToString());
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.StatusCode.ToString());
                }
                counterRec = 0;
                parcelRecs.Clear();
            }
            #endregion


            #region "Insert Notes"
            counterRec = 0; totalRec = 0;
            TTModels.clsV2Models.tblParcelNotes noteRecs = new TTModels.clsV2Models.tblParcelNotes();
            foreach (TTModels.clsV2Models.tblParcelNote data in parcelNotesData)
            {
                counterRec++; totalRec++;
                TTModels.clsV2Models.tblParcelNote noteRec = new TTModels.clsV2Models.tblParcelNote()
                {
                    keyParcelNoteID = data.keyParcelNoteID,
                    fkParcelID = data.fkParcelID,
                    fkUserID_EnteredBy = data.fkUserID_EnteredBy,
                    pnoteDateEntered = data.pnoteDateEntered,
                    pnoteStrNote = data.pnoteStrNote
                };
                noteRecs.Add(noteRec);
                if (counterRec > 100)
                {
                    this.lblProgress.Text = "Inserting Notes " + totalRec + " of " + parcelNotesData.Count; this.Refresh();
                    oResult = await RunAsync(URL, noteRecs, this.cboNewDatabase.Text.ToString());
                    if (oResult.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(oResult.StatusCode.ToString());
                    }
                    counterRec = 0;
                    noteRecs.Clear();
                }
            }
            if (counterRec > 0)
            {
                oResult = await RunAsync(URL, noteRecs, this.cboNewDatabase.Text.ToString());
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.StatusCode.ToString());
                }
                counterRec = 0;
                noteRecs.Clear();
            }
            #endregion

            #region "Insert Owners"
            counterRec = 0; totalRec = 0;
            TTModels.clsV2Models.tblParcelOwners ownerRecs = new TTModels.clsV2Models.tblParcelOwners();
            foreach (TTModels.clsV2Models.tblParcelOwner data in parcelOwnerData)
            {
                counterRec++; totalRec++;
                TTModels.clsV2Models.tblParcelOwner ownerRec = new TTModels.clsV2Models.tblParcelOwner()
                {
                    keyParcelOwnerID = data.keyParcelOwnerID,
                    fkParcelID = data.fkParcelID,
                    fkUserID_UpdatedBy = data.fkUserID_UpdatedBy,
                    pownerBolCurrent = data.pownerBolCurrent,
                    pownerDateCreated = data.pownerDateCreated,
                    pownerDateUpdated = data.pownerDateUpdated,
                    pownerStrAddress = data.pownerStrAddress,
                    pownerStrName1 = data.pownerStrName1,
                    pownerStrName2 = data.pownerStrName2,
                    pownerStrZip = data.pownerStrZip
                };
                ownerRecs.Add(ownerRec);
                if (counterRec > 100)
                {
                    this.lblProgress.Text = "Inserting Owners " + totalRec + " of " + parcelOwnerData.Count; this.Refresh();
                    oResult = await RunAsync(URL, ownerRecs, this.cboNewDatabase.Text.ToString());
                    if (oResult.StatusCode != HttpStatusCode.OK)
                    {
                        MessageBox.Show(oResult.StatusCode.ToString());
                    }
                    counterRec = 0;
                    ownerRecs.Clear();
                }
            }
            if (counterRec > 0)
            {
                oResult = await RunAsync(URL, ownerRecs, this.cboNewDatabase.Text.ToString());
                if (oResult.StatusCode != HttpStatusCode.OK)
                {
                    MessageBox.Show(oResult.StatusCode.ToString());
                }
                counterRec = 0;
                ownerRecs.Clear();
            }
            #endregion

            MessageBox.Show("Complete.");
        }
    }
}
