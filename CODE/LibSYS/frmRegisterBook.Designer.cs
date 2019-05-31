namespace LibSYS
{
    partial class frmRegisterBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegisterBook));
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBookInfo = new System.Windows.Forms.GroupBox();
            this.nudEdition = new System.Windows.Forms.NumericUpDown();
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.lblISBN = new System.Windows.Forms.Label();
            this.txtClassNo = new System.Windows.Forms.TextBox();
            this.lblClassNo = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblBookID = new System.Windows.Forms.Label();
            this.txtBookID = new System.Windows.Forms.TextBox();
            this.mnuRegMember.SuspendLayout();
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
            this.mnuRegMember.Size = new System.Drawing.Size(436, 25);
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
            // grpBookInfo
            // 
            this.grpBookInfo.Controls.Add(this.nudEdition);
            this.grpBookInfo.Controls.Add(this.cmbSubject);
            this.grpBookInfo.Controls.Add(this.lblSubject);
            this.grpBookInfo.Controls.Add(this.grpPublisherInfo);
            this.grpBookInfo.Controls.Add(this.txtPages);
            this.grpBookInfo.Controls.Add(this.lblPages);
            this.grpBookInfo.Controls.Add(this.txtPrice);
            this.grpBookInfo.Controls.Add(this.lblPrice);
            this.grpBookInfo.Controls.Add(this.label1);
            this.grpBookInfo.Controls.Add(this.txtAuthor);
            this.grpBookInfo.Controls.Add(this.lblAuthor);
            this.grpBookInfo.Controls.Add(this.txtTitle);
            this.grpBookInfo.Controls.Add(this.lblTitle);
            this.grpBookInfo.Controls.Add(this.txtISBN);
            this.grpBookInfo.Controls.Add(this.lblISBN);
            this.grpBookInfo.Controls.Add(this.txtClassNo);
            this.grpBookInfo.Controls.Add(this.lblClassNo);
            this.grpBookInfo.ForeColor = System.Drawing.Color.Blue;
            this.grpBookInfo.Location = new System.Drawing.Point(7, 65);
            this.grpBookInfo.Name = "grpBookInfo";
            this.grpBookInfo.Size = new System.Drawing.Size(422, 345);
            this.grpBookInfo.TabIndex = 1;
            this.grpBookInfo.TabStop = false;
            this.grpBookInfo.Text = "Enter Book Details";
            // 
            // nudEdition
            // 
            this.nudEdition.Location = new System.Drawing.Point(93, 151);
            this.nudEdition.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.nudEdition.Name = "nudEdition";
            this.nudEdition.Size = new System.Drawing.Size(76, 20);
            this.nudEdition.TabIndex = 7;
            // 
            // cmbSubject
            // 
            this.cmbSubject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(93, 73);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(196, 21);
            this.cmbSubject.TabIndex = 4;
            this.cmbSubject.SelectedIndexChanged += new System.EventHandler(this.cmbSubject_SelectedIndexChanged);
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.ForeColor = System.Drawing.Color.Black;
            this.lblSubject.Location = new System.Drawing.Point(6, 76);
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
            this.grpPublisherInfo.Location = new System.Drawing.Point(6, 229);
            this.grpPublisherInfo.Name = "grpPublisherInfo";
            this.grpPublisherInfo.Size = new System.Drawing.Size(410, 109);
            this.grpPublisherInfo.TabIndex = 10;
            this.grpPublisherInfo.TabStop = false;
            this.grpPublisherInfo.Text = "Publisher Details";
            // 
            // cmbCountry
            // 
            this.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCountry.FormattingEnabled = true;
            this.cmbCountry.Location = new System.Drawing.Point(86, 48);
            this.cmbCountry.Name = "cmbCountry";
            this.cmbCountry.Size = new System.Drawing.Size(194, 21);
            this.cmbCountry.TabIndex = 12;
            this.cmbCountry.SelectedIndexChanged += new System.EventHandler(this.cmbCountry_SelectedIndexChanged);
            // 
            // txtYearPub
            // 
            this.txtYearPub.Location = new System.Drawing.Point(86, 75);
            this.txtYearPub.MaxLength = 4;
            this.txtYearPub.Name = "txtYearPub";
            this.txtYearPub.Size = new System.Drawing.Size(92, 20);
            this.txtYearPub.TabIndex = 13;
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
            this.txtPName.Location = new System.Drawing.Point(86, 23);
            this.txtPName.MaxLength = 35;
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(227, 20);
            this.txtPName.TabIndex = 11;
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
            this.txtPages.Location = new System.Drawing.Point(93, 203);
            this.txtPages.MaxLength = 4;
            this.txtPages.Name = "txtPages";
            this.txtPages.Size = new System.Drawing.Size(94, 20);
            this.txtPages.TabIndex = 9;
            // 
            // lblPages
            // 
            this.lblPages.AutoSize = true;
            this.lblPages.ForeColor = System.Drawing.Color.Black;
            this.lblPages.Location = new System.Drawing.Point(6, 206);
            this.lblPages.Name = "lblPages";
            this.lblPages.Size = new System.Drawing.Size(72, 13);
            this.lblPages.TabIndex = 0;
            this.lblPages.Text = "No. of Pages:";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(93, 177);
            this.txtPrice.MaxLength = 6;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(94, 20);
            this.txtPrice.TabIndex = 8;
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.Black;
            this.lblPrice.Location = new System.Drawing.Point(6, 180);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(34, 13);
            this.lblPrice.TabIndex = 0;
            this.lblPrice.Text = "Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edition:";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(93, 125);
            this.txtAuthor.MaxLength = 35;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(186, 20);
            this.txtAuthor.TabIndex = 6;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.ForeColor = System.Drawing.Color.Black;
            this.lblAuthor.Location = new System.Drawing.Point(6, 128);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(41, 13);
            this.lblAuthor.TabIndex = 0;
            this.lblAuthor.Text = "Author:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(93, 99);
            this.txtTitle.MaxLength = 110;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(285, 20);
            this.txtTitle.TabIndex = 5;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(6, 102);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(30, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(93, 22);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(124, 20);
            this.txtISBN.TabIndex = 2;
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
            this.txtClassNo.Location = new System.Drawing.Point(93, 47);
            this.txtClassNo.MaxLength = 7;
            this.txtClassNo.Name = "txtClassNo";
            this.txtClassNo.Size = new System.Drawing.Size(111, 20);
            this.txtClassNo.TabIndex = 3;
            // 
            // lblClassNo
            // 
            this.lblClassNo.AutoSize = true;
            this.lblClassNo.ForeColor = System.Drawing.Color.Black;
            this.lblClassNo.Location = new System.Drawing.Point(6, 50);
            this.lblClassNo.Name = "lblClassNo";
            this.lblClassNo.Size = new System.Drawing.Size(52, 13);
            this.lblClassNo.TabIndex = 0;
            this.lblClassNo.Text = "Class No:";
            // 
            // btnRegister
            // 
            this.btnRegister.ForeColor = System.Drawing.Color.Black;
            this.btnRegister.Location = new System.Drawing.Point(335, 416);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(94, 23);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblBookID
            // 
            this.lblBookID.AutoSize = true;
            this.lblBookID.Location = new System.Drawing.Point(10, 39);
            this.lblBookID.Name = "lblBookID";
            this.lblBookID.Size = new System.Drawing.Size(49, 13);
            this.lblBookID.TabIndex = 0;
            this.lblBookID.Text = "Book ID:";
            // 
            // txtBookID
            // 
            this.txtBookID.Enabled = false;
            this.txtBookID.Location = new System.Drawing.Point(65, 36);
            this.txtBookID.Name = "txtBookID";
            this.txtBookID.Size = new System.Drawing.Size(73, 20);
            this.txtBookID.TabIndex = 0;
            // 
            // frmRegisterBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 445);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtBookID);
            this.Controls.Add(this.lblBookID);
            this.Controls.Add(this.grpBookInfo);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRegisterBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register Book";
            this.Load += new System.EventHandler(this.frmRegisterBook_Load);
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
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
        private System.Windows.Forms.GroupBox grpBookInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.TextBox txtClassNo;
        private System.Windows.Forms.Label lblClassNo;
        private System.Windows.Forms.GroupBox grpPublisherInfo;
        private System.Windows.Forms.TextBox txtPages;
        private System.Windows.Forms.Label lblPages;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.TextBox txtYearPub;
        private System.Windows.Forms.Label lblYearPublished;
        private System.Windows.Forms.Label lblPubCountry;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.Label lblPublisherName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label lblBookID;
        private System.Windows.Forms.TextBox txtBookID;
        private System.Windows.Forms.ComboBox cmbCountry;
        private System.Windows.Forms.ComboBox cmbSubject;
        private System.Windows.Forms.Label lblSubject;
        private System.Windows.Forms.NumericUpDown nudEdition;
    }
}