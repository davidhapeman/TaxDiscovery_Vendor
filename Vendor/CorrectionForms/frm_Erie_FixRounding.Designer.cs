namespace Vendor.CorrectionForms
{
    partial class frm_Erie_FixRounding
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgFileImport = new System.Windows.Forms.DataGridView();
            this.btnLoadDatagrid = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtFiscalSubYear = new System.Windows.Forms.TextBox();
            this.txtFiscalYear = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radCountyMuni = new System.Windows.Forms.RadioButton();
            this.radSchool = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgFileImport
            // 
            this.dgFileImport.AllowUserToAddRows = false;
            this.dgFileImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileImport.Location = new System.Drawing.Point(13, 52);
            this.dgFileImport.Margin = new System.Windows.Forms.Padding(4);
            this.dgFileImport.Name = "dgFileImport";
            this.dgFileImport.Size = new System.Drawing.Size(909, 185);
            this.dgFileImport.TabIndex = 121;
            // 
            // btnLoadDatagrid
            // 
            this.btnLoadDatagrid.Location = new System.Drawing.Point(822, 20);
            this.btnLoadDatagrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadDatagrid.Name = "btnLoadDatagrid";
            this.btnLoadDatagrid.Size = new System.Drawing.Size(100, 28);
            this.btnLoadDatagrid.TabIndex = 120;
            this.btnLoadDatagrid.Text = "Load";
            this.btnLoadDatagrid.UseVisualStyleBackColor = true;
            this.btnLoadDatagrid.Click += new System.EventHandler(this.btnLoadDatagrid_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(714, 20);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 119;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(87, 22);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(617, 22);
            this.txtFileName.TabIndex = 118;
            this.txtFileName.Text = "C:\\TaxTracker\\Imports\\Franklin\\Normal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 26);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 17);
            this.Label1.TabIndex = 117;
            this.Label1.Text = "Filename:";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(822, 249);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 28);
            this.btnImport.TabIndex = 168;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(19, 325);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(111, 17);
            this.Label15.TabIndex = 167;
            this.Label15.Text = "Fiscal Sub Year:";
            // 
            // txtFiscalSubYear
            // 
            this.txtFiscalSubYear.Location = new System.Drawing.Point(139, 321);
            this.txtFiscalSubYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiscalSubYear.Name = "txtFiscalSubYear";
            this.txtFiscalSubYear.Size = new System.Drawing.Size(240, 22);
            this.txtFiscalSubYear.TabIndex = 166;
            this.txtFiscalSubYear.Text = "Normal-";
            // 
            // txtFiscalYear
            // 
            this.txtFiscalYear.Location = new System.Drawing.Point(139, 292);
            this.txtFiscalYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiscalYear.Name = "txtFiscalYear";
            this.txtFiscalYear.Size = new System.Drawing.Size(132, 22);
            this.txtFiscalYear.TabIndex = 165;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(49, 296);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(82, 17);
            this.Label16.TabIndex = 164;
            this.Label16.Text = "Fiscal Year:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSchool);
            this.groupBox1.Controls.Add(this.radCountyMuni);
            this.groupBox1.Location = new System.Drawing.Point(395, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 70);
            this.groupBox1.TabIndex = 169;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Which Normal Grouping?";
            // 
            // radCountyMuni
            // 
            this.radCountyMuni.AutoSize = true;
            this.radCountyMuni.Location = new System.Drawing.Point(19, 31);
            this.radCountyMuni.Name = "radCountyMuni";
            this.radCountyMuni.Size = new System.Drawing.Size(107, 21);
            this.radCountyMuni.TabIndex = 0;
            this.radCountyMuni.TabStop = true;
            this.radCountyMuni.Text = "County/Muni";
            this.radCountyMuni.UseVisualStyleBackColor = true;
            // 
            // radSchool
            // 
            this.radSchool.AutoSize = true;
            this.radSchool.Location = new System.Drawing.Point(175, 32);
            this.radSchool.Name = "radSchool";
            this.radSchool.Size = new System.Drawing.Size(72, 21);
            this.radSchool.TabIndex = 1;
            this.radSchool.TabStop = true;
            this.radSchool.Text = "School";
            this.radSchool.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pbarProgress,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 416);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 25);
            this.statusStrip1.TabIndex = 170;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(68, 20);
            this.toolStripStatusLabel1.Text = "Progress:";
            // 
            // pbarProgress
            // 
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Size = new System.Drawing.Size(100, 19);
            // 
            // lblProgress
            // 
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(82, 20);
            this.lblProgress.Text = "lblProgress";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 171;
            this.label2.Text = "Database:";
            // 
            // cboDatabase
            // 
            this.cboDatabase.FormattingEnabled = true;
            this.cboDatabase.Items.AddRange(new object[] {
            "TTrackerErie25",
            "TTrackerErie27",
            "TTrackerErie31",
            "TTrackerErie33",
            "TTrackerErie40"});
            this.cboDatabase.Location = new System.Drawing.Point(139, 261);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(240, 24);
            this.cboDatabase.TabIndex = 172;
            // 
            // frm_Erie_FixRounding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 441);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtFiscalSubYear);
            this.Controls.Add(this.txtFiscalYear);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.dgFileImport);
            this.Controls.Add(this.btnLoadDatagrid);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.Label1);
            this.Name = "frm_Erie_FixRounding";
            this.Text = "frm_Erie_FixRounding";
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgFileImport;
        internal System.Windows.Forms.Button btnLoadDatagrid;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtFileName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnImport;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtFiscalSubYear;
        internal System.Windows.Forms.TextBox txtFiscalYear;
        internal System.Windows.Forms.Label Label16;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radSchool;
        private System.Windows.Forms.RadioButton radCountyMuni;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pbarProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDatabase;
    }
}