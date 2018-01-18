namespace Vendor.V2.Conversions
{
    partial class frm_Exonerations
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.cboNewDatabase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboDatabase = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgExonerations = new System.Windows.Forms.DataGridView();
            this.dgTaxRolls = new System.Windows.Forms.DataGridView();
            this.dgParcels = new System.Windows.Forms.DataGridView();
            this.bntConvert = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgExonerations)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxRolls)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParcels)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(199, 35);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(56, 19);
            this.btnLoad.TabIndex = 188;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
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
            this.cboNewDatabase.Location = new System.Drawing.Point(396, 11);
            this.cboNewDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.cboNewDatabase.Name = "cboNewDatabase";
            this.cboNewDatabase.Size = new System.Drawing.Size(181, 21);
            this.cboNewDatabase.TabIndex = 187;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 186;
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
            this.cboDatabase.Location = new System.Drawing.Point(75, 11);
            this.cboDatabase.Margin = new System.Windows.Forms.Padding(2);
            this.cboDatabase.Name = "cboDatabase";
            this.cboDatabase.Size = new System.Drawing.Size(181, 21);
            this.cboDatabase.TabIndex = 185;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 184;
            this.label3.Text = "Database:";
            // 
            // dgExonerations
            // 
            this.dgExonerations.AllowUserToAddRows = false;
            this.dgExonerations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgExonerations.Location = new System.Drawing.Point(15, 59);
            this.dgExonerations.Name = "dgExonerations";
            this.dgExonerations.Size = new System.Drawing.Size(378, 361);
            this.dgExonerations.TabIndex = 189;
            // 
            // dgTaxRolls
            // 
            this.dgTaxRolls.AllowUserToAddRows = false;
            this.dgTaxRolls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTaxRolls.Location = new System.Drawing.Point(399, 59);
            this.dgTaxRolls.Name = "dgTaxRolls";
            this.dgTaxRolls.Size = new System.Drawing.Size(378, 108);
            this.dgTaxRolls.TabIndex = 190;
            // 
            // dgParcels
            // 
            this.dgParcels.AllowUserToAddRows = false;
            this.dgParcels.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgParcels.Location = new System.Drawing.Point(399, 173);
            this.dgParcels.Name = "dgParcels";
            this.dgParcels.Size = new System.Drawing.Size(378, 108);
            this.dgParcels.TabIndex = 191;
            // 
            // bntConvert
            // 
            this.bntConvert.Location = new System.Drawing.Point(783, 59);
            this.bntConvert.Name = "bntConvert";
            this.bntConvert.Size = new System.Drawing.Size(75, 23);
            this.bntConvert.TabIndex = 192;
            this.bntConvert.Text = "Convert";
            this.bntConvert.UseVisualStyleBackColor = true;
            this.bntConvert.Click += new System.EventHandler(this.bntConvert_Click);
            // 
            // frm_Exonerations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 509);
            this.Controls.Add(this.bntConvert);
            this.Controls.Add(this.dgParcels);
            this.Controls.Add(this.dgTaxRolls);
            this.Controls.Add(this.dgExonerations);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.cboNewDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboDatabase);
            this.Controls.Add(this.label3);
            this.Name = "frm_Exonerations";
            this.Text = "frm_Exonerations";
            ((System.ComponentModel.ISupportInitialize)(this.dgExonerations)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTaxRolls)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgParcels)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.ComboBox cboNewDatabase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboDatabase;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgExonerations;
        private System.Windows.Forms.DataGridView dgTaxRolls;
        private System.Windows.Forms.DataGridView dgParcels;
        private System.Windows.Forms.Button bntConvert;
    }
}