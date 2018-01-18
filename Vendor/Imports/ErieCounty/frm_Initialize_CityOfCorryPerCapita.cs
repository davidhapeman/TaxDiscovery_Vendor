using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor.Imports.ErieCounty
{
    public partial class frm_Initialize_CityOfCorryPerCapita : Form
    {
        TTModels.clsFunctions oFunc = new TTModels.clsFunctions();

        public class inputRecs : List<inputRec>
        {
            public inputRecs() { }
            public inputRecs(List<inputRec> inputRecs) : base(inputRecs) { }
        }
        public class inputRec
        {
            public string ssn { get; set; }
            public string name { get; set; }
            public string street { get; set; }
            public string citystatezip { get; set; }
            public string ward { get; set; }
            public string perCapita { get; set; }
            public DateTime moveIn { get; set; }
            public string lastITR { get; set; }
            public DateTime moveOut { get; set; }
            public string phone { get; set; }
            public string remarks1 { get; set; }
            public string remarks2 { get; set; }
        }

        public frm_Initialize_CityOfCorryPerCapita()
        {
            InitializeComponent();
        }

        private void frm_Initialize_CityOfCorryPerCapita_Load(object sender, EventArgs e)
        {
            frm_Initialize_CityOfCorryPerCapita_Resize(sender, e);
        }

        private void btnBrowse_Resize(object sender, EventArgs e)
        {

        }

        private void frm_Initialize_CityOfCorryPerCapita_Resize(object sender, EventArgs e)
        {
            this.dgFileImport.Width = this.Width - this.dgFileImport.Left - 25;
            this.dgFileImport.Height = this.Height - this.dgFileImport.Top - 50;
        }

        inputRecs dataRecs = new inputRecs();
        private void loadClass(DataGridViewRow oRow)
        {

            DateTime moveIn = new DateTime(); DateTime moveOut = new DateTime(); moveIn = Convert.ToDateTime("01/01/2017"); moveOut = DateTime.MaxValue;
            try { moveIn = Convert.ToDateTime(oRow.Cells[6].Value.ToString()); } catch { }

            inputRec dataRec = new inputRec()
                {
                    ssn          = oRow.Cells[0].Value.ToString(),
                    name         = oRow.Cells[1].Value.ToString(),
                    street       = oRow.Cells[2].Value.ToString(),
                    citystatezip = oRow.Cells[3].Value.ToString(),
                    ward         = oRow.Cells[4].Value.ToString(),
                    perCapita    = oRow.Cells[5].Value.ToString(),
                    moveIn       = moveIn,
                    lastITR      = oRow.Cells[7].Value.ToString(),
                    moveOut      = moveOut,
                    phone        = oRow.Cells[9].Value.ToString(),
                    remarks1     = oRow.Cells[10].Value.ToString(),
                    remarks2     = oRow.Cells[11].Value.ToString()
            };
            dataRecs.Add(dataRec);
        }

        private void btnLoadDatagrid_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            string fileName = System.IO.Path.GetFileName(this.txtFileName.Text);
            string pathName = this.txtFileName.Text.Replace(fileName, "").ToString();

            DataTable oDTRawData2 = new DataTable();
            oDTRawData2 = oFunc.getDataFromCSV(this.txtFileName.Text, fileName, pathName).Tables[0];
            this.dgFileImport.DataSource = oDTRawData2;

            for (int i = 0; i < this.dgFileImport.Rows.Count; i++)
            {
                loadClass(this.dgFileImport.Rows[i]);
            }
            Cursor = Cursors.Default;

        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            this.txtFileName.Text = oFunc.getFileName(this.txtFileName.Text);
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            foreach (inputRec dataRec in dataRecs)
            {
                string ssn = oFunc.enc(dataRec.ssn);
            }
        }
    }
}
