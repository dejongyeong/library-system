namespace LibSYS
{
    partial class frmRecordFine
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
            this.grpFine = new System.Windows.Forms.GroupBox();
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
            this.btnPay = new System.Windows.Forms.Button();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblPPS = new System.Windows.Forms.Label();
            this.txtPPSSearch = new System.Windows.Forms.TextBox();
            this.mnuRegMember.SuspendLayout();
            this.grpFine.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(342, 25);
            this.mnuRegMember.TabIndex = 2;
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
            // grpFine
            // 
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
            this.grpFine.Location = new System.Drawing.Point(12, 117);
            this.grpFine.Name = "grpFine";
            this.grpFine.Size = new System.Drawing.Size(323, 161);
            this.grpFine.TabIndex = 0;
            this.grpFine.TabStop = false;
            this.grpFine.Text = "Fine Details";
            // 
            // txtPPSFine
            // 
            this.txtPPSFine.Location = new System.Drawing.Point(81, 23);
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
            this.lblPpsNo.Location = new System.Drawing.Point(6, 26);
            this.lblPpsNo.Name = "lblPpsNo";
            this.lblPpsNo.Size = new System.Drawing.Size(51, 13);
            this.lblPpsNo.TabIndex = 0;
            this.lblPpsNo.Text = "PPS No.:";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.ForeColor = System.Drawing.Color.Black;
            this.lblFine.Location = new System.Drawing.Point(6, 130);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(57, 13);
            this.lblFine.TabIndex = 0;
            this.lblFine.Text = "Total Fine:";
            // 
            // txtFine
            // 
            this.txtFine.Location = new System.Drawing.Point(81, 127);
            this.txtFine.Name = "txtFine";
            this.txtFine.ReadOnly = true;
            this.txtFine.Size = new System.Drawing.Size(94, 20);
            this.txtFine.TabIndex = 0;
            this.txtFine.TabStop = false;
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(81, 101);
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(142, 20);
            this.txtForename.TabIndex = 0;
            this.txtForename.TabStop = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(81, 75);
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
            this.lblForename.Location = new System.Drawing.Point(6, 104);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename:";
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(81, 49);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.ReadOnly = true;
            this.txtMemberID.Size = new System.Drawing.Size(98, 20);
            this.txtMemberID.TabIndex = 5;
            this.txtMemberID.TabStop = false;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(6, 78);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.ForeColor = System.Drawing.Color.Black;
            this.lblMemberID.Location = new System.Drawing.Point(6, 52);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID:";
            // 
            // btnPay
            // 
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(227, 284);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(108, 23);
            this.btnPay.TabIndex = 7;
            this.btnPay.Text = "Pay";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblPPS);
            this.grpSearch.Controls.Add(this.txtPPSSearch);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpSearch.Location = new System.Drawing.Point(12, 29);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(323, 82);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(215, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(102, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // lblPPS
            // 
            this.lblPPS.AutoSize = true;
            this.lblPPS.ForeColor = System.Drawing.Color.Black;
            this.lblPPS.Location = new System.Drawing.Point(6, 26);
            this.lblPPS.Name = "lblPPS";
            this.lblPPS.Size = new System.Drawing.Size(51, 13);
            this.lblPPS.TabIndex = 0;
            this.lblPPS.Text = "PPS No.:";
            // 
            // txtPPSSearch
            // 
            this.txtPPSSearch.Location = new System.Drawing.Point(63, 23);
            this.txtPPSSearch.Name = "txtPPSSearch";
            this.txtPPSSearch.Size = new System.Drawing.Size(116, 20);
            this.txtPPSSearch.TabIndex = 2;
            // 
            // frmRecordFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 314);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpFine);
            this.Controls.Add(this.mnuRegMember);
            this.Controls.Add(this.btnPay);
            this.Name = "frmRecordFine";
            this.Text = "Record Fine";
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.grpFine.ResumeLayout(false);
            this.grpFine.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpFine;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.TextBox txtPPSFine;
        private System.Windows.Forms.Label lblPpsNo;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblPPS;
        private System.Windows.Forms.TextBox txtPPSSearch;
    }
}