using DGVPrinterHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibSYS
{
    public partial class frmViewMembersHistory : Form
    {
        frmMainMenu parent;

        public frmViewMembersHistory()
        {
            InitializeComponent();
        }

        public frmViewMembersHistory(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        //Exit Menu
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Back menu
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        //Page Load Event
        private void frmViewMembersHistory_Load(object sender, EventArgs e)
        {
            //Call Method to Set Grid Style
            setMemberListStyle();
            setLoanListStyle();       
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset UI
            txtSurname.Text = "";
            txtForename.Text = "";
            txtSurname.Focus();
            grdMemberList.DataSource = null;
            grdMemberList.Visible = false;
            grdLoanList.DataSource = null;
            grpLoanItems.Visible = false;
        }

        //Search Button Event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get Surname and Forname
            String strSurname = txtSurname.Text;
            String strForename = txtForename.Text;

            //Validate String not empty
            if(strSurname == "" || strForename == "")
            {
                //Display appropriate error message
                MessageBox.Show("All field must be entered", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Return Focus to Surname
                txtSurname.Focus();
            }
            else
            {
                //Instantiate DataSet object
                DataSet ds = new DataSet();

                //Load Data onto data grid
                grdMemberList.DataSource = Members.getMember(ds, strSurname, strForename).Tables["mem"];

                //Check if any data source return, if no data return display message
                if (grdMemberList.DataSource == null || grdMemberList.RowCount == 0)
                {
                    //Display appropriate error message
                    MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Text = "";
                    txtForename.Text = "";
                    txtSurname.Focus();
                }
                else
                {
                    //Set Visibility
                    grdMemberList.Visible = true;

                    //Disable Sorting when clicking Column Header
                    foreach (DataGridViewColumn column in grdMemberList.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }   
        } //End Search Button Event

        //Cell Click Event
        private void grdMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Variable to store Member ID
            int intMemID = Convert.ToInt32(grdMemberList.Rows[grdMemberList.CurrentCell.RowIndex].Cells[0].Value);

            //List Loan Item Details of the Member
            //Instantiate DataSet object
            DataSet ds = new DataSet();

            //Load Data onto data grid
            grdLoanList.DataSource = LoanItems.getLoanItemsHistory(ds, intMemID).Tables["loan"];

            //Check if any data source return, if no data return display message
            if (grdLoanList.DataSource == null || grdLoanList.RowCount == 0)
            {
                //Reset UI
                MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Text = "";
                txtForename.Text = "";
                txtSurname.Focus();
                grpLoanItems.Visible = false;
                grdMemberList.Visible = false;
            }
            else
            {
                //Set Visibility
                grpLoanItems.Visible = true;

                //Disable Sorting when clicking Column Header
                foreach (DataGridViewColumn column in grdLoanList.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                //Set lblMemName Text
                lblMemName.Text = txtForename.Text.ToUpperInvariant() + " " + txtSurname.Text.ToUpperInvariant();
            }
        } //End Cell Click Event

        //Method to Style MemberList Grid
        private void setMemberListStyle()
        {
            //Set Style
            grdMemberList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdMemberList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdMemberList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdMemberList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMemberList.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdMemberList.DefaultCellStyle.BackColor = Color.Empty;
            grdMemberList.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdMemberList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdMemberList.GridColor = SystemColors.ControlDarkDark;
            grdMemberList.DefaultCellStyle.ForeColor = Color.Black;
            grdMemberList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        } //End

        //Method to Style LoanList Grid
        private void setLoanListStyle()
        {
            //Set Style
            grdLoanList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdLoanList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdLoanList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdLoanList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoanList.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdLoanList.DefaultCellStyle.BackColor = Color.Empty;
            grdLoanList.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdLoanList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdLoanList.GridColor = SystemColors.ControlDarkDark;
            grdLoanList.DefaultCellStyle.ForeColor = Color.Black;
        } //End

        //Print Button Event
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //DataGridView Printer Java Class
            /*****************************************************
            * Title: C# Tutorial - Print DataGridView with Header & Footer with Landscape | FoxLearn
            * Author: FoxLearn
            * Site owner/sponsor: youtube.com
            * Date: 07 Nov 2016
            * Availability: https://www.youtube.com/watch?v=-UB5mDPxAmo (Accessed 19 MARCH 2017)
            * Modified: Identifiers rename
            * *****************************************************/

            //Print Member Borrow History (Listing)
            //Instance of DGVPrinter
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.Title = "Member Borrow History"; //Header
            dgvPrinter.SubTitle = String.Format("Name: " + lblMemName.Text + "\nDate: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")); //Sub-Header

            //StringFormatFlags specifies the display and layout information for text strings
            dgvPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dgvPrinter.PageNumbers = true;
            dgvPrinter.PageNumberInHeader = false;
            dgvPrinter.PorportionalColumns = true;
            dgvPrinter.HeaderCellAlignment = StringAlignment.Near;
            dgvPrinter.Footer = "Library";
            dgvPrinter.FooterSpacing = 15;
            dgvPrinter.printDocument.DefaultPageSettings.Landscape = true;
            dgvPrinter.PrintDataGridView(grdLoanList);

            //End of [non-original or refactored] code
        }

        //End of Code
    }
}
