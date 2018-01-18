namespace Vendor.Imports.ErieCounty
{
    partial class frm_ImportSchool
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
            this.dgFileImport2 = new System.Windows.Forms.DataGridView();
            this.btnBrowse2 = new System.Windows.Forms.Button();
            this.txtFileName2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtReductionRate = new System.Windows.Forms.TextBox();
            this.txtReductionID = new System.Windows.Forms.TextBox();
            this.chkReduction = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbarProgress = new System.Windows.Forms.ToolStripProgressBar();
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
            this.Label9 = new System.Windows.Forms.Label();
            this.txtSchoolRate = new System.Windows.Forms.TextBox();
            this.txtSchoolID = new System.Windows.Forms.TextBox();
            this.chkSchool = new System.Windows.Forms.CheckBox();
            this.dgFileImport = new System.Windows.Forms.DataGridView();
            this.btnLoadDatagrid = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cboDistrict = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtInstallments = new System.Windows.Forms.TextBox();
            this.txtLibraryRate = new System.Windows.Forms.TextBox();
            this.txtLibraryID = new System.Windows.Forms.TextBox();
            this.chkLibrary = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport2)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFileImport2
            // 
            this.dgFileImport2.AllowUserToAddRows = false;
            this.dgFileImport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileImport2.Location = new System.Drawing.Point(536, 38);
            this.dgFileImport2.Name = "dgFileImport2";
            this.dgFileImport2.Size = new System.Drawing.Size(520, 150);
            this.dgFileImport2.TabIndex = 284;
            // 
            // btnBrowse2
            // 
            this.btnBrowse2.Location = new System.Drawing.Point(981, 9);
            this.btnBrowse2.Name = "btnBrowse2";
            this.btnBrowse2.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse2.TabIndex = 283;
            this.btnBrowse2.Text = "Browse";
            this.btnBrowse2.UseVisualStyleBackColor = true;
            this.btnBrowse2.Click += new System.EventHandler(this.btnBrowse2_Click);
            // 
            // txtFileName2
            // 
            this.txtFileName2.Location = new System.Drawing.Point(592, 11);
            this.txtFileName2.Name = "txtFileName2";
            this.txtFileName2.Size = new System.Drawing.Size(350, 20);
            this.txtFileName2.TabIndex = 282;
            this.txtFileName2.Text = "C:\\TaxTracker\\Imports\\Franklin\\Normal";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(534, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 281;
            this.label2.Text = "Filename:";
            // 
            // lblProgress
            // 
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(65, 17);
            this.lblProgress.Text = "lblProgress";
            // 
            // txtReductionRate
            // 
            this.txtReductionRate.Location = new System.Drawing.Point(340, 287);
            this.txtReductionRate.Name = "txtReductionRate";
            this.txtReductionRate.Size = new System.Drawing.Size(100, 20);
            this.txtReductionRate.TabIndex = 280;
            this.txtReductionRate.Text = "-100.00";
            // 
            // txtReductionID
            // 
            this.txtReductionID.Location = new System.Drawing.Point(235, 287);
            this.txtReductionID.Name = "txtReductionID";
            this.txtReductionID.Size = new System.Drawing.Size(100, 20);
            this.txtReductionID.TabIndex = 279;
            this.txtReductionID.Text = "4";
            // 
            // chkReduction
            // 
            this.chkReduction.AutoSize = true;
            this.chkReduction.Checked = true;
            this.chkReduction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkReduction.Location = new System.Drawing.Point(154, 288);
            this.chkReduction.Name = "chkReduction";
            this.chkReduction.Size = new System.Drawing.Size(75, 17);
            this.chkReduction.TabIndex = 278;
            this.chkReduction.Text = "Reduction";
            this.chkReduction.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(337, 244);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 277;
            this.label7.Text = "Millage Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(232, 244);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 276;
            this.label6.Text = "Tax Type ID";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pbarProgress,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 22);
            this.statusStrip1.TabIndex = 275;
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
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(981, 236);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 274;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(511, 386);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(45, 13);
            this.Label12.TabIndex = 273;
            this.Label12.Text = "Penalty:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(523, 360);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(34, 13);
            this.Label11.TabIndex = 272;
            this.Label11.Text = "Face:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(505, 334);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(52, 13);
            this.Label10.TabIndex = 271;
            this.Label10.Text = "Discount:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(721, 311);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(29, 13);
            this.Label13.TabIndex = 270;
            this.Label13.Text = "End:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(597, 311);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(32, 13);
            this.Label14.TabIndex = 269;
            this.Label14.Text = "Start:";
            // 
            // dtPenlEnd
            // 
            this.dtPenlEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPenlEnd.Location = new System.Drawing.Point(681, 383);
            this.dtPenlEnd.Name = "dtPenlEnd";
            this.dtPenlEnd.Size = new System.Drawing.Size(112, 20);
            this.dtPenlEnd.TabIndex = 268;
            // 
            // dtPenlStart
            // 
            this.dtPenlStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPenlStart.Location = new System.Drawing.Point(562, 383);
            this.dtPenlStart.Name = "dtPenlStart";
            this.dtPenlStart.Size = new System.Drawing.Size(112, 20);
            this.dtPenlStart.TabIndex = 267;
            // 
            // dtFaceEnd
            // 
            this.dtFaceEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFaceEnd.Location = new System.Drawing.Point(681, 357);
            this.dtFaceEnd.Name = "dtFaceEnd";
            this.dtFaceEnd.Size = new System.Drawing.Size(112, 20);
            this.dtFaceEnd.TabIndex = 266;
            this.dtFaceEnd.ValueChanged += new System.EventHandler(this.dtFaceEnd_ValueChanged);
            // 
            // dtFaceStart
            // 
            this.dtFaceStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFaceStart.Location = new System.Drawing.Point(562, 357);
            this.dtFaceStart.Name = "dtFaceStart";
            this.dtFaceStart.Size = new System.Drawing.Size(112, 20);
            this.dtFaceStart.TabIndex = 265;
            this.dtFaceStart.ValueChanged += new System.EventHandler(this.dtFaceStart_ValueChanged);
            // 
            // dtDiscEnd
            // 
            this.dtDiscEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiscEnd.Location = new System.Drawing.Point(681, 331);
            this.dtDiscEnd.Name = "dtDiscEnd";
            this.dtDiscEnd.Size = new System.Drawing.Size(112, 20);
            this.dtDiscEnd.TabIndex = 264;
            this.dtDiscEnd.ValueChanged += new System.EventHandler(this.dtDiscEnd_ValueChanged);
            // 
            // dtDiscStart
            // 
            this.dtDiscStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiscStart.Location = new System.Drawing.Point(562, 331);
            this.dtDiscStart.Name = "dtDiscStart";
            this.dtDiscStart.Size = new System.Drawing.Size(112, 20);
            this.dtDiscStart.TabIndex = 263;
            this.dtDiscStart.ValueChanged += new System.EventHandler(this.dtDiscStart_ValueChanged);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(472, 288);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(84, 13);
            this.Label15.TabIndex = 262;
            this.Label15.Text = "Fiscal Sub Year:";
            // 
            // txtFiscalSubYear
            // 
            this.txtFiscalSubYear.Location = new System.Drawing.Point(562, 285);
            this.txtFiscalSubYear.Name = "txtFiscalSubYear";
            this.txtFiscalSubYear.Size = new System.Drawing.Size(181, 20);
            this.txtFiscalSubYear.TabIndex = 261;
            // 
            // txtFiscalYear
            // 
            this.txtFiscalYear.Location = new System.Drawing.Point(562, 262);
            this.txtFiscalYear.Name = "txtFiscalYear";
            this.txtFiscalYear.Size = new System.Drawing.Size(100, 20);
            this.txtFiscalYear.TabIndex = 260;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(495, 265);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(62, 13);
            this.Label16.TabIndex = 259;
            this.Label16.Text = "Fiscal Year:";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(514, 243);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(42, 13);
            this.Label9.TabIndex = 257;
            this.Label9.Text = "District:";
            // 
            // txtSchoolRate
            // 
            this.txtSchoolRate.Location = new System.Drawing.Point(339, 261);
            this.txtSchoolRate.Name = "txtSchoolRate";
            this.txtSchoolRate.Size = new System.Drawing.Size(100, 20);
            this.txtSchoolRate.TabIndex = 256;
            // 
            // txtSchoolID
            // 
            this.txtSchoolID.Location = new System.Drawing.Point(234, 261);
            this.txtSchoolID.Name = "txtSchoolID";
            this.txtSchoolID.Size = new System.Drawing.Size(100, 20);
            this.txtSchoolID.TabIndex = 255;
            this.txtSchoolID.Text = "3";
            // 
            // chkSchool
            // 
            this.chkSchool.AutoSize = true;
            this.chkSchool.Checked = true;
            this.chkSchool.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSchool.Location = new System.Drawing.Point(153, 262);
            this.chkSchool.Name = "chkSchool";
            this.chkSchool.Size = new System.Drawing.Size(59, 17);
            this.chkSchool.TabIndex = 254;
            this.chkSchool.Text = "School";
            this.chkSchool.UseVisualStyleBackColor = true;
            // 
            // dgFileImport
            // 
            this.dgFileImport.AllowUserToAddRows = false;
            this.dgFileImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileImport.Location = new System.Drawing.Point(10, 38);
            this.dgFileImport.Name = "dgFileImport";
            this.dgFileImport.Size = new System.Drawing.Size(520, 150);
            this.dgFileImport.TabIndex = 253;
            // 
            // btnLoadDatagrid
            // 
            this.btnLoadDatagrid.Location = new System.Drawing.Point(492, 194);
            this.btnLoadDatagrid.Name = "btnLoadDatagrid";
            this.btnLoadDatagrid.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDatagrid.TabIndex = 252;
            this.btnLoadDatagrid.Text = "Load";
            this.btnLoadDatagrid.UseVisualStyleBackColor = true;
            this.btnLoadDatagrid.Click += new System.EventHandler(this.btnLoadDatagrid_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(454, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 251;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(66, 11);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(350, 20);
            this.txtFileName.TabIndex = 250;
            this.txtFileName.Text = "C:\\TaxTracker\\Imports\\Franklin\\Normal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(8, 14);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 249;
            this.Label1.Text = "Filename:";
            // 
            // cboDistrict
            // 
            this.cboDistrict.FormattingEnabled = true;
            this.cboDistrict.Items.AddRange(new object[] {
            "03-Debbie Gates",
            "25-Husted",
            "27-Brink",
            "29-Lawrenceville",
            "31-Hamme",
            "33-Case",
            "40-Cameron",
            "44-Venago",
            "NE-Northeast Boro",
            "CC-City of Corry",
            "UC-Union City Boro (Uber)"});
            this.cboDistrict.Location = new System.Drawing.Point(562, 237);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Size = new System.Drawing.Size(230, 21);
            this.cboDistrict.TabIndex = 258;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(762, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 286;
            this.label3.Text = "Num Installments:";
            // 
            // txtInstallments
            // 
            this.txtInstallments.Location = new System.Drawing.Point(857, 287);
            this.txtInstallments.Name = "txtInstallments";
            this.txtInstallments.Size = new System.Drawing.Size(34, 20);
            this.txtInstallments.TabIndex = 285;
            this.txtInstallments.Text = "3";
            // 
            // txtLibraryRate
            // 
            this.txtLibraryRate.Location = new System.Drawing.Point(340, 313);
            this.txtLibraryRate.Name = "txtLibraryRate";
            this.txtLibraryRate.Size = new System.Drawing.Size(100, 20);
            this.txtLibraryRate.TabIndex = 289;
            // 
            // txtLibraryID
            // 
            this.txtLibraryID.Location = new System.Drawing.Point(235, 313);
            this.txtLibraryID.Name = "txtLibraryID";
            this.txtLibraryID.Size = new System.Drawing.Size(100, 20);
            this.txtLibraryID.TabIndex = 288;
            this.txtLibraryID.Text = "9";
            // 
            // chkLibrary
            // 
            this.chkLibrary.AutoSize = true;
            this.chkLibrary.Location = new System.Drawing.Point(154, 314);
            this.chkLibrary.Name = "chkLibrary";
            this.chkLibrary.Size = new System.Drawing.Size(57, 17);
            this.chkLibrary.TabIndex = 287;
            this.chkLibrary.Text = "Library";
            this.chkLibrary.UseVisualStyleBackColor = true;
            // 
            // frm_ImportSchool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 492);
            this.Controls.Add(this.txtLibraryRate);
            this.Controls.Add(this.txtLibraryID);
            this.Controls.Add(this.chkLibrary);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInstallments);
            this.Controls.Add(this.dgFileImport2);
            this.Controls.Add(this.btnBrowse2);
            this.Controls.Add(this.txtFileName2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtReductionRate);
            this.Controls.Add(this.txtReductionID);
            this.Controls.Add(this.chkReduction);
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
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtSchoolRate);
            this.Controls.Add(this.txtSchoolID);
            this.Controls.Add(this.chkSchool);
            this.Controls.Add(this.dgFileImport);
            this.Controls.Add(this.btnLoadDatagrid);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cboDistrict);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_ImportSchool";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Import Normal School";
            this.Load += new System.EventHandler(this.frm_ImportSchool_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport2)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgFileImport2;
        internal System.Windows.Forms.Button btnBrowse2;
        internal System.Windows.Forms.TextBox txtFileName2;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        internal System.Windows.Forms.TextBox txtReductionRate;
        internal System.Windows.Forms.TextBox txtReductionID;
        internal System.Windows.Forms.CheckBox chkReduction;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pbarProgress;
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
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.TextBox txtSchoolRate;
        internal System.Windows.Forms.TextBox txtSchoolID;
        internal System.Windows.Forms.CheckBox chkSchool;
        internal System.Windows.Forms.DataGridView dgFileImport;
        internal System.Windows.Forms.Button btnLoadDatagrid;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtFileName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cboDistrict;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.TextBox txtInstallments;
        internal System.Windows.Forms.TextBox txtLibraryRate;
        internal System.Windows.Forms.TextBox txtLibraryID;
        internal System.Windows.Forms.CheckBox chkLibrary;
    }
}