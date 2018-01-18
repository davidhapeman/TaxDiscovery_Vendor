using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vendor
{
    public partial class Main : Form
    {
        private int childFormNumber = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imports.frm_Shippensburg oForm = new Imports.frm_Shippensburg();
            oForm.MdiParent = this;
            oForm.Show();

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fixRoundingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorrectionForms.frm_EriePrinterRounding oForm = new CorrectionForms.frm_EriePrinterRounding();
            oForm.MdiParent = this;
            oForm.Show();

        }

        private void interimsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imports.ErieCounty.frm_ImportInterims oForm = new Imports.ErieCounty.frm_ImportInterims();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void cMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imports.ErieCounty.frm_ImportCM oForm = new Imports.ErieCounty.frm_ImportCM();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void pamImportStreetLightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imports.ErieCounty.frm_PamStreetLights oForm = new Imports.ErieCounty.frm_PamStreetLights();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void schoolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imports.ErieCounty.frm_ImportSchool oForm = new Imports.ErieCounty.frm_ImportSchool();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void taxRollsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V2.Conversions.frm_TaxRolls oForm = new V2.Conversions.frm_TaxRolls();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void parcelsOwnersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V2.Conversions.frm_Parcels oForm = new V2.Conversions.frm_Parcels();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void userDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V2.Conversions.frm_User oForm = new V2.Conversions.frm_User();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void billsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V2.Conversions.frm_Bills oForm = new V2.Conversions.frm_Bills();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void remittanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V2.Conversions.frm_Remittances oForm = new V2.Conversions.frm_Remittances();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void moneyPostingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V2.Conversions.frm_Moneys oForm = new V2.Conversions.frm_Moneys();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void exonerationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            V2.Conversions.frm_Exonerations oForm = new V2.Conversions.frm_Exonerations();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void oneTimeRunCorryPerCapitaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Imports.ErieCounty.frm_Initialize_CityOfCorryPerCapita oForm = new Imports.ErieCounty.frm_Initialize_CityOfCorryPerCapita();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void incidentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IncidentTracking.frm_IncidentTracking oForm = new IncidentTracking.frm_IncidentTracking();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void userMaintenanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserMaintenance.frm_UserMaintenance oForm = new UserMaintenance.frm_UserMaintenance();
            oForm.MdiParent = this;
            oForm.Show();
        }

        private void gmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Testing.frm_Gmail oForm = new Testing.frm_Gmail();
            oForm.MdiParent = this;
            oForm.Show();
        }
    }
}
