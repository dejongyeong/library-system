namespace LibSYS
{
    partial class frmBorrow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBorrow));
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpMember = new System.Windows.Forms.GroupBox();
            this.grdMemberList = new System.Windows.Forms.DataGridView();
            this.grpMemberDetails = new System.Windows.Forms.GroupBox();
            this.txtPPS = new System.Windows.Forms.TextBox();
            this.lblPPSNo = new System.Windows.Forms.Label();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.txtMemID = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.lblMemberID = new System.Windows.Forms.Label();
            this.grpSchPPS = new System.Windows.Forms.GroupBox();
            this.btnClearSname = new System.Windows.Forms.Button();
            this.btnSearchMember = new System.Windows.Forms.Button();
            this.txtSname = new System.Windows.Forms.TextBox();
            this.lblSearchSurname = new System.Windows.Forms.Label();
            this.grpBook = new System.Windows.Forms.GroupBox();
            this.btnDone = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lstCart = new System.Windows.Forms.ListBox();
            this.grdBookList = new System.Windows.Forms.DataGridView();
            this.grpSchISBN = new System.Windows.Forms.GroupBox();
            this.btnClearTitle = new System.Windows.Forms.Button();
            this.btnSearchBook = new System.Windows.Forms.Button();
            this.txtSTitle = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.grpBorrowDetails = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtpCurrentDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblTodayDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.lblLoanID = new System.Windows.Forms.Label();
            this.txtLoanID = new System.Windows.Forms.TextBox();
            this.mnuRegMember.SuspendLayout();
            this.grpMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberList)).BeginInit();
            this.grpMemberDetails.SuspendLayout();
            this.grpSchPPS.SuspendLayout();
            this.grpBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookList)).BeginInit();
            this.grpSchISBN.SuspendLayout();
            this.grpBorrowDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(951, 25);
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
            // grpMember
            // 
            this.grpMember.Controls.Add(this.grdMemberList);
            this.grpMember.Controls.Add(this.grpMemberDetails);
            this.grpMember.Controls.Add(this.grpSchPPS);
            this.grpMember.ForeColor = System.Drawing.Color.Black;
            this.grpMember.Location = new System.Drawing.Point(12, 63);
            this.grpMember.Name = "grpMember";
            this.grpMember.Size = new System.Drawing.Size(465, 435);
            this.grpMember.TabIndex = 1;
            this.grpMember.TabStop = false;
            this.grpMember.Text = "Member Details";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMemberList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdMemberList.Location = new System.Drawing.Point(10, 73);
            this.grdMemberList.Name = "grdMemberList";
            this.grdMemberList.ReadOnly = true;
            this.grdMemberList.RowHeadersWidth = 35;
            this.grdMemberList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMemberList.Size = new System.Drawing.Size(442, 204);
            this.grdMemberList.TabIndex = 5;
            this.grdMemberList.Visible = false;
            this.grdMemberList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMemberList_CellClick);
            // 
            // grpMemberDetails
            // 
            this.grpMemberDetails.Controls.Add(this.txtPPS);
            this.grpMemberDetails.Controls.Add(this.lblPPSNo);
            this.grpMemberDetails.Controls.Add(this.txtForename);
            this.grpMemberDetails.Controls.Add(this.txtSurname);
            this.grpMemberDetails.Controls.Add(this.lblForename);
            this.grpMemberDetails.Controls.Add(this.txtMemID);
            this.grpMemberDetails.Controls.Add(this.lblSurname);
            this.grpMemberDetails.Controls.Add(this.lblMemberID);
            this.grpMemberDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpMemberDetails.Location = new System.Drawing.Point(10, 283);
            this.grpMemberDetails.Name = "grpMemberDetails";
            this.grpMemberDetails.Size = new System.Drawing.Size(442, 146);
            this.grpMemberDetails.TabIndex = 0;
            this.grpMemberDetails.TabStop = false;
            this.grpMemberDetails.Text = "Details";
            this.grpMemberDetails.Visible = false;
            // 
            // txtPPS
            // 
            this.txtPPS.Location = new System.Drawing.Point(74, 52);
            this.txtPPS.Name = "txtPPS";
            this.txtPPS.ReadOnly = true;
            this.txtPPS.Size = new System.Drawing.Size(121, 20);
            this.txtPPS.TabIndex = 0;
            this.txtPPS.TabStop = false;
            // 
            // lblPPSNo
            // 
            this.lblPPSNo.AutoSize = true;
            this.lblPPSNo.ForeColor = System.Drawing.Color.Black;
            this.lblPPSNo.Location = new System.Drawing.Point(6, 55);
            this.lblPPSNo.Name = "lblPPSNo";
            this.lblPPSNo.Size = new System.Drawing.Size(48, 13);
            this.lblPPSNo.TabIndex = 0;
            this.lblPPSNo.Text = "PPS No:";
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(74, 105);
            this.txtForename.Name = "txtForename";
            this.txtForename.ReadOnly = true;
            this.txtForename.Size = new System.Drawing.Size(164, 20);
            this.txtForename.TabIndex = 0;
            this.txtForename.TabStop = false;
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(74, 79);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.ReadOnly = true;
            this.txtSurname.Size = new System.Drawing.Size(164, 20);
            this.txtSurname.TabIndex = 0;
            this.txtSurname.TabStop = false;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.ForeColor = System.Drawing.Color.Black;
            this.lblForename.Location = new System.Drawing.Point(6, 108);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename:";
            // 
            // txtMemID
            // 
            this.txtMemID.Location = new System.Drawing.Point(74, 23);
            this.txtMemID.Name = "txtMemID";
            this.txtMemID.ReadOnly = true;
            this.txtMemID.Size = new System.Drawing.Size(83, 20);
            this.txtMemID.TabIndex = 0;
            this.txtMemID.TabStop = false;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(6, 82);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // lblMemberID
            // 
            this.lblMemberID.AutoSize = true;
            this.lblMemberID.ForeColor = System.Drawing.Color.Black;
            this.lblMemberID.Location = new System.Drawing.Point(6, 26);
            this.lblMemberID.Name = "lblMemberID";
            this.lblMemberID.Size = new System.Drawing.Size(62, 13);
            this.lblMemberID.TabIndex = 0;
            this.lblMemberID.Text = "Member ID:";
            // 
            // grpSchPPS
            // 
            this.grpSchPPS.Controls.Add(this.btnClearSname);
            this.grpSchPPS.Controls.Add(this.btnSearchMember);
            this.grpSchPPS.Controls.Add(this.txtSname);
            this.grpSchPPS.Controls.Add(this.lblSearchSurname);
            this.grpSchPPS.ForeColor = System.Drawing.Color.Blue;
            this.grpSchPPS.Location = new System.Drawing.Point(10, 19);
            this.grpSchPPS.Name = "grpSchPPS";
            this.grpSchPPS.Size = new System.Drawing.Size(442, 48);
            this.grpSchPPS.TabIndex = 0;
            this.grpSchPPS.TabStop = false;
            this.grpSchPPS.Text = "Search";
            // 
            // btnClearSname
            // 
            this.btnClearSname.ForeColor = System.Drawing.Color.Black;
            this.btnClearSname.Location = new System.Drawing.Point(350, 16);
            this.btnClearSname.Name = "btnClearSname";
            this.btnClearSname.Size = new System.Drawing.Size(86, 23);
            this.btnClearSname.TabIndex = 4;
            this.btnClearSname.Text = "Clear";
            this.btnClearSname.UseVisualStyleBackColor = true;
            this.btnClearSname.Click += new System.EventHandler(this.btnClearSname_Click);
            // 
            // btnSearchMember
            // 
            this.btnSearchMember.ForeColor = System.Drawing.Color.Black;
            this.btnSearchMember.Location = new System.Drawing.Point(258, 16);
            this.btnSearchMember.Name = "btnSearchMember";
            this.btnSearchMember.Size = new System.Drawing.Size(86, 23);
            this.btnSearchMember.TabIndex = 3;
            this.btnSearchMember.Text = "Search";
            this.btnSearchMember.UseVisualStyleBackColor = true;
            this.btnSearchMember.Click += new System.EventHandler(this.btnSearchMember_Click);
            // 
            // txtSname
            // 
            this.txtSname.Location = new System.Drawing.Point(65, 18);
            this.txtSname.MaxLength = 9;
            this.txtSname.Name = "txtSname";
            this.txtSname.Size = new System.Drawing.Size(120, 20);
            this.txtSname.TabIndex = 2;
            // 
            // lblSearchSurname
            // 
            this.lblSearchSurname.AutoSize = true;
            this.lblSearchSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSearchSurname.Location = new System.Drawing.Point(7, 21);
            this.lblSearchSurname.Name = "lblSearchSurname";
            this.lblSearchSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSearchSurname.TabIndex = 0;
            this.lblSearchSurname.Text = "Surname:";
            // 
            // grpBook
            // 
            this.grpBook.Controls.Add(this.btnDone);
            this.grpBook.Controls.Add(this.btnRemove);
            this.grpBook.Controls.Add(this.lstCart);
            this.grpBook.Controls.Add(this.grdBookList);
            this.grpBook.Controls.Add(this.grpSchISBN);
            this.grpBook.ForeColor = System.Drawing.Color.Black;
            this.grpBook.Location = new System.Drawing.Point(483, 63);
            this.grpBook.Name = "grpBook";
            this.grpBook.Size = new System.Drawing.Size(460, 356);
            this.grpBook.TabIndex = 6;
            this.grpBook.TabStop = false;
            this.grpBook.Text = "Book Details";
            this.grpBook.Visible = false;
            // 
            // btnDone
            // 
            this.btnDone.Location = new System.Drawing.Point(379, 327);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(75, 23);
            this.btnDone.TabIndex = 12;
            this.btnDone.Text = "Done";
            this.btnDone.UseVisualStyleBackColor = true;
            this.btnDone.Visible = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(298, 327);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 11;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Visible = false;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lstCart
            // 
            this.lstCart.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCart.FormattingEnabled = true;
            this.lstCart.ItemHeight = 14;
            this.lstCart.Location = new System.Drawing.Point(9, 235);
            this.lstCart.Name = "lstCart";
            this.lstCart.Size = new System.Drawing.Size(442, 88);
            this.lstCart.TabIndex = 0;
            this.lstCart.Visible = false;
            // 
            // grdBookList
            // 
            this.grdBookList.AllowUserToAddRows = false;
            this.grdBookList.AllowUserToDeleteRows = false;
            this.grdBookList.AllowUserToOrderColumns = true;
            this.grdBookList.AllowUserToResizeRows = false;
            this.grdBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBookList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdBookList.Location = new System.Drawing.Point(9, 73);
            this.grdBookList.Name = "grdBookList";
            this.grdBookList.ReadOnly = true;
            this.grdBookList.RowHeadersWidth = 35;
            this.grdBookList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBookList.Size = new System.Drawing.Size(442, 156);
            this.grdBookList.TabIndex = 10;
            this.grdBookList.Visible = false;
            this.grdBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBookList_CellClick);
            // 
            // grpSchISBN
            // 
            this.grpSchISBN.Controls.Add(this.btnClearTitle);
            this.grpSchISBN.Controls.Add(this.btnSearchBook);
            this.grpSchISBN.Controls.Add(this.txtSTitle);
            this.grpSchISBN.Controls.Add(this.lblISBN);
            this.grpSchISBN.ForeColor = System.Drawing.Color.Blue;
            this.grpSchISBN.Location = new System.Drawing.Point(9, 19);
            this.grpSchISBN.Name = "grpSchISBN";
            this.grpSchISBN.Size = new System.Drawing.Size(442, 48);
            this.grpSchISBN.TabIndex = 7;
            this.grpSchISBN.TabStop = false;
            this.grpSchISBN.Text = "Search";
            // 
            // btnClearTitle
            // 
            this.btnClearTitle.ForeColor = System.Drawing.Color.Black;
            this.btnClearTitle.Location = new System.Drawing.Point(350, 16);
            this.btnClearTitle.Name = "btnClearTitle";
            this.btnClearTitle.Size = new System.Drawing.Size(86, 23);
            this.btnClearTitle.TabIndex = 9;
            this.btnClearTitle.Text = "Clear";
            this.btnClearTitle.UseVisualStyleBackColor = true;
            this.btnClearTitle.Click += new System.EventHandler(this.btnClearTitle_Click);
            // 
            // btnSearchBook
            // 
            this.btnSearchBook.ForeColor = System.Drawing.Color.Black;
            this.btnSearchBook.Location = new System.Drawing.Point(258, 16);
            this.btnSearchBook.Name = "btnSearchBook";
            this.btnSearchBook.Size = new System.Drawing.Size(86, 23);
            this.btnSearchBook.TabIndex = 8;
            this.btnSearchBook.Text = "Search";
            this.btnSearchBook.UseVisualStyleBackColor = true;
            this.btnSearchBook.Click += new System.EventHandler(this.btnSearchBook_Click);
            // 
            // txtSTitle
            // 
            this.txtSTitle.Location = new System.Drawing.Point(43, 18);
            this.txtSTitle.MaxLength = 13;
            this.txtSTitle.Name = "txtSTitle";
            this.txtSTitle.Size = new System.Drawing.Size(142, 20);
            this.txtSTitle.TabIndex = 7;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.ForeColor = System.Drawing.Color.Black;
            this.lblISBN.Location = new System.Drawing.Point(7, 21);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(30, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "Title:";
            // 
            // grpBorrowDetails
            // 
            this.grpBorrowDetails.Controls.Add(this.btnReturn);
            this.grpBorrowDetails.Controls.Add(this.dtpCurrentDate);
            this.grpBorrowDetails.Controls.Add(this.dtpDueDate);
            this.grpBorrowDetails.Controls.Add(this.lblTodayDate);
            this.grpBorrowDetails.Controls.Add(this.lblDueDate);
            this.grpBorrowDetails.Controls.Add(this.btnBorrow);
            this.grpBorrowDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpBorrowDetails.Location = new System.Drawing.Point(483, 425);
            this.grpBorrowDetails.Name = "grpBorrowDetails";
            this.grpBorrowDetails.Size = new System.Drawing.Size(460, 73);
            this.grpBorrowDetails.TabIndex = 11;
            this.grpBorrowDetails.TabStop = false;
            this.grpBorrowDetails.Text = "Borrow Details";
            this.grpBorrowDetails.Visible = false;
            // 
            // btnReturn
            // 
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.Location = new System.Drawing.Point(379, 43);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 23);
            this.btnReturn.TabIndex = 15;
            this.btnReturn.Text = "Cancel";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtpCurrentDate
            // 
            this.dtpCurrentDate.CustomFormat = "dd-MMM-yyyy";
            this.dtpCurrentDate.Enabled = false;
            this.dtpCurrentDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCurrentDate.Location = new System.Drawing.Point(84, 20);
            this.dtpCurrentDate.Name = "dtpCurrentDate";
            this.dtpCurrentDate.Size = new System.Drawing.Size(112, 20);
            this.dtpCurrentDate.TabIndex = 14;
            this.dtpCurrentDate.Value = new System.DateTime(2017, 3, 21, 22, 46, 14, 0);
            // 
            // dtpDueDate
            // 
            this.dtpDueDate.CustomFormat = "dd-MMM-yyy";
            this.dtpDueDate.Enabled = false;
            this.dtpDueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDueDate.Location = new System.Drawing.Point(84, 46);
            this.dtpDueDate.MinDate = new System.DateTime(2016, 10, 22, 0, 0, 0, 0);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(113, 20);
            this.dtpDueDate.TabIndex = 12;
            this.dtpDueDate.Value = new System.DateTime(2017, 3, 21, 22, 46, 7, 0);
            // 
            // lblTodayDate
            // 
            this.lblTodayDate.AutoSize = true;
            this.lblTodayDate.ForeColor = System.Drawing.Color.Black;
            this.lblTodayDate.Location = new System.Drawing.Point(8, 24);
            this.lblTodayDate.Name = "lblTodayDate";
            this.lblTodayDate.Size = new System.Drawing.Size(70, 13);
            this.lblTodayDate.TabIndex = 13;
            this.lblTodayDate.Text = "Current Date:";
            // 
            // lblDueDate
            // 
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.ForeColor = System.Drawing.Color.Black;
            this.lblDueDate.Location = new System.Drawing.Point(8, 50);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(56, 13);
            this.lblDueDate.TabIndex = 0;
            this.lblDueDate.Text = "Due Date:";
            // 
            // btnBorrow
            // 
            this.btnBorrow.ForeColor = System.Drawing.Color.Black;
            this.btnBorrow.Location = new System.Drawing.Point(379, 14);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(75, 23);
            this.btnBorrow.TabIndex = 13;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // lblLoanID
            // 
            this.lblLoanID.AutoSize = true;
            this.lblLoanID.Location = new System.Drawing.Point(12, 37);
            this.lblLoanID.Name = "lblLoanID";
            this.lblLoanID.Size = new System.Drawing.Size(48, 13);
            this.lblLoanID.TabIndex = 0;
            this.lblLoanID.Text = "Loan ID:";
            // 
            // txtLoanID
            // 
            this.txtLoanID.Enabled = false;
            this.txtLoanID.Location = new System.Drawing.Point(66, 34);
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.Size = new System.Drawing.Size(86, 20);
            this.txtLoanID.TabIndex = 0;
            // 
            // frmBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 509);
            this.Controls.Add(this.txtLoanID);
            this.Controls.Add(this.lblLoanID);
            this.Controls.Add(this.grpBorrowDetails);
            this.Controls.Add(this.grpBook);
            this.Controls.Add(this.grpMember);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borrow Book";
            this.Load += new System.EventHandler(this.frmBorrow_Load);
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.grpMember.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberList)).EndInit();
            this.grpMemberDetails.ResumeLayout(false);
            this.grpMemberDetails.PerformLayout();
            this.grpSchPPS.ResumeLayout(false);
            this.grpSchPPS.PerformLayout();
            this.grpBook.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdBookList)).EndInit();
            this.grpSchISBN.ResumeLayout(false);
            this.grpSchISBN.PerformLayout();
            this.grpBorrowDetails.ResumeLayout(false);
            this.grpBorrowDetails.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpMember;
        private System.Windows.Forms.Button btnSearchMember;
        private System.Windows.Forms.TextBox txtSname;
        private System.Windows.Forms.Label lblSearchSurname;
        private System.Windows.Forms.GroupBox grpBook;
        private System.Windows.Forms.Button btnSearchBook;
        private System.Windows.Forms.GroupBox grpBorrowDetails;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.GroupBox grpMemberDetails;
        private System.Windows.Forms.Label lblMemberID;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.TextBox txtMemID;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.TextBox txtSTitle;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.DataGridView grdBookList;
        private System.Windows.Forms.Label lblLoanID;
        private System.Windows.Forms.TextBox txtLoanID;
        private System.Windows.Forms.GroupBox grpSchPPS;
        private System.Windows.Forms.GroupBox grpSchISBN;
        private System.Windows.Forms.DataGridView grdMemberList;
        private System.Windows.Forms.TextBox txtPPS;
        private System.Windows.Forms.Label lblPPSNo;
        private System.Windows.Forms.Button btnClearSname;
        private System.Windows.Forms.Button btnClearTitle;
        private System.Windows.Forms.DateTimePicker dtpCurrentDate;
        private System.Windows.Forms.Label lblTodayDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.ListBox lstCart;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnDone;
        private System.Windows.Forms.Button btnReturn;
    }
}