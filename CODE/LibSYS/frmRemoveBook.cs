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
    public partial class frmRemoveBook : Form
    {
        frmMainMenu parent;

        public frmRemoveBook()
        {
            InitializeComponent();
        }

        public frmRemoveBook(frmMainMenu Parent)
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

        //Form Load
        private void frmRemoveBook_Load(object sender, EventArgs e)
        {
            //Set Book List and book info to false
            grdBookList.Visible = false;
            grpBookInfo.Visible = false;

            //Calling method to set BookList Grid
            setBookListStyle();

            //Calling method to load ComboBox
            loadSubjectCmb();
            loadCountryCmb();
                        
        } //End frmRemoveBook_Load event

        //Search
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get Searched Book Title
            String strSTitle = txtSTitle.Text;

            //Validate strSTitle
            if(strSTitle == "")
            {
                MessageBox.Show("Search field must not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTitle.Focus();
            }
            else
            {
                DataSet ds = new DataSet();

                //Load data onto grid
                grdBookList.DataSource = Books.getBook(ds, strSTitle).Tables["book"];

                //Check if any data source return, if no data return display message
                if (grdBookList.DataSource == null || grdBookList.RowCount == 0)
                {
                    MessageBox.Show("No such record found. It is either 'Unavailable' or 'No such record in DB'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSTitle.Text = "";
                    txtSTitle.Focus();
                }
                else
                {
                    //Set Visibility
                    grdBookList.Visible = true;

                    //Disable Sorting when clicking Column Header
                    foreach (DataGridViewColumn column in grdBookList.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
        } //End Search event

        //Clear
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset UI
            txtSTitle.Text = "";
            grdBookList.Visible = false;
            grpBookInfo.Visible = false;
        }

        //Cell Click
        private void grdBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Instantiate Book object
            Books aBook = new Books();

            //Retrieve details from this member item from DB
            aBook.getBook(Convert.ToInt32(grdBookList.Rows[grdBookList.CurrentCell.RowIndex].Cells[0].Value));

            //Load instance variable values onto form
            txtBookID.Text = aBook.getBookID().ToString("0000");
            txtISBN.Text = aBook.getISBN();
            txtClassNo.Text = aBook.getClassNo();

            //Subject
            //Declare Variable to hold Subject Name
            String strSubjectName = Books.getSubjectName(aBook.getSubjectCode());
            cmbSubject.SelectedItem = strSubjectName;

            txtTitle.Text = aBook.getTitle();
            txtAuthor.Text = aBook.getAuthor();
            nudEdition.Value = aBook.getEdition();
            txtPrice.Text = aBook.getPrice().ToString();
            txtPages.Text = aBook.getPage().ToString();
            txtPName.Text = aBook.getPubName().ToString();

            //Country
            //Declare Variable to hold Country Name
            String strCountryName = Books.getCountryName(aBook.getCountry());
            cmbCountry.SelectedItem = strCountryName;

            txtYearPub.Text = aBook.getYearPub();

            //Display Member details
            grpBookInfo.Visible = true;
        } //End Cell Click

        //Remove
        private void btnRemove_Click(object sender, EventArgs e)
        {
            //Dereg Book
            //Instance of Books
            Books aBook = new Books();

            //Retrieve details from this book item from DB
            aBook.getBook(Convert.ToInt32(grdBookList.Rows[grdBookList.CurrentCell.RowIndex].Cells[0].Value));

            aBook.rmvBook();

            //Display Confirmation Message
            MessageBox.Show("Book " + txtBookID.Text + " Removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grpBookInfo.Visible = false;
            grdBookList.Visible = false;
            txtSTitle.Text = "";
            txtSTitle.Focus();
        } //End Remove

        //Load cmbSubject ComboBox
        private void loadSubjectCmb()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Populate value to cmbSubject
            try
            {
                //Connect to DB
                conn.Open();

                //Define SQL
                String strSQL = "SELECT SubjectName FROM Subjects ORDER BY SubjectName";
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Execute SQL Query
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //Populate Value to cmbCountry
                    cmbSubject.Items.Add(dr["SubjectName"].ToString());
                }

                //Close Connection
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error Populating Subject ComboBox\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } //End populate cmbSubject
        } //End loadSubjectCmb();

        //Load cmbCountry ComboBox
        private void loadCountryCmb()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Populate value to cmbCountry
            try
            {
                //Connect to DB
                conn.Open();

                //Define SQL
                String strSQL = "SELECT CountryName FROM Countries ORDER BY CountryName";
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Execute SQL Query
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //Populate Value to cmbCountry
                    cmbCountry.Items.Add(dr["CountryName"].ToString());
                }

                //Close Connection
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error Populating Subject ComboBox\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } //End populate cmbCountry
        } //End loadCountryCmb();

        //Set DataGridView Style
        private void setBookListStyle()
        {
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

        //End of Code
    }
}
