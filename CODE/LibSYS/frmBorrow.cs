using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace LibSYS
{
    public partial class frmBorrow : Form
    {
        frmMainMenu parent;
        private Members aMember;
        private Books aBook;
        private const int INT_TWO_WEEKS = 14;

        public frmBorrow()
        {
            InitializeComponent();
        }

        public frmBorrow(frmMainMenu Parent)
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

        private void frmBorrow_Load(object sender, EventArgs e)
        {
            //Get Next Loan ID
            txtLoanID.Text = Loans.getNextLoanID().ToString("00000");

            //Calling method to set GridView Style
            setMemberListStyle();
            setBookListStyle();

            //Set Min Date for Due Date
            dtpDueDate.MinDate = DateTime.Today;
        }

        //Search Member
        private void btnSearchMember_Click(object sender, EventArgs e)
        {
            //Validate Member Search
            if (txtSname.Text == "")
            {
                MessageBox.Show("PPS Search Field must not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSname.Focus();
            }
            else
            {
                //Variable
                String strSearch = txtSname.Text;

                DataSet ds = new DataSet();

                //Load Data onto data grid
                grdMemberList.DataSource = Members.getMember(ds, strSearch).Tables["mem"];

                //Check if any data source return, if no data return display message
                if (grdMemberList.DataSource == null || grdMemberList.RowCount == 0)
                {
                    MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSname.Text = "";
                    txtSname.Focus();
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
        } //End Search Member

        //Member List Cell Click Event
        private void grdMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Extract MemID from column 0 of selected row
            aMember = new Members();

            //Retrieve details from this member item from DB
            aMember.getMember(Convert.ToInt32(grdMemberList.Rows[grdMemberList.CurrentCell.RowIndex].Cells[0].Value));

            //Load instance variable values onto form
            txtMemID.Text = aMember.getMemID().ToString("0000");
            txtPPS.Text = aMember.getPpsNo();
            txtSurname.Text = aMember.getSurname();
            txtForename.Text = aMember.getForename();

            //Set Member Details to Visible
            grpMemberDetails.Visible = true;
            grpBook.Visible = true;
        }

        //Clear Button for search Surname
        private void btnClearSname_Click(object sender, EventArgs e)
        {
            //Reset Member Details
            resetMember();

            //Reset Book Items
            resetBook();

            //Reset Borrow Details
            grpBorrowDetails.Visible = false;

            //Focus to Search Surname
            txtSname.Focus();

        } //End Clear Button

        //Clear Search Book Title Field
        private void btnClearTitle_Click(object sender, EventArgs e)
        {
            //Clear Search Book Title
            grdBookList.DataSource = null;
            txtSTitle.Text = "";
            txtSTitle.Focus();

        } //End Clear Button

        //Search Book Button Event
        private void btnSearchBook_Click(object sender, EventArgs e)
        {
            //Validate Title Search Box
            if (txtSTitle.Text == "")
            {
                MessageBox.Show("Book Title Search Field must not be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTitle.Focus();
            }
            else
            {
                DataSet ds = new DataSet();

                //Load Data onto data grid
                grdBookList.DataSource = Books.getBook(ds, txtSTitle.Text).Tables["book"];

                //Check if any data source return, if no data return display message
                if (grdBookList.DataSource == null || grdBookList.RowCount == 0)
                {
                    MessageBox.Show("No details found, Either all books is on loan or invalid ISBN entered", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSTitle.Text = "";
                    txtSTitle.Focus();
                }
                else
                {
                    //Set Visibility of DataGridView BookList
                    grdBookList.Visible = true;

                    //Disable Sorting when clicking Column Header
                    foreach (DataGridViewColumn column in grdBookList.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }

                    //Calling SetVisibility Method
                    setVisibility();
                }
            }
        } //End Search Method

        private void grdBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Extract BookID from column 0 of selected row
            aBook = new Books();

            //Retrieve details from this member item from DB
            aBook.getBook(Convert.ToInt32(grdBookList.Rows[grdBookList.CurrentCell.RowIndex].Cells[0].Value));

            //Variables to Store Book ID, ISBN, and Book Title
            int intBookID = aBook.getBookID();
            String strISBN = aBook.getISBN();
            String strTitle = aBook.getTitle();

            //Join All Variables
            String strValue = intBookID.ToString("0000") + " " + strISBN + " " + strTitle;

            //Add Details to List
            //Prevent Duplicates entries into ListBox
            if(lstCart.Items.Contains(strValue))
            {
                //Display error message to indicates that no duplicates allow
                String strErrorMessage = "'" + strTitle + "' has been added, no duplicates";
                MessageBox.Show(strErrorMessage, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                lstCart.Items.Add(strValue);
            }
               
        } //End Book List

        //Remove Items on lstCart
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Remove Items from lstCart at selected index
            lstCart.Items.RemoveAt(lstCart.SelectedIndex);

        } //End Remove

        //Done Button Event
        private void btnDone_Click(object sender, EventArgs e)
        {
            //Check if ListBox is empty
            if(lstCart.Items.Count == 0)
            {
                MessageBox.Show("Cart must not be empty", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                //Set DateTimePicker Value
                dtpCurrentDate.Value = DateTime.Today;
                dtpDueDate.Value = DateTime.Today.AddDays(INT_TWO_WEEKS);
                grpBorrowDetails.Visible = true;

                //Prevent Editing
                btnDone.Enabled = false;
                btnRemove.Enabled = false;
                btnSearchBook.Enabled = false;
                btnClearTitle.Enabled = false;
                btnSearchMember.Enabled = false;
                btnClearSname.Enabled = false;
                txtSname.Enabled = false;
                txtSTitle.Enabled = false;

                //Clear grdBookList selection and prevent editing
                grdBookList.ClearSelection();
                grdBookList.Enabled = false;

                //Prevent Editing
                grdMemberList.Enabled = false;

                //Clear lstCard selection and read-only
                lstCart.Enabled = false;
                lstCart.ClearSelected();
            }
        } //End

        //Return Button
        private void btnReturn_Click(object sender, EventArgs e)
        {
            //Enable Editing and hide grpBorrowDetails
            grpBorrowDetails.Visible = false;
            btnDone.Enabled = true;
            btnRemove.Enabled = true;
            btnSearchBook.Enabled = true;
            btnClearTitle.Enabled = true;
            btnSearchMember.Enabled = true;
            btnClearSname.Enabled = true;
            txtSname.Enabled = true;
            txtSTitle.Enabled = true;
            lstCart.Enabled = true;
            grdBookList.Enabled = true;
            grdMemberList.Enabled = true;
        }

        //Borrow Button Event
        private void btnBorrow_Click(object sender, EventArgs e)
        {   
            //Initialize Variable to get Number of Books Borrowed
            int numBooks = Loans.getNumBooksBorrow(Convert.ToInt32(txtMemID.Text));
            
            //Validates Number of Books Borrowed (Not more than 3)
            if (!isValidBooksBorrowed(numBooks))
            {
                
                //Display appropriate error message
                //If numBooks == 0 but Librarian selected more than 3 books
                if(numBooks == 0)
                {
                    String strMessage = "Member '" + txtForename.Text + " " + txtSurname.Text + "' can only borrow 3 books";
                    MessageBox.Show(strMessage,"Message",MessageBoxButtons.OK,MessageBoxIcon.Error);

                    //Hide grpBorrowDetails
                    grpBorrowDetails.Visible = false;

                    lstCart.Focus();

                    //Do nothing
                    return;
                }
                //If numBooks == 1 but Librarian selected more than 2 books
                else if(numBooks == 1)
                {
                    String strMessage = "Member '" + txtForename.Text + " " + txtSurname.Text + "' can only borrow 2 books";
                    MessageBox.Show(strMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Hide grpBorrowDetails
                    grpBorrowDetails.Visible = false;

                    lstCart.Focus();

                    //Do nothing
                    return;
                }
                //If numBooks == 2 but Librarian selected more than 1 books
                else if(numBooks == 2)
                {
                    String strMessage = "Member '" + txtForename.Text + " " + txtSurname.Text + "' can only borrow 1 books";
                    MessageBox.Show(strMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Hide grpBorrowDetails
                    grpBorrowDetails.Visible = false;

                    lstCart.Focus();

                    //Do nothing
                    return;
                }
                //Reset whole UI if numBooks >= 3
                else
                {
                    String strMessage = "Total books borrowed by Member '" + txtForename.Text + " " + txtSurname.Text + "' has exceeded 3 books";
                    MessageBox.Show(strMessage, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Calling resetMember() method to reset Member Details
                    resetMember();
                    txtSname.Focus();

                    //Calling resetBook() method to reset Book Details
                    resetBook();
                    grpBorrowDetails.Visible = false;

                    //Do nothing
                    return;
                }                
            }
            else
            {
                //Calling method to save Loan Details in Rental File
                registerLoan();

                //Calling method to save rental items in Book Rental Items File
                saveRentalItems(); 

                //Display confirmation message
                MessageBox.Show("Loan " + txtLoanID.Text + " registered succesfully", "Registered", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                //Reset UI
                //Reset Member Details
                resetMember();

                //Reset Book Details
                resetBook();

                //Reset Borrow Details
                grpBorrowDetails.Visible = false;
                txtSname.Focus();

                //Get next Loan ID
                txtLoanID.Text = Loans.getNextLoanID().ToString("00000");

            } //End if
        } //End click event

        //Private Method to Save Rental Items
        private void saveRentalItems()
        {
            //For item in lstCart from 0 to lstCart total items - 1
            for (int i = 0; i < lstCart.Items.Count; i++)
            {
                //Instantiate LoanItems Object
                LoanItems aLoanItem = new LoanItems();
                aLoanItem.setLoanID(Convert.ToInt32(txtLoanID.Text));
                aLoanItem.setBookID(Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 4)));

                //Save Rental Item Detials
                aLoanItem.regLoanItems();

                //Update book status in Book File
                Loans.updBookStatus(Convert.ToInt32(lstCart.Items[i].ToString().Substring(0, 4)), 'U');

                //Update No. Books Borrow of the member in Member File
                Loans.updBooksBorrowIncrement(aMember.getMemID());

            } //End For
        } //End saveRentalItems();

        //Private Method to Register Loans
        private void registerLoan()
        {
            //Insert Items into Rental File
            //Instantiate Loan Object
            Loans aLoan = new Loans();
            aLoan.setLoanID(Convert.ToInt32(txtLoanID.Text));
            aLoan.setMemID(Convert.ToInt32(txtMemID.Text));
            aLoan.setBorrowDate(dtpCurrentDate.Text);
            aLoan.setReturnDate(dtpDueDate.Text);
           
            //Save Details
            aLoan.regLoan();

        } //End registerLoan();

        //Set Visibility Method
        private void setVisibility()
        {
            //Set LstCart Visibility to True and Button
            lstCart.Visible = true;
            btnRemove.Visible = true;
            btnDone.Visible = true;

        } //End Set Visibility

        //Reset UI Method
        private void resetBook()
        {
            grpBook.Visible = false;

            //Reset Book Items
            txtSTitle.Text = "";
            txtSTitle.Enabled = true;
            
            grdBookList.Enabled = true;
            grdBookList.DataSource = null;
            grdBookList.Visible = false;
            btnSearchBook.Enabled = true;
            btnClearTitle.Enabled = true;

            lstCart.Items.Clear();
            lstCart.Visible = false;
            lstCart.Enabled = true;

            btnRemove.Visible = false;
            btnRemove.Enabled = true;

            btnDone.Visible = false;
            btnDone.Enabled = true;

        } //End Reset Book

        private void resetMember()
        {
            //Reset Member Details
            txtSname.Text = "";
            txtMemID.Text = "";
            txtPPS.Text = "";
            txtSurname.Text = "";
            txtForename.Text = "";

            btnSearchMember.Enabled = true;
            btnClearSname.Enabled = true;
            txtSname.Enabled = true;

            grdMemberList.Visible = false;
            grdMemberList.Enabled = true;
            grpMemberDetails.Visible = false;
            grdMemberList.DataSource = null;

        } //End Reset member

        //Method to set MemberList GridView Style
        private void setMemberListStyle()
        {
            //Style
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

        //Method to set BookList GridView Style
        private void setBookListStyle()
        {
            //Style
            grdBookList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdBookList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdBookList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdBookList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdBookList.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdBookList.DefaultCellStyle.BackColor = Color.Empty;
            grdBookList.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdBookList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdBookList.GridColor = SystemColors.ControlDarkDark;
            grdBookList.DefaultCellStyle.ForeColor = Color.Black;
            grdBookList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        } //End

        //Method to Validate Number of Books Borrowed
        private Boolean isValidBooksBorrowed(int intNumBooks)
        {
            if ((intNumBooks + lstCart.Items.Count) <= 3)
            {
                return true;
            }
            else
            {
                //Enable Editing and hide grpBorrowDetails
                grpBorrowDetails.Visible = false;
                btnDone.Enabled = true;
                btnRemove.Enabled = true;
                btnSearchBook.Enabled = true;
                btnClearTitle.Enabled = true;
                btnSearchMember.Enabled = true;
                btnClearSname.Enabled = true;
                txtSname.Enabled = true;
                txtSTitle.Enabled = true;
                lstCart.Enabled = true;
                grdBookList.Enabled = true;
                grdMemberList.Enabled = true;

                return false;
            }
        } //End

      

        //End Of Code
    }
}
