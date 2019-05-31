namespace LibSYS
{
    partial class frmViewMembersHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewMembersHistory));
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.grdMemberList = new System.Windows.Forms.DataGridView();
            this.txtForename = new System.Windows.Forms.TextBox();
            this.lblForename = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.lblSurname = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpLoanItems = new System.Windows.Forms.GroupBox();
            this.lblMemName = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.grdLoanList = new System.Windows.Forms.DataGridView();
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberList)).BeginInit();
            this.grpLoanItems.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoanList)).BeginInit();
            this.mnuRegMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.grdMemberList);
            this.grpSearch.Controls.Add(this.txtForename);
            this.grpSearch.Controls.Add(this.lblForename);
            this.grpSearch.Controls.Add(this.btnClear);
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.txtSurname);
            this.grpSearch.Controls.Add(this.lblSurname);
            this.grpSearch.ForeColor = System.Drawing.Color.Black;
            this.grpSearch.Location = new System.Drawing.Point(5, 28);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(536, 193);
            this.grpSearch.TabIndex = 1;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Search";
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMemberList.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdMemberList.Location = new System.Drawing.Point(9, 77);
            this.grdMemberList.Name = "grdMemberList";
            this.grdMemberList.ReadOnly = true;
            this.grdMemberList.RowHeadersWidth = 35;
            this.grdMemberList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMemberList.Size = new System.Drawing.Size(515, 110);
            this.grdMemberList.TabIndex = 0;
            this.grdMemberList.Visible = false;
            this.grdMemberList.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMemberList_CellClick);
            // 
            // txtForename
            // 
            this.txtForename.Location = new System.Drawing.Point(69, 47);
            this.txtForename.Name = "txtForename";
            this.txtForename.Size = new System.Drawing.Size(132, 20);
            this.txtForename.TabIndex = 3;
            // 
            // lblForename
            // 
            this.lblForename.AutoSize = true;
            this.lblForename.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForename.ForeColor = System.Drawing.Color.Black;
            this.lblForename.Location = new System.Drawing.Point(6, 50);
            this.lblForename.Name = "lblForename";
            this.lblForename.Size = new System.Drawing.Size(57, 13);
            this.lblForename.TabIndex = 0;
            this.lblForename.Text = "Forename:";
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.Color.Black;
            this.btnClear.Location = new System.Drawing.Point(441, 48);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(352, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(83, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSurname
            // 
            this.txtSurname.Location = new System.Drawing.Point(69, 22);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(132, 20);
            this.txtSurname.TabIndex = 2;
            // 
            // lblSurname
            // 
            this.lblSurname.AutoSize = true;
            this.lblSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSurname.ForeColor = System.Drawing.Color.Black;
            this.lblSurname.Location = new System.Drawing.Point(6, 25);
            this.lblSurname.Name = "lblSurname";
            this.lblSurname.Size = new System.Drawing.Size(52, 13);
            this.lblSurname.TabIndex = 0;
            this.lblSurname.Text = "Surname:";
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(441, 323);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(83, 23);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpLoanItems
            // 
            this.grpLoanItems.Controls.Add(this.lblMemName);
            this.grpLoanItems.Controls.Add(this.lblName);
            this.grpLoanItems.Controls.Add(this.grdLoanList);
            this.grpLoanItems.Controls.Add(this.btnPrint);
            this.grpLoanItems.ForeColor = System.Drawing.Color.Black;
            this.grpLoanItems.Location = new System.Drawing.Point(5, 227);
            this.grpLoanItems.Name = "grpLoanItems";
            this.grpLoanItems.Size = new System.Drawing.Size(536, 352);
            this.grpLoanItems.TabIndex = 6;
            this.grpLoanItems.TabStop = false;
            this.grpLoanItems.Text = "Book Rented History";
            this.grpLoanItems.Visible = false;
            // 
            // lblMemName
            // 
            this.lblMemName.AutoSize = true;
            this.lblMemName.ForeColor = System.Drawing.Color.Black;
            this.lblMemName.Location = new System.Drawing.Point(53, 25);
            this.lblMemName.Name = "lblMemName";
            this.lblMemName.Size = new System.Drawing.Size(73, 13);
            this.lblMemName.TabIndex = 0;
            this.lblMemName.Text = "MemberName";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(6, 25);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name: ";
            // 
            // grdLoanList
            // 
            this.grdLoanList.AllowUserToAddRows = false;
            this.grdLoanList.AllowUserToDeleteRows = false;
            this.grdLoanList.AllowUserToResizeRows = false;
            this.grdLoanList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdLoanList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdLoanList.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdLoanList.Location = new System.Drawing.Point(9, 46);
            this.grdLoanList.Name = "grdLoanList";
            this.grdLoanList.ReadOnly = true;
            this.grdLoanList.RowHeadersWidth = 35;
            this.grdLoanList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdLoanList.Size = new System.Drawing.Size(515, 271);
            this.grdLoanList.TabIndex = 0;
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(548, 25);
            this.mnuRegMember.TabIndex = 5;
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
            // frmViewMembersHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 585);
            this.Controls.Add(this.mnuRegMember);
            this.Controls.Add(this.grpLoanItems);
            this.Controls.Add(this.grpSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmViewMembersHistory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "View Members Borrow History";
            this.Load += new System.EventHandler(this.frmViewMembersHistory_Load);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMemberList)).EndInit();
            this.grpLoanItems.ResumeLayout(false);
            this.grpLoanItems.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdLoanList)).EndInit();
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.Label lblSurname;
        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.GroupBox grpLoanItems;
        private System.Windows.Forms.DataGridView grdLoanList;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtForename;
        private System.Windows.Forms.Label lblForename;
        private System.Windows.Forms.Label lblMemName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DataGridView grdMemberList;
    }
}