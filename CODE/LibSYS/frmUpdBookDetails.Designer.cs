namespace LibSYS
{
    partial class frmUpdBookDetails
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.cmbCondition = new System.Windows.Forms.ComboBox();
            this.lblCondition = new System.Windows.Forms.Label();
            this.grpPublisherInfo = new System.Windows.Forms.GroupBox();
            this.txtYearPublished = new System.Windows.Forms.TextBox();
            this.lblYearPublished = new System.Windows.Forms.Label();
            this.txtPublisherAddress = new System.Windows.Forms.TextBox();
            this.lblPublisherAddress = new System.Windows.Forms.Label();
            this.txtPublisherName = new System.Windows.Forms.TextBox();
            this.lblPublisherName = new System.Windows.Forms.Label();
            this.txtPages = new System.Windows.Forms.TextBox();
            this.lblPages = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.lblPrice = new System.Windows.Forms.Label();
            this.txtEdition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpPurchaseDate = new System.Windows.Forms.DateTimePicker();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtClassNo = new System.Windows.Forms.TextBox();
            this.lblClassNo = new System.Windows.Forms.Label();
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBookInfo.SuspendLayout();
            this.grpPublisherInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.mnuRegMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(442, 466);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(109, 23);
            this.btnUpdate.TabIndex = 0;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.cmbCondition);
            this.grpBookInfo.Controls.Add(this.lblCondition);
            this.grpBookInfo.Controls.Add(this.grpPublisherInfo);
            this.grpBookInfo.Controls.Add(this.txtPages);
            this.grpBookInfo.Controls.Add(this.lblPages);
            this.grpBookInfo.Controls.Add(this.numQuantity);
            this.grpBookInfo.Controls.Add(this.txtPrice);
            this.grpBookInfo.Controls.Add(this.lblPrice);
            this.grpBookInfo.Controls.Add(this.txtEdition);
            this.grpBookInfo.Controls.Add(this.label1);
            this.grpBookInfo.Controls.Add(this.dtpPurchaseDate);
            this.grpBookInfo.Controls.Add(this.lblPurchaseDate);
            this.grpBookInfo.Controls.Add(this.lblQuantity);
            this.grpBookInfo.Controls.Add(this.txtAuthor);
            this.grpBookInfo.Controls.Add(this.lblAuthor);
            this.grpBookInfo.Controls.Add(this.cmbCategory);
            this.grpBookInfo.Controls.Add(this.lblCategory);
            this.grpBookInfo.Controls.Add(this.txtTitle);
            this.grpBookInfo.Controls.Add(this.lblTitle);
            this.grpBookInfo.Controls.Add(this.txtISBN);
            this.grpBookInfo.Controls.Add(this.lblISBN);
            this.grpBookInfo.Controls.Add(this.txtClassNo);
            this.grpBookInfo.Controls.Add(this.lblClassNo);
            this.grpBookInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpBookInfo.Location = new System.Drawing.Point(4, 28);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(547, 432);
            this.grpBookInfo.TabIndex = 3;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Book Details";
            // 
            // cmbCondition
            // 
            this.cmbCondition.FormattingEnabled = true;
            this.cmbCondition.Items.AddRange(new object[] {
            "New",
            "Old"});
            this.cmbCondition.Location = new System.Drawing.Point(93, 401);
            this.cmbCondition.Name = "cmbCondition";
            this.cmbCondition.Size = new System.Drawing.Size(111, 21);
            this.cmbCondition.TabIndex = 15;
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.ForeColor = System.Drawing.Color.Black;
            this.lblCondition.Location = new System.Drawing.Point(6, 404);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(54, 13);
            this.lblCondition.TabIndex = 0;
            this.lblCondition.Text = "Condition:";
            // 
            // grpPublisherInfo
            // 
            this.grpPublisherInfo.Controls.Add(this.txtYearPublished);
            this.grpPublisherInfo.Controls.Add(this.lblYearPublished);
            this.grpPublisherInfo.Controls.Add(this.txtPublisherAddress);
            this.grpPublisherInfo.Controls.Add(this.lblPublisherAddress);
            this.grpPublisherInfo.Controls.Add(this.txtPublisherName);
            this.grpPublisherInfo.Controls.Add(this.lblPublisherName);
            this.grpPublisherInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpPublisherInfo.Location = new System.Drawing.Point(6, 289);
            this.grpPublisherInfo.Name = "grpPublisherInfo";
            this.grpPublisherInfo.Size = new System.Drawing.Size(528, 106);
            this.grpPublisherInfo.TabIndex = 11;
            this.grpPublisherInfo.TabStop = false;
            this.grpPublisherInfo.Text = "Publisher Details";
            // 
            // txtYearPublished
            // 
            this.txtYearPublished.Location = new System.Drawing.Point(86, 75);
            this.txtYearPublished.Name = "txtYearPublished";
            this.txtYearPublished.Size = new System.Drawing.Size(92, 20);
            this.txtYearPublished.TabIndex = 14;
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
            // txtPublisherAddress
            // 
            this.txtPublisherAddress.Location = new System.Drawing.Point(86, 49);
            this.txtPublisherAddress.Name = "txtPublisherAddress";
            this.txtPublisherAddress.Size = new System.Drawing.Size(355, 20);
            this.txtPublisherAddress.TabIndex = 13;
            // 
            // lblPublisherAddress
            // 
            this.lblPublisherAddress.AutoSize = true;
            this.lblPublisherAddress.ForeColor = System.Drawing.Color.Black;
            this.lblPublisherAddress.Location = new System.Drawing.Point(6, 52);
            this.lblPublisherAddress.Name = "lblPublisherAddress";
            this.lblPublisherAddress.Size = new System.Drawing.Size(48, 13);
            this.lblPublisherAddress.TabIndex = 0;
            this.lblPublisherAddress.Text = "Address:";
            // 
            // txtPublisherName
            // 
            this.txtPublisherName.Location = new System.Drawing.Point(86, 23);
            this.txtPublisherName.Name = "txtPublisherName";
            this.txtPublisherName.Size = new System.Drawing.Size(297, 20);
            this.txtPublisherName.TabIndex = 12;
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
            this.txtPages.Location = new System.Drawing.Point(93, 259);
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(111, 20);
            this.txtPages.TabIndex = 10;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.ForeColor = System.Drawing.Color.Black;
            this.lblPages.Location = new System.Drawing.Point(6, 262);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(72, 13);
            this.lblPages.TabIndex = 0;
            this.lblPages.Text = "No. of Pages:";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(93, 156);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(72, 20);
            this.numQuantity.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(93, 233);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(111, 20);
            this.txtPrice.TabIndex = 9;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(6, 236);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price:";
            // 
            // txtEdition
            // 
            this.txtEdition.Location = new System.Drawing.Point(93, 207);
            this.txtEdition.Name = "txtEdition";
            this.txtEdition.Size = new System.Drawing.Size(111, 20);
            this.txtEdition.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edition:";
            // 
            // dtpPurchaseDate
            // 
            this.dtpPurchaseDate.Location = new System.Drawing.Point(93, 182);
            this.dtpPurchaseDate.Name = "dtpPurchaseDate";
            this.dtpPurchaseDate.Size = new System.Drawing.Size(146, 20);
            this.dtpPurchaseDate.TabIndex = 7;
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.ForeColor = System.Drawing.Color.Black;
            this.lblPurchaseDate.Location = new System.Drawing.Point(6, 185);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(81, 13);
            this.lblPurchaseDate.TabIndex = 0;
            this.lblPurchaseDate.Text = "Purchase Date:";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.ForeColor = System.Drawing.Color.Black;
            this.lblQuantity.Location = new System.Drawing.Point(6, 159);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(49, 13);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(93, 130);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(398, 20);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(6, 133);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author:";
            // 
            // cmbCategory
            // 
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "I.T",
            "Health",
            "Science",
            "History",
            "Math",
            "Dictionaries",
            "Encyclopedias",
            "Computer Science",
            "Autobiographies",
            "Art",
            "Others"});
            this.cmbCategory.Location = new System.Drawing.Point(93, 103);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(146, 21);
            this.cmbCategory.TabIndex = 4;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.ForeColor = System.Drawing.Color.Black;
            this.lblCategory.Location = new System.Drawing.Point(6, 106);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(52, 13);
            this.lblCategory.TabIndex = 4;
            this.lblCategory.Text = "Category:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(93, 77);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(398, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(6, 80);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(93, 22);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(111, 20);
            this.txtISBN.TabIndex = 1;
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.ForeColor = System.Drawing.Color.Black;
            this.lblISBN.Location = new System.Drawing.Point(6, 25);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(35, 13);
            this.lblISBN.TabIndex = 0;
            this.lblISBN.Text = "ISBN:";
            // 
            // txtClassNo
            // 
            this.txtClassNo.Location = new System.Drawing.Point(93, 51);
            this.txtClassNo.Name = "txtClassNo";
            this.txtClassNo.Size = new System.Drawing.Size(111, 20);
            this.txtClassNo.TabIndex = 2;
            // 
            // lblClassNo
            // 
            this.lblClassNo.AutoSize = true;
            this.lblClassNo.ForeColor = System.Drawing.Color.Black;
            this.lblClassNo.Location = new System.Drawing.Point(6, 54);
            this.lblClassNo.Name = "lblClassNo";
            this.lblClassNo.Size = new System.Drawing.Size(52, 13);
            this.lblClassNo.TabIndex = 0;
            this.lblClassNo.Text = "Class No:";
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(560, 25);
            this.mnuRegMember.TabIndex = 4;
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
            // frmUpdBookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 498);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.mnuRegMember);
            this.Name = "frmUpdBookDetails";
            this.Text = "Update Book Details";
            this.grpBookInfo.ResumeLayout(false);
            this.grpBookInfo.PerformLayout();
            this.grpPublisherInfo.ResumeLayout(false);
            this.grpPublisherInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.ComboBox cmbCondition;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.GroupBox grpPublisherInfo;
        private System.Windows.Forms.TextBox txtYearPublished;
        private System.Windows.Forms.Label lblYearPublished;
        private System.Windows.Forms.TextBox txtPublisherAddress;
        private System.Windows.Forms.Label lblPublisherAddress;
        private System.Windows.Forms.TextBox txtPublisherName;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtEdition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpPurchaseDate;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtClassNo;
        private System.Windows.Forms.Label lblClassNo;
        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
    }
}