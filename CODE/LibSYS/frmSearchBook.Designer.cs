namespace LibSYS
{
    partial class frmSearchBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchBook));
            this.grpOptions = new System.Windows.Forms.GroupBox();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.radUnavailable = new System.Windows.Forms.RadioButton();
            this.radAvailable = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.grpOtherOpt = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpSearchOpt = new System.Windows.Forms.GroupBox();
            this.grpOrderBy = new System.Windows.Forms.GroupBox();
            this.radSubject = new System.Windows.Forms.RadioButton();
            this.radBookID = new System.Windows.Forms.RadioButton();
            this.radTitle = new System.Windows.Forms.RadioButton();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grdBookList = new System.Windows.Forms.DataGridView();
            this.grpOptions.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpOtherOpt.SuspendLayout();
            this.grpSearchOpt.SuspendLayout();
            this.grpOrderBy.SuspendLayout();
            this.mnuRegMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // grpOptions
            // 
            this.grpOptions.Controls.Add(this.grpFilter);
            this.grpOptions.Controls.Add(this.grpOtherOpt);
            this.grpOptions.Controls.Add(this.grpSearchOpt);
            this.grpOptions.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.grpOptions.Location = new System.Drawing.Point(12, 369);
            this.grpOptions.Name = "grpOptions";
            this.grpOptions.Size = new System.Drawing.Size(554, 187);
            this.grpOptions.TabIndex = 1;
            this.grpOptions.TabStop = false;
            this.grpOptions.Text = "Options";
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.radUnavailable);
            this.grpFilter.Controls.Add(this.radAvailable);
            this.grpFilter.Controls.Add(this.radAll);
            this.grpFilter.ForeColor = System.Drawing.Color.Blue;
            this.grpFilter.Location = new System.Drawing.Point(342, 20);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(206, 94);
            this.grpFilter.TabIndex = 9;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter";
            // 
            // radUnavailable
            // 
            this.radUnavailable.AutoSize = true;
            this.radUnavailable.ForeColor = System.Drawing.Color.Black;
            this.radUnavailable.Location = new System.Drawing.Point(7, 67);
            this.radUnavailable.Name = "radUnavailable";
            this.radUnavailable.Size = new System.Drawing.Size(81, 17);
            this.radUnavailable.TabIndex = 2;
            this.radUnavailable.Text = "Unavailable";
            this.radUnavailable.UseVisualStyleBackColor = true;
            this.radUnavailable.Click += new System.EventHandler(this.radUnavailable_Click);
            // 
            // radAvailable
            // 
            this.radAvailable.AutoSize = true;
            this.radAvailable.ForeColor = System.Drawing.Color.Black;
            this.radAvailable.Location = new System.Drawing.Point(7, 43);
            this.radAvailable.Name = "radAvailable";
            this.radAvailable.Size = new System.Drawing.Size(68, 17);
            this.radAvailable.TabIndex = 1;
            this.radAvailable.Text = "Available";
            this.radAvailable.UseVisualStyleBackColor = true;
            this.radAvailable.Click += new System.EventHandler(this.radAvailable_Click);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.ForeColor = System.Drawing.Color.Black;
            this.radAll.Location = new System.Drawing.Point(7, 19);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(36, 17);
            this.radAll.TabIndex = 0;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.Click += new System.EventHandler(this.radAll_Click);
            // 
            // grpOtherOpt
            // 
            this.grpOtherOpt.Controls.Add(this.btnClear);
            this.grpOtherOpt.Controls.Add(this.btnPrint);
            this.grpOtherOpt.ForeColor = System.Drawing.Color.Blue;
            this.grpOtherOpt.Location = new System.Drawing.Point(342, 120);
            this.grpOtherOpt.Name = "grpOtherOpt";
            this.grpOtherOpt.Size = new System.Drawing.Size(206, 59);
            this.grpOtherOpt.TabIndex = 8;
            this.grpOtherOpt.TabStop = false;
            this.grpOtherOpt.Text = "Other Options";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(6, 27);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(80, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Reset UI";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(92, 27);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(80, 23);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpSearchOpt
            // 
            this.grpSearchOpt.Controls.Add(this.grpOrderBy);
            this.grpSearchOpt.Controls.Add(this.btnSearch);
            this.grpSearchOpt.Controls.Add(this.lblTitle);
            this.grpSearchOpt.Controls.Add(this.txtTitle);
            this.grpSearchOpt.ForeColor = System.Drawing.Color.Blue;
            this.grpSearchOpt.Location = new System.Drawing.Point(6, 20);
            this.grpSearchOpt.Name = "grpSearchOpt";
            this.grpSearchOpt.Size = new System.Drawing.Size(330, 159);
            this.grpSearchOpt.TabIndex = 2;
            this.grpSearchOpt.TabStop = false;
            this.grpSearchOpt.Text = "Search Option";
            // 
            // grpOrderBy
            // 
            this.grpOrderBy.Controls.Add(this.radSubject);
            this.grpOrderBy.Controls.Add(this.radBookID);
            this.grpOrderBy.Controls.Add(this.radTitle);
            this.grpOrderBy.ForeColor = System.Drawing.Color.Blue;
            this.grpOrderBy.Location = new System.Drawing.Point(6, 55);
            this.grpOrderBy.Name = "grpOrderBy";
            this.grpOrderBy.Size = new System.Drawing.Size(167, 95);
            this.grpOrderBy.TabIndex = 8;
            this.grpOrderBy.TabStop = false;
            this.grpOrderBy.Text = "Order By";
            // 
            // radSubject
            // 
            this.radSubject.AutoSize = true;
            this.radSubject.ForeColor = System.Drawing.Color.Black;
            this.radSubject.Location = new System.Drawing.Point(6, 66);
            this.radSubject.Name = "radSubject";
            this.radSubject.Size = new System.Drawing.Size(61, 17);
            this.radSubject.TabIndex = 6;
            this.radSubject.Text = "Subject";
            this.radSubject.UseVisualStyleBackColor = true;
            // 
            // radBookID
            // 
            this.radBookID.AutoSize = true;
            this.radBookID.Checked = true;
            this.radBookID.ForeColor = System.Drawing.Color.Black;
            this.radBookID.Location = new System.Drawing.Point(6, 20);
            this.radBookID.Name = "radBookID";
            this.radBookID.Size = new System.Drawing.Size(64, 17);
            this.radBookID.TabIndex = 4;
            this.radBookID.TabStop = true;
            this.radBookID.Text = "Book ID";
            this.radBookID.UseVisualStyleBackColor = true;
            // 
            // radTitle
            // 
            this.radTitle.AutoSize = true;
            this.radTitle.ForeColor = System.Drawing.Color.Black;
            this.radTitle.Location = new System.Drawing.Point(6, 43);
            this.radTitle.Name = "radTitle";
            this.radTitle.Size = new System.Drawing.Size(45, 17);
            this.radTitle.TabIndex = 5;
            this.radTitle.Text = "Title";
            this.radTitle.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(244, 127);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(9, 28);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(58, 13);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Book Title:";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(73, 25);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(247, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(578, 25);
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
            // grdBookList
            // 
            this.grdBookList.AllowUserToAddRows = false;
            this.grdBookList.AllowUserToDeleteRows = false;
            this.grdBookList.AllowUserToResizeRows = false;
            this.grdBookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdBookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookList.Location = new System.Drawing.Point(12, 35);
            this.grdBookList.Name = "grdBookList";
            this.grdBookList.ReadOnly = true;
            this.grdBookList.RowHeadersWidth = 35;
            this.grdBookList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBookList.Size = new System.Drawing.Size(554, 328);
            this.grdBookList.TabIndex = 0;
            // 
            // frmSearchBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 562);
            this.Controls.Add(this.grdBookList);
            this.Controls.Add(this.grpOptions);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSearchBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Search Book";
            this.Load += new System.EventHandler(this.frmSearchBook_Load);
            this.grpOptions.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpOtherOpt.ResumeLayout(false);
            this.grpSearchOpt.ResumeLayout(false);
            this.grpSearchOpt.PerformLayout();
            this.grpOrderBy.ResumeLayout(false);
            this.grpOrderBy.PerformLayout();
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOptions;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataGridView grdBookList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.RadioButton radSubject;
        private System.Windows.Forms.RadioButton radTitle;
        private System.Windows.Forms.GroupBox grpSearchOpt;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.RadioButton radBookID;
        private System.Windows.Forms.GroupBox grpOtherOpt;
        private System.Windows.Forms.GroupBox grpOrderBy;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.RadioButton radUnavailable;
        private System.Windows.Forms.RadioButton radAvailable;
        private System.Windows.Forms.RadioButton radAll;
    }
}