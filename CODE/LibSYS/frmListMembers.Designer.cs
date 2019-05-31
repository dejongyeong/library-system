namespace LibSYS
{
    partial class frmListMembers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListMembers));
            this.mnuRegMember = new System.Windows.Forms.MenuStrip();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuBack = new System.Windows.Forms.ToolStripMenuItem();
            this.grdMembers = new System.Windows.Forms.DataGridView();
            this.btnPrint = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.radActive = new System.Windows.Forms.RadioButton();
            this.radDereg = new System.Windows.Forms.RadioButton();
            this.radAll = new System.Windows.Forms.RadioButton();
            this.lblSysDate = new System.Windows.Forms.Label();
            this.grpMemList = new System.Windows.Forms.GroupBox();
            this.mnuRegMember.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).BeginInit();
            this.grpFilter.SuspendLayout();
            this.grpMemList.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuRegMember
            // 
            this.mnuRegMember.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit,
            this.mnuBack});
            this.mnuRegMember.Location = new System.Drawing.Point(0, 0);
            this.mnuRegMember.Name = "mnuRegMember";
            this.mnuRegMember.Size = new System.Drawing.Size(610, 25);
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
            // grdMembers
            // 
            this.grdMembers.AllowUserToAddRows = false;
            this.grdMembers.AllowUserToDeleteRows = false;
            this.grdMembers.AllowUserToResizeRows = false;
            this.grdMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMembers.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdMembers.GridColor = System.Drawing.SystemColors.ControlLightLight;
            this.grdMembers.Location = new System.Drawing.Point(6, 32);
            this.grdMembers.Name = "grdMembers";
            this.grdMembers.ReadOnly = true;
            this.grdMembers.RowHeadersWidth = 35;
            this.grdMembers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grdMembers.Size = new System.Drawing.Size(581, 291);
            this.grdMembers.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(521, 418);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(84, 23);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.radActive);
            this.grpFilter.Controls.Add(this.radDereg);
            this.grpFilter.Controls.Add(this.radAll);
            this.grpFilter.ForeColor = System.Drawing.Color.Blue;
            this.grpFilter.Location = new System.Drawing.Point(12, 28);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(225, 49);
            this.grpFilter.TabIndex = 1;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Filter Option";
            // 
            // radActive
            // 
            this.radActive.AutoSize = true;
            this.radActive.ForeColor = System.Drawing.Color.Black;
            this.radActive.Location = new System.Drawing.Point(61, 22);
            this.radActive.Name = "radActive";
            this.radActive.Size = new System.Drawing.Size(55, 17);
            this.radActive.TabIndex = 3;
            this.radActive.Text = "Active";
            this.radActive.UseVisualStyleBackColor = true;
            this.radActive.Click += new System.EventHandler(this.radActive_Click);
            // 
            // radDereg
            // 
            this.radDereg.AutoSize = true;
            this.radDereg.ForeColor = System.Drawing.Color.Black;
            this.radDereg.Location = new System.Drawing.Point(132, 22);
            this.radDereg.Name = "radDereg";
            this.radDereg.Size = new System.Drawing.Size(85, 17);
            this.radDereg.TabIndex = 4;
            this.radDereg.Text = "Deregistered";
            this.radDereg.UseVisualStyleBackColor = true;
            this.radDereg.Click += new System.EventHandler(this.radDereg_Click);
            // 
            // radAll
            // 
            this.radAll.AutoSize = true;
            this.radAll.Checked = true;
            this.radAll.ForeColor = System.Drawing.Color.Black;
            this.radAll.Location = new System.Drawing.Point(6, 22);
            this.radAll.Name = "radAll";
            this.radAll.Size = new System.Drawing.Size(36, 17);
            this.radAll.TabIndex = 2;
            this.radAll.TabStop = true;
            this.radAll.Text = "All";
            this.radAll.UseVisualStyleBackColor = true;
            this.radAll.Click += new System.EventHandler(this.radAll_Click);
            // 
            // lblSysDate
            // 
            this.lblSysDate.AutoSize = true;
            this.lblSysDate.ForeColor = System.Drawing.Color.Black;
            this.lblSysDate.Location = new System.Drawing.Point(521, 14);
            this.lblSysDate.Name = "lblSysDate";
            this.lblSysDate.Size = new System.Drawing.Size(47, 13);
            this.lblSysDate.TabIndex = 2;
            this.lblSysDate.Text = "SysDate";
            // 
            // grpMemList
            // 
            this.grpMemList.Controls.Add(this.grdMembers);
            this.grpMemList.Controls.Add(this.lblSysDate);
            this.grpMemList.ForeColor = System.Drawing.Color.Black;
            this.grpMemList.Location = new System.Drawing.Point(12, 83);
            this.grpMemList.Name = "grpMemList";
            this.grpMemList.Size = new System.Drawing.Size(593, 329);
            this.grpMemList.TabIndex = 0;
            this.grpMemList.TabStop = false;
            this.grpMemList.Text = "Member Listing";
            // 
            // frmListMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 448);
            this.Controls.Add(this.grpMemList);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.mnuRegMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmListMembers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "List Members";
            this.Load += new System.EventHandler(this.frmListMembers_Load);
            this.mnuRegMember.ResumeLayout(false);
            this.mnuRegMember.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdMembers)).EndInit();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpMemList.ResumeLayout(false);
            this.grpMemList.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuRegMember;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuBack;
        private System.Windows.Forms.DataGridView grdMembers;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.RadioButton radActive;
        private System.Windows.Forms.RadioButton radDereg;
        private System.Windows.Forms.RadioButton radAll;
        private System.Windows.Forms.Label lblSysDate;
        private System.Windows.Forms.GroupBox grpMemList;
    }
}