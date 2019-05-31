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
    public partial class frmReturn : Form
    {
        frmMainMenu parent;

        //Global Variables
        private int intMemID;
        private int intBookID;
        private int intLoanID;
        private String strReturnDate;

        public frmReturn()
        {
            InitializeComponent();
        }

        public frmReturn(frmMainMenu Parent)
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

        //Form Load Event
        private void frmReturn_Load(object sender, EventArgs e)
        {
            //Calling method to set GridViewStyle
            setLoanItemListStyle();
            setMemberListStyle();
            
        } //End Form Load Event

        //Clear Button Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset UI
            txtSurname.Text = "";
            txtSurname.Focus();

            //Reset DataGridView
            grdMemList.DataSource = null;
            grdMemList.Visible = false;
            grpLoanItemList.Visible = false;
            grpLoanDetails.Visible = false;
            grpFineDetails.Visible = false;

        } //End Clear Button Event

        //Search Member Button Event
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            //Validate search field
            if(txtSurname.Equals(""))
            {
                //Display error message if field is empty
                MessageBox.Show("Search field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
            }
            else
            {
                //Display Member on DataGridView
                //Initiate DateSet object
                DataSet ds = new DataSet();

                //Variables
                String strSurname = txtSurname.Text.ToUpperInvariant();

                //Load data onto DataGridView
                //Member List
                grdMemList.DataSource = Members.getMember(ds, strSurname).Tables["mem"];

                if(grdMemList.DataSource == null || grdMemList.RowCount == 0)
                {
                    //Display error message if no data returned
                    MessageBox.Show("No such record found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSurname.Text = "";
                    txtSurname.Focus();
                }
                else
                {
                    //Set Visible of grdMemList to true
                    grdMemList.Visible = true;

                    //Disable Sorting when clicking Column Header
                    foreach (DataGridViewColumn column in grdMemList.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
        } //End Search Member Button Event

        //MemList cell click event
        private void grdMemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Extract MemID from column 0 of selected row
            intMemID = Convert.ToInt32(grdMemList.Rows[grdMemList.CurrentCell.RowIndex].Cells[0].Value);

            //Instantiate Members object
            Members aMember = new Members();
            aMember.getMember(intMemID);
            String strName = aMember.getForename() + " " + aMember.getSurname();

            //Display Loan Items on DataGridView for the selected Member
            //Initiate DataSet Object
            DataSet ds = new DataSet();

            //Load data onto DataGridView
            //LoanItemList
            grdLoanItemList.DataSource = LoanItems.getLoanItems(ds, intMemID).Tables["loan"];

            if(grdLoanItemList.DataSource == null || grdLoanItemList.RowCount == 0)
            {
                //Display error message if no data returned
                MessageBox.Show("No Rental Items found for Member '" + strName + "'", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grpLoanItemList.Visible = false;
                grpLoanDetails.Visible = false;
                txtSurname.Focus();          
            }
            else
            {
                //Display UI
                grpLoanItemList.Visible = true;

                //Disable Sorting when clicking Column Header
                foreach (DataGridViewColumn column in grdLoanItemList.Columns)
                {
                    column.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
        } //End Cell Click Event

        private void grdLoanItemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Extract LoanID from column 0 of selected row
            //Extract BookID from column 1 of selected row
            intLoanID = Convert.ToInt32(grdLoanItemList.Rows[grdLoanItemList.CurrentCell.RowIndex].Cells[0].Value);
            intBookID = Convert.ToInt32(grdLoanItemList.Rows[grdLoanItemList.CurrentCell.RowIndex].Cells[1].Value);

            //Extract Book Title from column 3 of selected row
            //Variable to store Book Title
            String strTitle = Convert.ToString(grdLoanItemList.Rows[grdLoanItemList.CurrentCell.RowIndex].Cells[3].Value).Trim();

            //Instantiate Members object and retrieve member details from Member File
            Members aMember = new Members();
            aMember.getMember(intMemID);
            String strForename = aMember.getForename().Trim();
            String strSurname = aMember.getSurname().Trim();

            //Instantiate Loans object to retrieve loan details
            Loans aLoan = new Loans();
            aLoan.getLoan(intLoanID);
            String strBorrowDate = aLoan.getBorrowDate();
            this.strReturnDate = aLoan.getReturnDate();

            //Variable to store Member Name
            String strMemName = strForename + " " + strSurname;          

            //Set Text to TextBox
            txtLoanID.Text = intLoanID.ToString("00000");
            txtMemName.Text = strMemName;
            txtBookTitle.Text = strTitle;
            dtpBorrowDate.Value = Convert.ToDateTime(strBorrowDate);
            dtpDueDate.Value = Convert.ToDateTime(strReturnDate);

            //Set Book Loan to True
            grpLoanDetails.Visible = true;
        } 

        //Return Button
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Assign Return Date and Update Return Date of the selected Items in BookRentalItems File
            String strCurrentDate = Convert.ToString(DateTime.Today.ToString("dd-MMM-yy"));
            LoanItems.updLoanItems(intLoanID, intBookID, strCurrentDate);

            //Instantiate DateTime object and Calculate Number of Days
            DateTime dtToday = DateTime.Today.Date;
            DateTime dtDue = dtpDueDate.Value.Date;
            double dblTotalDays = numberOfDays(dtToday, dtDue);

            //Check if book is overdue
            //If book is not overdue (Total Days <= 0)
            if(dblTotalDays <= 0)
            {
                //Method to do Updates
                updDetails();
            }
            else //Fine Detected
            {
                //Display Error Message
                MessageBox.Show("Book '" + txtBookTitle.Text + "' Overdue", "Overdue", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Calculates Fine
                double dblFine = dblTotalDays * Loans.PENALTY;

                //Update Fine Amount of LoanItem
                LoanItems.updLoanItemFine(intLoanID, intBookID, dblFine);

                //Display Fine Details on UI
                dtpFDueDate.Value = Convert.ToDateTime(strReturnDate);
                dtpReturnDate.Value = DateTime.Today;
                txtFine.Text = dblFine.ToString("0.00");
                grpFineDetails.Visible = true;

                //Hide Loan Details Return Button
                //Hide Clear Button to prevent User from exiting current steps
                btnClear.Visible = false;
                btnSMem.SetBounds(253, 16, 83, 23);
                btnReturn.Visible = false;           
            }            
        }

        //Return Button in Fine Details
        private void btnFReturn_Click(object sender, EventArgs e)
        {
            //Get Payment Method
            //If Payment is Owe
            if (radOwe.Checked == true)
            {
                //Update Fine Balance of Member
                Members.updFineAmount(intMemID, Convert.ToDouble(txtFine.Text));
            }

            //Display Confirmation Message
            MessageBox.Show("Fine Details Recorded", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Method to do Updates
            updDetails();
        }

        //Calculate Number of Days
        private double numberOfDays(DateTime dtToday, DateTime dtDue)
        {
            //Calculate number of days using TimeSpan class
            TimeSpan timeSpan = dtToday - dtDue;

            //Return total days
            return timeSpan.TotalDays;

        } //End numberOfDays

        //Method to do updates
        private void updDetails()
        {
            //Update Book Status to Available
            Loans.updBookStatus(intBookID, 'A');

            //Update Number of Books Borrow (-1)
            Loans.updBooksBorrowDecrement(intMemID);

            //Display confirmation message
            MessageBox.Show("Book '" + txtBookTitle.Text + "' Returned Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Calling method to prompt user more books to be returned for same Member?
            returnMoreBooks();

        } //End Update

        //Method to prompt user more books to be returned for same Member?
        public void returnMoreBooks()
        {
            //Check if RowCount is not equal to 1.
            //1 indicate that there is only one book left on grdLoanItemList
            if(grdLoanItemList.RowCount != 1)
            {
                DialogResult result = MessageBox.Show("More books to be return for Member '" + txtMemName.Text + "'?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(result == DialogResult.Yes)
                {
                    //Display Loan Items on DataGridView for the selected Member
                    //Initiate DataSet Object
                    DataSet ds = new DataSet();

                    //Reload data onto DataGridView
                    //LoanItemList
                    grdLoanItemList.DataSource = LoanItems.getLoanItems(ds, intMemID).Tables["loan"];

                    //Display UI
                    grpLoanItemList.Visible = true;

                    //Hide grpLoanDetails and grpFineDetails
                    grpLoanDetails.Visible = false;
                    btnReturn.Visible = true;
                    grpFineDetails.Visible = false;
                }
                else
                {
                    //Reset UI because Member may return only one book
                    clearUI();
                }
            }
            else
            {
                //Display Information Message
                MessageBox.Show("All books has been returned", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset UI
                clearUI();
            }
        } //End Method

        //Clear UI
        private void clearUI()
        {
            radPaid.Checked = true;
            grpFineDetails.Visible = false;
            grpLoanDetails.Visible = false;
            grdMemList.Visible = false;
            grpLoanItemList.Visible = false;
            btnReturn.Visible = true;
            txtSurname.Text = "";
            txtSurname.Focus();
            btnClear.Visible = true;
        }

        //Method to set MemberList Style
        private void setMemberListStyle()
        {
            grdMemList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdMemList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdMemList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdMemList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMemList.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdMemList.DefaultCellStyle.BackColor = Color.Empty;
            grdMemList.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdMemList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdMemList.GridColor = SystemColors.ControlDarkDark;

        } //End set style

        //Method to Set LoanItemList Style
        private void setLoanItemListStyle()
        {
            grdLoanItemList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdLoanItemList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdLoanItemList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdLoanItemList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdLoanItemList.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdLoanItemList.DefaultCellStyle.BackColor = Color.Empty;
            grdLoanItemList.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdLoanItemList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdLoanItemList.GridColor = SystemColors.ControlDarkDark;

        } //End Set Styles

        //End of Code
    }
}
