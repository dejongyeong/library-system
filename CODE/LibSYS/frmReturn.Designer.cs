namespace LibSYS
{
    partial class frmReturn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReturn));
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpLoanDetails = new System.Windows.Forms.GroupBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.txtBookTitle = new System.Windows.Forms.TextBox();
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblMemberName = new System.Windows.Forms.Label();
            this.txtMemName = new System.Windows.Forms.TextBox();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.grpSearchMember = new System.Windows.Forms.GroupBox();
            this.lblText = new System.Windows.Forms.Label();
            this.grdMemList = new System.Windows.Forms.DataGridView();
            this.grpSchPPS = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.btnSMem = new System.Windows.Forms.Button();
            this.lblSurname = new System.Windows.Forms.Label();
            this.grpFineDetails = new System.Windows.Forms.GroupBox();
            this.radOwe = new System.Windows.Forms.RadioButton();
            this.radPaid = new System.Windows.Forms.RadioButton();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtFine = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.dtpFDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblFDue = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnFineReturn = new System.Windows.Forms.Button();
            this.grpLoanItemList = new System.Windows.Forms.GroupBox();
            this.grdLoanItemList = new System.Windows.Forms.DataGridView();
            this.mnuRegMember.SuspendLayout();
            this.grpLoanDetails.SuspendLayout();
            this.grpSearchMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemList)).BeginInit();
            this.grpSchPPS.SuspendLayout();
            this.grpFineDetails.SuspendLayout();
            this.grpLoanItemList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoanItemList)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(870, 25);
            this.mnuRegMember.TabIndex = 3;
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
            // grpLoanDetails
            // 
            this.grpLoanDetails.Controls.Add(this.dtpDueDate);
            this.grpLoanDetails.Controls.Add(this.lblDueDate);
            this.grpLoanDetails.Controls.Add(this.dtpBorrowDate);
            this.grpLoanDetails.Controls.Add(this.lblBorrowDate);
            this.grpLoanDetails.Controls.Add(this.txtBookTitle);
            this.grpLoanDetails.Controls.Add(this.lblBookTitle);
            this.grpLoanDetails.Controls.Add(this.lblMemberName);
            this.grpLoanDetails.Controls.Add(this.txtMemName);
            this.grpLoanDetails.Controls.Add(this.txtLoanID);
            this.grpLoanDetails.Controls.Add(this.lblLoanID);
            this.grpLoanDetails.Controls.Add(this.btnReturn);
            this.grpLoanDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpLoanDetails.Location = new System.Drawing.Point(467, 28);
            this.grpLoanDetails.Name = "grpLoanDetails";
            this.grpLoanDetails.Size = new System.Drawing.Size(395, 176);
            this.grpLoanDetails.TabIndex = 0;
            this.grpLoanDetails.TabStop = false;
            this.grpLoanDetails.Text = "Loan Details";
            this.grpLoanDetails.Visible = false;
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(91, 132);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(120, 20);
            this.dtpDueDate.TabIndex = 6;
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.ForeColor = System.Drawing.Color.Black;
            this.lblDueDate.Location = new System.Drawing.Point(6, 137);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 5;
            this.lblDueDate.Text = "Due Date:";
            // 
            // dtpBorrowDate
            // 
            this.dtpBorrowDate.CustomFormat = "dd/MM/yyyy";
            this.dtpBorrowDate.Enabled = false;
            this.dtpBorrowDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBorrowDate.Location = new System.Drawing.Point(91, 106);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(120, 20);
            this.dtpBorrowDate.TabIndex = 0;
            // 
            // lblBorrowDate
            // 
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.ForeColor = System.Drawing.Color.Black;
            this.lblBorrowDate.Location = new System.Drawing.Point(6, 111);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(69, 13);
            this.lblBorrowDate.TabIndex = 0;
            this.lblBorrowDate.Text = "Borrow Date:";
            // 
            // txtBookTitle
            // 
            this.txtBookTitle.Enabled = false;
            this.txtBookTitle.Location = new System.Drawing.Point(91, 80);
            this.txtBookTitle.Name = "txtBookTitle";
            this.txtBookTitle.Size = new System.Drawing.Size(291, 20);
            this.txtBookTitle.TabIndex = 0;
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.ForeColor = System.Drawing.Color.Black;
            this.lblBookTitle.Location = new System.Drawing.Point(6, 83);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(58, 13);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Book Title:";
            // 
            // lblMemberName
            // 
            this.lblMemberName.AutoSize = true;
            this.lblMemberName.ForeColor = System.Drawing.Color.Black;
            this.lblMemberName.Location = new System.Drawing.Point(6, 57);
            this.lblMemberName.Name = "lblMemberName";
            this.lblMemberName.Size = new System.Drawing.Size(79, 13);
            this.lblMemberName.TabIndex = 0;
            this.lblMemberName.Text = "Member Name:";
            // 
            // txtMemName
            // 
            this.txtMemName.Enabled = false;
            this.txtMemName.Location = new System.Drawing.Point(91, 54);
            this.txtMemName.Name = "txtMemName";
            this.txtMemName.Size = new System.Drawing.Size(158, 20);
            this.txtMemName.TabIndex = 0;
            // 
            // txtLoanID
            // 
            this.txtLoanID.Enabled = false;
            this.txtLoanID.Location = new System.Drawing.Point(91, 27);
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(86, 20);
            this.txtLoanID.TabIndex = 0;
            // 
            // lblLoanID
            // 
            this.lblLoanID.AutoSize = true;
            this.lblLoanID.ForeColor = System.Drawing.Color.Black;
            this.lblLoanID.Location = new System.Drawing.Point(6, 30);
            this.lblLoanID.Name = "lblLoanID";
            this.lblLoanID.Size = new System.Drawing.Size(48, 13);
            this.lblLoanID.TabIndex = 0;
            this.lblLoanID.Text = "Loan ID:";
            // 
            // btnReturn
            // 
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(296, 129);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(86, 23);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // grpSearchMember
            // 
            this.grpSearchMember.Controls.Add(this.lblText);
            this.grpSearchMember.Controls.Add(this.grdMemList);
            this.grpSearchMember.Controls.Add(this.grpSchPPS);
            this.grpSearchMember.ForeColor = System.Drawing.Color.Black;
            this.grpSearchMember.Location = new System.Drawing.Point(12, 28);
            this.grpSearchMember.Name = "grpSearchMember";
            this.grpSearchMember.Size = new System.Drawing.Size(449, 199);
            this.grpSearchMember.TabIndex = 1;
            this.grpSearchMember.TabStop = false;
            this.grpSearchMember.Text = "Search Member";
            // 
            // lblText
            // 
            this.lblText.AutoSize = true;
            this.lblText.Location = new System.Drawing.Point(3, 72);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(0, 13);
            this.lblText.TabIndex = 3;
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
            this.grdMemList.Location = new System.Drawing.Point(6, 73);
            this.grdMemList.Name = "grdMemList";
            this.grdMemList.ReadOnly = true;
            this.grdMemList.RowHeadersWidth = 35;
            this.grdMemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMemList.Size = new System.Drawing.Size(437, 114);
            this.grdMemList.TabIndex = 0;
            this.grdMemList.Visible = false;
            this.grdMemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMemList_CellClick);
            // 
            // grpSchPPS
            // 
            this.grpSchPPS.Controls.Add(this.btnClear);
            this.grpSchPPS.Controls.Add(this.txtSurname);
            this.grpSchPPS.Controls.Add(this.btnSMem);
            this.grpSchPPS.Controls.Add(this.lblSurname);
            this.grpSchPPS.ForeColor = System.Drawing.Color.Blue;
            this.grpSchPPS.Location = new System.Drawing.Point(6, 19);
            this.grpSchPPS.Name = "grpSchPPS";
            this.grpSchPPS.Size = new System.Drawing.Size(437, 48);
            this.grpSchPPS.TabIndex = 2;
            this.grpSchPPS.TabStop = false;
            this.grpSchPPS.Text = "Search";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(345, 16);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(86, 23);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(75, 18);
            this.txtSurname.MaxLength = 9;
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(133, 20);
            this.txtSurname.TabIndex = 3;
            // 
            // btnSMem
            // 
            this.btnSMem.ForeColor = System.Drawing.Color.Black;
            this.btnSMem.Location = new System.Drawing.Point(253, 16);
            this.btnSMem.Name = "btnSMem";
            this.btnSMem.Size = new System.Drawing.Size(86, 23);
            this.btnSMem.TabIndex = 5;
            this.btnSMem.Text = "Search";
            this.btnSMem.UseVisualStyleBackColor = true;
            this.btnSMem.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(7, 21);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // grpFineDetails
            // 
            this.grpFineDetails.Controls.Add(this.radOwe);
            this.grpFineDetails.Controls.Add(this.radPaid);
            this.grpFineDetails.Controls.Add(this.lblPayment);
            this.grpFineDetails.Controls.Add(this.txtFine);
            this.grpFineDetails.Controls.Add(this.label2);
            this.grpFineDetails.Controls.Add(this.dtpReturnDate);
            this.grpFineDetails.Controls.Add(this.lblReturnDate);
            this.grpFineDetails.Controls.Add(this.dtpFDueDate);
            this.grpFineDetails.Controls.Add(this.lblFDue);
            this.grpFineDetails.Controls.Add(this.lblNote);
            this.grpFineDetails.Controls.Add(this.btnFineReturn);
            this.grpFineDetails.ForeColor = System.Drawing.Color.Blue;
            this.grpFineDetails.Location = new System.Drawing.Point(467, 210);
            this.grpFineDetails.Name = "grpFineDetails";
            this.grpFineDetails.Size = new System.Drawing.Size(395, 169);
            this.grpFineDetails.TabIndex = 4;
            this.grpFineDetails.TabStop = false;
            this.grpFineDetails.Text = "Fine Details";
            this.grpFineDetails.Visible = false;
            // 
            // radOwe
            // 
            this.radOwe.AutoSize = true;
            this.radOwe.ForeColor = System.Drawing.Color.Black;
            this.radOwe.Location = new System.Drawing.Point(133, 104);
            this.radOwe.Name = "radOwe";
            this.radOwe.Size = new System.Drawing.Size(47, 17);
            this.radOwe.TabIndex = 9;
            this.radOwe.Text = "Owe";
            this.radOwe.UseVisualStyleBackColor = true;
            // 
            // radPaid
            // 
            this.radPaid.AutoSize = true;
            this.radPaid.Checked = true;
            this.radPaid.ForeColor = System.Drawing.Color.Black;
            this.radPaid.Location = new System.Drawing.Point(81, 104);
            this.radPaid.Name = "radPaid";
            this.radPaid.Size = new System.Drawing.Size(46, 17);
            this.radPaid.TabIndex = 8;
            this.radPaid.TabStop = true;
            this.radPaid.Text = "Paid";
            this.radPaid.UseVisualStyleBackColor = true;
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.ForeColor = System.Drawing.Color.Black;
            this.lblPayment.Location = new System.Drawing.Point(6, 107);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(51, 13);
            this.lblPayment.TabIndex = 0;
            this.lblPayment.Text = "Payment:";
            // 
            // txtFine
            // 
            this.txtFine.Enabled = false;
            this.txtFine.Location = new System.Drawing.Point(81, 78);
            this.txtFine.Name = "txtFine";
            this.txtFine.Size = new System.Drawing.Size(120, 20);
            this.txtFine.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Total Fine €:";
            // 
            // dtpReturnDate
            // 
            this.dtpReturnDate.CustomFormat = "dd/MM/yyyy";
            this.dtpReturnDate.Enabled = false;
            this.dtpReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpReturnDate.Location = new System.Drawing.Point(81, 50);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(120, 20);
            this.dtpReturnDate.TabIndex = 0;
            // 
            // lblReturnDate
            // 
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblReturnDate.ForeColor = System.Drawing.Color.Black;
            this.lblReturnDate.Location = new System.Drawing.Point(6, 53);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(68, 13);
            this.lblReturnDate.TabIndex = 11;
            this.lblReturnDate.Text = "Return Date:";
            // 
            // dtpFDueDate
            // 
            this.dtpFDueDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFDueDate.Enabled = false;
            this.dtpFDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFDueDate.Location = new System.Drawing.Point(81, 24);
            this.dtpFDueDate.Name = "dtpFDueDate";
            this.dtpFDueDate.Size = new System.Drawing.Size(120, 20);
            this.dtpFDueDate.TabIndex = 0;
            // 
            // lblFDue
            // 
            this.lblFDue.AutoSize = true;
            this.lblFDue.ForeColor = System.Drawing.Color.Black;
            this.lblFDue.Location = new System.Drawing.Point(6, 27);
            this.lblFDue.Name = "lblFDue";
            this.lblFDue.Size = new System.Drawing.Size(56, 13);
            this.lblFDue.TabIndex = 0;
            this.lblFDue.Text = "Due Date:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.Red;
            this.lblNote.Location = new System.Drawing.Point(6, 134);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(135, 13);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "Note: Penalty of ‎€0.20/day";
            // 
            // btnFineReturn
            // 
            this.btnFineReturn.ForeColor = System.Drawing.Color.Black;
            this.btnFineReturn.Location = new System.Drawing.Point(296, 129);
            this.btnFineReturn.Name = "btnFineReturn";
            this.btnFineReturn.Size = new System.Drawing.Size(86, 23);
            this.btnFineReturn.TabIndex = 10;
            this.btnFineReturn.Text = "Return";
            this.btnFineReturn.UseVisualStyleBackColor = true;
            this.btnFineReturn.Click += new System.EventHandler(this.btnFReturn_Click);
            // 
            // grpLoanItemList
            // 
            this.grpLoanItemList.Controls.Add(this.grdLoanItemList);
            this.grpLoanItemList.Location = new System.Drawing.Point(13, 233);
            this.grpLoanItemList.Name = "grpLoanItemList";
            this.grpLoanItemList.Size = new System.Drawing.Size(448, 146);
            this.grpLoanItemList.TabIndex = 5;
            this.grpLoanItemList.TabStop = false;
            this.grpLoanItemList.Text = "Loan Item List";
            this.grpLoanItemList.Visible = false;
            // 
            // grdLoanItemList
            // 
            this.grdLoanItemList.AllowUserToAddRows = false;
            this.grdLoanItemList.AllowUserToDeleteRows = false;
            this.grdLoanItemList.AllowUserToResizeRows = false;
            this.grdLoanItemList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdLoanItemList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdLoanItemList.Location = new System.Drawing.Point(6, 20);
            this.grdLoanItemList.Name = "grdLoanItemList";
            this.grdLoanItemList.ReadOnly = true;
            this.grdLoanItemList.RowHeadersWidth = 35;
            this.grdLoanItemList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdLoanItemList.Size = new System.Drawing.Size(436, 120);
            this.grdLoanItemList.TabIndex = 0;
            this.grdLoanItemList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdLoanItemList_CellClick);
            // 
            // frmReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 391);
            this.Controls.Add(this.grpLoanItemList);
            this.Controls.Add(this.grpFineDetails);
            this.Controls.Add(this.grpSearchMember);
            this.Controls.Add(this.grpLoanDetails);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Return Book";
            this.Load += new System.EventHandler(this.frmReturn_Load);
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.grpLoanDetails.ResumeLayout(false);
            this.grpLoanDetails.PerformLayout();
            this.grpSearchMember.ResumeLayout(false);
            this.grpSearchMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemList)).EndInit();
            this.grpSchPPS.ResumeLayout(false);
            this.grpSchPPS.PerformLayout();
            this.grpFineDetails.ResumeLayout(false);
            this.grpFineDetails.PerformLayout();
            this.grpLoanItemList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdLoanItemList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.GroupBox grpLoanDetails;
        private System.Windows.Forms.GroupBox grpSearchMember;
        private System.Windows.Forms.DataGridView grdMemList;
        private System.Windows.Forms.GroupBox grpSchPPS;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Button btnSMem;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtBookTitle;
        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblMemberName;
        private System.Windows.Forms.TextBox txtMemName;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.Label lblLoanID;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.GroupBox grpFineDetails;
        private System.Windows.Forms.TextBox txtFine;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.DateTimePicker dtpFDueDate;
        private System.Windows.Forms.Label lblFDue;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Button btnFineReturn;
        private System.Windows.Forms.RadioButton radOwe;
        private System.Windows.Forms.RadioButton radPaid;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.GroupBox grpLoanItemList;
        private System.Windows.Forms.DataGridView grdLoanItemList;
    }
}