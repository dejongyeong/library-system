namespace LibSYS
{
    partial class frmUpdateMember
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateMember));
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdMemberList = new System.Windows.Forms.DataGridView();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grpUpdMemDetails = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.lblGender = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblPPS = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtPPS = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.mnuRegMember.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberList)).BeginInit();
            this.grpUpdMemDetails.SuspendLayout();
            this.grpAddress.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(495, 25);
            this.mnuRegMember.TabIndex = 1;
            this.mnuRegMember.Text = "Register Member Menu";
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(40, 21);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // mnuBack
            // 
            this.mnuBack.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuBack.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuBack.Name = "mnuBack";
            this.mnuBack.Size = new System.Drawing.Size(46, 21);
            this.mnuBack.Text = "Back";
            this.mnuBack.Click += new System.EventHandler(this.mnuBack_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnClear);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.grdMemberList);
            this.grpSearch.Controls.Add(this.txtSname);
            this.grpSearch.Controls.Add(this.lblSurname);
            this.grpSearch.ForeColor = System.Drawing.Color.Black;
            this.grpSearch.Location = new System.Drawing.Point(9, 28);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(476, 169);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(386, 20);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(84, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(293, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(87, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdMemberList
            // 
            this.grdMemberList.AllowUserToAddRows = false;
            this.grdMemberList.AllowUserToDeleteRows = false;
            this.grdMemberList.AllowUserToResizeRows = false;
            this.grdMemberList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMemberList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMemberList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdMemberList.Location = new System.Drawing.Point(6, 49);
            this.grdMemberList.Name = "grdMemberList";
            this.grdMemberList.ReadOnly = true;
            this.grdMemberList.RowHeadersWidth = 35;
            this.grdMemberList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMemberList.Size = new System.Drawing.Size(464, 112);
            this.grdMemberList.TabIndex = 0;
            this.grdMemberList.Visible = false;
            this.grdMemberList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMemberList_CellClick);
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(61, 22);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(128, 20);
            this.txtSname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(3, 25);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // grpUpdMemDetails
            // 
            this.grpUpdMemDetails.Controls.Add(this.btnUpdate);
            this.grpUpdMemDetails.Controls.Add(this.label1);
            this.grpUpdMemDetails.Controls.Add(this.txtMemID);
            this.grpUpdMemDetails.Controls.Add(this.lblContact);
            this.grpUpdMemDetails.Controls.Add(this.dtpRegisterDate);
            this.grpUpdMemDetails.Controls.Add(this.txtPhone);
            this.grpUpdMemDetails.Controls.Add(this.lblRegisterDate);
            this.grpUpdMemDetails.Controls.Add(this.txtEmail);
            this.grpUpdMemDetails.Controls.Add(this.lblEmail);
            this.grpUpdMemDetails.Controls.Add(this.radFemale);
            this.grpUpdMemDetails.Controls.Add(this.radMale);
            this.grpUpdMemDetails.Controls.Add(this.lblGender);
            this.grpUpdMemDetails.Controls.Add(this.dtpDOB);
            this.grpUpdMemDetails.Controls.Add(this.lblDOB);
            this.grpUpdMemDetails.Controls.Add(this.grpAddress);
            this.grpUpdMemDetails.Controls.Add(this.txtForename);
            this.grpUpdMemDetails.Controls.Add(this.lblPPS);
            this.grpUpdMemDetails.Controls.Add(this.lblForename);
            this.grpUpdMemDetails.Controls.Add(this.txtPPS);
            this.grpUpdMemDetails.Controls.Add(this.txtSurname);
            this.grpUpdMemDetails.Controls.Add(this.label2);
            this.grpUpdMemDetails.ForeColor = System.Drawing.Color.Blue;
            this.grpUpdMemDetails.Location = new System.Drawing.Point(9, 203);
            this.grpUpdMemDetails.Name = "grpUpdMemDetails";
            this.grpUpdMemDetails.Size = new System.Drawing.Size(476, 357);
            this.grpUpdMemDetails.TabIndex = 5;
            this.grpUpdMemDetails.TabStop = false;
            this.grpUpdMemDetails.Text = "Update Member Details";
            this.grpUpdMemDetails.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnUpdate.Location = new System.Drawing.Point(386, 323);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 23);
            this.btnUpdate.TabIndex = 19;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member ID:";
            // 
            // txtMemID
            // 
            this.txtMemID.Enabled = false;
            this.txtMemID.Location = new System.Drawing.Point(74, 24);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(81, 20);
            this.txtMemID.TabIndex = 0;
            this.txtMemID.TabStop = false;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(6, 160);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(41, 13);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Phone:";
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRegisterDate.Enabled = false;
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegisterDate.Location = new System.Drawing.Point(90, 325);
            this.dtpRegisterDate.MaxDate = new System.DateTime(2016, 10, 21, 0, 0, 0, 0);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(110, 20);
            this.dtpRegisterDate.TabIndex = 18;
            this.dtpRegisterDate.Value = new System.DateTime(2016, 10, 21, 0, 0, 0, 0);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(74, 157);
            this.txtPhone.MaxLength = 14;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(157, 20);
            this.txtPhone.TabIndex = 16;
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterDate.Location = new System.Drawing.Point(6, 328);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(75, 13);
            this.lblRegisterDate.TabIndex = 0;
            this.lblRegisterDate.Text = "Register Date:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(74, 183);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 17;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(6, 186);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.ForeColor = System.Drawing.Color.Black;
            this.radFemale.Location = new System.Drawing.Point(149, 133);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 11;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.ForeColor = System.Drawing.Color.Black;
            this.radMale.Location = new System.Drawing.Point(74, 133);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 10;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.ForeColor = System.Drawing.Color.Black;
            this.lblGender.Location = new System.Drawing.Point(6, 134);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(45, 13);
            this.lblGender.TabIndex = 0;
            this.lblGender.Text = "Gender:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(74, 104);
            this.dtpDOB.MaxDate = new System.DateTime(2016, 10, 21, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(106, 20);
            this.dtpDOB.TabIndex = 9;
            this.dtpDOB.Value = new System.DateTime(2016, 10, 21, 0, 0, 0, 0);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(6, 107);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(39, 13);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "D.O.B:";
            // 
            // grpAddress
            // 
            this.grpAddress.Controls.Add(this.txtCounty);
            this.grpAddress.Controls.Add(this.lblCounty);
            this.grpAddress.Controls.Add(this.txtTown);
            this.grpAddress.Controls.Add(this.lblTown);
            this.grpAddress.Controls.Add(this.txtStreet);
            this.grpAddress.Controls.Add(this.lblStreet);
            this.grpAddress.ForeColor = System.Drawing.Color.Blue;
            this.grpAddress.Location = new System.Drawing.Point(6, 209);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(461, 108);
            this.grpAddress.TabIndex = 12;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(65, 75);
            this.txtCounty.MaxLength = 20;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(148, 20);
            this.txtCounty.TabIndex = 15;
            // 
            // lblCounty
            // 
            this.lblCounty.AutoSize = true;
            this.lblCounty.ForeColor = System.Drawing.Color.Black;
            this.lblCounty.Location = new System.Drawing.Point(9, 78);
            this.lblCounty.Name = "lblCounty";
            this.lblCounty.Size = new System.Drawing.Size(43, 13);
            this.lblCounty.TabIndex = 0;
            this.lblCounty.Text = "County:";
            // 
            // txtTown
            // 
            this.txtTown.Location = new System.Drawing.Point(65, 49);
            this.txtTown.MaxLength = 20;
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(173, 20);
            this.txtTown.TabIndex = 14;
            // 
            // lblTown
            // 
            this.lblTown.AutoSize = true;
            this.lblTown.ForeColor = System.Drawing.Color.Black;
            this.lblTown.Location = new System.Drawing.Point(9, 52);
            this.lblTown.Name = "lblTown";
            this.lblTown.Size = new System.Drawing.Size(37, 13);
            this.lblTown.TabIndex = 0;
            this.lblTown.Text = "Town:";
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(65, 22);
            this.txtStreet.MaxLength = 25;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(218, 20);
            this.txtStreet.TabIndex = 13;
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.ForeColor = System.Drawing.Color.Black;
            this.lblStreet.Location = new System.Drawing.Point(9, 25);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 0;
            this.lblStreet.Text = "Street:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(310, 76);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(135, 20);
            this.txtForename.TabIndex = 8;
            // 
            // lblPPS
            // 
            this.lblPPS.AutoSize = true;
            this.lblPPS.ForeColor = System.Drawing.Color.Black;
            this.lblPPS.Location = new System.Drawing.Point(6, 53);
            this.lblPPS.Name = "lblPPS";
            this.lblPPS.Size = new System.Drawing.Size(51, 13);
            this.lblPPS.TabIndex = 0;
            this.lblPPS.Text = "PPS No.:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.ForeColor = System.Drawing.Color.Black;
            this.lblForename.Location = new System.Drawing.Point(247, 79);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename:";
            // 
            // txtPPS
            // 
            this.txtPPS.Location = new System.Drawing.Point(74, 50);
            this.txtPPS.MaxLength = 9;
            this.txtPPS.Name = "txtPPS";
            this.txtPPS.Size = new System.Drawing.Size(135, 20);
            this.txtPPS.TabIndex = 6;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(74, 76);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(148, 20);
            this.txtSurname.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Surname:";
            // 
            // frmUpdateMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 572);
            this.Controls.Add(this.grpUpdMemDetails);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Member Profile";
            this.Load += new System.EventHandler(this.frmUpdateMember_Load);
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberList)).EndInit();
            this.grpUpdMemDetails.ResumeLayout(false);
            this.grpUpdMemDetails.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdMemberList;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.GroupBox grpUpdMemDetails;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblPPS;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtPPS;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label label2;
    }
}