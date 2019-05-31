using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSYS
{
    public partial class frmListMembers : Form
    {
        frmMainMenu parent;

        public frmListMembers()
        {
            InitializeComponent();
        }

        public frmListMembers(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        private void frmListMembers_Load(object sender, EventArgs e)
        {
            //Display system date
            lblSysDate.Text = DateTime.Today.ToString("dd/MM/yyyy");

            //Load data onto grid view
            DataSet ds = new DataSet();

            //Load Data onto data grid
            grdMembers.DataSource = Members.getMember(ds).Tables["mem"];

            //Check if any data source return, if no data return display message
            if (grdMembers.DataSource == null || grdMembers.RowCount == 0)
            {
                //Display error message
                MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                grdMembers.Visible = true;

                //Calling method to set Members GridView style
                setMembersStyle();

                //Disable Sorting when clicking Column Header
                foreach (DataGridViewColumn column in grdMembers.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }

            
           
        } //End frmListMembers_load

        private void radAll_Click(object sender, EventArgs e)
        {
            //Load data onto grid view
            DataSet ds = new DataSet();

            //Load Data onto data grid
            grdMembers.DataSource = Members.getMember(ds).Tables["mem"];
        } //End All

        private void radActive_Click(object sender, EventArgs e)
        {
            //Load data onto grid view
            DataSet ds = new DataSet();

            //Load Data onto data grid
            grdMembers.DataSource = Members.getMemberSort(ds, "A").Tables["mem"];

            //Check if any data source return, if no data return display message
            if (grdMembers.DataSource == null || grdMembers.RowCount == 0)
            {
                //Display error message
                MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //End Active

        private void radDereg_Click(object sender, EventArgs e)
        {
            //Load data onto grid view
            DataSet ds = new DataSet();

            //Load Data onto data grid
            grdMembers.DataSource = Members.getMemberSort(ds, "D").Tables["mem"];

            //Check if any data source return, if no data return display message
            if (grdMembers.DataSource == null || grdMembers.RowCount == 0)
            {
                //display error message
                MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        } //End Deregistered

        //Set GridView Style
        private void setMembersStyle()
        {
            grdMembers.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdMembers.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdMembers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdMembers.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMembers.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdMembers.DefaultCellStyle.BackColor = Color.Empty;
            grdMembers.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdMembers.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdMembers.GridColor = SystemColors.ControlDarkDark;
            grdMembers.DefaultCellStyle.ForeColor = Color.Black;
        } //End Set GridViewStyle

        private void btnPrint_Click(object sender, EventArgs e)
        {
            //String variable to store Page Title for Printing
            String strTitle = "";
            if(radAll.Checked)
            {
                strTitle = "Member Listing";
            }
            else if (radActive.Checked)
            {
                strTitle = "Active Member Listing";
            }
            else if(radDereg.Checked)
            {
                strTitle = "Deregistered Member Listing";
            }

            //DataGridView Printer Java Class
            /*****************************************************
            * Title: C# Tutorial - Print DataGridView with Header & Footer with Landscape | FoxLearn
            * Author: FoxLearn
            * Site owner/sponsor: youtube.com
            * Date: 07 Nov 2016
            * Availability: https://www.youtube.com/watch?v=-UB5mDPxAmo (Accessed 19 MARCH 2017)
            * Modified: Identifiers rename
            * *****************************************************/

            //Print Member Listing
            //Instance of DGVPrinter
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.Title = strTitle; //Header
            dgvPrinter.SubTitle = String.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")); //Sub-Header

            //StringFormatFlags specifies the display and layout information for text strings
            dgvPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dgvPrinter.PageNumbers = true;
            dgvPrinter.PageNumberInHeader = false;
            dgvPrinter.PorportionalColumns = true;
            dgvPrinter.HeaderCellAlignment = StringAlignment.Near;
            dgvPrinter.Footer = "Library";
            dgvPrinter.FooterSpacing = 15;
            dgvPrinter.printDocument.DefaultPageSettings.Landscape = true;
            dgvPrinter.PrintDataGridView(grdMembers);

            //End of [non-original or refactored] code
        }

        //End of Code
    }
}

