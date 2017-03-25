namespace TicketingRequestSystem
{
    partial class frmOperator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOperator));
            this.btnClose = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblDate = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAssign = new System.Windows.Forms.Button();
            this.comboxWorker = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboxDepartment = new System.Windows.Forms.ComboBox();
            this.workerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.requestTicketingSystemDataSet = new TicketingRequestSystem.RequestTicketingSystemDataSet();
            this.departmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtDeadline = new System.Windows.Forms.DateTimePicker();
            this.tboxRequestorContactInfo = new System.Windows.Forms.TextBox();
            this.tboxRequest = new System.Windows.Forms.TextBox();
            this.tboxRequestorName = new System.Windows.Forms.TextBox();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentTableAdapter = new TicketingRequestSystem.RequestTicketingSystemDataSetTableAdapters.DepartmentTableAdapter();
            this.workerTableAdapter = new TicketingRequestSystem.RequestTicketingSystemDataSetTableAdapters.WorkerTableAdapter();
            this.ticketBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.requestTicketingSystemDataSet11 = new TicketingRequestSystem.RequestTicketingSystemDataSet1();
            this.ticketBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.requestTicketingSystemDataSet1 = new TicketingRequestSystem.RequestTicketingSystemDataSet();
            this.ticketBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketTableAdapter = new TicketingRequestSystem.RequestTicketingSystemDataSetTableAdapters.TicketTableAdapter();
            this.ticketTableAdapter1 = new TicketingRequestSystem.RequestTicketingSystemDataSet1TableAdapters.TicketTableAdapter();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tboxTrackID = new System.Windows.Forms.TextBox();
            this.btnTrack = new System.Windows.Forms.Button();
            this.lblViewArea = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTicketingSystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTicketingSystemDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTicketingSystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(942, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(2);
            this.btnClose.Size = new System.Drawing.Size(33, 31);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogout.Location = new System.Drawing.Point(12, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(357, 44);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Ariel Catli";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblDate
            // 
            this.lblDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDate.Location = new System.Drawing.Point(568, 23);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(75, 25);
            this.lblDate.TabIndex = 3;
            this.lblDate.Text = "label1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTime.Location = new System.Drawing.Point(630, 48);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(75, 25);
            this.lblTime.TabIndex = 4;
            this.lblTime.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.btnAssign);
            this.groupBox1.Controls.Add(this.comboxWorker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboxDepartment);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtDeadline);
            this.groupBox1.Controls.Add(this.tboxRequestorContactInfo);
            this.groupBox1.Controls.Add(this.tboxRequest);
            this.groupBox1.Controls.Add(this.tboxRequestorName);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(12, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(670, 437);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add A Request";
            // 
            // btnAssign
            // 
            this.btnAssign.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAssign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAssign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssign.Location = new System.Drawing.Point(168, 392);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(317, 28);
            this.btnAssign.TabIndex = 6;
            this.btnAssign.Text = "ASSIGN";
            this.btnAssign.UseVisualStyleBackColor = true;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // comboxWorker
            // 
            this.comboxWorker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxWorker.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxWorker.FormattingEnabled = true;
            this.comboxWorker.Location = new System.Drawing.Point(127, 346);
            this.comboxWorker.Name = "comboxWorker";
            this.comboxWorker.Size = new System.Drawing.Size(523, 29);
            this.comboxWorker.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Worker";
            // 
            // comboxDepartment
            // 
            this.comboxDepartment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboxDepartment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.workerBindingSource1, "departmentID", true));
            this.comboxDepartment.DataSource = this.departmentBindingSource;
            this.comboxDepartment.DisplayMember = "departmentName";
            this.comboxDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboxDepartment.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxDepartment.FormattingEnabled = true;
            this.comboxDepartment.Location = new System.Drawing.Point(127, 306);
            this.comboxDepartment.Name = "comboxDepartment";
            this.comboxDepartment.Size = new System.Drawing.Size(523, 29);
            this.comboxDepartment.TabIndex = 4;
            this.comboxDepartment.ValueMember = "departmentID";
            this.comboxDepartment.SelectedIndexChanged += new System.EventHandler(this.comboxDepartment_SelectedIndexChanged);
            // 
            // workerBindingSource1
            // 
            this.workerBindingSource1.DataMember = "Worker";
            this.workerBindingSource1.DataSource = this.requestTicketingSystemDataSet;
            // 
            // requestTicketingSystemDataSet
            // 
            this.requestTicketingSystemDataSet.DataSetName = "RequestTicketingSystemDataSet";
            this.requestTicketingSystemDataSet.EnforceConstraints = false;
            this.requestTicketingSystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // departmentBindingSource
            // 
            this.departmentBindingSource.DataMember = "Department";
            this.departmentBindingSource.DataSource = this.requestTicketingSystemDataSet;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Department";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deadline";
            // 
            // dtDeadline
            // 
            this.dtDeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtDeadline.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtDeadline.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtDeadline.Location = new System.Drawing.Point(280, 269);
            this.dtDeadline.MinDate = new System.DateTime(2017, 3, 12, 0, 0, 0, 0);
            this.dtDeadline.Name = "dtDeadline";
            this.dtDeadline.Size = new System.Drawing.Size(205, 27);
            this.dtDeadline.TabIndex = 3;
            // 
            // tboxRequestorContactInfo
            // 
            this.tboxRequestorContactInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxRequestorContactInfo.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxRequestorContactInfo.ForeColor = System.Drawing.Color.Gray;
            this.tboxRequestorContactInfo.Location = new System.Drawing.Point(15, 70);
            this.tboxRequestorContactInfo.Name = "tboxRequestorContactInfo";
            this.tboxRequestorContactInfo.Size = new System.Drawing.Size(640, 31);
            this.tboxRequestorContactInfo.TabIndex = 1;
            this.tboxRequestorContactInfo.Text = "Requestor contact information ";
            this.tboxRequestorContactInfo.WordWrap = false;
            this.tboxRequestorContactInfo.Enter += new System.EventHandler(this.tboxRequestorContactInfo_Enter);
            // 
            // tboxRequest
            // 
            this.tboxRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxRequest.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxRequest.ForeColor = System.Drawing.Color.Gray;
            this.tboxRequest.Location = new System.Drawing.Point(15, 114);
            this.tboxRequest.Multiline = true;
            this.tboxRequest.Name = "tboxRequest";
            this.tboxRequest.Size = new System.Drawing.Size(640, 146);
            this.tboxRequest.TabIndex = 2;
            this.tboxRequest.Text = "Request...";
            this.tboxRequest.Enter += new System.EventHandler(this.tboxRequest_Enter);
            // 
            // tboxRequestorName
            // 
            this.tboxRequestorName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxRequestorName.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxRequestorName.ForeColor = System.Drawing.Color.Gray;
            this.tboxRequestorName.Location = new System.Drawing.Point(15, 26);
            this.tboxRequestorName.Name = "tboxRequestorName";
            this.tboxRequestorName.Size = new System.Drawing.Size(640, 31);
            this.tboxRequestorName.TabIndex = 0;
            this.tboxRequestorName.Text = "Requestor name";
            this.tboxRequestorName.WordWrap = false;
            this.tboxRequestorName.Enter += new System.EventHandler(this.tboxRequestorName_Enter);
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataMember = "Worker";
            this.workerBindingSource.DataSource = this.requestTicketingSystemDataSet;
            // 
            // departmentTableAdapter
            // 
            this.departmentTableAdapter.ClearBeforeFill = true;
            // 
            // workerTableAdapter
            // 
            this.workerTableAdapter.ClearBeforeFill = true;
            // 
            // ticketBindingSource2
            // 
            this.ticketBindingSource2.DataMember = "Ticket";
            this.ticketBindingSource2.DataSource = this.requestTicketingSystemDataSet11;
            // 
            // requestTicketingSystemDataSet11
            // 
            this.requestTicketingSystemDataSet11.DataSetName = "RequestTicketingSystemDataSet1";
            this.requestTicketingSystemDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource1
            // 
            this.ticketBindingSource1.DataMember = "Ticket";
            this.ticketBindingSource1.DataSource = this.requestTicketingSystemDataSet1;
            // 
            // requestTicketingSystemDataSet1
            // 
            this.requestTicketingSystemDataSet1.DataSetName = "RequestTicketingSystemDataSet";
            this.requestTicketingSystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketBindingSource
            // 
            this.ticketBindingSource.DataMember = "Ticket";
            this.ticketBindingSource.DataSource = this.requestTicketingSystemDataSet1;
            // 
            // ticketTableAdapter
            // 
            this.ticketTableAdapter.ClearBeforeFill = true;
            // 
            // ticketTableAdapter1
            // 
            this.ticketTableAdapter1.ClearBeforeFill = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(688, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(287, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "DELETE";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tboxTrackID
            // 
            this.tboxTrackID.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxTrackID.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxTrackID.ForeColor = System.Drawing.Color.Gray;
            this.tboxTrackID.Location = new System.Drawing.Point(688, 85);
            this.tboxTrackID.Name = "tboxTrackID";
            this.tboxTrackID.Size = new System.Drawing.Size(287, 31);
            this.tboxTrackID.TabIndex = 10;
            this.tboxTrackID.Text = "Ticket Code";
            this.tboxTrackID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tboxTrackID.WordWrap = false;
            this.tboxTrackID.Enter += new System.EventHandler(this.tboxTrackID_Enter);
            // 
            // btnTrack
            // 
            this.btnTrack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTrack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTrack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTrack.Location = new System.Drawing.Point(688, 156);
            this.btnTrack.Name = "btnTrack";
            this.btnTrack.Size = new System.Drawing.Size(287, 28);
            this.btnTrack.TabIndex = 12;
            this.btnTrack.Text = "TRACK";
            this.btnTrack.UseVisualStyleBackColor = true;
            this.btnTrack.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblViewArea
            // 
            this.lblViewArea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblViewArea.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblViewArea.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblViewArea.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblViewArea.Location = new System.Drawing.Point(688, 190);
            this.lblViewArea.Name = "lblViewArea";
            this.lblViewArea.Size = new System.Drawing.Size(287, 323);
            this.lblViewArea.TabIndex = 0;
            // 
            // frmOperator
            // 
            this.AcceptButton = this.btnTrack;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(987, 546);
            this.Controls.Add(this.lblViewArea);
            this.Controls.Add(this.btnTrack);
            this.Controls.Add(this.tboxTrackID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOperator";
            this.Text = "frmOperator";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmOperator_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTicketingSystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTicketingSystemDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestTicketingSystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxRequestorName;
        private System.Windows.Forms.TextBox tboxRequest;
        private System.Windows.Forms.TextBox tboxRequestorContactInfo;
        private System.Windows.Forms.DateTimePicker dtDeadline;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboxDepartment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboxWorker;
        private System.Windows.Forms.Button btnAssign;
        private RequestTicketingSystemDataSet requestTicketingSystemDataSet;
        private System.Windows.Forms.BindingSource departmentBindingSource;
        private RequestTicketingSystemDataSetTableAdapters.DepartmentTableAdapter departmentTableAdapter;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private RequestTicketingSystemDataSetTableAdapters.WorkerTableAdapter workerTableAdapter;
        private System.Windows.Forms.BindingSource workerBindingSource1;
        private RequestTicketingSystemDataSet requestTicketingSystemDataSet1;
        private System.Windows.Forms.BindingSource ticketBindingSource;
        private RequestTicketingSystemDataSetTableAdapters.TicketTableAdapter ticketTableAdapter;
        private System.Windows.Forms.BindingSource ticketBindingSource1;
        private RequestTicketingSystemDataSet1 requestTicketingSystemDataSet11;
        private System.Windows.Forms.BindingSource ticketBindingSource2;
        private RequestTicketingSystemDataSet1TableAdapters.TicketTableAdapter ticketTableAdapter1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox tboxTrackID;
        private System.Windows.Forms.Button btnTrack;
        private System.Windows.Forms.Label lblViewArea;
    }
}