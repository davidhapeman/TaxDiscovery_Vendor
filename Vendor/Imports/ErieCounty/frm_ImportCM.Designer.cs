namespace Vendor.Imports.ErieCounty
{
    partial class frm_ImportCM
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
            this.txtMuniRate = new System.Windows.Forms.TextBox();
            this.txtMuniID = new System.Windows.Forms.TextBox();
            this.chkMuni = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnImport = new System.Windows.Forms.Button();
            this.Label12 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label10 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label14 = new System.Windows.Forms.Label();
            this.dtPenlEnd = new System.Windows.Forms.DateTimePicker();
            this.dtPenlStart = new System.Windows.Forms.DateTimePicker();
            this.dtFaceEnd = new System.Windows.Forms.DateTimePicker();
            this.dtFaceStart = new System.Windows.Forms.DateTimePicker();
            this.dtDiscEnd = new System.Windows.Forms.DateTimePicker();
            this.dtDiscStart = new System.Windows.Forms.DateTimePicker();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtFiscalSubYear = new System.Windows.Forms.TextBox();
            this.txtFiscalYear = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.cboDistrict = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.txtCountyRate = new System.Windows.Forms.TextBox();
            this.txtCountyID = new System.Windows.Forms.TextBox();
            this.chkCounty = new System.Windows.Forms.CheckBox();
            this.dgFileImport = new System.Windows.Forms.DataGridView();
            this.btnLoadDatagrid = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgFileImport2 = new System.Windows.Forms.DataGridView();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.txtFileName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMuniReductionRate = new System.Windows.Forms.TextBox();
            this.txtMuniReductionID = new System.Windows.Forms.TextBox();
            this.chkMuniReduction = new System.Windows.Forms.CheckBox();
            this.txtLibraryRate = new System.Windows.Forms.TextBox();
            this.txtLibraryID = new System.Windows.Forms.TextBox();
            this.chkLibrary = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMuniRate
            // 
            this.txtMuniRate.Location = new System.Drawing.Point(342, 302);
            this.txtMuniRate.Name = "txtMuniRate";
            this.txtMuniRate.Size = new System.Drawing.Size(100, 20);
            this.txtMuniRate.TabIndex = 241;
            // 
            // txtMuniID
            // 
            this.txtMuniID.Location = new System.Drawing.Point(237, 302);
            this.txtMuniID.Name = "txtMuniID";
            this.txtMuniID.Size = new System.Drawing.Size(100, 20);
            this.txtMuniID.TabIndex = 240;
            this.txtMuniID.Text = "2";
            // 
            // chkMuni
            // 
            this.chkMuni.AutoSize = true;
            this.chkMuni.Checked = true;
            this.chkMuni.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMuni.Location = new System.Drawing.Point(156, 304);
            this.chkMuni.Name = "chkMuni";
            this.chkMuni.Size = new System.Drawing.Size(49, 17);
            this.chkMuni.TabIndex = 239;
            this.chkMuni.Text = "Muni";
            this.chkMuni.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(339, 259);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 238;
            this.label7.Text = "Millage Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(234, 259);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 237;
            this.label6.Text = "Tax Type ID";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pbarProgress,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 484);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1134, 22);
            this.statusStrip1.TabIndex = 236;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(55, 17);
            this.toolStripStatusLabel1.Text = "Progress:";
            // 
            // pbarProgress
            // 
            this.pbarProgress.Name = "pbarProgress";
            this.pbarProgress.Size = new System.Drawing.Size(75, 16);
            // 
            // lblProgress
            // 
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(65, 17);
            this.lblProgress.Text = "lblProgress";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(983, 251);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 235;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(513, 401);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(45, 13);
            this.Label12.TabIndex = 234;
            this.Label12.Text = "Penalty:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(525, 375);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(34, 13);
            this.Label11.TabIndex = 233;
            this.Label11.Text = "Face:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(507, 349);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(52, 13);
            this.Label10.TabIndex = 232;
            this.Label10.Text = "Discount:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(723, 327);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(29, 13);
            this.Label13.TabIndex = 231;
            this.Label13.Text = "End:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(599, 327);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(32, 13);
            this.Label14.TabIndex = 230;
            this.Label14.Text = "Start:";
            // 
            // dtPenlEnd
            // 
            this.dtPenlEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPenlEnd.Location = new System.Drawing.Point(683, 398);
            this.dtPenlEnd.Name = "dtPenlEnd";
            this.dtPenlEnd.Size = new System.Drawing.Size(112, 20);
            this.dtPenlEnd.TabIndex = 229;
            // 
            // dtPenlStart
            // 
            this.dtPenlStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPenlStart.Location = new System.Drawing.Point(564, 398);
            this.dtPenlStart.Name = "dtPenlStart";
            this.dtPenlStart.Size = new System.Drawing.Size(112, 20);
            this.dtPenlStart.TabIndex = 228;
            // 
            // dtFaceEnd
            // 
            this.dtFaceEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFaceEnd.Location = new System.Drawing.Point(683, 372);
            this.dtFaceEnd.Name = "dtFaceEnd";
            this.dtFaceEnd.Size = new System.Drawing.Size(112, 20);
            this.dtFaceEnd.TabIndex = 227;
            // 
            // dtFaceStart
            // 
            this.dtFaceStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFaceStart.Location = new System.Drawing.Point(564, 372);
            this.dtFaceStart.Name = "dtFaceStart";
            this.dtFaceStart.Size = new System.Drawing.Size(112, 20);
            this.dtFaceStart.TabIndex = 226;
            // 
            // dtDiscEnd
            // 
            this.dtDiscEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiscEnd.Location = new System.Drawing.Point(683, 346);
            this.dtDiscEnd.Name = "dtDiscEnd";
            this.dtDiscEnd.Size = new System.Drawing.Size(112, 20);
            this.dtDiscEnd.TabIndex = 225;
            // 
            // dtDiscStart
            // 
            this.dtDiscStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiscStart.Location = new System.Drawing.Point(564, 346);
            this.dtDiscStart.Name = "dtDiscStart";
            this.dtDiscStart.Size = new System.Drawing.Size(112, 20);
            this.dtDiscStart.TabIndex = 224;
            this.dtDiscStart.ValueChanged += new System.EventHandler(this.dtDiscStart_ValueChanged);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(474, 304);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(84, 13);
            this.Label15.TabIndex = 223;
            this.Label15.Text = "Fiscal Sub Year:";
            // 
            // txtFiscalSubYear
            // 
            this.txtFiscalSubYear.Location = new System.Drawing.Point(564, 301);
            this.txtFiscalSubYear.Name = "txtFiscalSubYear";
            this.txtFiscalSubYear.Size = new System.Drawing.Size(181, 20);
            this.txtFiscalSubYear.TabIndex = 222;
            // 
            // txtFiscalYear
            // 
            this.txtFiscalYear.Location = new System.Drawing.Point(564, 277);
            this.txtFiscalYear.Name = "txtFiscalYear";
            this.txtFiscalYear.Size = new System.Drawing.Size(100, 20);
            this.txtFiscalYear.TabIndex = 221;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(497, 280);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(62, 13);
            this.Label16.TabIndex = 220;
            this.Label16.Text = "Fiscal Year:";
            // 
            // cboDistrict
            // 
            this.cboDistrict.FormattingEnabled = true;
            this.cboDistrict.Items.AddRange(new object[] {
            "CC-City of Corry",
            "NE-Northeast Boro",
            "UC-Union City Boro",
            "00-Hapeman Sandbox",
            "03-Debbie Gates",
            "25-Husted",
            "27-Brink",
            "29-Laweranceville",
            "31-Hamme",
            "33-Case",
            "40-Cameron",
            "44-Venago"});
            this.cboDistrict.Location = new System.Drawing.Point(564, 253);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Size = new System.Drawing.Size(230, 21);
            this.cboDistrict.TabIndex = 219;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(516, 258);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(42, 13);
            this.Label9.TabIndex = 218;
            this.Label9.Text = "District:";
            // 
            // txtCountyRate
            // 
            this.txtCountyRate.Location = new System.Drawing.Point(341, 276);
            this.txtCountyRate.Name = "txtCountyRate";
            this.txtCountyRate.Size = new System.Drawing.Size(100, 20);
            this.txtCountyRate.TabIndex = 217;
            // 
            // txtCountyID
            // 
            this.txtCountyID.Location = new System.Drawing.Point(236, 276);
            this.txtCountyID.Name = "txtCountyID";
            this.txtCountyID.Size = new System.Drawing.Size(100, 20);
            this.txtCountyID.TabIndex = 216;
            this.txtCountyID.Text = "1";
            // 
            // chkCounty
            // 
            this.chkCounty.AutoSize = true;
            this.chkCounty.Checked = true;
            this.chkCounty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCounty.Location = new System.Drawing.Point(155, 278);
            this.chkCounty.Name = "chkCounty";
            this.chkCounty.Size = new System.Drawing.Size(59, 17);
            this.chkCounty.TabIndex = 215;
            this.chkCounty.Text = "County";
            this.chkCounty.UseVisualStyleBackColor = true;
            // 
            // dgFileImport
            // 
            this.dgFileImport.AllowUserToAddRows = false;
            this.dgFileImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileImport.Location = new System.Drawing.Point(12, 54);
            this.dgFileImport.Name = "dgFileImport";
            this.dgFileImport.Size = new System.Drawing.Size(520, 150);
            this.dgFileImport.TabIndex = 214;
            // 
            // btnLoadDatagrid
            // 
            this.btnLoadDatagrid.Location = new System.Drawing.Point(494, 210);
            this.btnLoadDatagrid.Name = "btnLoadDatagrid";
            this.btnLoadDatagrid.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDatagrid.TabIndex = 213;
            this.btnLoadDatagrid.Text = "Load";
            this.btnLoadDatagrid.UseVisualStyleBackColor = true;
            this.btnLoadDatagrid.Click += new System.EventHandler(this.btnLoadDatagrid_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(457, 24);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 212;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(68, 26);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(350, 20);
            this.txtFileName.TabIndex = 211;
            this.txtFileName.Text = "C:\\TaxTracker\\Imports\\Franklin\\Normal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(10, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 210;
            this.Label1.Text = "Filename:";
            // 
            // dgFileImport2
            // 
            this.dgFileImport2.AllowUserToAddRows = false;
            this.dgFileImport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileImport2.Location = new System.Drawing.Point(538, 54);
            this.dgFileImport2.Name = "dgFileImport2";
            this.dgFileImport2.Size = new System.Drawing.Size(520, 150);
            this.dgFileImport2.TabIndex = 245;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(983, 24);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 244;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // txtFileName2
            // 
            this.txtFileName2.Location = new System.Drawing.Point(594, 26);
            this.txtFileName2.Name = "txtFileName2";
            this.txtFileName2.Size = new System.Drawing.Size(350, 20);
            this.txtFileName2.TabIndex = 243;
            this.txtFileName2.Text = "C:\\TaxTracker\\Imports\\Franklin\\Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 242;
            this.label2.Text = "Filename:";
            // 
            // txtMuniReductionRate
            // 
            this.txtMuniReductionRate.Location = new System.Drawing.Point(342, 328);
            this.txtMuniReductionRate.Name = "txtMuniReductionRate";
            this.txtMuniReductionRate.Size = new System.Drawing.Size(100, 20);
            this.txtMuniReductionRate.TabIndex = 248;
            // 
            // txtMuniReductionID
            // 
            this.txtMuniReductionID.Location = new System.Drawing.Point(237, 328);
            this.txtMuniReductionID.Name = "txtMuniReductionID";
            this.txtMuniReductionID.Size = new System.Drawing.Size(100, 20);
            this.txtMuniReductionID.TabIndex = 247;
            this.txtMuniReductionID.Text = "2";
            // 
            // chkMuniReduction
            // 
            this.chkMuniReduction.AutoSize = true;
            this.chkMuniReduction.Location = new System.Drawing.Point(156, 330);
            this.chkMuniReduction.Name = "chkMuniReduction";
            this.chkMuniReduction.Size = new System.Drawing.Size(75, 17);
            this.chkMuniReduction.TabIndex = 246;
            this.chkMuniReduction.Text = "Muni Red.";
            this.chkMuniReduction.UseVisualStyleBackColor = true;
            // 
            // txtLibraryRate
            // 
            this.txtLibraryRate.Location = new System.Drawing.Point(342, 354);
            this.txtLibraryRate.Name = "txtLibraryRate";
            this.txtLibraryRate.Size = new System.Drawing.Size(100, 20);
            this.txtLibraryRate.TabIndex = 251;
            // 
            // txtLibraryID
            // 
            this.txtLibraryID.Location = new System.Drawing.Point(237, 354);
            this.txtLibraryID.Name = "txtLibraryID";
            this.txtLibraryID.Size = new System.Drawing.Size(100, 20);
            this.txtLibraryID.TabIndex = 250;
            this.txtLibraryID.Text = "9";
            // 
            // chkLibrary
            // 
            this.chkLibrary.AutoSize = true;
            this.chkLibrary.Location = new System.Drawing.Point(156, 356);
            this.chkLibrary.Name = "chkLibrary";
            this.chkLibrary.Size = new System.Drawing.Size(75, 17);
            this.chkLibrary.TabIndex = 249;
            this.chkLibrary.Text = "Muni Red.";
            this.chkLibrary.UseVisualStyleBackColor = true;
            // 
            // frm_ImportCM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 506);
            this.Controls.Add(this.txtLibraryRate);
            this.Controls.Add(this.txtLibraryID);
            this.Controls.Add(this.chkLibrary);
            this.Controls.Add(this.txtMuniReductionRate);
            this.Controls.Add(this.txtMuniReductionID);
            this.Controls.Add(this.chkMuniReduction);
            this.Controls.Add(this.dgFileImport2);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.txtFileName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMuniRate);
            this.Controls.Add(this.txtMuniID);
            this.Controls.Add(this.chkMuni);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Label11);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.Label13);
            this.Controls.Add(this.Label14);
            this.Controls.Add(this.dtPenlEnd);
            this.Controls.Add(this.dtPenlStart);
            this.Controls.Add(this.dtFaceEnd);
            this.Controls.Add(this.dtFaceStart);
            this.Controls.Add(this.dtDiscEnd);
            this.Controls.Add(this.dtDiscStart);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtFiscalSubYear);
            this.Controls.Add(this.txtFiscalYear);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.cboDistrict);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtCountyRate);
            this.Controls.Add(this.txtCountyID);
            this.Controls.Add(this.chkCounty);
            this.Controls.Add(this.dgFileImport);
            this.Controls.Add(this.btnLoadDatagrid);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.Label1);
            this.Name = "frm_ImportCM";
            this.Text = "frm_ImportCM";
            this.Load += new System.EventHandler(this.frm_ImportCM_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox txtMuniRate;
        internal System.Windows.Forms.TextBox txtMuniID;
        internal System.Windows.Forms.CheckBox chkMuni;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pbarProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        internal System.Windows.Forms.Button btnImport;
        internal System.Windows.Forms.Label Label12;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label10;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label14;
        internal System.Windows.Forms.DateTimePicker dtPenlEnd;
        internal System.Windows.Forms.DateTimePicker dtPenlStart;
        internal System.Windows.Forms.DateTimePicker dtFaceEnd;
        internal System.Windows.Forms.DateTimePicker dtFaceStart;
        internal System.Windows.Forms.DateTimePicker dtDiscEnd;
        internal System.Windows.Forms.DateTimePicker dtDiscStart;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtFiscalSubYear;
        internal System.Windows.Forms.TextBox txtFiscalYear;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.ComboBox cboDistrict;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtCountyRate;
        internal System.Windows.Forms.TextBox txtCountyID;
        internal System.Windows.Forms.CheckBox chkCounty;
        internal System.Windows.Forms.DataGridView dgFileImport;
        internal System.Windows.Forms.Button btnLoadDatagrid;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtFileName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgFileImport2;
        internal System.Windows.Forms.Button btnBrowse2;
        internal System.Windows.Forms.TextBox txtFileName2;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox txtMuniReductionRate;
        internal System.Windows.Forms.TextBox txtMuniReductionID;
        internal System.Windows.Forms.CheckBox chkMuniReduction;
        internal System.Windows.Forms.TextBox txtLibraryRate;
        internal System.Windows.Forms.TextBox txtLibraryID;
        internal System.Windows.Forms.CheckBox chkLibrary;
    }
}