namespace Vendor.UserMaintenance
{
    partial class frm_UserMaintenance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_UserMaintenance));
            this.panelList = new System.Windows.Forms.Panel();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.btnIFAdd = new System.Windows.Forms.ToolStripButton();
            this.btnIFChg = new System.Windows.Forms.ToolStripButton();
            this.btnIFDel = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKeyTaxTrackerUserID = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblKeyUserID = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.searchName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchExpire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyTaxTrackerUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSecPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkTaxTracker = new System.Windows.Forms.CheckBox();
            this.chkWebMaster = new System.Windows.Forms.CheckBox();
            this.chkGuest = new System.Windows.Forms.CheckBox();
            this.chkDJ = new System.Windows.Forms.CheckBox();
            this.rchAddress = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboSecurityLevels = new System.Windows.Forms.ComboBox();
            this.chkActive = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtExpires = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.panelList.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelList.Controls.Add(this.dgList);
            this.panelList.Controls.Add(this.toolStrip1);
            this.panelList.Location = new System.Drawing.Point(12, 12);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(480, 525);
            this.panelList.TabIndex = 0;
            this.panelList.Resize += new System.EventHandler(this.panelList_Resize);
            // 
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Controls.Add(this.groupBox2);
            this.panelInfo.Controls.Add(this.label7);
            this.panelInfo.Controls.Add(this.rchAddress);
            this.panelInfo.Controls.Add(this.groupBox1);
            this.panelInfo.Controls.Add(this.txtAuthor);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.txtLogin);
            this.panelInfo.Controls.Add(this.label6);
            this.panelInfo.Controls.Add(this.txtSecPhone);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.txtPhone);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.txtEmail);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.txtName);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.statusStrip1);
            this.panelInfo.Controls.Add(this.toolStrip2);
            this.panelInfo.Location = new System.Drawing.Point(498, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(480, 525);
            this.panelInfo.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(476, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIFAdd,
            this.btnIFChg,
            this.btnIFDel,
            this.btnCancel});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(476, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(23, 22);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDel
            // 
            this.btnDel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(23, 22);
            this.btnDel.Text = "Delete";
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnIFAdd
            // 
            this.btnIFAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIFAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnIFAdd.Image")));
            this.btnIFAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIFAdd.Name = "btnIFAdd";
            this.btnIFAdd.Size = new System.Drawing.Size(23, 22);
            this.btnIFAdd.Text = "Add";
            this.btnIFAdd.Click += new System.EventHandler(this.btnIFAdd_Click);
            // 
            // btnIFChg
            // 
            this.btnIFChg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIFChg.Image = ((System.Drawing.Image)(resources.GetObject("btnIFChg.Image")));
            this.btnIFChg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIFChg.Name = "btnIFChg";
            this.btnIFChg.Size = new System.Drawing.Size(23, 22);
            this.btnIFChg.Text = "Change";
            this.btnIFChg.Click += new System.EventHandler(this.btnIFChg_Click);
            // 
            // btnIFDel
            // 
            this.btnIFDel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnIFDel.Image = ((System.Drawing.Image)(resources.GetObject("btnIFDel.Image")));
            this.btnIFDel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnIFDel.Name = "btnIFDel";
            this.btnIFDel.Size = new System.Drawing.Size(23, 22);
            this.btnIFDel.Text = "Delete";
            this.btnIFDel.Click += new System.EventHandler(this.btnIFDel_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(23, 22);
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.searchName,
            this.searchExpire,
            this.searchDB,
            this.keyTaxTrackerUserID,
            this.keyUserID});
            this.dgList.Location = new System.Drawing.Point(3, 28);
            this.dgList.Name = "dgList";
            this.dgList.Size = new System.Drawing.Size(436, 438);
            this.dgList.TabIndex = 1;
            this.dgList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgList_RowHeaderMouseDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblKeyTaxTrackerUserID,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblKeyUserID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 499);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(476, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(117, 17);
            this.toolStripStatusLabel1.Text = "keyTaxTrackerUserID:";
            // 
            // lblKeyTaxTrackerUserID
            // 
            this.lblKeyTaxTrackerUserID.Name = "lblKeyTaxTrackerUserID";
            this.lblKeyTaxTrackerUserID.Size = new System.Drawing.Size(128, 17);
            this.lblKeyTaxTrackerUserID.Text = "lblKeyTaxTrackerUserID";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel3.Text = "keyUserID:";
            // 
            // lblKeyUserID
            // 
            this.lblKeyUserID.Name = "lblKeyUserID";
            this.lblKeyUserID.Size = new System.Drawing.Size(73, 17);
            this.lblKeyUserID.Text = "lblKeyUserID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name:";
            // 
            // searchName
            // 
            this.searchName.DataPropertyName = "searchName";
            this.searchName.HeaderText = "Name";
            this.searchName.Name = "searchName";
            this.searchName.Width = 200;
            // 
            // searchExpire
            // 
            this.searchExpire.DataPropertyName = "searchExpire";
            this.searchExpire.HeaderText = "Expires";
            this.searchExpire.Name = "searchExpire";
            // 
            // searchDB
            // 
            this.searchDB.DataPropertyName = "searchDB";
            this.searchDB.HeaderText = "DB";
            this.searchDB.Name = "searchDB";
            // 
            // keyTaxTrackerUserID
            // 
            this.keyTaxTrackerUserID.DataPropertyName = "keyTaxTrackerUserID";
            this.keyTaxTrackerUserID.HeaderText = "keyTaxTrackerUserID";
            this.keyTaxTrackerUserID.Name = "keyTaxTrackerUserID";
            // 
            // keyUserID
            // 
            this.keyUserID.DataPropertyName = "keyUserID";
            this.keyUserID.HeaderText = "keyUserID";
            this.keyUserID.Name = "keyUserID";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(287, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(123, 85);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(287, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EMail:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(123, 111);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 20);
            this.txtPhone.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Phone:";
            // 
            // txtSecPhone
            // 
            this.txtSecPhone.Location = new System.Drawing.Point(310, 111);
            this.txtSecPhone.Name = "txtSecPhone";
            this.txtSecPhone.Size = new System.Drawing.Size(100, 20);
            this.txtSecPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(238, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Sec. Phone:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(310, 137);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAuthor.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Password:";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(123, 137);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(76, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Login:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkGuest);
            this.groupBox1.Controls.Add(this.chkWebMaster);
            this.groupBox1.Controls.Add(this.chkDJ);
            this.groupBox1.Controls.Add(this.chkTaxTracker);
            this.groupBox1.Location = new System.Drawing.Point(54, 243);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 172);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Applications";
            // 
            // chkTaxTracker
            // 
            this.chkTaxTracker.AutoSize = true;
            this.chkTaxTracker.Location = new System.Drawing.Point(51, 19);
            this.chkTaxTracker.Name = "chkTaxTracker";
            this.chkTaxTracker.Size = new System.Drawing.Size(84, 17);
            this.chkTaxTracker.TabIndex = 0;
            this.chkTaxTracker.Text = "Tax Tracker";
            this.chkTaxTracker.UseVisualStyleBackColor = true;
            // 
            // chkWebMaster
            // 
            this.chkWebMaster.AutoSize = true;
            this.chkWebMaster.Location = new System.Drawing.Point(51, 42);
            this.chkWebMaster.Name = "chkWebMaster";
            this.chkWebMaster.Size = new System.Drawing.Size(84, 17);
            this.chkWebMaster.TabIndex = 1;
            this.chkWebMaster.Text = "Web Master";
            this.chkWebMaster.UseVisualStyleBackColor = true;
            // 
            // chkGuest
            // 
            this.chkGuest.AutoSize = true;
            this.chkGuest.Location = new System.Drawing.Point(51, 65);
            this.chkGuest.Name = "chkGuest";
            this.chkGuest.Size = new System.Drawing.Size(54, 17);
            this.chkGuest.TabIndex = 2;
            this.chkGuest.Text = "Guest";
            this.chkGuest.UseVisualStyleBackColor = true;
            // 
            // chkDJ
            // 
            this.chkDJ.AutoSize = true;
            this.chkDJ.Location = new System.Drawing.Point(51, 88);
            this.chkDJ.Name = "chkDJ";
            this.chkDJ.Size = new System.Drawing.Size(39, 17);
            this.chkDJ.TabIndex = 3;
            this.chkDJ.Text = "DJ";
            this.chkDJ.UseVisualStyleBackColor = true;
            // 
            // rchAddress
            // 
            this.rchAddress.Location = new System.Drawing.Point(123, 163);
            this.rchAddress.Name = "rchAddress";
            this.rchAddress.Size = new System.Drawing.Size(287, 74);
            this.rchAddress.TabIndex = 15;
            this.rchAddress.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Address:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDB);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.dtExpires);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.chkActive);
            this.groupBox2.Controls.Add(this.cboSecurityLevels);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Location = new System.Drawing.Point(220, 243);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 172);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Security Levels";
            // 
            // cboSecurityLevels
            // 
            this.cboSecurityLevels.FormattingEnabled = true;
            this.cboSecurityLevels.Items.AddRange(new object[] {
            "00-Guest",
            "80-Administrator",
            "99-God"});
            this.cboSecurityLevels.Location = new System.Drawing.Point(21, 36);
            this.cboSecurityLevels.Name = "cboSecurityLevels";
            this.cboSecurityLevels.Size = new System.Drawing.Size(121, 21);
            this.cboSecurityLevels.TabIndex = 1;
            // 
            // chkActive
            // 
            this.chkActive.AutoSize = true;
            this.chkActive.Location = new System.Drawing.Point(21, 63);
            this.chkActive.Name = "chkActive";
            this.chkActive.Size = new System.Drawing.Size(56, 17);
            this.chkActive.TabIndex = 2;
            this.chkActive.Text = "Active";
            this.chkActive.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Expires";
            // 
            // dtExpires
            // 
            this.dtExpires.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtExpires.Location = new System.Drawing.Point(21, 99);
            this.dtExpires.Name = "dtExpires";
            this.dtExpires.Size = new System.Drawing.Size(121, 20);
            this.dtExpires.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Database";
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(21, 138);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(121, 20);
            this.txtDB.TabIndex = 12;
            // 
            // frm_UserMaintenance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 589);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelList);
            this.Name = "frm_UserMaintenance";
            this.Text = "frm_UserMaintenance";
            this.Load += new System.EventHandler(this.frm_UserMaintenance_Load);
            this.Resize += new System.EventHandler(this.frm_UserMaintenance_Resize);
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelList;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Panel panelInfo;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView dgList;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnDel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblKeyTaxTrackerUserID;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblKeyUserID;
        private System.Windows.Forms.ToolStripButton btnIFAdd;
        private System.Windows.Forms.ToolStripButton btnIFChg;
        private System.Windows.Forms.ToolStripButton btnIFDel;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchName;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchExpire;
        private System.Windows.Forms.DataGridViewTextBoxColumn searchDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyTaxTrackerUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyUserID;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSecPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rchAddress;
        private System.Windows.Forms.CheckBox chkDJ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkGuest;
        private System.Windows.Forms.CheckBox chkWebMaster;
        private System.Windows.Forms.CheckBox chkTaxTracker;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtExpires;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.ComboBox cboSecurityLevels;
        private System.Windows.Forms.Label label8;
    }
}