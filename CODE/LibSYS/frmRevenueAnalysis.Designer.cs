namespace LibSYS
{
    partial class frmRevenueAnalysis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRevenueAnalysis));
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grdBookReport = new System.Windows.Forms.DataGridView();
            this.btnPrintBookPriceAnalysisReport = new System.Windows.Forms.Button();
            this.grpFineReport = new System.Windows.Forms.GroupBox();
            this.txtTotalFine = new System.Windows.Forms.TextBox();
            this.lblTotalFine = new System.Windows.Forms.Label();
            this.btnPrintFineAnalysisReport = new System.Windows.Forms.Button();
            this.dtpFine = new System.Windows.Forms.DateTimePicker();
            this.lblFine = new System.Windows.Forms.Label();
            this.grdFineReport = new System.Windows.Forms.DataGridView();
            this.grpBookReport = new System.Windows.Forms.GroupBox();
            this.txtTotalBookPrice = new System.Windows.Forms.TextBox();
            this.lblTotalBookPrice = new System.Windows.Forms.Label();
            this.dtpBook = new System.Windows.Forms.DateTimePicker();
            this.lblBook = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.mnuRegMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookReport)).BeginInit();
            this.grpFineReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFineReport)).BeginInit();
            this.grpBookReport.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(655, 25);
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
            // grdBookReport
            // 
            this.grdBookReport.AllowUserToAddRows = false;
            this.grdBookReport.AllowUserToDeleteRows = false;
            this.grdBookReport.AllowUserToResizeRows = false;
            this.grdBookReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBookReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBookReport.Location = new System.Drawing.Point(6, 47);
            this.grdBookReport.Name = "grdBookReport";
            this.grdBookReport.ReadOnly = true;
            this.grdBookReport.RowHeadersWidth = 35;
            this.grdBookReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdBookReport.Size = new System.Drawing.Size(296, 287);
            this.grdBookReport.TabIndex = 0;
            this.grdBookReport.Visible = false;
            // 
            // btnPrintBookPriceAnalysisReport
            // 
            this.btnPrintBookPriceAnalysisReport.ForeColor = System.Drawing.Color.Black;
            this.btnPrintBookPriceAnalysisReport.Location = new System.Drawing.Point(221, 344);
            this.btnPrintBookPriceAnalysisReport.Name = "btnPrintBookPriceAnalysisReport";
            this.btnPrintBookPriceAnalysisReport.Size = new System.Drawing.Size(81, 23);
            this.btnPrintBookPriceAnalysisReport.TabIndex = 13;
            this.btnPrintBookPriceAnalysisReport.Text = "Print";
            this.btnPrintBookPriceAnalysisReport.UseVisualStyleBackColor = true;
            this.btnPrintBookPriceAnalysisReport.Click += new System.EventHandler(this.btnPrintBookPriceAnalysis_Click);
            // 
            // grpFineReport
            // 
            this.grpFineReport.Controls.Add(this.txtTotalFine);
            this.grpFineReport.Controls.Add(this.lblTotalFine);
            this.grpFineReport.Controls.Add(this.btnPrintFineAnalysisReport);
            this.grpFineReport.Controls.Add(this.dtpFine);
            this.grpFineReport.Controls.Add(this.lblFine);
            this.grpFineReport.Controls.Add(this.grdFineReport);
            this.grpFineReport.ForeColor = System.Drawing.Color.Black;
            this.grpFineReport.Location = new System.Drawing.Point(332, 28);
            this.grpFineReport.Name = "grpFineReport";
            this.grpFineReport.Size = new System.Drawing.Size(314, 374);
            this.grpFineReport.TabIndex = 14;
            this.grpFineReport.TabStop = false;
            this.grpFineReport.Text = "Fine Analysis Report";
            // 
            // txtTotalFine
            // 
            this.txtTotalFine.Location = new System.Drawing.Point(66, 344);
            this.txtTotalFine.Name = "txtTotalFine";
            this.txtTotalFine.ReadOnly = true;
            this.txtTotalFine.Size = new System.Drawing.Size(89, 20);
            this.txtTotalFine.TabIndex = 19;
            // 
            // lblTotalFine
            // 
            this.lblTotalFine.AutoSize = true;
            this.lblTotalFine.Location = new System.Drawing.Point(3, 347);
            this.lblTotalFine.Name = "lblTotalFine";
            this.lblTotalFine.Size = new System.Drawing.Size(57, 13);
            this.lblTotalFine.TabIndex = 18;
            this.lblTotalFine.Text = "Total Fine:";
            // 
            // btnPrintFineAnalysisReport
            // 
            this.btnPrintFineAnalysisReport.Location = new System.Drawing.Point(221, 342);
            this.btnPrintFineAnalysisReport.Name = "btnPrintFineAnalysisReport";
            this.btnPrintFineAnalysisReport.Size = new System.Drawing.Size(81, 23);
            this.btnPrintFineAnalysisReport.TabIndex = 17;
            this.btnPrintFineAnalysisReport.Text = "Print";
            this.btnPrintFineAnalysisReport.UseVisualStyleBackColor = true;
            this.btnPrintFineAnalysisReport.Click += new System.EventHandler(this.btnPrintFineAnalysisReport_Click);
            // 
            // dtpFine
            // 
            this.dtpFine.CustomFormat = "yyyy";
            this.dtpFine.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFine.Location = new System.Drawing.Point(47, 21);
            this.dtpFine.Name = "dtpFine";
            this.dtpFine.ShowUpDown = true;
            this.dtpFine.Size = new System.Drawing.Size(79, 20);
            this.dtpFine.TabIndex = 8;
            this.dtpFine.Value = new System.DateTime(2017, 3, 16, 0, 0, 0, 0);
            this.dtpFine.ValueChanged += new System.EventHandler(this.dtpFine_ValueChanged);
            // 
            // lblFine
            // 
            this.lblFine.AutoSize = true;
            this.lblFine.ForeColor = System.Drawing.Color.Black;
            this.lblFine.Location = new System.Drawing.Point(6, 24);
            this.lblFine.Name = "lblFine";
            this.lblFine.Size = new System.Drawing.Size(35, 13);
            this.lblFine.TabIndex = 7;
            this.lblFine.Text = "Year: ";
            // 
            // grdFineReport
            // 
            this.grdFineReport.AllowUserToAddRows = false;
            this.grdFineReport.AllowUserToDeleteRows = false;
            this.grdFineReport.AllowUserToResizeRows = false;
            this.grdFineReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdFineReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFineReport.Location = new System.Drawing.Point(6, 47);
            this.grdFineReport.Name = "grdFineReport";
            this.grdFineReport.ReadOnly = true;
            this.grdFineReport.RowHeadersWidth = 35;
            this.grdFineReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdFineReport.Size = new System.Drawing.Size(296, 287);
            this.grdFineReport.TabIndex = 6;
            this.grdFineReport.Visible = false;
            // 
            // grpBookReport
            // 
            this.grpBookReport.Controls.Add(this.txtTotalBookPrice);
            this.grpBookReport.Controls.Add(this.lblTotalBookPrice);
            this.grpBookReport.Controls.Add(this.grdBookReport);
            this.grpBookReport.Controls.Add(this.dtpBook);
            this.grpBookReport.Controls.Add(this.btnPrintBookPriceAnalysisReport);
            this.grpBookReport.Controls.Add(this.lblBook);
            this.grpBookReport.ForeColor = System.Drawing.Color.Black;
            this.grpBookReport.Location = new System.Drawing.Point(12, 28);
            this.grpBookReport.Name = "grpBookReport";
            this.grpBookReport.Size = new System.Drawing.Size(314, 374);
            this.grpBookReport.TabIndex = 0;
            this.grpBookReport.TabStop = false;
            this.grpBookReport.Text = "Book Price Analysis Report";
            // 
            // txtTotalBookPrice
            // 
            this.txtTotalBookPrice.Location = new System.Drawing.Point(73, 344);
            this.txtTotalBookPrice.Name = "txtTotalBookPrice";
            this.txtTotalBookPrice.ReadOnly = true;
            this.txtTotalBookPrice.Size = new System.Drawing.Size(89, 20);
            this.txtTotalBookPrice.TabIndex = 17;
            // 
            // lblTotalBookPrice
            // 
            this.lblTotalBookPrice.AutoSize = true;
            this.lblTotalBookPrice.Location = new System.Drawing.Point(6, 347);
            this.lblTotalBookPrice.Name = "lblTotalBookPrice";
            this.lblTotalBookPrice.Size = new System.Drawing.Size(61, 13);
            this.lblTotalBookPrice.TabIndex = 16;
            this.lblTotalBookPrice.Text = "Total Price:";
            // 
            // dtpBook
            // 
            this.dtpBook.CustomFormat = "yyyy";
            this.dtpBook.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBook.Location = new System.Drawing.Point(49, 21);
            this.dtpBook.Name = "dtpBook";
            this.dtpBook.ShowUpDown = true;
            this.dtpBook.Size = new System.Drawing.Size(79, 20);
            this.dtpBook.TabIndex = 2;
            this.dtpBook.Value = new System.DateTime(2017, 3, 16, 0, 0, 0, 0);
            this.dtpBook.ValueChanged += new System.EventHandler(this.dtpBook_ValueChanged);
            // 
            // lblBook
            // 
            this.lblBook.AutoSize = true;
            this.lblBook.ForeColor = System.Drawing.Color.Black;
            this.lblBook.Location = new System.Drawing.Point(8, 24);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(35, 13);
            this.lblBook.TabIndex = 1;
            this.lblBook.Text = "Year: ";
            // 
            // btnReset
            // 
            this.btnReset.ForeColor = System.Drawing.Color.Black;
            this.btnReset.Location = new System.Drawing.Point(553, 408);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(81, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset UI";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // frmRevenueAnalysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 439);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.grpFineReport);
            this.Controls.Add(this.grpBookReport);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmRevenueAnalysis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revenue Analysis";
            this.Load += new System.EventHandler(this.frmRevenueAnalysis_Load);
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdBookReport)).EndInit();
            this.grpFineReport.ResumeLayout(false);
            this.grpFineReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdFineReport)).EndInit();
            this.grpBookReport.ResumeLayout(false);
            this.grpBookReport.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataGridView grdBookReport;
        private System.Windows.Forms.Button btnPrintBookPriceAnalysisReport;
        private System.Windows.Forms.GroupBox grpFineReport;
        private System.Windows.Forms.DataGridView grdFineReport;
        private System.Windows.Forms.GroupBox grpBookReport;
        private System.Windows.Forms.DateTimePicker dtpBook;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.DateTimePicker dtpFine;
        private System.Windows.Forms.Label lblFine;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnPrintFineAnalysisReport;
        private System.Windows.Forms.TextBox txtTotalFine;
        private System.Windows.Forms.Label lblTotalFine;
        private System.Windows.Forms.TextBox txtTotalBookPrice;
        private System.Windows.Forms.Label lblTotalBookPrice;
    }
}