namespace LibSYS
{
    partial class frmFine
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
            this.grpFine = new System.Windows.Forms.GroupBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblPayStatus = new System.Windows.Forms.Label();
            this.txtPPSFine = new System.Windows.Forms.TextBox();
            this.lblPpsNo = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.grpFine.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFine
            // 
            this.grpFine.Controls.Add(this.cmbStatus);
            this.grpFine.Controls.Add(this.lblPayStatus);
            this.grpFine.Controls.Add(this.txtPPSFine);
            this.grpFine.Controls.Add(this.lblPpsNo);
            this.grpFine.Controls.Add(this.lblFine);
            this.grpFine.Controls.Add(this.txtFine);
            this.grpFine.Controls.Add(this.txtForename);
            this.grpFine.Controls.Add(this.txtSurname);
            this.grpFine.Controls.Add(this.lblForename);
            this.grpFine.Controls.Add(this.txtMemberID);
            this.grpFine.Controls.Add(this.lblSurname);
            this.grpFine.Controls.Add(this.lblMemberID);
            this.grpFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpFine.Location = new System.Drawing.Point(12, 12);
            this.grpFine.Name = "grpFine";
            this.grpFine.Size = new System.Drawing.Size(323, 190);
            this.grpFine.TabIndex = 0;
            this.grpFine.TabStop = false;
            this.grpFine.Text = "Fine Details";
            // 
            // cmbStatus
            // 
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Paid",
            "Owed"});
            this.cmbStatus.Location = new System.Drawing.Point(82, 156);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 21);
            this.cmbStatus.TabIndex = 0;
            this.cmbStatus.TabStop = false;
            // 
            // lblPayStatus
            // 
            this.lblPayStatus.AutoSize = true;
            this.lblPayStatus.ForeColor = System.Drawing.Color.Black;
            this.lblPayStatus.Location = new System.Drawing.Point(7, 156);
            this.lblPayStatus.Name = "lblPayStatus";
            this.lblPayStatus.Size = new System.Drawing.Size(40, 13);
            this.lblPayStatus.TabIndex = 0;
            this.lblPayStatus.Text = "Status:";
            // 
            // txtPPSFine
            // 
            this.txtPPSFine.Location = new System.Drawing.Point(82, 25);
            this.txtPPSFine.Name = "txtPPSFine";
            this.txtPPSFine.ReadOnly = true;
            this.txtPPSFine.Size = new System.Drawing.Size(98, 20);
            this.txtPPSFine.TabIndex = 0;
            this.txtPPSFine.TabStop = false;
            // 
            // lblPpsNo
            // 
            this.lblPpsNo.AutoSize = true;
            this.lblPpsNo.ForeColor = System.Drawing.Color.Black;
            this.lblPpsNo.Location = new System.Drawing.Point(7, 28);
            this.lblPpsNo.Name = "lblPpsNo";
            this.lblPpsNo.Size = new System.Drawing.Size(51, 13);
            this.lblPpsNo.TabIndex = 0;
            this.lblPpsNo.Text = "PPS No.:";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.ForeColor = System.Drawing.Color.Black;
            this.lblFine.Location = new System.Drawing.Point(7, 132);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(30, 13);
            this.lblFine.TabIndex = 0;
            this.lblFine.Text = "Fine:";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(82, 129);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(94, 20);
            this.txtFine.TabIndex = 0;
            this.txtFine.TabStop = false;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(82, 103);
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(142, 20);
            this.txtForename.TabIndex = 0;
            this.txtForename.TabStop = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(82, 77);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(142, 20);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.TabStop = false;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.ForeColor = System.Drawing.Color.Black;
            this.lblForename.Location = new System.Drawing.Point(7, 106);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(82, 51);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(98, 20);
            this.txtMemberID.TabIndex = 0;
            this.txtMemberID.TabStop = false;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(7, 80);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.ForeColor = System.Drawing.Color.Black;
            this.lblMemberID.Location = new System.Drawing.Point(7, 54);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID:";
            // 
            // btnSave
            // 
            this.btnSave.ForeColor = System.Drawing.Color.Black;
            this.btnSave.Location = new System.Drawing.Point(151, 208);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Location = new System.Drawing.Point(246, 208);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 23);
            this.btnCancel.TabIndex = 22;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 238);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.grpFine);
            this.Controls.Add(this.btnSave);
            this.Name = "frmFine";
            this.Text = "Fine";
            this.grpFine.ResumeLayout(false);
            this.grpFine.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFine;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblPayStatus;
        private System.Windows.Forms.TextBox txtPPSFine;
        private System.Windows.Forms.Label lblPpsNo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Button btnCancel;
    }
}