namespace LibSYS
{
    partial class frmMainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.mnuMainMenu = new System.Windows.Forms.MenuStrip();
            this.mnuMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDeRegMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuListMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuViewMember = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRegisterBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRemoveBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUpdateBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBorrowBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFinance = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRecordFine = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRevenue = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.lblTime = new System.Windows.Forms.Label();
            this.tmrDateTime = new System.Windows.Forms.Timer(this.components);
            this.picImage = new System.Windows.Forms.PictureBox();
            this.mnuMainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuMainMenu
            // 
            this.mnuMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMembers,
            this.mnuBooks,
            this.mnuLoans,
            this.mnuFinance,
            this.mnuExit});
            this.mnuMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMainMenu.Name = "mnuMainMenu";
            this.mnuMainMenu.Size = new System.Drawing.Size(396, 24);
            this.mnuMainMenu.TabIndex = 0;
            this.mnuMainMenu.Text = "Main Menu Strip";
            // 
            // mnuMembers
            // 
            this.mnuMembers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegMember,
            this.mnuDeRegMember,
            this.mnuUpdMember,
            this.mnuListMember,
            this.mnuViewMember});
            this.mnuMembers.Name = "mnuMembers";
            this.mnuMembers.Size = new System.Drawing.Size(69, 20);
            this.mnuMembers.Text = "Members";
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(188, 22);
            this.mnuRegMember.Text = "Register Member";
            this.mnuRegMember.Click += new System.EventHandler(this.mnuRegMember_Click);
            // 
            // mnuDeRegMember
            // 
            this.mnuDeRegMember.Name = "mnuDeRegMember";
            this.mnuDeRegMember.Size = new System.Drawing.Size(188, 22);
            this.mnuDeRegMember.Text = "De-register Member";
            this.mnuDeRegMember.Click += new System.EventHandler(this.mnuDeRegMember_Click);
            // 
            // mnuUpdMember
            // 
            this.mnuUpdMember.Name = "mnuUpdMember";
            this.mnuUpdMember.Size = new System.Drawing.Size(188, 22);
            this.mnuUpdMember.Text = "Update Member";
            this.mnuUpdMember.Click += new System.EventHandler(this.mnuUpdMember_Click);
            // 
            // mnuListMember
            // 
            this.mnuListMember.Name = "mnuListMember";
            this.mnuListMember.Size = new System.Drawing.Size(188, 22);
            this.mnuListMember.Text = "List Members";
            this.mnuListMember.Click += new System.EventHandler(this.mnuListMember_Click);
            // 
            // mnuViewMember
            // 
            this.mnuViewMember.Name = "mnuViewMember";
            this.mnuViewMember.Size = new System.Drawing.Size(188, 22);
            this.mnuViewMember.Text = "View Member History";
            this.mnuViewMember.Click += new System.EventHandler(this.mnuViewMember_Click);
            // 
            // mnuBooks
            // 
            this.mnuBooks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRegisterBook,
            this.mnuRemoveBook,
            this.mnuUpdateBook,
            this.mnuSearchBook});
            this.mnuBooks.Name = "mnuBooks";
            this.mnuBooks.Size = new System.Drawing.Size(51, 20);
            this.mnuBooks.Text = "Books";
            // 
            // mnuRegisterBook
            // 
            this.mnuRegisterBook.Name = "mnuRegisterBook";
            this.mnuRegisterBook.Size = new System.Drawing.Size(147, 22);
            this.mnuRegisterBook.Text = "Register Book";
            this.mnuRegisterBook.Click += new System.EventHandler(this.mnuRegisterBook_Click);
            // 
            // mnuRemoveBook
            // 
            this.mnuRemoveBook.Name = "mnuRemoveBook";
            this.mnuRemoveBook.Size = new System.Drawing.Size(147, 22);
            this.mnuRemoveBook.Text = "Remove Book";
            this.mnuRemoveBook.Click += new System.EventHandler(this.mnuRemoveBook_Click);
            // 
            // mnuUpdateBook
            // 
            this.mnuUpdateBook.Name = "mnuUpdateBook";
            this.mnuUpdateBook.Size = new System.Drawing.Size(147, 22);
            this.mnuUpdateBook.Text = "Update Book";
            this.mnuUpdateBook.Click += new System.EventHandler(this.mnuUpdateBook_Click);
            // 
            // mnuSearchBook
            // 
            this.mnuSearchBook.Name = "mnuSearchBook";
            this.mnuSearchBook.Size = new System.Drawing.Size(147, 22);
            this.mnuSearchBook.Text = "Search Book";
            this.mnuSearchBook.Click += new System.EventHandler(this.mnuSearchBook_Click);
            // 
            // mnuLoans
            // 
            this.mnuLoans.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuBorrowBook,
            this.mnuReturnBook});
            this.mnuLoans.Name = "mnuLoans";
            this.mnuLoans.Size = new System.Drawing.Size(50, 20);
            this.mnuLoans.Text = "Loans";
            // 
            // mnuBorrowBook
            // 
            this.mnuBorrowBook.Name = "mnuBorrowBook";
            this.mnuBorrowBook.Size = new System.Drawing.Size(142, 22);
            this.mnuBorrowBook.Text = "Borrow Book";
            this.mnuBorrowBook.Click += new System.EventHandler(this.mnuBorrowBook_Click);
            // 
            // mnuReturnBook
            // 
            this.mnuReturnBook.Name = "mnuReturnBook";
            this.mnuReturnBook.Size = new System.Drawing.Size(142, 22);
            this.mnuReturnBook.Text = "Return Book";
            this.mnuReturnBook.Click += new System.EventHandler(this.mnuReturnBook_Click);
            // 
            // mnuFinance
            // 
            this.mnuFinance.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRecordFine,
            this.mnuRevenue});
            this.mnuFinance.Name = "mnuFinance";
            this.mnuFinance.Size = new System.Drawing.Size(60, 20);
            this.mnuFinance.Text = "Finance";
            // 
            // mnuRecordFine
            // 
            this.mnuRecordFine.Name = "mnuRecordFine";
            this.mnuRecordFine.Size = new System.Drawing.Size(165, 22);
            this.mnuRecordFine.Text = "Update Fine";
            this.mnuRecordFine.Click += new System.EventHandler(this.mnuRecordFine_Click);
            // 
            // mnuRevenue
            // 
            this.mnuRevenue.Name = "mnuRevenue";
            this.mnuRevenue.Size = new System.Drawing.Size(165, 22);
            this.mnuRevenue.Text = "Revenue Analysis";
            this.mnuRevenue.Click += new System.EventHandler(this.mnuRevenue_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(37, 20);
            this.mnuExit.Text = "Exit";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(9, 282);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(53, 13);
            this.lblTime.TabIndex = 1;
            this.lblTime.Text = "DateTime";
            // 
            // tmrDateTime
            // 
            this.tmrDateTime.Interval = 1000;
            this.tmrDateTime.Tick += new System.EventHandler(this.tmrDateTime_Tick);
            // 
            // picImage
            // 
            this.picImage.Image = ((System.Drawing.Image)(resources.GetObject("picImage.Image")));
            this.picImage.Location = new System.Drawing.Point(12, 37);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(372, 129);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picImage.TabIndex = 2;
            this.picImage.TabStop = false;
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 304);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.mnuMainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMainMenu;
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.mnuMainMenu.ResumeLayout(false);
            this.mnuMainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuMembers;
        private System.Windows.Forms.ToolStripMenuItem mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuDeRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdMember;
        private System.Windows.Forms.ToolStripMenuItem mnuListMember;
        private System.Windows.Forms.ToolStripMenuItem mnuViewMember;
        private System.Windows.Forms.ToolStripMenuItem mnuBooks;
        private System.Windows.Forms.ToolStripMenuItem mnuLoans;
        private System.Windows.Forms.ToolStripMenuItem mnuFinance;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuRegisterBook;
        private System.Windows.Forms.ToolStripMenuItem mnuRemoveBook;
        private System.Windows.Forms.ToolStripMenuItem mnuUpdateBook;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchBook;
        private System.Windows.Forms.ToolStripMenuItem mnuBorrowBook;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnBook;
        private System.Windows.Forms.ToolStripMenuItem mnuRecordFine;
        private System.Windows.Forms.ToolStripMenuItem mnuRevenue;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Timer tmrDateTime;
        private System.Windows.Forms.PictureBox picImage;
    }
}

