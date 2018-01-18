namespace Vendor.Imports.ErieCounty
{
    partial class frm_ImportInterims
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
            this.txtMuniRate = new System.Windows.Forms.TextBox();
            this.txtMuniID = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtSchoolRate = new System.Windows.Forms.TextBox();
            this.txtSchoolID = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(235, 219);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 203;
            this.label7.Text = "Millage Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(130, 219);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 202;
            this.label6.Text = "Tax Type ID";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pbarProgress,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 410);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(969, 22);
            this.statusStrip1.TabIndex = 201;
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
            this.btnImport.Location = new System.Drawing.Point(869, 213);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(75, 23);
            this.btnImport.TabIndex = 200;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(422, 361);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(45, 13);
            this.Label12.TabIndex = 199;
            this.Label12.Text = "Penalty:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(434, 335);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(34, 13);
            this.Label11.TabIndex = 198;
            this.Label11.Text = "Face:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(416, 309);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(52, 13);
            this.Label10.TabIndex = 197;
            this.Label10.Text = "Discount:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(632, 287);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(29, 13);
            this.Label13.TabIndex = 196;
            this.Label13.Text = "End:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(508, 287);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(32, 13);
            this.Label14.TabIndex = 195;
            this.Label14.Text = "Start:";
            // 
            // dtPenlEnd
            // 
            this.dtPenlEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPenlEnd.Location = new System.Drawing.Point(592, 358);
            this.dtPenlEnd.Name = "dtPenlEnd";
            this.dtPenlEnd.Size = new System.Drawing.Size(112, 20);
            this.dtPenlEnd.TabIndex = 194;
            this.dtPenlEnd.ValueChanged += new System.EventHandler(this.dtPenlEnd_ValueChanged);
            // 
            // dtPenlStart
            // 
            this.dtPenlStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPenlStart.Location = new System.Drawing.Point(473, 358);
            this.dtPenlStart.Name = "dtPenlStart";
            this.dtPenlStart.Size = new System.Drawing.Size(112, 20);
            this.dtPenlStart.TabIndex = 193;
            this.dtPenlStart.ValueChanged += new System.EventHandler(this.dtPenlStart_ValueChanged);
            // 
            // dtFaceEnd
            // 
            this.dtFaceEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFaceEnd.Location = new System.Drawing.Point(592, 332);
            this.dtFaceEnd.Name = "dtFaceEnd";
            this.dtFaceEnd.Size = new System.Drawing.Size(112, 20);
            this.dtFaceEnd.TabIndex = 192;
            this.dtFaceEnd.ValueChanged += new System.EventHandler(this.dtFaceEnd_ValueChanged);
            // 
            // dtFaceStart
            // 
            this.dtFaceStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFaceStart.Location = new System.Drawing.Point(473, 332);
            this.dtFaceStart.Name = "dtFaceStart";
            this.dtFaceStart.Size = new System.Drawing.Size(112, 20);
            this.dtFaceStart.TabIndex = 191;
            this.dtFaceStart.ValueChanged += new System.EventHandler(this.dtFaceStart_ValueChanged);
            // 
            // dtDiscEnd
            // 
            this.dtDiscEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiscEnd.Location = new System.Drawing.Point(592, 306);
            this.dtDiscEnd.Name = "dtDiscEnd";
            this.dtDiscEnd.Size = new System.Drawing.Size(112, 20);
            this.dtDiscEnd.TabIndex = 190;
            this.dtDiscEnd.ValueChanged += new System.EventHandler(this.dtDiscEnd_ValueChanged);
            // 
            // dtDiscStart
            // 
            this.dtDiscStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiscStart.Location = new System.Drawing.Point(473, 306);
            this.dtDiscStart.Name = "dtDiscStart";
            this.dtDiscStart.Size = new System.Drawing.Size(112, 20);
            this.dtDiscStart.TabIndex = 189;
            this.dtDiscStart.ValueChanged += new System.EventHandler(this.dtDiscStart_ValueChanged);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(383, 264);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(84, 13);
            this.Label15.TabIndex = 188;
            this.Label15.Text = "Fiscal Sub Year:";
            // 
            // txtFiscalSubYear
            // 
            this.txtFiscalSubYear.Location = new System.Drawing.Point(473, 261);
            this.txtFiscalSubYear.Name = "txtFiscalSubYear";
            this.txtFiscalSubYear.Size = new System.Drawing.Size(181, 20);
            this.txtFiscalSubYear.TabIndex = 187;
            // 
            // txtFiscalYear
            // 
            this.txtFiscalYear.Location = new System.Drawing.Point(473, 237);
            this.txtFiscalYear.Name = "txtFiscalYear";
            this.txtFiscalYear.Size = new System.Drawing.Size(100, 20);
            this.txtFiscalYear.TabIndex = 186;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(406, 240);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(62, 13);
            this.Label16.TabIndex = 185;
            this.Label16.Text = "Fiscal Year:";
            // 
            // cboDistrict
            // 
            this.cboDistrict.FormattingEnabled = true;
            this.cboDistrict.Items.AddRange(new object[] {
            "03-Gates",
            "25-Husted",
            "27-Brink",
            "31-Hamme",
            "33-Case",
            "40-Cameron",
            "44-Venago",
            "CC-City Of Corry",
            "UC-Union City Boro (Uber)"});
            this.cboDistrict.Location = new System.Drawing.Point(473, 213);
            this.cboDistrict.Name = "cboDistrict";
            this.cboDistrict.Size = new System.Drawing.Size(230, 21);
            this.cboDistrict.TabIndex = 184;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(425, 218);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(42, 13);
            this.Label9.TabIndex = 183;
            this.Label9.Text = "District:";
            // 
            // txtCountyRate
            // 
            this.txtCountyRate.Location = new System.Drawing.Point(237, 236);
            this.txtCountyRate.Name = "txtCountyRate";
            this.txtCountyRate.Size = new System.Drawing.Size(100, 20);
            this.txtCountyRate.TabIndex = 182;
            // 
            // txtCountyID
            // 
            this.txtCountyID.Location = new System.Drawing.Point(132, 236);
            this.txtCountyID.Name = "txtCountyID";
            this.txtCountyID.Size = new System.Drawing.Size(100, 20);
            this.txtCountyID.TabIndex = 181;
            this.txtCountyID.Text = "1";
            // 
            // chkCounty
            // 
            this.chkCounty.AutoSize = true;
            this.chkCounty.Checked = true;
            this.chkCounty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCounty.Location = new System.Drawing.Point(64, 238);
            this.chkCounty.Name = "chkCounty";
            this.chkCounty.Size = new System.Drawing.Size(59, 17);
            this.chkCounty.TabIndex = 180;
            this.chkCounty.Text = "County";
            this.chkCounty.UseVisualStyleBackColor = true;
            // 
            // dgFileImport
            // 
            this.dgFileImport.AllowUserToAddRows = false;
            this.dgFileImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileImport.Location = new System.Drawing.Point(20, 40);
            this.dgFileImport.Name = "dgFileImport";
            this.dgFileImport.Size = new System.Drawing.Size(924, 150);
            this.dgFileImport.TabIndex = 179;
            // 
            // btnLoadDatagrid
            // 
            this.btnLoadDatagrid.Location = new System.Drawing.Point(627, 10);
            this.btnLoadDatagrid.Name = "btnLoadDatagrid";
            this.btnLoadDatagrid.Size = new System.Drawing.Size(75, 23);
            this.btnLoadDatagrid.TabIndex = 178;
            this.btnLoadDatagrid.Text = "Load";
            this.btnLoadDatagrid.UseVisualStyleBackColor = true;
            this.btnLoadDatagrid.Click += new System.EventHandler(this.btnLoadDatagrid_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(546, 10);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 23);
            this.btnBrowse.TabIndex = 177;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(76, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(464, 20);
            this.txtFileName.TabIndex = 176;
            this.txtFileName.Text = "C:\\TaxTracker\\Imports\\Franklin\\Normal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(18, 15);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(52, 13);
            this.Label1.TabIndex = 175;
            this.Label1.Text = "Filename:";
            // 
            // txtMuniRate
            // 
            this.txtMuniRate.Location = new System.Drawing.Point(238, 262);
            this.txtMuniRate.Name = "txtMuniRate";
            this.txtMuniRate.Size = new System.Drawing.Size(100, 20);
            this.txtMuniRate.TabIndex = 206;
            // 
            // txtMuniID
            // 
            this.txtMuniID.Location = new System.Drawing.Point(133, 262);
            this.txtMuniID.Name = "txtMuniID";
            this.txtMuniID.Size = new System.Drawing.Size(100, 20);
            this.txtMuniID.TabIndex = 205;
            this.txtMuniID.Text = "2";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(65, 264);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(49, 17);
            this.checkBox1.TabIndex = 204;
            this.checkBox1.Text = "Muni";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtSchoolRate
            // 
            this.txtSchoolRate.Location = new System.Drawing.Point(238, 288);
            this.txtSchoolRate.Name = "txtSchoolRate";
            this.txtSchoolRate.Size = new System.Drawing.Size(100, 20);
            this.txtSchoolRate.TabIndex = 209;
            // 
            // txtSchoolID
            // 
            this.txtSchoolID.Location = new System.Drawing.Point(133, 288);
            this.txtSchoolID.Name = "txtSchoolID";
            this.txtSchoolID.Size = new System.Drawing.Size(100, 20);
            this.txtSchoolID.TabIndex = 208;
            this.txtSchoolID.Text = "3";
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(65, 290);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(59, 17);
            this.checkBox2.TabIndex = 207;
            this.checkBox2.Text = "School";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // frm_ImportInterims
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 432);
            this.Controls.Add(this.txtSchoolRate);
            this.Controls.Add(this.txtSchoolID);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.txtMuniRate);
            this.Controls.Add(this.txtMuniID);
            this.Controls.Add(this.checkBox1);
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
            this.Name = "frm_ImportInterims";
            this.Text = "Import Erie Interims";
            this.Load += new System.EventHandler(this.frm_ImportInterims_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        internal System.Windows.Forms.TextBox txtMuniRate;
        internal System.Windows.Forms.TextBox txtMuniID;
        internal System.Windows.Forms.CheckBox checkBox1;
        internal System.Windows.Forms.TextBox txtSchoolRate;
        internal System.Windows.Forms.TextBox txtSchoolID;
        internal System.Windows.Forms.CheckBox checkBox2;
    }
}