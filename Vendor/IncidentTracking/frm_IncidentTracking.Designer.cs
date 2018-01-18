namespace Vendor.IncidentTracking
{
    partial class frm_IncidentTracking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_IncidentTracking));
            this.panelList = new System.Windows.Forms.Panel();
            this.dgList = new System.Windows.Forms.DataGridView();
            this.irIntNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irStrTitle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stsStrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priorStrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irDateCreate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.appStrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.catStrName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irStrReporter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.irStrReporterPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keyIncidentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnDel = new System.Windows.Forms.ToolStripButton();
            this.panelInfo = new System.Windows.Forms.Panel();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtAssigned = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.rchResolution = new System.Windows.Forms.RichTextBox();
            this.chkNotificationOff = new System.Windows.Forms.CheckBox();
            this.chkWhatsNew = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cboPriority = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboApplication = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtNotification = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.dtResolved = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.dtAssigned = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.dtCreated = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txtReporterEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtReporterPhone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtReporter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rchDescription = new System.Windows.Forms.RichTextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblKeyIncidentID = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnIFAdd = new System.Windows.Forms.ToolStripButton();
            this.btnIFChg = new System.Windows.Forms.ToolStripButton();
            this.btnIFDel = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.txtClientDB = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panelList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panelInfo.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelList
            // 
            this.panelList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelList.Controls.Add(this.dgList);
            this.panelList.Controls.Add(this.toolStrip1);
            this.panelList.Location = new System.Drawing.Point(12, 12);
            this.panelList.Name = "panelList";
            this.panelList.Size = new System.Drawing.Size(504, 605);
            this.panelList.TabIndex = 0;
            this.panelList.Resize += new System.EventHandler(this.panelList_Resize);
            // 
            // dgList
            // 
            this.dgList.AllowUserToAddRows = false;
            this.dgList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.irIntNumber,
            this.irStrTitle,
            this.stsStrName,
            this.priorStrName,
            this.irDateCreate,
            this.appStrName,
            this.catStrName,
            this.irStrReporter,
            this.irStrReporterPhone,
            this.keyIncidentID});
            this.dgList.Location = new System.Drawing.Point(3, 38);
            this.dgList.Name = "dgList";
            this.dgList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgList.Size = new System.Drawing.Size(468, 433);
            this.dgList.TabIndex = 1;
            this.dgList.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgList_RowHeaderMouseDoubleClick);
            // 
            // irIntNumber
            // 
            this.irIntNumber.DataPropertyName = "irIntNumber";
            this.irIntNumber.HeaderText = "Number";
            this.irIntNumber.Name = "irIntNumber";
            // 
            // irStrTitle
            // 
            this.irStrTitle.DataPropertyName = "irStrTitle";
            this.irStrTitle.HeaderText = "Title";
            this.irStrTitle.Name = "irStrTitle";
            // 
            // stsStrName
            // 
            this.stsStrName.DataPropertyName = "stsStrName";
            this.stsStrName.HeaderText = "Status";
            this.stsStrName.Name = "stsStrName";
            // 
            // priorStrName
            // 
            this.priorStrName.DataPropertyName = "priorStrName";
            this.priorStrName.HeaderText = "Priority";
            this.priorStrName.Name = "priorStrName";
            // 
            // irDateCreate
            // 
            this.irDateCreate.DataPropertyName = "irDateCreate";
            this.irDateCreate.HeaderText = "Created";
            this.irDateCreate.Name = "irDateCreate";
            // 
            // appStrName
            // 
            this.appStrName.DataPropertyName = "appStrName";
            this.appStrName.HeaderText = "Application";
            this.appStrName.Name = "appStrName";
            // 
            // catStrName
            // 
            this.catStrName.DataPropertyName = "catStrName";
            this.catStrName.HeaderText = "Category";
            this.catStrName.Name = "catStrName";
            // 
            // irStrReporter
            // 
            this.irStrReporter.DataPropertyName = "irStrReporter";
            this.irStrReporter.HeaderText = "Reporter";
            this.irStrReporter.Name = "irStrReporter";
            // 
            // irStrReporterPhone
            // 
            this.irStrReporterPhone.DataPropertyName = "irStrReporterPhone";
            this.irStrReporterPhone.HeaderText = "Phone";
            this.irStrReporterPhone.Name = "irStrReporterPhone";
            // 
            // keyIncidentID
            // 
            this.keyIncidentID.DataPropertyName = "keyIncidentID";
            this.keyIncidentID.HeaderText = "key";
            this.keyIncidentID.Name = "keyIncidentID";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAdd,
            this.btnDel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(500, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // panelInfo
            // 
            this.panelInfo.AutoScroll = true;
            this.panelInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelInfo.Controls.Add(this.txtNumber);
            this.panelInfo.Controls.Add(this.groupBox3);
            this.panelInfo.Controls.Add(this.panel1);
            this.panelInfo.Controls.Add(this.groupBox2);
            this.panelInfo.Controls.Add(this.groupBox1);
            this.panelInfo.Controls.Add(this.txtReporterEmail);
            this.panelInfo.Controls.Add(this.label5);
            this.panelInfo.Controls.Add(this.txtReporterPhone);
            this.panelInfo.Controls.Add(this.label4);
            this.panelInfo.Controls.Add(this.txtReporter);
            this.panelInfo.Controls.Add(this.label3);
            this.panelInfo.Controls.Add(this.label2);
            this.panelInfo.Controls.Add(this.rchDescription);
            this.panelInfo.Controls.Add(this.statusStrip1);
            this.panelInfo.Controls.Add(this.txtTitle);
            this.panelInfo.Controls.Add(this.label1);
            this.panelInfo.Controls.Add(this.toolStrip2);
            this.panelInfo.Location = new System.Drawing.Point(522, 12);
            this.panelInfo.Name = "panelInfo";
            this.panelInfo.Size = new System.Drawing.Size(530, 605);
            this.panelInfo.TabIndex = 1;
            // 
            // txtNumber
            // 
            this.txtNumber.Enabled = false;
            this.txtNumber.Location = new System.Drawing.Point(399, 38);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(89, 20);
            this.txtNumber.TabIndex = 16;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAssigned);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.rchResolution);
            this.groupBox3.Controls.Add(this.chkNotificationOff);
            this.groupBox3.Controls.Add(this.chkWhatsNew);
            this.groupBox3.Location = new System.Drawing.Point(35, 448);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(465, 228);
            this.groupBox3.TabIndex = 15;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Finalize";
            // 
            // txtAssigned
            // 
            this.txtAssigned.Location = new System.Drawing.Point(86, 192);
            this.txtAssigned.Name = "txtAssigned";
            this.txtAssigned.Size = new System.Drawing.Size(356, 20);
            this.txtAssigned.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(24, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 13);
            this.label15.TabIndex = 8;
            this.label15.Text = "Assigned:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(17, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 7;
            this.label14.Text = "Resolution:";
            // 
            // rchResolution
            // 
            this.rchResolution.Location = new System.Drawing.Point(86, 42);
            this.rchResolution.Name = "rchResolution";
            this.rchResolution.Size = new System.Drawing.Size(356, 144);
            this.rchResolution.TabIndex = 6;
            this.rchResolution.Text = "";
            // 
            // chkNotificationOff
            // 
            this.chkNotificationOff.AutoSize = true;
            this.chkNotificationOff.Location = new System.Drawing.Point(190, 19);
            this.chkNotificationOff.Name = "chkNotificationOff";
            this.chkNotificationOff.Size = new System.Drawing.Size(96, 17);
            this.chkNotificationOff.TabIndex = 1;
            this.chkNotificationOff.Text = "Notification Off";
            this.chkNotificationOff.UseVisualStyleBackColor = true;
            // 
            // chkWhatsNew
            // 
            this.chkWhatsNew.AutoSize = true;
            this.chkWhatsNew.Location = new System.Drawing.Point(86, 19);
            this.chkWhatsNew.Name = "chkWhatsNew";
            this.chkWhatsNew.Size = new System.Drawing.Size(90, 17);
            this.chkWhatsNew.TabIndex = 0;
            this.chkWhatsNew.Text = "What\'s New?";
            this.chkWhatsNew.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 589);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(26, 100);
            this.panel1.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.cboPriority);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.cboCategory);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.cboStatus);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.cboApplication);
            this.groupBox2.Location = new System.Drawing.Point(300, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 223);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "References";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 7;
            this.label13.Text = "Priority";
            // 
            // cboPriority
            // 
            this.cboPriority.FormattingEnabled = true;
            this.cboPriority.Location = new System.Drawing.Point(18, 166);
            this.cboPriority.Name = "cboPriority";
            this.cboPriority.Size = new System.Drawing.Size(170, 21);
            this.cboPriority.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(15, 108);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Category";
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(18, 124);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(170, 21);
            this.cboCategory.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Status";
            // 
            // cboStatus
            // 
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Location = new System.Drawing.Point(18, 83);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(170, 21);
            this.cboStatus.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Application";
            // 
            // cboApplication
            // 
            this.cboApplication.FormattingEnabled = true;
            this.cboApplication.Location = new System.Drawing.Point(18, 44);
            this.cboApplication.Name = "cboApplication";
            this.cboApplication.Size = new System.Drawing.Size(170, 21);
            this.cboApplication.TabIndex = 0;
            this.cboApplication.SelectedIndexChanged += new System.EventHandler(this.cboApplication_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtClientDB);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.dtNotification);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.dtResolved);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.dtAssigned);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dtCreated);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(35, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(259, 224);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dates";
            // 
            // dtNotification
            // 
            this.dtNotification.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNotification.Location = new System.Drawing.Point(117, 107);
            this.dtNotification.Name = "dtNotification";
            this.dtNotification.Size = new System.Drawing.Size(118, 20);
            this.dtNotification.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Notification Off Date:";
            // 
            // dtResolved
            // 
            this.dtResolved.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtResolved.Location = new System.Drawing.Point(117, 81);
            this.dtResolved.Name = "dtResolved";
            this.dtResolved.Size = new System.Drawing.Size(118, 20);
            this.dtResolved.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(56, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Resolved:";
            // 
            // dtAssigned
            // 
            this.dtAssigned.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtAssigned.Location = new System.Drawing.Point(117, 55);
            this.dtAssigned.Name = "dtAssigned";
            this.dtAssigned.Size = new System.Drawing.Size(118, 20);
            this.dtAssigned.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Assigned:";
            // 
            // dtCreated
            // 
            this.dtCreated.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtCreated.Location = new System.Drawing.Point(117, 29);
            this.dtCreated.Name = "dtCreated";
            this.dtCreated.Size = new System.Drawing.Size(118, 20);
            this.dtCreated.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Created:";
            // 
            // txtReporterEmail
            // 
            this.txtReporterEmail.Location = new System.Drawing.Point(280, 192);
            this.txtReporterEmail.Name = "txtReporterEmail";
            this.txtReporterEmail.Size = new System.Drawing.Size(208, 20);
            this.txtReporterEmail.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Email:";
            // 
            // txtReporterPhone
            // 
            this.txtReporterPhone.Location = new System.Drawing.Point(132, 192);
            this.txtReporterPhone.Name = "txtReporterPhone";
            this.txtReporterPhone.Size = new System.Drawing.Size(103, 20);
            this.txtReporterPhone.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Phone:";
            // 
            // txtReporter
            // 
            this.txtReporter.Location = new System.Drawing.Point(132, 166);
            this.txtReporter.Name = "txtReporter";
            this.txtReporter.Size = new System.Drawing.Size(356, 20);
            this.txtReporter.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Reporter:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Description:";
            // 
            // rchDescription
            // 
            this.rchDescription.Location = new System.Drawing.Point(132, 64);
            this.rchDescription.Name = "rchDescription";
            this.rchDescription.Size = new System.Drawing.Size(356, 96);
            this.rchDescription.TabIndex = 4;
            this.rchDescription.Text = "";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblKeyIncidentID});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(509, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblKeyIncidentID
            // 
            this.lblKeyIncidentID.Name = "lblKeyIncidentID";
            this.lblKeyIncidentID.Size = new System.Drawing.Size(93, 17);
            this.lblKeyIncidentID.Text = "lblKeyIncidentID";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(132, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(261, 20);
            this.txtTitle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
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
            this.toolStrip2.Size = new System.Drawing.Size(509, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
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
            // txtClientDB
            // 
            this.txtClientDB.Location = new System.Drawing.Point(117, 133);
            this.txtClientDB.Name = "txtClientDB";
            this.txtClientDB.Size = new System.Drawing.Size(118, 20);
            this.txtClientDB.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(55, 136);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(56, 13);
            this.label16.TabIndex = 10;
            this.label16.Text = "Database:";
            // 
            // frm_IncidentTracking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 629);
            this.Controls.Add(this.panelInfo);
            this.Controls.Add(this.panelList);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_IncidentTracking";
            this.Text = "Incident Tracking";
            this.Load += new System.EventHandler(this.frm_IncidentTracking_Load);
            this.Resize += new System.EventHandler(this.frm_IncidentTracking_Resize);
            this.panelList.ResumeLayout(false);
            this.panelList.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgList)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panelInfo.ResumeLayout(false);
            this.panelInfo.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
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
        private System.Windows.Forms.ToolStripButton btnIFAdd;
        private System.Windows.Forms.ToolStripButton btnIFChg;
        private System.Windows.Forms.ToolStripButton btnIFDel;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblKeyIncidentID;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cboPriority;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboApplication;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtNotification;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtResolved;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtAssigned;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtCreated;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtReporterEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReporterPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtReporter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rchDescription;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.RichTextBox rchResolution;
        private System.Windows.Forms.CheckBox chkNotificationOff;
        private System.Windows.Forms.CheckBox chkWhatsNew;
        private System.Windows.Forms.TextBox txtAssigned;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn irIntNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn irStrTitle;
        private System.Windows.Forms.DataGridViewTextBoxColumn stsStrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn priorStrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn irDateCreate;
        private System.Windows.Forms.DataGridViewTextBoxColumn appStrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn catStrName;
        private System.Windows.Forms.DataGridViewTextBoxColumn irStrReporter;
        private System.Windows.Forms.DataGridViewTextBoxColumn irStrReporterPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyIncidentID;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtClientDB;
        private System.Windows.Forms.Label label16;
    }
}