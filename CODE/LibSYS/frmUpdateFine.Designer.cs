namespace LibSYS
{
    partial class frmUpdateFine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUpdateFine));
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpFine = new System.Windows.Forms.GroupBox();
            this.lblAmntPaid = new System.Windows.Forms.Label();
            this.txtAmtPaid = new System.Windows.Forms.TextBox();
            this.txtPPS = new System.Windows.Forms.TextBox();
            this.lblPpsNo = new System.Windows.Forms.Label();
            this.lblFine = new System.Windows.Forms.Label();
            this.btnPay = new System.Windows.Forms.Button();
            this.txtTFine = new System.Windows.Forms.TextBox();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grdMemList = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSname = new System.Windows.Forms.Label();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.mnuRegMember.SuspendLayout();
            this.grpFine.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemList)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(457, 25);
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
            this.grpFine.Controls.Add(this.lblAmntPaid);
            this.grpFine.Controls.Add(this.txtAmtPaid);
            this.grpFine.Controls.Add(this.txtPPS);
            this.grpFine.Controls.Add(this.lblPpsNo);
            this.grpFine.Controls.Add(this.lblFine);
            this.grpFine.Controls.Add(this.btnPay);
            this.grpFine.Controls.Add(this.txtTFine);
            this.grpFine.Controls.Add(this.txtForename);
            this.grpFine.Controls.Add(this.txtSurname);
            this.grpFine.Controls.Add(this.lblForename);
            this.grpFine.Controls.Add(this.txtMemID);
            this.grpFine.Controls.Add(this.lblSurname);
            this.grpFine.Controls.Add(this.lblMemberID);
            this.grpFine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpFine.Location = new System.Drawing.Point(12, 207);
            this.grpFine.Name = "grpFine";
            this.grpFine.Size = new System.Drawing.Size(437, 186);
            this.grpFine.TabIndex = 6;
            this.grpFine.TabStop = false;
            this.grpFine.Text = "Fine Details";
            this.grpFine.Visible = false;
            // 
            // lblAmntPaid
            // 
            this.lblAmntPaid.AutoSize = true;
            this.lblAmntPaid.ForeColor = System.Drawing.Color.Black;
            this.lblAmntPaid.Location = new System.Drawing.Point(6, 158);
            this.lblAmntPaid.Name = "lblAmntPaid";
            this.lblAmntPaid.Size = new System.Drawing.Size(70, 13);
            this.lblAmntPaid.TabIndex = 0;
            this.lblAmntPaid.Text = "Amount Paid:";
            // 
            // txtAmtPaid
            // 
            this.txtAmtPaid.Location = new System.Drawing.Point(82, 155);
            this.txtAmtPaid.Name = "txtAmtPaid";
            this.txtAmtPaid.Size = new System.Drawing.Size(94, 20);
            this.txtAmtPaid.TabIndex = 7;
            this.txtAmtPaid.TabStop = false;
            // 
            // txtPPS
            // 
            this.txtPPS.Enabled = false;
            this.txtPPS.Location = new System.Drawing.Point(82, 51);
            this.txtPPS.Name = "txtPPS";
            this.txtPPS.Size = new System.Drawing.Size(126, 20);
            this.txtPPS.TabIndex = 0;
            this.txtPPS.TabStop = false;
            // 
            // lblPpsNo
            // 
            this.lblPpsNo.AutoSize = true;
            this.lblPpsNo.ForeColor = System.Drawing.Color.Black;
            this.lblPpsNo.Location = new System.Drawing.Point(6, 54);
            this.lblPpsNo.Name = "lblPpsNo";
            this.lblPpsNo.Size = new System.Drawing.Size(51, 13);
            this.lblPpsNo.TabIndex = 0;
            this.lblPpsNo.Text = "PPS No.:";
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.ForeColor = System.Drawing.Color.Black;
            this.lblFine.Location = new System.Drawing.Point(6, 132);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(57, 13);
            this.lblFine.TabIndex = 0;
            this.lblFine.Text = "Total Fine:";
            // 
            // btnPay
            // 
            this.btnPay.ForeColor = System.Drawing.Color.Black;
            this.btnPay.Location = new System.Drawing.Point(349, 153);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(82, 23);
            this.btnPay.TabIndex = 8;
            this.btnPay.Text = "Pay Now";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // txtTFine
            // 
            this.txtTFine.Enabled = false;
            this.txtTFine.Location = new System.Drawing.Point(82, 129);
            this.txtTFine.Name = "txtTFine";
            this.txtTFine.Size = new System.Drawing.Size(94, 20);
            this.txtTFine.TabIndex = 0;
            this.txtTFine.TabStop = false;
            // 
            // txtForename
            // 
            this.txtForename.Enabled = false;
            this.txtForename.Location = new System.Drawing.Point(82, 103);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(142, 20);
            this.txtForename.TabIndex = 0;
            this.txtForename.TabStop = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Enabled = false;
            this.txtSurname.Location = new System.Drawing.Point(82, 77);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(142, 20);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.TabStop = false;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.ForeColor = System.Drawing.Color.Black;
            this.lblForename.Location = new System.Drawing.Point(6, 106);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename:";
            // 
            // txtMemID
            // 
            this.txtMemID.Enabled = false;
            this.txtMemID.Location = new System.Drawing.Point(82, 22);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.Size = new System.Drawing.Size(81, 20);
            this.txtMemID.TabIndex = 0;
            this.txtMemID.TabStop = false;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(6, 80);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.ForeColor = System.Drawing.Color.Black;
            this.lblMemberID.Location = new System.Drawing.Point(6, 25);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID:";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.grdMemList);
            this.grpSearch.Controls.Add(this.btnClear);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblSname);
            this.grpSearch.Controls.Add(this.txtSname);
            this.grpSearch.ForeColor = System.Drawing.Color.Black;
            this.grpSearch.Location = new System.Drawing.Point(12, 29);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(437, 172);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // grdMemList
            // 
            this.grdMemList.AllowUserToAddRows = false;
            this.grdMemList.AllowUserToDeleteRows = false;
            this.grdMemList.AllowUserToResizeRows = false;
            this.grdMemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMemList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdMemList.Location = new System.Drawing.Point(9, 55);
            this.grdMemList.Name = "grdMemList";
            this.grdMemList.ReadOnly = true;
            this.grdMemList.RowHeadersWidth = 35;
            this.grdMemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMemList.Size = new System.Drawing.Size(422, 107);
            this.grdMemList.TabIndex = 5;
            this.grdMemList.Visible = false;
            this.grdMemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMemList_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(349, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 23);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(261, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(82, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSname
            // 
            this.lblSname.AutoSize = true;
            this.lblSname.ForeColor = System.Drawing.Color.Black;
            this.lblSname.Location = new System.Drawing.Point(6, 26);
            this.lblSname.Name = "lblSname";
            this.lblSname.Size = new System.Drawing.Size(52, 13);
            this.lblSname.TabIndex = 0;
            this.lblSname.Text = "Surname:";
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(64, 23);
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(126, 20);
            this.txtSname.TabIndex = 2;
            // 
            // frmUpdateFine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 399);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.grpFine);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUpdateFine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Fine";
            this.Load += new System.EventHandler(this.frmUpdateFine_Load);
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.grpFine.ResumeLayout(false);
            this.grpFine.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemList)).EndInit();
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
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.TextBox txtTFine;
        private System.Windows.Forms.TextBox txtPPS;
        private System.Windows.Forms.Label lblPpsNo;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblSname;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView grdMemList;
        private System.Windows.Forms.Label lblAmntPaid;
        private System.Windows.Forms.TextBox txtAmtPaid;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label lblMemberID;
    }
}