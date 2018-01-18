using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor.V2.Conversions
{
    public partial class frm_Exonerations : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();
        Classes.clsConversionFunctions oConvFunc = new Classes.clsConversionFunctions();
        //string URL = "http://208.109.186.146:100/";
        string URL = "http://localhost:29471/";

        public frm_Exonerations()
        {
            InitializeComponent();
        }

        TTModels.clsV2Models.tblTaxRolls taxRollDatas = new TTModels.clsV2Models.tblTaxRolls();
        TTModels.clsV2Models.tblParcels parcelDatas = new TTModels.clsV2Models.tblParcels();

        #region "Load Classes"
        private void loadClassTaxRolls(DataTable oDT)
        {
            for (int i = 0; i < oDT.Rows.Count; i++)
            {
                TTModels.clsV2Models.tblTaxRoll rec = new TTModels.clsV2Models.tblTaxRoll()
                {
                    keyTaxRollID = oDT.Rows[i]["keyTaxRollID"].ToString(),
                    taxrollBolActive = Convert.ToBoolean(oDT.Rows[i]["taxrollBolActive"].ToString()),
                    taxrollBolInterim = Convert.ToBoolean(oDT.Rows[i]["taxrollBolInterim"].ToString()),
                    taxrollDateEntered = Convert.ToDateTime(oDT.Rows[i]["taxrollDateEntered"].ToString()),
                    taxrollStrFiscalSubYear = oDT.Rows[i]["taxrollStrFiscalSubYear"].ToString(),
                    taxrollStrFiscalYear = oDT.Rows[i]["taxrollStrFiscalYear"].ToString()
                };
                taxRollDatas.Add(rec);
            }

        }
        private void loadClassParcels(DataTable oDT)
        {
            for (int i = 0; i < oDT.Rows.Count; i++)
            {
                TTModels.clsV2Models.tblParcel rec = new TTModels.clsV2Models.tblParcel()
                {
                    keyParcelID = oDT.Rows[i]["keyParcelID"].ToString(),
                    fkSchoolDistrictID     = oDT.Rows[i]["fkSchoolDistrictID"].ToString(),
                    fkUserID_UpdatedBy     = oDT.Rows[i]["fkUserID_UpdatedBy"].ToString(),
                    parcelBolFarmstead     = Convert.ToBoolean(oDT.Rows[i]["parcelBolFarmstead"].ToString()),
                    parcelBolHomestead     = Convert.ToBoolean(oDT.Rows[i]["parcelBolHomestead"].ToString()),
                    parcelDateCreated      = Convert.ToDateTime(oDT.Rows[i]["parcelDateCreated"].ToString()),
                    parcelDateUpdated      = Convert.ToDateTime(oDT.Rows[i]["parcelDateUpdated"].ToString()),
                    parcelStrAcres         = oDT.Rows[i]["parcelStrAcres"].ToString(),
                    parcelStrBarCodeValue  = oDT.Rows[i]["parcelStrBarCodeValue"].ToString(),
                    parcelStrBook          = oDT.Rows[i]["parcelStrBook"].ToString(),
                    parcelStrCleanAndGreen = oDT.Rows[i]["parcelStrCleanAndGreen"].ToString(),
                    parcelStrCode          = oDT.Rows[i]["parcelStrCode"].ToString(),
                    parcelStrControlNumber = oDT.Rows[i]["parcelStrControlNumber"].ToString(),
                    parcelStrDistrict      = oDT.Rows[i]["parcelStrDistrict"].ToString(),
                    parcelStrLegal         = oDT.Rows[i]["parcelStrLegal"].ToString(),
                    parcelStrLocation      = oDT.Rows[i]["parcelStrLocation"].ToString(),
                    parcelStrNumber        = oDT.Rows[i]["parcelStrNumber"].ToString(),
                    parcelStrPage          = oDT.Rows[i]["parcelStrPage"].ToString(),
                    parcelStrTaxCode       = oDT.Rows[i]["parcelStrTaxCode"].ToString()
                };
                parcelDatas.Add(rec);

            };
        }
        #endregion

        private void btnLoad_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            DataSet oDS = new DataSet();
            string url = URL + "/api/Conversion/" + this.cboDatabase.Text + "/Exonerations";
            oDS = oFunc.getData_V15(url, "", "");
            this.dgExonerations.DataSource = oDS.Tables[0];

            url = URL + "/api/V2/" + this.cboNewDatabase.Text + "/tblTaxRolls";
            oDS = oFunc.getData_V15(url, "", "");
            loadClassTaxRolls(oDS.Tables[0]);
            this.dgTaxRolls.DataSource = oDS.Tables[0];

            url = URL + "/api/V2/" + this.cboNewDatabase.Text + "/tblParcels";
            oDS = oFunc.getData_V15(url, "", "");
            loadClassParcels(oDS.Tables[0]);
            this.dgParcels.DataSource = oDS.Tables[0];


            Cursor = Cursors.Default;
        }


        private string getParcelKey(string parcelNumber)
        {
            string keyParcelID = "";

            foreach(TTModels.clsV2Models.tblParcel data in parcelDatas)
            {
                if (data.parcelStrNumber == parcelNumber)
                {
                    keyParcelID = data.keyParcelID;
                }
            }

            return keyParcelID;
        }


        private void bntConvert_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < this.dgExonerations.Rows.Count; i++)
            {

            }
        }
    }
}
