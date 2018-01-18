namespace Vendor.V2.Conversions
{
    partial class frm_Moneys
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbarProgress = new System.Windows.Forms.ToolStripProgressBar();
            this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnConvert = new System.Windows.Forms.Button();
            this.cboNewDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgMoneys = new System.Windows.Forms.DataGridView();
            this.dgBankAccounts = new System.Windows.Forms.DataGridView();
            this.dgTaxRolls = new System.Windows.Forms.DataGridView();
            this.dgLineItems = new System.Windows.Forms.DataGridView();
            this.dgPostings = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblMax = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoneys)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBankAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxRolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPostings)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.pbarProgress,
            this.lblProgress});
            this.statusStrip1.Location = new System.Drawing.Point(0, 664);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1362, 25);
            this.statusStrip1.TabIndex = 224;
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
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(272, 42);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 222;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(1264, 72);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(75, 23);
            this.btnConvert.TabIndex = 223;
            this.btnConvert.Text = "Convert";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
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
            this.cboNewDatabase.Location = new System.Drawing.Point(534, 12);
            this.cboNewDatabase.Name = "cboNewDatabase";
            this.cboNewDatabase.Size = new System.Drawing.Size(240, 24);
            this.cboNewDatabase.TabIndex = 221;
            this.cboNewDatabase.SelectedIndexChanged += new System.EventHandler(this.cboNewDatabase_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(367, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 17);
            this.label1.TabIndex = 220;
            this.label1.Text = "Converting to Database:";
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
            this.cboDatabase.Location = new System.Drawing.Point(107, 12);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(240, 24);
            this.cboDatabase.TabIndex = 219;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 218;
            this.label3.Text = "Database:";
            // 
            // dgMoneys
            // 
            this.dgMoneys.AllowUserToAddRows = false;
            this.dgMoneys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMoneys.Location = new System.Drawing.Point(28, 72);
            this.dgMoneys.Name = "dgMoneys";
            this.dgMoneys.RowTemplate.Height = 24;
            this.dgMoneys.Size = new System.Drawing.Size(319, 542);
            this.dgMoneys.TabIndex = 225;
            // 
            // dgBankAccounts
            // 
            this.dgBankAccounts.AllowUserToAddRows = false;
            this.dgBankAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgBankAccounts.Location = new System.Drawing.Point(1018, 72);
            this.dgBankAccounts.Name = "dgBankAccounts";
            this.dgBankAccounts.RowTemplate.Height = 24;
            this.dgBankAccounts.Size = new System.Drawing.Size(240, 164);
            this.dgBankAccounts.TabIndex = 226;
            // 
            // dgTaxRolls
            // 
            this.dgTaxRolls.AllowUserToAddRows = false;
            this.dgTaxRolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaxRolls.Location = new System.Drawing.Point(1018, 242);
            this.dgTaxRolls.Name = "dgTaxRolls";
            this.dgTaxRolls.RowTemplate.Height = 24;
            this.dgTaxRolls.Size = new System.Drawing.Size(240, 164);
            this.dgTaxRolls.TabIndex = 227;
            // 
            // dgLineItems
            // 
            this.dgLineItems.AllowUserToAddRows = false;
            this.dgLineItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgLineItems.Location = new System.Drawing.Point(353, 72);
            this.dgLineItems.Name = "dgLineItems";
            this.dgLineItems.RowTemplate.Height = 24;
            this.dgLineItems.Size = new System.Drawing.Size(319, 542);
            this.dgLineItems.TabIndex = 228;
            // 
            // dgPostings
            // 
            this.dgPostings.AllowUserToAddRows = false;
            this.dgPostings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPostings.Location = new System.Drawing.Point(678, 72);
            this.dgPostings.Name = "dgPostings";
            this.dgPostings.RowTemplate.Height = 24;
            this.dgPostings.Size = new System.Drawing.Size(319, 542);
            this.dgPostings.TabIndex = 229;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 617);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 17);
            this.label2.TabIndex = 230;
            this.label2.Text = "label2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 617);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 231;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(675, 617);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 232;
            this.label5.Text = "label5";
            // 
            // lblMin
            // 
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(795, 15);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(30, 17);
            this.lblMin.TabIndex = 233;
            this.lblMin.Text = "min";
            // 
            // lblMax
            // 
            this.lblMax.AutoSize = true;
            this.lblMax.Location = new System.Drawing.Point(795, 45);
            this.lblMax.Name = "lblMax";
            this.lblMax.Size = new System.Drawing.Size(33, 17);
            this.lblMax.TabIndex = 234;
            this.lblMax.Text = "max";
            // 
            // frm_Moneys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 689);
            this.Controls.Add(this.lblMax);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgPostings);
            this.Controls.Add(this.dgLineItems);
            this.Controls.Add(this.dgTaxRolls);
            this.Controls.Add(this.dgBankAccounts);
            this.Controls.Add(this.dgMoneys);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.cboNewDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.label3);
            this.Name = "frm_Moneys";
            this.Text = "frm_Moneys";
            this.Load += new System.EventHandler(this.frm_Moneys_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgMoneys)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgBankAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxRolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgLineItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgPostings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar pbarProgress;
        private System.Windows.Forms.ToolStripStatusLabel lblProgress;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.ComboBox cboNewDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgMoneys;
        private System.Windows.Forms.DataGridView dgBankAccounts;
        private System.Windows.Forms.DataGridView dgTaxRolls;
        private System.Windows.Forms.DataGridView dgLineItems;
        private System.Windows.Forms.DataGridView dgPostings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblMax;
    }
}