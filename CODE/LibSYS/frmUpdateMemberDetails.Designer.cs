namespace LibSYS
{
    partial class frmUpdateMemberDetails
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
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.dtpRegisterDate = new System.Windows.Forms.DateTimePicker();
            this.lblRegisterDate = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
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
            this.lblSurname = new System.Windows.Forms.Label();
            this.mnuRegMember.SuspendLayout();
            this.grpMemberDetails.SuspendLayout();
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
            this.mnuRegMember.Size = new System.Drawing.Size(503, 25);
            this.mnuRegMember.TabIndex = 13;
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
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(389, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(102, 23);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.Controls.Add(this.label1);
            this.grpMemberDetails.Controls.Add(this.txtMemberID);
            this.grpMemberDetails.Controls.Add(this.dtpRegisterDate);
            this.grpMemberDetails.Controls.Add(this.lblRegisterDate);
            this.grpMemberDetails.Controls.Add(this.txtEmail);
            this.grpMemberDetails.Controls.Add(this.lblEmail);
            this.grpMemberDetails.Controls.Add(this.txtContact);
            this.grpMemberDetails.Controls.Add(this.lblContact);
            this.grpMemberDetails.Controls.Add(this.optFemale);
            this.grpMemberDetails.Controls.Add(this.optMale);
            this.grpMemberDetails.Controls.Add(this.lblGender);
            this.grpMemberDetails.Controls.Add(this.dtpDOB);
            this.grpMemberDetails.Controls.Add(this.lblDOB);
            this.grpMemberDetails.Controls.Add(this.grpAddress);
            this.grpMemberDetails.Controls.Add(this.txtForename);
            this.grpMemberDetails.Controls.Add(this.lblPPS);
            this.grpMemberDetails.Controls.Add(this.lblForename);
            this.grpMemberDetails.Controls.Add(this.txtPPS);
            this.grpMemberDetails.Controls.Add(this.txtSurname);
            this.grpMemberDetails.Controls.Add(this.lblSurname);
            this.grpMemberDetails.ForeColor = System.Drawing.Color.Blue;
            this.grpMemberDetails.Location = new System.Drawing.Point(12, 28);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(476, 367);
            this.grpMemberDetails.TabIndex = 1;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Member Details";
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
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(74, 24);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(135, 20);
            this.txtMemberID.TabIndex = 0;
            this.txtMemberID.TabStop = false;
            // 
            // dtpRegisterDate
            // 
            this.dtpRegisterDate.CustomFormat = "dd/MM/yyyy";
            this.dtpRegisterDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRegisterDate.Location = new System.Drawing.Point(99, 331);
            this.dtpRegisterDate.MaxDate = new System.DateTime(2016, 10, 21, 0, 0, 0, 0);
            this.dtpRegisterDate.Name = "dtpRegisterDate";
            this.dtpRegisterDate.Size = new System.Drawing.Size(110, 20);
            this.dtpRegisterDate.TabIndex = 12;
            this.dtpRegisterDate.Value = new System.DateTime(2016, 10, 21, 0, 0, 0, 0);
            // 
            // lblRegisterDate
            // 
            this.lblRegisterDate.AutoSize = true;
            this.lblRegisterDate.ForeColor = System.Drawing.Color.Black;
            this.lblRegisterDate.Location = new System.Drawing.Point(6, 336);
            this.lblRegisterDate.Name = "lblRegisterDate";
            this.lblRegisterDate.Size = new System.Drawing.Size(75, 13);
            this.lblRegisterDate.TabIndex = 0;
            this.lblRegisterDate.Text = "Register Date:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(99, 305);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(193, 20);
            this.txtEmail.TabIndex = 11;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Black;
            this.lblEmail.Location = new System.Drawing.Point(6, 309);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email:";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(99, 279);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(157, 20);
            this.txtContact.TabIndex = 10;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.ForeColor = System.Drawing.Color.Black;
            this.lblContact.Location = new System.Drawing.Point(6, 283);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(41, 13);
            this.lblContact.TabIndex = 0;
            this.lblContact.Text = "Phone:";
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.ForeColor = System.Drawing.Color.Black;
            this.optFemale.Location = new System.Drawing.Point(149, 133);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(59, 17);
            this.optFemale.TabIndex = 0;
            this.optFemale.Text = "Female";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.ForeColor = System.Drawing.Color.Black;
            this.optMale.Location = new System.Drawing.Point(74, 133);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(48, 17);
            this.optMale.TabIndex = 0;
            this.optMale.Text = "Male";
            this.optMale.UseVisualStyleBackColor = true;
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
            this.dtpDOB.CustomFormat = "dd/MM/yyyy";
            this.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDOB.Location = new System.Drawing.Point(74, 104);
            this.dtpDOB.MaxDate = new System.DateTime(2016, 10, 21, 0, 0, 0, 0);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(106, 20);
            this.dtpDOB.TabIndex = 5;
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
            this.grpAddress.Location = new System.Drawing.Point(9, 161);
            this.grpAddress.Name = "grpAddress";
            this.grpAddress.Size = new System.Drawing.Size(461, 108);
            this.grpAddress.TabIndex = 6;
            this.grpAddress.TabStop = false;
            this.grpAddress.Text = "Address";
            // 
            // txtCounty
            // 
            this.txtCounty.Location = new System.Drawing.Point(65, 75);
            this.txtCounty.Name = "txtCounty";
            this.txtCounty.Size = new System.Drawing.Size(148, 20);
            this.txtCounty.TabIndex = 9;
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
            this.txtTown.Name = "txtTown";
            this.txtTown.Size = new System.Drawing.Size(173, 20);
            this.txtTown.TabIndex = 8;
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
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(250, 20);
            this.txtStreet.TabIndex = 7;
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
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(135, 20);
            this.txtForename.TabIndex = 4;
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
            this.txtPPS.Name = "txtPPS";
            this.txtPPS.Size = new System.Drawing.Size(135, 20);
            this.txtPPS.TabIndex = 2;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(74, 76);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(148, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(6, 79);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // frmUpdateMemberDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 441);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpMemberDetails);
            this.Controls.Add(this.mnuRegMember);
            this.Name = "frmUpdateMemberDetails";
            this.Text = " Update Member";
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.grpAddress.ResumeLayout(false);
            this.grpAddress.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.DateTimePicker dtpRegisterDate;
        private System.Windows.Forms.Label lblRegisterDate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
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
        private System.Windows.Forms.Label lblSurname;
    }
}