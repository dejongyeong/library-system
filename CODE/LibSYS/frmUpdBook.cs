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
    public partial class frmUpdBook : Form
    {
        //Declare Variable
        frmMainMenu parent;
        private String strSubjectCode;
        private String strCountryCode;
        private String strSubjectName;
        private String strCountryName;

        public frmUpdBook()
        {
            InitializeComponent();
        }

        public frmUpdBook(frmMainMenu Parent)
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

        private void frmUpdBook_Load(object sender, EventArgs e)
        {
            //Set Visible of GridView and Book Details
            grdBookList.Visible = false;
            grpBookInfo.Visible = false;

            //Calling Method to Set BookList DataGridView
            setBookListStyle();
            
            //Calling Method to Load Subject and Country ComboBox
            loadSubjectCmb();
            loadCountryCmb();

            //Calling Method to set tool tip text
            setToolTipText();
           
        } //End Form Load event

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset UI
            txtSTitle.Text = "";
            txtSTitle.Focus();
            grpBookInfo.Visible = false;
            grdBookList.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get Search Book Title
            String strTitle = txtSTitle.Text;

            //Validate Search Title if is empty
            if(strTitle.Equals(""))
            {
                //Display error message
                MessageBox.Show("Search field must not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSTitle.Focus();
            }
            else
            {
                DataSet ds = new DataSet();

                //Load Data onto data grid
                grdBookList.DataSource = Books.getBook(ds, strTitle).Tables["book"];

                //Check if any data source return, if no data return display message
                if (grdBookList.DataSource == null || grdBookList.RowCount == 0)
                {
                    MessageBox.Show("No record found. It is either 'Unavailable' or 'No such record in DB'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            } //End Validate Search Title          
        } //End Search

        private void grdBookList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Extract BookID from column 0 of selected row
            Books aBook = new Books();

            //Retrieve details from this member item from DB
            aBook.getBook(Convert.ToInt32(grdBookList.Rows[grdBookList.CurrentCell.RowIndex].Cells[0].Value));

            //Load instance variable values onto form
            txtBookID.Text = aBook.getBookID().ToString("0000");
            txtISBN.Text = aBook.getISBN();
            txtClassNo.Text = aBook.getClassNo();

            //Subject
            //Declare Variable to hold Subject Name
            strSubjectName = Books.getSubjectName(aBook.getSubjectCode());
            cmbSubject.SelectedItem = strSubjectName;

            txtTitle.Text = aBook.getTitle();
            txtAuthor.Text = aBook.getAuthor();
            nudEdition.Value = aBook.getEdition();
            txtPrice.Text = aBook.getPrice().ToString();
            txtPages.Text = aBook.getPage().ToString();
            txtPName.Text = aBook.getPubName();

            //Country
            //Declare Variable to hold Country Name
            strCountryName = Books.getCountryName(aBook.getCountry());
            cmbCountry.SelectedItem = strCountryName;

            txtYearPub.Text = aBook.getYearPub();

            //Display Member details
            grpBookInfo.Visible = true;
        } //End Cell Click Event

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Instance of Book
            Books aBook = new Books();

            //Validate input
            //Calling method to check all fields must not be empty
            if (!checkEmptyBox())
            {
                return;
            } //End Validate all fields

            //Validate ISBN format
            if (!BookValidation.isValidISBN(txtISBN.Text))
            {
                MessageBox.Show("Book ISBN: '" + txtISBN.Text + "' invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtISBN.Text = "";
                txtISBN.Focus();
                return;
            } //End Validate ISBN

            //Validate Class No
            if (!BookValidation.isValidClassNo(txtClassNo.Text))
            {
                MessageBox.Show("Class No: '" + txtClassNo.Text + "' invalid format (Format: 005-CAY)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassNo.Text = "";
                txtClassNo.Focus();
                return;
            } //End Validate ClassNo

            //Validate Title
            if (!BookValidation.isValidTitle(txtTitle.Text))
            {
                MessageBox.Show("Book Title: '" + txtTitle.Text + "' invalid! Alphanumeric Values Only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Text = "";
                txtTitle.Focus();
                return;
            } //End Validate Title

            //Validate Author
            if (!BookValidation.isValidAuthor(txtAuthor.Text))
            {
                MessageBox.Show("Author: '" + txtAuthor.Text + "' invalid! Alphabets Only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Text = "";
                txtAuthor.Focus();
                return;
            } //End Validate Author

            //Validate Price
            if (!BookValidation.isValidPrice(txtPrice.Text))
            {
                MessageBox.Show("Price: '" + txtPrice.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Text = "";
                txtPrice.Focus();
                return;
            } //End Validate Price

            //Validate NoPages
            if (!BookValidation.isValidNoPages(txtPages.Text))
            {
                MessageBox.Show("Pages '" + txtPages.Text + "' invalid! Only digits allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPages.Text = "";
                txtPages.Focus();
                return;
            } //End Validate Pages

            //Validate PubName
            if (!BookValidation.isValidPubName(txtPName.Text))
            {
                MessageBox.Show("Publisher Name: '" + txtPName.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPName.Text = "";
                txtPName.Focus();
                return;
            } //End Validate PubName

            //Validate YearPublish
            if (!BookValidation.isValidYearPublished(txtYearPub.Text))
            {
                MessageBox.Show("Year Published: '" + txtYearPub.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearPub.Text = "";
                txtYearPub.Focus();
                return;
            } //End Validate Year Publish

            //Validate Year Range
            if (!BookValidation.isValidYearRange(txtYearPub.Text))
            {
                MessageBox.Show("Invalid Year Entered!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearPub.Text = "";
                txtYearPub.Focus();
                return;
            } //End Validate Year Range

            //Update Book Details in Book File
            aBook.setBookID(Convert.ToInt32(txtBookID.Text));
            aBook.setISBN(txtISBN.Text.Trim());
            aBook.setClassNo(txtClassNo.Text.ToString());

            //Check if the subject has changed
            if(cmbSubject.SelectedItem.Equals(strSubjectName))
            {
                //No change then get subject code
                aBook.setSubjectCode(Books.getSubjectCode(cmbSubject.SelectedItem.ToString()));
            }

            aBook.setSubjectCode(strSubjectCode);
            aBook.setTitle(txtTitle.Text);
            aBook.setAuthor(txtAuthor.Text);
            aBook.setEdition(Convert.ToInt32(nudEdition.Value));
            aBook.setPrice(Convert.ToDouble(txtPrice.Text));
            aBook.setPage(Convert.ToInt32(txtPages.Text));
            aBook.setPubName(txtPName.Text);

            //Check if the country has changed
            if (cmbCountry.SelectedItem.Equals(strCountryName))
            {
                //If no change get country code
                aBook.setCountry(Books.getCountryCode(cmbCountry.SelectedItem.ToString()));
            }
            
            aBook.setCountry(strCountryCode);
            aBook.setYearPub(txtYearPub.Text);

            //Update
            aBook.updBook();

            //Display Confirmation message
            MessageBox.Show("Book " + txtBookID.Text + " Details Updated","Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grdBookList.Visible = false;
            grpBookInfo.Visible = false;
            txtSTitle.Text = "";
            txtSTitle.Focus();
        } //End Update 

        //Check Empty Box
        private Boolean checkEmptyBox()
        {
            //Empty ISBN
            if (txtISBN.Text == "")
            {
                //Display error message
                MessageBox.Show("ISBN Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtISBN.Focus();
                return false;
            }

            //Empty ClassNo
            if (txtClassNo.Text == "")
            {
                //Display error message
                MessageBox.Show("Class No Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassNo.Focus();
                return false;
            }

            //Empty Title
            //String.isNullOrWhileSpace indicate whether a specified string is null, empty, or consists only of whitespace character
            if (String.IsNullOrWhiteSpace(txtTitle.Text))
            {
                //Display error message
                MessageBox.Show("Title Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
                return false;
            }

            //Subject ComboBox
            if (cmbSubject.SelectedIndex == -1)
            {
                //Display Error Message
                MessageBox.Show("Subject ComboBox must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSubject.Focus();
                return false;
            }

            //Empty Author
            //String.isNullOrWhileSpace indicate whether a specified string is null, empty, or consists only of whitespace character
            if (String.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                //Display error message
                MessageBox.Show("Author Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                return false;
            }

            //Check Edition
            if (nudEdition.Value == 0)
            {
                //Display error message
                MessageBox.Show("Edition Field must not be 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                nudEdition.Focus();
                return false;
            }

            //Empty Price
            if (txtPrice.Text == "")
            {
                //Display error message
                MessageBox.Show("Price Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Focus();
                return false;
            }

            //Empty Pages
            if (txtPages.Text == "")
            {
                //Display error message
                MessageBox.Show("No. of Pages Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPages.Focus();
                return false;
            }

            //Empty Publisher Name
            //String.isNullOrWhileSpace indicate whether a specified string is null, empty, or consists only of whitespace character
            if (String.IsNullOrWhiteSpace(txtPName.Text))
            {
                //Display error message
                MessageBox.Show("Publisher Name Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPName.Focus();
                return false;
            }

            //Country ComboBox
            if (cmbCountry.SelectedIndex == -1)
            {
                //Display Error Message
                MessageBox.Show("Country ComboBox must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCountry.Focus();
                return false;
            }

            //Empty Year Published
            if (txtYearPub.Text == "")
            {
                //Display error message
                MessageBox.Show("Year Published Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearPub.Focus();
                return false;
            }

            return true;
        }

        /*****************************************************
        * Title: C# MS Access Database Tutorial 10 # Database values in textbox if select ComboBox
        * Author: ProgrammingKnowledge
        * Site owner/sponsor: youtube.com
        * Date: 14 Jul 2014
        * Availability: https://www.youtube.com/watch?v=oEiHByK1PAQ (Accessed 12 FEB 2017)
        * Modified: Code refactored
        * *****************************************************/
        //Get Subject Code
        private void cmbSubject_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                //Connect to DB
                conn.Open();

                //Define SQL Query to get Subject Code
                String strSQL = "SELECT SubjectCode FROM Subjects WHERE SubjectName = '" + cmbSubject.Text + "'";
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Execute SQL Query
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //Populate Value to cmbCountry
                    strSubjectCode = dr["SubjectCode"].ToString();
                }

                //Close Connection
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error Getting Subject Code\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } //End populate cmbSubject
        } //End cmbSubject_SelectedIndexChanged()

        //Get Country Code
        /*****************************************************
        * Title: C# MS Access Database Tutorial 10 # Database values in textbox if select ComboBox
        * Author: ProgrammingKnowledge
        * Site owner/sponsor: youtube.com
        * Date: 14 Jul 2014
        * Availability: https://www.youtube.com/watch?v=oEiHByK1PAQ (Accessed 12 FEB 2017)
        * Modified: Code refactored
        * *****************************************************/
        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                OracleConnection conn = new OracleConnection(DBConnect.oradb);
                //Connect to DB
                conn.Open();

                //Define SQL to get CountryCode
                String strSQL = "SELECT CountryCode FROM Countries WHERE CountryName = '" + cmbCountry.Text + "'";
                OracleCommand cmd = new OracleCommand(strSQL, conn);

                //Execute SQL Query
                OracleDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    //Get Country Code
                    strCountryCode = dr["CountryCode"].ToString();
                }

                //Close Connection
                conn.Close();
            }
            catch (OracleException ex)
            {
                MessageBox.Show("Error Getting Country Code\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } //End populate cmbCountry
        } //End selected index changed event

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
        } //End loadSubjectCmb()

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
        } //End loadCountryCmb()

        //Method to Style BookList DataGridView
        private void setBookListStyle()
        {
            //Set BookList Grid Style
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
        }

        //Method to set tool tip text
        private void setToolTipText()
        {
            //Create the ToolTip and associate with the Form container.
            ToolTip toolTip = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 3000; //millisecond
            toolTip.InitialDelay = 500; //millisecond
            toolTip.ReshowDelay = 200;
            //Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            //Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this.txtClassNo, "Class No Format: 000-AAA");
            toolTip.SetToolTip(this.txtISBN, "Book ISBN Format: 13 Digits or 10 Digits");
            toolTip.SetToolTip(this.txtPrice, "Price Format: xxx.xx or xx.xx");
        }

        //End of Code
    }
}
