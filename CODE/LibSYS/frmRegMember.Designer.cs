namespace LibSYS
{
    partial class frmRegMember
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegMember));
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnRegister = new System.Windows.Forms.Button();
            this.grpEnterMemberDetails = new System.Windows.Forms.GroupBox();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.grpAddress = new System.Windows.Forms.GroupBox();
            this.txtCounty = new System.Windows.Forms.TextBox();
            this.lblCounty = new System.Windows.Forms.Label();
            this.txtTown = new System.Windows.Forms.TextBox();
            this.lblTown = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.lblDOB = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblPPS = new System.Windows.Forms.Label();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtPPS = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.mnuRegMember.SuspendLayout();
            this.grpEnterMemberDetails.SuspendLayout();
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
            this.mnuRegMember.Size = new System.Drawing.Size(482, 25);
            this.mnuRegMember.TabIndex = 0;
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
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(352, 300);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(97, 23);
            this.btnRegister.TabIndex = 15;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // grpEnterMemberDetails
            // 
            this.grpEnterMemberDetails.Controls.Add(this.dtpRegisterDate);
            this.grpEnterMemberDetails.Controls.Add(this.lblRegisterDate);
            this.grpEnterMemberDetails.Controls.Add(this.btnRegister);
            this.grpEnterMemberDetails.Controls.Add(this.grpAddress);
            this.grpEnterMemberDetails.Controls.Add(this.txtEmail);
            this.grpEnterMemberDetails.Controls.Add(this.lblEmail);
            this.grpEnterMemberDetails.Controls.Add(this.txtPhone);
            this.grpEnterMemberDetails.Controls.Add(this.lblContact);
            this.grpEnterMemberDetails.Controls.Add(this.radFemale);
            this.grpEnterMemberDetails.Controls.Add(this.radMale);
            this.grpEnterMemberDetails.Controls.Add(this.label1);
            this.grpEnterMemberDetails.Controls.Add(this.dtpDOB);
            this.grpEnterMemberDetails.Controls.Add(this.lblDOB);
            this.grpEnterMemberDetails.Controls.Add(this.txtForename);
            this.grpEnterMemberDetails.Controls.Add(this.lblPPS);
            this.grpEnterMemberDetails.Controls.Add(this.lblForename);
            this.grpEnterMemberDetails.Controls.Add(this.txtPPS);
            this.grpEnterMemberDetails.Controls.Add(this.txtSurname);
            this.grpEnterMemberDetails.Controls.Add(this.lblSurname);
            this.grpEnterMemberDetails.ForeColor = System.Drawing.Color.Blue;
            this.grpEnterMemberDetails.Location = new System.Drawing.Point(12, 73);
            this.grpEnterMemberDetails.Name = "grpEnterMemberDetails";
            this.grpEnterMemberDetails.Size = new System.Drawing.Size(461, 331);
            this.grpEnterMemberDetails.TabIndex = 1;
            this.grpEnterMemberDetails.TabStop = false;
            this.grpEnterMemberDetails.Text = "Enter Member Details";
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegisterDate.Location = new System.Drawing.Point(89, 302);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(106, 20);
            this.dtpRegisterDate.TabIndex = 14;
            this.dtpRegisterDate.Value = new System.DateTime(2017, 2, 2, 0, 0, 0, 0);
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterDate.Location = new System.Drawing.Point(8, 305);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(75, 13);
            this.lblRegisterDate.TabIndex = 0;
            this.lblRegisterDate.Text = "Register Date:";
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
            this.grpAddress.Location = new System.Drawing.Point(6, 190);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(443, 103);
            this.grpAddress.TabIndex = 10;
            this.grpAddress.TabStop = false;
            this.grpAddress.Tag = "";
            this.grpAddress.Text = "Address";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(65, 75);
            this.txtCounty.MaxLength = 20;
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(148, 20);
            this.txtCounty.TabIndex = 13;
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
            this.txtTown.TabIndex = 12;
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
            this.txtStreet.Size = new System.Drawing.Size(213, 20);
            this.txtStreet.TabIndex = 11;
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
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(78, 164);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(10, 167);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(78, 138);
            this.txtPhone.MaxLength = 14;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(135, 20);
            this.txtPhone.TabIndex = 8;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(10, 141);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(41, 13);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Phone:";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.ForeColor = System.Drawing.Color.Black;
            this.radFemale.Location = new System.Drawing.Point(153, 110);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 7;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Checked = true;
            this.radMale.ForeColor = System.Drawing.Color.Black;
            this.radMale.Location = new System.Drawing.Point(78, 110);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 6;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(10, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gender:";
            // 
            // dtpDOB
            // 
            this.dtpDOB.CustomFormat = "dd-MMM-yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(78, 81);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(119, 20);
            this.dtpDOB.TabIndex = 5;
            this.dtpDOB.Value = new System.DateTime(2017, 2, 2, 0, 0, 0, 0);
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.ForeColor = System.Drawing.Color.Black;
            this.lblDOB.Location = new System.Drawing.Point(10, 84);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(39, 13);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "D.O.B:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(314, 53);
            this.txtForename.MaxLength = 20;
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(135, 20);
            this.txtForename.TabIndex = 4;
            // 
            // lblPPS
            // 
            this.lblPPS.AutoSize = true;
            this.lblPPS.ForeColor = System.Drawing.Color.Black;
            this.lblPPS.Location = new System.Drawing.Point(10, 30);
            this.lblPPS.Name = "lblPPS";
            this.lblPPS.Size = new System.Drawing.Size(51, 13);
            this.lblPPS.TabIndex = 0;
            this.lblPPS.Text = "PPS No.:";
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.ForeColor = System.Drawing.Color.Black;
            this.lblForename.Location = new System.Drawing.Point(251, 56);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename:";
            // 
            // txtPPS
            // 
            this.txtPPS.Location = new System.Drawing.Point(78, 27);
            this.txtPPS.MaxLength = 9;
            this.txtPPS.Name = "txtPPS";
            this.txtPPS.Size = new System.Drawing.Size(135, 20);
            this.txtPPS.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(78, 53);
            this.txtSurname.MaxLength = 20;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(148, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(10, 56);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.Location = new System.Drawing.Point(12, 43);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Enabled = false;
            this.txtMemberID.Location = new System.Drawing.Point(90, 40);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(78, 20);
            this.txtMemberID.TabIndex = 0;
            // 
            // frmRegMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(482, 415);
            this.Controls.Add(this.txtMemberID);
            this.Controls.Add(this.lblMemberID);
            this.Controls.Add(this.grpEnterMemberDetails);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuRegMember;
            this.Name = "frmRegMember";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Member";
            this.Load += new System.EventHandler(this.frmRegMember_Load);
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.grpEnterMemberDetails.ResumeLayout(false);
            this.grpEnterMemberDetails.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.GroupBox grpEnterMemberDetails;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.GroupBox grpAddress;
        private System.Windows.Forms.TextBox txtCounty;
        private System.Windows.Forms.Label lblCounty;
        private System.Windows.Forms.TextBox txtTown;
        private System.Windows.Forms.Label lblTown;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblPPS;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtPPS;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtMemberID;
    }
}