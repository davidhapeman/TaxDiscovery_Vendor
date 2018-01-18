namespace Vendor.CorrectionForms
{
    partial class frm_EriePrinterRounding
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
            this.dgTaxRolls = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtFiscalSubYear = new System.Windows.Forms.TextBox();
            this.txtFiscalYear = new System.Windows.Forms.TextBox();
            this.Label16 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboTaxTypes = new System.Windows.Forms.ComboBox();
            this.btnPerformFix = new System.Windows.Forms.Button();
            this.btnLoadBills = new System.Windows.Forms.Button();
            this.dgLineItems = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnTaxTypes = new System.Windows.Forms.Button();
            this.dgPrinterRecordData = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoadCorrections = new System.Windows.Forms.Button();
            this.dgCorrections = new System.Windows.Forms.DataGridView();
            this.lblNumberRecords = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxRolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrinterRecordData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrections)).BeginInit();
            this.SuspendLayout();
            // 
            // dgFileImport
            // 
            this.dgFileImport.AllowUserToAddRows = false;
            this.dgFileImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgFileImport.Location = new System.Drawing.Point(22, 37);
            this.dgFileImport.Margin = new System.Windows.Forms.Padding(4);
            this.dgFileImport.Name = "dgFileImport";
            this.dgFileImport.Size = new System.Drawing.Size(909, 185);
            this.dgFileImport.TabIndex = 126;
            // 
            // btnLoadDatagrid
            // 
            this.btnLoadDatagrid.Location = new System.Drawing.Point(831, 5);
            this.btnLoadDatagrid.Margin = new System.Windows.Forms.Padding(4);
            this.btnLoadDatagrid.Name = "btnLoadDatagrid";
            this.btnLoadDatagrid.Size = new System.Drawing.Size(100, 28);
            this.btnLoadDatagrid.TabIndex = 125;
            this.btnLoadDatagrid.Text = "Load";
            this.btnLoadDatagrid.UseVisualStyleBackColor = true;
            this.btnLoadDatagrid.Click += new System.EventHandler(this.btnLoadDatagrid_Click);
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(723, 5);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(100, 28);
            this.btnBrowse.TabIndex = 124;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(96, 7);
            this.txtFileName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(617, 22);
            this.txtFileName.TabIndex = 123;
            this.txtFileName.Text = "C:\\TaxTracker\\Imports\\Franklin\\Normal";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(19, 11);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(69, 17);
            this.Label1.TabIndex = 122;
            this.Label1.Text = "Filename:";
            // 
            // dgTaxRolls
            // 
            this.dgTaxRolls.AllowUserToAddRows = false;
            this.dgTaxRolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaxRolls.Location = new System.Drawing.Point(22, 387);
            this.dgTaxRolls.Margin = new System.Windows.Forms.Padding(4);
            this.dgTaxRolls.Name = "dgTaxRolls";
            this.dgTaxRolls.Size = new System.Drawing.Size(334, 185);
            this.dgTaxRolls.TabIndex = 127;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 366);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 17);
            this.label2.TabIndex = 128;
            this.label2.Text = "List of Bill Totals Unpaid";
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
            this.cboDatabase.Location = new System.Drawing.Point(166, 229);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(240, 24);
            this.cboDatabase.TabIndex = 178;
            this.cboDatabase.SelectedIndexChanged += new System.EventHandler(this.cboDatabase_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 177;
            this.label3.Text = "Database:";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Location = new System.Drawing.Point(46, 293);
            this.Label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(111, 17);
            this.Label15.TabIndex = 176;
            this.Label15.Text = "Fiscal Sub Year:";
            // 
            // txtFiscalSubYear
            // 
            this.txtFiscalSubYear.Location = new System.Drawing.Point(166, 289);
            this.txtFiscalSubYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiscalSubYear.Name = "txtFiscalSubYear";
            this.txtFiscalSubYear.Size = new System.Drawing.Size(240, 22);
            this.txtFiscalSubYear.TabIndex = 175;
            this.txtFiscalSubYear.Text = "Normal-";
            // 
            // txtFiscalYear
            // 
            this.txtFiscalYear.Location = new System.Drawing.Point(166, 260);
            this.txtFiscalYear.Margin = new System.Windows.Forms.Padding(4);
            this.txtFiscalYear.Name = "txtFiscalYear";
            this.txtFiscalYear.Size = new System.Drawing.Size(132, 22);
            this.txtFiscalYear.TabIndex = 174;
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Location = new System.Drawing.Point(76, 264);
            this.Label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(82, 17);
            this.Label16.TabIndex = 173;
            this.Label16.Text = "Fiscal Year:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 17);
            this.label4.TabIndex = 180;
            this.label4.Text = "Tax Type To Adjust";
            // 
            // cboTaxTypes
            // 
            this.cboTaxTypes.FormattingEnabled = true;
            this.cboTaxTypes.Location = new System.Drawing.Point(166, 318);
            this.cboTaxTypes.Name = "cboTaxTypes";
            this.cboTaxTypes.Size = new System.Drawing.Size(240, 24);
            this.cboTaxTypes.TabIndex = 181;
            this.cboTaxTypes.SelectedIndexChanged += new System.EventHandler(this.cboTaxTypes_SelectedIndexChanged);
            // 
            // btnPerformFix
            // 
            this.btnPerformFix.Location = new System.Drawing.Point(997, 733);
            this.btnPerformFix.Name = "btnPerformFix";
            this.btnPerformFix.Size = new System.Drawing.Size(75, 23);
            this.btnPerformFix.TabIndex = 182;
            this.btnPerformFix.Text = "Fix";
            this.btnPerformFix.UseVisualStyleBackColor = true;
            this.btnPerformFix.Click += new System.EventHandler(this.btnPerformFix_Click);
            // 
            // btnLoadBills
            // 
            this.btnLoadBills.Location = new System.Drawing.Point(585, 277);
            this.btnLoadBills.Name = "btnLoadBills";
            this.btnLoadBills.Size = new System.Drawing.Size(75, 53);
            this.btnLoadBills.TabIndex = 183;
            this.btnLoadBills.Text = "Load Bill Data";
            this.btnLoadBills.UseVisualStyleBackColor = true;
            this.btnLoadBills.Click += new System.EventHandler(this.btnLoadBills_Click);
            // 
            // dgLineItems
            // 
            this.dgLineItems.AllowUserToAddRows = false;
            this.dgLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineItems.Location = new System.Drawing.Point(364, 387);
            this.dgLineItems.Margin = new System.Windows.Forms.Padding(4);
            this.dgLineItems.Name = "dgLineItems";
            this.dgLineItems.Size = new System.Drawing.Size(349, 185);
            this.dgLineItems.TabIndex = 184;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 17);
            this.label5.TabIndex = 185;
            this.label5.Text = "List of Bill Items";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pbarProgress,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 780);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1159, 25);
            this.statusStrip1.TabIndex = 186;
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
            // btnTaxTypes
            // 
            this.btnTaxTypes.Location = new System.Drawing.Point(413, 277);
            this.btnTaxTypes.Name = "btnTaxTypes";
            this.btnTaxTypes.Size = new System.Drawing.Size(166, 34);
            this.btnTaxTypes.TabIndex = 187;
            this.btnTaxTypes.Text = "Tax Types";
            this.btnTaxTypes.UseVisualStyleBackColor = true;
            this.btnTaxTypes.Click += new System.EventHandler(this.btnTaxTypes_Click);
            // 
            // dgPrinterRecordData
            // 
            this.dgPrinterRecordData.AllowUserToAddRows = false;
            this.dgPrinterRecordData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPrinterRecordData.Location = new System.Drawing.Point(723, 387);
            this.dgPrinterRecordData.Margin = new System.Windows.Forms.Padding(4);
            this.dgPrinterRecordData.Name = "dgPrinterRecordData";
            this.dgPrinterRecordData.Size = new System.Drawing.Size(349, 185);
            this.dgPrinterRecordData.TabIndex = 188;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(720, 366);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 17);
            this.label6.TabIndex = 189;
            this.label6.Text = "List of Bill Items";
            // 
            // btnLoadCorrections
            // 
            this.btnLoadCorrections.Location = new System.Drawing.Point(22, 579);
            this.btnLoadCorrections.Name = "btnLoadCorrections";
            this.btnLoadCorrections.Size = new System.Drawing.Size(235, 23);
            this.btnLoadCorrections.TabIndex = 190;
            this.btnLoadCorrections.Text = "Load Corrections";
            this.btnLoadCorrections.UseVisualStyleBackColor = true;
            this.btnLoadCorrections.Click += new System.EventHandler(this.btnLoadCorrections_Click);
            // 
            // dgCorrections
            // 
            this.dgCorrections.AllowUserToAddRows = false;
            this.dgCorrections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCorrections.Location = new System.Drawing.Point(22, 607);
            this.dgCorrections.Margin = new System.Windows.Forms.Padding(4);
            this.dgCorrections.Name = "dgCorrections";
            this.dgCorrections.Size = new System.Drawing.Size(968, 149);
            this.dgCorrections.TabIndex = 191;
            // 
            // lblNumberRecords
            // 
            this.lblNumberRecords.AutoSize = true;
            this.lblNumberRecords.Location = new System.Drawing.Point(997, 713);
            this.lblNumberRecords.Name = "lblNumberRecords";
            this.lblNumberRecords.Size = new System.Drawing.Size(125, 17);
            this.lblNumberRecords.TabIndex = 192;
            this.lblNumberRecords.Text = "lblNumberRecords";
            // 
            // frm_EriePrinterRounding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 805);
            this.Controls.Add(this.lblNumberRecords);
            this.Controls.Add(this.dgCorrections);
            this.Controls.Add(this.btnLoadCorrections);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgPrinterRecordData);
            this.Controls.Add(this.btnTaxTypes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgLineItems);
            this.Controls.Add(this.btnLoadBills);
            this.Controls.Add(this.btnPerformFix);
            this.Controls.Add(this.cboTaxTypes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtFiscalSubYear);
            this.Controls.Add(this.txtFiscalYear);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgTaxRolls);
            this.Controls.Add(this.dgFileImport);
            this.Controls.Add(this.btnLoadDatagrid);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.Label1);
            this.Name = "frm_EriePrinterRounding";
            this.Text = "frm_EriePrinterRounding";
            this.Load += new System.EventHandler(this.frm_EriePrinterRounding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgFileImport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxRolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgPrinterRecordData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgCorrections)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgFileImport;
        internal System.Windows.Forms.Button btnLoadDatagrid;
        internal System.Windows.Forms.Button btnBrowse;
        internal System.Windows.Forms.TextBox txtFileName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.DataGridView dgTaxRolls;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.TextBox txtFiscalSubYear;
        internal System.Windows.Forms.TextBox txtFiscalYear;
        internal System.Windows.Forms.Label Label16;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboTaxTypes;
        private System.Windows.Forms.Button btnPerformFix;
        private System.Windows.Forms.Button btnLoadBills;
        internal System.Windows.Forms.DataGridView dgLineItems;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pbarProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.Windows.Forms.Button btnTaxTypes;
        internal System.Windows.Forms.DataGridView dgPrinterRecordData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoadCorrections;
        internal System.Windows.Forms.DataGridView dgCorrections;
        private System.Windows.Forms.Label lblNumberRecords;
    }
}