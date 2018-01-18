namespace Vendor.Imports
{
    partial class frm_Shippensburg
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
            this.btnLoadDatagrid = new System.Windows.Forms.Button();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgFileImport = new System.Windows.Forms.DataGridView();
            this.txtMuniID = new System.Windows.Forms.TextBox();
            this.txtCountyLibID = new System.Windows.Forms.TextBox();
            this.txtCountyID = new System.Windows.Forms.TextBox();
            this.chkMunicipal = new System.Windows.Forms.CheckBox();
            this.chkCountyLibrary = new System.Windows.Forms.CheckBox();
            this.chkCounty = new System.Windows.Forms.CheckBox();
            this.txtSchoolID = new System.Windows.Forms.TextBox();
            this.txtSpec2ID = new System.Windows.Forms.TextBox();
            this.txtSpec1ID = new System.Windows.Forms.TextBox();
            this.chkSchool = new System.Windows.Forms.CheckBox();
            this.chkSpecial2 = new System.Windows.Forms.CheckBox();
            this.chkSpecial1 = new System.Windows.Forms.CheckBox();
            this.txtSchoolMills = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.cboSchoolDistrict = new System.Windows.Forms.ComboBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtFiscalSubYear = new System.Windows.Forms.TextBox();
            this.txtFiscalYear = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
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
            this.btnImport = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtInstallment3 = new System.Windows.Forms.DateTimePicker();
            this.dtInstallment2 = new System.Windows.Forms.DateTimePicker();
            this.dtInstallment1 = new System.Windows.Forms.DateTimePicker();
            this.chkPCCountyMuni = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.chkPCSchool = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoadDatagrid
            // 
            this.btnLoadDatagrid.Location = new System.Drawing.Point(836, 25);
            this.btnLoadDatagrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadDatagrid.Name = "btnLoadDatagrid";
            this.btnLoadDatagrid.Size = new System.Drawing.Size(100, 28);
            this.btnLoadDatagrid.TabIndex = 55;
            this.btnLoadDatagrid.Text = "Load";
            this.btnLoadDatagrid.UseVisualStyleBackColor = true;
            this.btnLoadDatagrid.Click += new System.EventHandler(this.btnLoadDatagrid_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(728, 25);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 54;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(101, 27);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(617, 22);
            this.txtFileName.TabIndex = 53;
            this.txtFileName.Text = "C:\\TaxTracker\\Imports\\Franklin\\Normal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(24, 31);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 17);
            this.Label1.TabIndex = 52;
            this.Label1.Text = "Filename:";
            // 
            // dgFileImport
            // 
            this.dgFileImport.AllowUserToAddRows = false;
            this.dgFileImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileImport.Location = new System.Drawing.Point(27, 61);
            this.dgFileImport.Margin = new System.Windows.Forms.Padding(4);
            this.dgFileImport.Name = "dgFileImport";
            this.dgFileImport.Size = new System.Drawing.Size(1232, 185);
            this.dgFileImport.TabIndex = 116;
            // 
            // txtMuniID
            // 
            this.txtMuniID.Location = new System.Drawing.Point(176, 361);
            this.txtMuniID.Margin = new System.Windows.Forms.Padding(4);
            this.txtMuniID.Name = "txtMuniID";
            this.txtMuniID.Size = new System.Drawing.Size(132, 22);
            this.txtMuniID.TabIndex = 133;
            this.txtMuniID.Text = "20";
            // 
            // txtCountyLibID
            // 
            this.txtCountyLibID.Location = new System.Drawing.Point(176, 332);
            this.txtCountyLibID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountyLibID.Name = "txtCountyLibID";
            this.txtCountyLibID.Size = new System.Drawing.Size(132, 22);
            this.txtCountyLibID.TabIndex = 132;
            this.txtCountyLibID.Text = "60";
            // 
            // txtCountyID
            // 
            this.txtCountyID.Location = new System.Drawing.Point(176, 303);
            this.txtCountyID.Margin = new System.Windows.Forms.Padding(4);
            this.txtCountyID.Name = "txtCountyID";
            this.txtCountyID.Size = new System.Drawing.Size(132, 22);
            this.txtCountyID.TabIndex = 131;
            this.txtCountyID.Text = "10";
            // 
            // chkMunicipal
            // 
            this.chkMunicipal.AutoSize = true;
            this.chkMunicipal.Location = new System.Drawing.Point(71, 363);
            this.chkMunicipal.Margin = new System.Windows.Forms.Padding(4);
            this.chkMunicipal.Name = "chkMunicipal";
            this.chkMunicipal.Size = new System.Drawing.Size(97, 21);
            this.chkMunicipal.TabIndex = 130;
            this.chkMunicipal.Text = "Municipal?";
            this.chkMunicipal.UseVisualStyleBackColor = true;
            // 
            // chkCountyLibrary
            // 
            this.chkCountyLibrary.AutoSize = true;
            this.chkCountyLibrary.Checked = true;
            this.chkCountyLibrary.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCountyLibrary.Location = new System.Drawing.Point(38, 334);
            this.chkCountyLibrary.Margin = new System.Windows.Forms.Padding(4);
            this.chkCountyLibrary.Name = "chkCountyLibrary";
            this.chkCountyLibrary.Size = new System.Drawing.Size(130, 21);
            this.chkCountyLibrary.TabIndex = 129;
            this.chkCountyLibrary.Text = "County Library?";
            this.chkCountyLibrary.UseVisualStyleBackColor = true;
            // 
            // chkCounty
            // 
            this.chkCounty.AutoSize = true;
            this.chkCounty.Checked = true;
            this.chkCounty.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkCounty.Location = new System.Drawing.Point(86, 305);
            this.chkCounty.Margin = new System.Windows.Forms.Padding(4);
            this.chkCounty.Name = "chkCounty";
            this.chkCounty.Size = new System.Drawing.Size(82, 21);
            this.chkCounty.TabIndex = 128;
            this.chkCounty.Text = "County?";
            this.chkCounty.UseVisualStyleBackColor = true;
            // 
            // txtSchoolID
            // 
            this.txtSchoolID.Location = new System.Drawing.Point(176, 449);
            this.txtSchoolID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSchoolID.Name = "txtSchoolID";
            this.txtSchoolID.Size = new System.Drawing.Size(132, 22);
            this.txtSchoolID.TabIndex = 139;
            this.txtSchoolID.Text = "30";
            // 
            // txtSpec2ID
            // 
            this.txtSpec2ID.Location = new System.Drawing.Point(176, 420);
            this.txtSpec2ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpec2ID.Name = "txtSpec2ID";
            this.txtSpec2ID.Size = new System.Drawing.Size(132, 22);
            this.txtSpec2ID.TabIndex = 138;
            // 
            // txtSpec1ID
            // 
            this.txtSpec1ID.Location = new System.Drawing.Point(176, 391);
            this.txtSpec1ID.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpec1ID.Name = "txtSpec1ID";
            this.txtSpec1ID.Size = new System.Drawing.Size(132, 22);
            this.txtSpec1ID.TabIndex = 137;
            // 
            // chkSchool
            // 
            this.chkSchool.AutoSize = true;
            this.chkSchool.Location = new System.Drawing.Point(72, 451);
            this.chkSchool.Margin = new System.Windows.Forms.Padding(4);
            this.chkSchool.Name = "chkSchool";
            this.chkSchool.Size = new System.Drawing.Size(81, 21);
            this.chkSchool.TabIndex = 136;
            this.chkSchool.Text = "School?";
            this.chkSchool.UseVisualStyleBackColor = true;
            // 
            // chkSpecial2
            // 
            this.chkSpecial2.AutoSize = true;
            this.chkSpecial2.Location = new System.Drawing.Point(72, 421);
            this.chkSpecial2.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpecial2.Name = "chkSpecial2";
            this.chkSpecial2.Size = new System.Drawing.Size(96, 21);
            this.chkSpecial2.TabIndex = 135;
            this.chkSpecial2.Text = "Special 2?";
            this.chkSpecial2.UseVisualStyleBackColor = true;
            // 
            // chkSpecial1
            // 
            this.chkSpecial1.AutoSize = true;
            this.chkSpecial1.Location = new System.Drawing.Point(72, 393);
            this.chkSpecial1.Margin = new System.Windows.Forms.Padding(4);
            this.chkSpecial1.Name = "chkSpecial1";
            this.chkSpecial1.Size = new System.Drawing.Size(96, 21);
            this.chkSpecial1.TabIndex = 134;
            this.chkSpecial1.Text = "Special 1?";
            this.chkSpecial1.UseVisualStyleBackColor = true;
            // 
            // txtSchoolMills
            // 
            this.txtSchoolMills.Location = new System.Drawing.Point(316, 449);
            this.txtSchoolMills.Margin = new System.Windows.Forms.Padding(4);
            this.txtSchoolMills.Name = "txtSchoolMills";
            this.txtSchoolMills.Size = new System.Drawing.Size(132, 22);
            this.txtSchoolMills.TabIndex = 145;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(316, 420);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 22);
            this.textBox2.TabIndex = 144;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(316, 391);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(132, 22);
            this.textBox3.TabIndex = 143;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(316, 361);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 22);
            this.textBox4.TabIndex = 142;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(316, 332);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 22);
            this.textBox5.TabIndex = 141;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(316, 303);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 22);
            this.textBox6.TabIndex = 140;
            // 
            // cboSchoolDistrict
            // 
            this.cboSchoolDistrict.FormattingEnabled = true;
            this.cboSchoolDistrict.Items.AddRange(new object[] {
            "Shippensburg Area School District"});
            this.cboSchoolDistrict.Location = new System.Drawing.Point(631, 275);
            this.cboSchoolDistrict.Margin = new System.Windows.Forms.Padding(4);
            this.cboSchoolDistrict.Name = "cboSchoolDistrict";
            this.cboSchoolDistrict.Size = new System.Drawing.Size(305, 24);
            this.cboSchoolDistrict.TabIndex = 147;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Location = new System.Drawing.Point(519, 279);
            this.Label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(102, 17);
            this.Label9.TabIndex = 146;
            this.Label9.Text = "School District:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(511, 337);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(111, 17);
            this.Label15.TabIndex = 151;
            this.Label15.Text = "Fiscal Sub Year:";
            // 
            // txtFiscalSubYear
            // 
            this.txtFiscalSubYear.Location = new System.Drawing.Point(631, 333);
            this.txtFiscalSubYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiscalSubYear.Name = "txtFiscalSubYear";
            this.txtFiscalSubYear.Size = new System.Drawing.Size(240, 22);
            this.txtFiscalSubYear.TabIndex = 150;
            this.txtFiscalSubYear.Text = "Normal-";
            // 
            // txtFiscalYear
            // 
            this.txtFiscalYear.Location = new System.Drawing.Point(631, 304);
            this.txtFiscalYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiscalYear.Name = "txtFiscalYear";
            this.txtFiscalYear.Size = new System.Drawing.Size(132, 22);
            this.txtFiscalYear.TabIndex = 149;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(541, 308);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(82, 17);
            this.Label16.TabIndex = 148;
            this.Label16.Text = "Fiscal Year:";
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Location = new System.Drawing.Point(563, 457);
            this.Label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(59, 17);
            this.Label12.TabIndex = 162;
            this.Label12.Text = "Penalty:";
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Location = new System.Drawing.Point(578, 425);
            this.Label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(43, 17);
            this.Label11.TabIndex = 161;
            this.Label11.Text = "Face:";
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Location = new System.Drawing.Point(554, 393);
            this.Label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(67, 17);
            this.Label10.TabIndex = 160;
            this.Label10.Text = "Discount:";
            // 
            // Label13
            // 
            this.Label13.AutoSize = true;
            this.Label13.Location = new System.Drawing.Point(843, 366);
            this.Label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(37, 17);
            this.Label13.TabIndex = 159;
            this.Label13.Text = "End:";
            // 
            // Label14
            // 
            this.Label14.AutoSize = true;
            this.Label14.Location = new System.Drawing.Point(678, 365);
            this.Label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label14.Name = "Label14";
            this.Label14.Size = new System.Drawing.Size(42, 17);
            this.Label14.TabIndex = 158;
            this.Label14.Text = "Start:";
            // 
            // dtPenlEnd
            // 
            this.dtPenlEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPenlEnd.Location = new System.Drawing.Point(789, 453);
            this.dtPenlEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtPenlEnd.Name = "dtPenlEnd";
            this.dtPenlEnd.Size = new System.Drawing.Size(148, 22);
            this.dtPenlEnd.TabIndex = 157;
            // 
            // dtPenlStart
            // 
            this.dtPenlStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPenlStart.Location = new System.Drawing.Point(631, 453);
            this.dtPenlStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtPenlStart.Name = "dtPenlStart";
            this.dtPenlStart.Size = new System.Drawing.Size(148, 22);
            this.dtPenlStart.TabIndex = 156;
            this.dtPenlStart.ValueChanged += new System.EventHandler(this.dtPenlStart_ValueChanged);
            // 
            // dtFaceEnd
            // 
            this.dtFaceEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFaceEnd.Location = new System.Drawing.Point(789, 421);
            this.dtFaceEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtFaceEnd.Name = "dtFaceEnd";
            this.dtFaceEnd.Size = new System.Drawing.Size(148, 22);
            this.dtFaceEnd.TabIndex = 155;
            this.dtFaceEnd.ValueChanged += new System.EventHandler(this.dtFaceEnd_ValueChanged);
            // 
            // dtFaceStart
            // 
            this.dtFaceStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtFaceStart.Location = new System.Drawing.Point(631, 421);
            this.dtFaceStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtFaceStart.Name = "dtFaceStart";
            this.dtFaceStart.Size = new System.Drawing.Size(148, 22);
            this.dtFaceStart.TabIndex = 154;
            this.dtFaceStart.ValueChanged += new System.EventHandler(this.dtFaceStart_ValueChanged);
            // 
            // dtDiscEnd
            // 
            this.dtDiscEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiscEnd.Location = new System.Drawing.Point(789, 389);
            this.dtDiscEnd.Margin = new System.Windows.Forms.Padding(4);
            this.dtDiscEnd.Name = "dtDiscEnd";
            this.dtDiscEnd.Size = new System.Drawing.Size(148, 22);
            this.dtDiscEnd.TabIndex = 153;
            this.dtDiscEnd.ValueChanged += new System.EventHandler(this.dtDiscEnd_ValueChanged);
            // 
            // dtDiscStart
            // 
            this.dtDiscStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDiscStart.Location = new System.Drawing.Point(631, 389);
            this.dtDiscStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtDiscStart.Name = "dtDiscStart";
            this.dtDiscStart.Size = new System.Drawing.Size(148, 22);
            this.dtDiscStart.TabIndex = 152;
            this.dtDiscStart.ValueChanged += new System.EventHandler(this.dtDiscStart_ValueChanged);
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(1159, 275);
            this.btnImport.Margin = new System.Windows.Forms.Padding(4);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(100, 28);
            this.btnImport.TabIndex = 163;
            this.btnImport.Text = "Import";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pbarProgress,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 553);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1309, 25);
            this.statusStrip1.TabIndex = 164;
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
            this.label2.Location = new System.Drawing.Point(1013, 457);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 171;
            this.label2.Text = "3:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1013, 423);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 170;
            this.label3.Text = "2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1013, 392);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 169;
            this.label4.Text = "1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1038, 365);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 168;
            this.label5.Text = "Installment Due";
            // 
            // dtInstallment3
            // 
            this.dtInstallment3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInstallment3.Location = new System.Drawing.Point(1041, 452);
            this.dtInstallment3.Margin = new System.Windows.Forms.Padding(4);
            this.dtInstallment3.Name = "dtInstallment3";
            this.dtInstallment3.Size = new System.Drawing.Size(148, 22);
            this.dtInstallment3.TabIndex = 167;
            // 
            // dtInstallment2
            // 
            this.dtInstallment2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInstallment2.Location = new System.Drawing.Point(1041, 420);
            this.dtInstallment2.Margin = new System.Windows.Forms.Padding(4);
            this.dtInstallment2.Name = "dtInstallment2";
            this.dtInstallment2.Size = new System.Drawing.Size(148, 22);
            this.dtInstallment2.TabIndex = 166;
            // 
            // dtInstallment1
            // 
            this.dtInstallment1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtInstallment1.Location = new System.Drawing.Point(1041, 388);
            this.dtInstallment1.Margin = new System.Windows.Forms.Padding(4);
            this.dtInstallment1.Name = "dtInstallment1";
            this.dtInstallment1.Size = new System.Drawing.Size(148, 22);
            this.dtInstallment1.TabIndex = 165;
            // 
            // chkPCCountyMuni
            // 
            this.chkPCCountyMuni.AutoSize = true;
            this.chkPCCountyMuni.Location = new System.Drawing.Point(72, 485);
            this.chkPCCountyMuni.Margin = new System.Windows.Forms.Padding(4);
            this.chkPCCountyMuni.Name = "chkPCCountyMuni";
            this.chkPCCountyMuni.Size = new System.Drawing.Size(233, 21);
            this.chkPCCountyMuni.TabIndex = 172;
            this.chkPCCountyMuni.Text = "Per Capita? (County / Municipal)";
            this.chkPCCountyMuni.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 17);
            this.label6.TabIndex = 173;
            this.label6.Text = "Tax Type ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(313, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 174;
            this.label7.Text = "Millage Rate";
            // 
            // chkPCSchool
            // 
            this.chkPCSchool.AutoSize = true;
            this.chkPCSchool.Location = new System.Drawing.Point(72, 513);
            this.chkPCSchool.Name = "chkPCSchool";
            this.chkPCSchool.Size = new System.Drawing.Size(161, 21);
            this.chkPCSchool.TabIndex = 175;
            this.chkPCSchool.Text = "Per Capita? (School)";
            this.chkPCSchool.UseVisualStyleBackColor = true;
            // 
            // frm_Shippensburg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 578);
            this.Controls.Add(this.chkPCSchool);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.chkPCCountyMuni);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtInstallment3);
            this.Controls.Add(this.dtInstallment2);
            this.Controls.Add(this.dtInstallment1);
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
            this.Controls.Add(this.cboSchoolDistrict);
            this.Controls.Add(this.Label9);
            this.Controls.Add(this.txtSchoolMills);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtSchoolID);
            this.Controls.Add(this.txtSpec2ID);
            this.Controls.Add(this.txtSpec1ID);
            this.Controls.Add(this.chkSchool);
            this.Controls.Add(this.chkSpecial2);
            this.Controls.Add(this.chkSpecial1);
            this.Controls.Add(this.txtMuniID);
            this.Controls.Add(this.txtCountyLibID);
            this.Controls.Add(this.txtCountyID);
            this.Controls.Add(this.chkMunicipal);
            this.Controls.Add(this.chkCountyLibrary);
            this.Controls.Add(this.chkCounty);
            this.Controls.Add(this.dgFileImport);
            this.Controls.Add(this.btnLoadDatagrid);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.Label1);
            this.Name = "frm_Shippensburg";
            this.Text = "Shippensburg Data Load";
            this.Load += new System.EventHandler(this.frm_Shippensburg_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnLoadDatagrid;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtFileName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgFileImport;
        internal System.Windows.Forms.TextBox txtMuniID;
        internal System.Windows.Forms.TextBox txtCountyLibID;
        internal System.Windows.Forms.TextBox txtCountyID;
        internal System.Windows.Forms.CheckBox chkMunicipal;
        internal System.Windows.Forms.CheckBox chkCountyLibrary;
        internal System.Windows.Forms.CheckBox chkCounty;
        internal System.Windows.Forms.TextBox txtSchoolID;
        internal System.Windows.Forms.TextBox txtSpec2ID;
        internal System.Windows.Forms.TextBox txtSpec1ID;
        internal System.Windows.Forms.CheckBox chkSchool;
        internal System.Windows.Forms.CheckBox chkSpecial2;
        internal System.Windows.Forms.CheckBox chkSpecial1;
        internal System.Windows.Forms.TextBox txtSchoolMills;
        internal System.Windows.Forms.TextBox textBox2;
        internal System.Windows.Forms.TextBox textBox3;
        internal System.Windows.Forms.TextBox textBox4;
        internal System.Windows.Forms.TextBox textBox5;
        internal System.Windows.Forms.TextBox textBox6;
        internal System.Windows.Forms.ComboBox cboSchoolDistrict;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtFiscalSubYear;
        internal System.Windows.Forms.TextBox txtFiscalYear;
        internal System.Windows.Forms.Label Label16;
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
        internal System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pbarProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label5;
        internal System.Windows.Forms.DateTimePicker dtInstallment3;
        internal System.Windows.Forms.DateTimePicker dtInstallment2;
        internal System.Windows.Forms.DateTimePicker dtInstallment1;
        internal System.Windows.Forms.CheckBox chkPCCountyMuni;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkPCSchool;
    }
}