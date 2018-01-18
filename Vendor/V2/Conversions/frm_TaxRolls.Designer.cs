namespace Vendor.V2.Conversions
{
    partial class frm_TaxRolls
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
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cboNewDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.dgTaxRolls = new System.Windows.Forms.DataGridView();
            this.dgTaxDates = new System.Windows.Forms.DataGridView();
            this.dgStartingFigures = new System.Windows.Forms.DataGridView();
            this.btnConvert = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxRolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStartingFigures)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.cboDatabase.Location = new System.Drawing.Point(102, 12);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(240, 24);
            this.cboDatabase.TabIndex = 180;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 179;
            this.label3.Text = "Database:";
            // 
            // cboNewDatabase
            // 
            this.cboNewDatabase.FormattingEnabled = true;
            this.cboNewDatabase.Items.AddRange(new object[] {
            "TD_Erie25",
            "TD_Erie27",
            "TD_Erie31",
            "TD_Erie33",
            "TD_Erie40"});
            this.cboNewDatabase.Location = new System.Drawing.Point(529, 12);
            this.cboNewDatabase.Name = "cboNewDatabase";
            this.cboNewDatabase.Size = new System.Drawing.Size(240, 24);
            this.cboNewDatabase.TabIndex = 182;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 181;
            this.label1.Text = "Converting to Database:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(267, 42);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 183;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // dgTaxRolls
            // 
            this.dgTaxRolls.AllowUserToAddRows = false;
            this.dgTaxRolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaxRolls.Location = new System.Drawing.Point(23, 121);
            this.dgTaxRolls.Name = "dgTaxRolls";
            this.dgTaxRolls.RowTemplate.Height = 24;
            this.dgTaxRolls.Size = new System.Drawing.Size(240, 150);
            this.dgTaxRolls.TabIndex = 184;
            // 
            // dgTaxDates
            // 
            this.dgTaxDates.AllowUserToAddRows = false;
            this.dgTaxDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaxDates.Location = new System.Drawing.Point(269, 122);
            this.dgTaxDates.Name = "dgTaxDates";
            this.dgTaxDates.RowTemplate.Height = 24;
            this.dgTaxDates.Size = new System.Drawing.Size(240, 150);
            this.dgTaxDates.TabIndex = 185;
            // 
            // dgStartingFigures
            // 
            this.dgStartingFigures.AllowUserToAddRows = false;
            this.dgStartingFigures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgStartingFigures.Location = new System.Drawing.Point(515, 121);
            this.dgStartingFigures.Name = "dgStartingFigures";
            this.dgStartingFigures.RowTemplate.Height = 24;
            this.dgStartingFigures.Size = new System.Drawing.Size(240, 150);
            this.dgStartingFigures.TabIndex = 186;
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(680, 277);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 187;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pbarProgress,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 439);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1138, 25);
            this.statusStrip1.TabIndex = 188;
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
            // frm_TaxRolls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 464);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.dgStartingFigures);
            this.Controls.Add(this.dgTaxDates);
            this.Controls.Add(this.dgTaxRolls);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboNewDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.label3);
            this.Name = "frm_TaxRolls";
            this.Text = "frm_TaxRolls";
            this.Load += new System.EventHandler(this.frm_TaxRolls_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxRolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgStartingFigures)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboNewDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.DataGridView dgTaxRolls;
        private System.Windows.Forms.DataGridView dgTaxDates;
        private System.Windows.Forms.DataGridView dgStartingFigures;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pbarProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
    }
}