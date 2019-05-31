namespace LibSYS
{
    partial class frmRemoveBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRemoveBook));
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grdBookList = new System.Windows.Forms.DataGridView();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblSTitle = new System.Windows.Forms.Label();
            this.txtSTitle = new System.Windows.Forms.TextBox();
            this.btnRemove = new System.Windows.Forms.Button();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.nudEdition = new System.Windows.Forms.NumericUpDown();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.lblBookID = new System.Windows.Forms.Label();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            this.lblSubject = new System.Windows.Forms.Label();
            this.grpPublisherInfo = new System.Windows.Forms.GroupBox();
            this.cmbCountry = new System.Windows.Forms.ComboBox();
            this.txtYearPub = new System.Windows.Forms.TextBox();
            this.lblYearPublished = new System.Windows.Forms.Label();
            this.lblPubCountry = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEdition = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblIsbn = new System.Windows.Forms.Label();
            this.txtClassNo = new System.Windows.Forms.TextBox();
            this.lblClassNo = new System.Windows.Forms.Label();
            this.mnuRegMember.SuspendLayout();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookList)).BeginInit();
            this.grpBookInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdition)).BeginInit();
            this.grpPublisherInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(474, 25);
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
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.grdBookList);
            this.grpSearch.Controls.Add(this.btnClear);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.lblSTitle);
            this.grpSearch.Controls.Add(this.txtSTitle);
            this.grpSearch.ForeColor = System.Drawing.Color.Black;
            this.grpSearch.Location = new System.Drawing.Point(9, 28);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(457, 184);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
            // 
            // grdBookList
            // 
            this.grdBookList.AllowUserToAddRows = false;
            this.grdBookList.AllowUserToDeleteRows = false;
            this.grdBookList.AllowUserToResizeRows = false;
            this.grdBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdBookList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdBookList.Location = new System.Drawing.Point(9, 48);
            this.grdBookList.Name = "grdBookList";
            this.grdBookList.ReadOnly = true;
            this.grdBookList.RowHeadersWidth = 35;
            this.grdBookList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBookList.Size = new System.Drawing.Size(442, 130);
            this.grdBookList.TabIndex = 5;
            this.grdBookList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBookList_CellClick);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(367, 20);
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
            this.btnSearch.Location = new System.Drawing.Point(277, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(84, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblSTitle
            // 
            this.lblSTitle.AutoSize = true;
            this.lblSTitle.ForeColor = System.Drawing.Color.Black;
            this.lblSTitle.Location = new System.Drawing.Point(6, 25);
            this.lblSTitle.Name = "lblSTitle";
            this.lblSTitle.Size = new System.Drawing.Size(33, 13);
            this.lblSTitle.TabIndex = 0;
            this.lblSTitle.Text = "Title: ";
            // 
            // txtSTitle
            // 
            this.txtSTitle.Location = new System.Drawing.Point(45, 22);
            this.txtSTitle.Name = "txtSTitle";
            this.txtSTitle.Size = new System.Drawing.Size(183, 20);
            this.txtSTitle.TabIndex = 2;
            // 
            // btnRemove
            // 
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Location = new System.Drawing.Point(363, 365);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(88, 23);
            this.btnRemove.TabIndex = 5;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.nudEdition);
            this.grpBookInfo.Controls.Add(this.btnRemove);
            this.grpBookInfo.Controls.Add(this.txtBookID);
            this.grpBookInfo.Controls.Add(this.lblBookID);
            this.grpBookInfo.Controls.Add(this.cmbSubject);
            this.grpBookInfo.Controls.Add(this.lblSubject);
            this.grpBookInfo.Controls.Add(this.grpPublisherInfo);
            this.grpBookInfo.Controls.Add(this.txtPages);
            this.grpBookInfo.Controls.Add(this.lblPages);
            this.grpBookInfo.Controls.Add(this.txtPrice);
            this.grpBookInfo.Controls.Add(this.lblPrice);
            this.grpBookInfo.Controls.Add(this.lblEdition);
            this.grpBookInfo.Controls.Add(this.txtAuthor);
            this.grpBookInfo.Controls.Add(this.lblAuthor);
            this.grpBookInfo.Controls.Add(this.txtTitle);
            this.grpBookInfo.Controls.Add(this.lblTitle);
            this.grpBookInfo.Controls.Add(this.txtISBN);
            this.grpBookInfo.Controls.Add(this.lblIsbn);
            this.grpBookInfo.Controls.Add(this.txtClassNo);
            this.grpBookInfo.Controls.Add(this.lblClassNo);
            this.grpBookInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpBookInfo.Location = new System.Drawing.Point(9, 218);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(457, 397);
            this.grpBookInfo.TabIndex = 6;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Details";
            // 
            // nudEdition
            // 
            this.nudEdition.Enabled = false;
            this.nudEdition.Location = new System.Drawing.Point(95, 180);
            this.nudEdition.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudEdition.Name = "nudEdition";
            this.nudEdition.Size = new System.Drawing.Size(80, 20);
            this.nudEdition.TabIndex = 0;
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(95, 24);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(92, 20);
            this.txtBookID.TabIndex = 0;
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.ForeColor = System.Drawing.Color.Black;
            this.lblBookID.Location = new System.Drawing.Point(7, 27);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(49, 13);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Book ID:";
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.Enabled = false;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(95, 100);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(173, 21);
            this.cmbSubject.TabIndex = 0;
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.ForeColor = System.Drawing.Color.Black;
            this.lblSubject.Location = new System.Drawing.Point(8, 103);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(46, 13);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Subject:";
            // 
            // grpPublisherInfo
            // 
            this.grpPublisherInfo.Controls.Add(this.cmbCountry);
            this.grpPublisherInfo.Controls.Add(this.txtYearPub);
            this.grpPublisherInfo.Controls.Add(this.lblYearPublished);
            this.grpPublisherInfo.Controls.Add(this.lblPubCountry);
            this.grpPublisherInfo.Controls.Add(this.txtPName);
            this.grpPublisherInfo.Controls.Add(this.lblPublisherName);
            this.grpPublisherInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpPublisherInfo.Location = new System.Drawing.Point(9, 257);
            this.grpPublisherInfo.Name = "grpPublisherInfo";
            this.grpPublisherInfo.Size = new System.Drawing.Size(442, 102);
            this.grpPublisherInfo.TabIndex = 0;
            this.grpPublisherInfo.TabStop = false;
            this.grpPublisherInfo.Text = "Publisher Details";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.Enabled = false;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(86, 48);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(173, 21);
            this.cmbCountry.TabIndex = 0;
            // 
            // txtYearPub
            // 
            this.txtYearPub.Enabled = false;
            this.txtYearPub.Location = new System.Drawing.Point(86, 75);
            this.txtYearPub.MaxLength = 4;
            this.txtYearPub.Name = "txtYearPub";
            this.txtYearPub.Size = new System.Drawing.Size(92, 20);
            this.txtYearPub.TabIndex = 0;
            // 
            // lblYearPublished
            // 
            this.lblYearPublished.AutoSize = true;
            this.lblYearPublished.ForeColor = System.Drawing.Color.Black;
            this.lblYearPublished.Location = new System.Drawing.Point(6, 78);
            this.lblYearPublished.Name = "lblYearPublished";
            this.lblYearPublished.Size = new System.Drawing.Size(81, 13);
            this.lblYearPublished.TabIndex = 0;
            this.lblYearPublished.Text = "Year Published:";
            // 
            // lblPubCountry
            // 
            this.lblPubCountry.AutoSize = true;
            this.lblPubCountry.ForeColor = System.Drawing.Color.Black;
            this.lblPubCountry.Location = new System.Drawing.Point(6, 52);
            this.lblPubCountry.Name = "lblPubCountry";
            this.lblPubCountry.Size = new System.Drawing.Size(46, 13);
            this.lblPubCountry.TabIndex = 0;
            this.lblPubCountry.Text = "Country:";
            // 
            // txtPName
            // 
            this.txtPName.Enabled = false;
            this.txtPName.Location = new System.Drawing.Point(86, 23);
            this.txtPName.MaxLength = 35;
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(227, 20);
            this.txtPName.TabIndex = 0;
            // 
            // lblPublisherName
            // 
            this.lblPublisherName.AutoSize = true;
            this.lblPublisherName.ForeColor = System.Drawing.Color.Black;
            this.lblPublisherName.Location = new System.Drawing.Point(6, 26);
            this.lblPublisherName.Name = "lblPublisherName";
            this.lblPublisherName.Size = new System.Drawing.Size(38, 13);
            this.lblPublisherName.TabIndex = 0;
            this.lblPublisherName.Text = "Name:";
            // 
            // txtPages
            // 
            this.txtPages.Enabled = false;
            this.txtPages.Location = new System.Drawing.Point(95, 231);
            this.txtPages.MaxLength = 3;
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(94, 20);
            this.txtPages.TabIndex = 0;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.ForeColor = System.Drawing.Color.Black;
            this.lblPages.Location = new System.Drawing.Point(7, 234);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(72, 13);
            this.lblPages.TabIndex = 0;
            this.lblPages.Text = "No. of Pages:";
            // 
            // txtPrice
            // 
            this.txtPrice.Enabled = false;
            this.txtPrice.Location = new System.Drawing.Point(95, 205);
            this.txtPrice.MaxLength = 5;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(94, 20);
            this.txtPrice.TabIndex = 0;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(7, 208);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price:";
            // 
            // lblEdition
            // 
            this.lblEdition.AutoSize = true;
            this.lblEdition.ForeColor = System.Drawing.Color.Black;
            this.lblEdition.Location = new System.Drawing.Point(8, 182);
            this.lblEdition.Name = "lblEdition";
            this.lblEdition.Size = new System.Drawing.Size(42, 13);
            this.lblEdition.TabIndex = 0;
            this.lblEdition.Text = "Edition:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Location = new System.Drawing.Point(95, 153);
            this.txtAuthor.MaxLength = 35;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(186, 20);
            this.txtAuthor.TabIndex = 0;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(8, 156);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Enabled = false;
            this.txtTitle.Location = new System.Drawing.Point(95, 127);
            this.txtTitle.MaxLength = 110;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(257, 20);
            this.txtTitle.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(8, 130);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // txtISBN
            // 
            this.txtISBN.Enabled = false;
            this.txtISBN.Location = new System.Drawing.Point(95, 50);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(131, 20);
            this.txtISBN.TabIndex = 0;
            // 
            // lblIsbn
            // 
            this.lblIsbn.AutoSize = true;
            this.lblIsbn.ForeColor = System.Drawing.Color.Black;
            this.lblIsbn.Location = new System.Drawing.Point(8, 53);
            this.lblIsbn.Name = "lblIsbn";
            this.lblIsbn.Size = new System.Drawing.Size(35, 13);
            this.lblIsbn.TabIndex = 0;
            this.lblIsbn.Text = "ISBN:";
            // 
            // txtClassNo
            // 
            this.txtClassNo.Enabled = false;
            this.txtClassNo.Location = new System.Drawing.Point(95, 75);
            this.txtClassNo.MaxLength = 6;
            this.txtClassNo.Name = "txtClassNo";
            this.txtClassNo.Size = new System.Drawing.Size(111, 20);
            this.txtClassNo.TabIndex = 0;
            // 
            // lblClassNo
            // 
            this.lblClassNo.AutoSize = true;
            this.lblClassNo.ForeColor = System.Drawing.Color.Black;
            this.lblClassNo.Location = new System.Drawing.Point(8, 78);
            this.lblClassNo.Name = "lblClassNo";
            this.lblClassNo.Size = new System.Drawing.Size(52, 13);
            this.lblClassNo.TabIndex = 0;
            this.lblClassNo.Text = "Class No:";
            // 
            // frmRemoveBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 624);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.grpSearch);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRemoveBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Remove Book";
            this.Load += new System.EventHandler(this.frmRemoveBook_Load);
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookList)).EndInit();
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdition)).EndInit();
            this.grpPublisherInfo.ResumeLayout(false);
            this.grpPublisherInfo.PerformLayout();
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
        private System.Windows.Forms.TextBox txtSTitle;
        private System.Windows.Forms.Label lblSTitle;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.DataGridView grdBookList;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.NumericUpDown nudEdition;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.GroupBox grpPublisherInfo;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.TextBox txtYearPub;
        private System.Windows.Forms.Label lblYearPublished;
        private System.Windows.Forms.Label lblPubCountry;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEdition;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblIsbn;
        private System.Windows.Forms.TextBox txtClassNo;
        private System.Windows.Forms.Label lblClassNo;
    }
}