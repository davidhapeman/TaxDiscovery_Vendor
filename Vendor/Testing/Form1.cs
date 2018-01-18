using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor.Testing
{
    public partial class Form1 : Form
    {
        TTModels.clsFunctions oProcess = new TTModels.clsFunctions();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable oDT = new System.Data.DataTable();

            oDT = oProcess.getData_V15(Globals.Url15 + "/api/15/tblParcelInformation/TTrackerErie40","","").Tables[0];
            this.dataGridView1.DataSource = oDT;
        }
    }
}
