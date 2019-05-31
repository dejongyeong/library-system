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
    public partial class frmRegisterBook : Form
    {
        frmMainMenu parent;
        private String strSubjectCode;
        private String strCountryCode;

        public frmRegisterBook()
        {
            InitializeComponent();
        }

        public frmRegisterBook(frmMainMenu Parent)
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
        private void frmRegisterBook_Load(object sender, EventArgs e)
        {
            //Get next BookID
            txtBookID.Text = Books.getNextBookID().ToString("0000");

            //Calling methods to load combobox
            loadSubjectCmb();
            loadCountryCmb();

            //Initialize
            cmbSubject.SelectedIndex = -1;
            cmbCountry.SelectedIndex = -1;

            //Calling methods to set tool tip text
            setToolTipText();
        } //End form load event

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Validate Input
            //Calling method to check all fields must not be empty
            if (!checkEmptyBox())
            {
                return;
            }

            //Validate ISBN format
            if(!BookValidation.isValidISBN(txtISBN.Text))
            {
                MessageBox.Show("Book ISBN: '" + txtISBN.Text + "' invalid", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtISBN.Text = "";
                txtISBN.Focus();
                return;
            } //End Validate ISBN

            //Validate Class No
            if(!BookValidation.isValidClassNo(txtClassNo.Text))
            {
                MessageBox.Show("Class No: '" + txtClassNo.Text + "' invalid format (Format: 005-CAY)", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtClassNo.Text = "";
                txtClassNo.Focus();
                return;
            } //End Validate ClassNo

            //Validate Title
            if(!BookValidation.isValidTitle(txtTitle.Text))
            {
                MessageBox.Show("Book Title: '" + txtTitle.Text + "' invalid! Alphanumeric Values Only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Text = "";
                txtTitle.Focus();
                return;
            } //End Validate Title

            //Validate Author
            if(!BookValidation.isValidAuthor(txtAuthor.Text))
            {
                MessageBox.Show("Author: '" + txtAuthor.Text + "' invalid! Alphabets Only", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Text = "";
                txtAuthor.Focus();
                return;
            } //End Validate Author

            //Validate Price
            if(!BookValidation.isValidPrice(txtPrice.Text))
            {
                MessageBox.Show("Price: '" + txtPrice.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPrice.Text = "";
                txtPrice.Focus();
                return;
            } //End Validate Price

            //Validate NoPages
            if(!BookValidation.isValidNoPages(txtPages.Text))
            {
                MessageBox.Show("Pages '" + txtPages.Text + "' invalid! Only digits allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPages.Text = "";
                txtPages.Focus();
                return;
            } //End Validate Pages

            //Validate PubName
            if(!BookValidation.isValidPubName(txtPName.Text))
            {
                MessageBox.Show("Publisher Name: '" + txtPName.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPName.Text = "";
                txtPName.Focus();
                return;
            } //End Validate PubName

            //Validate YearPublish
            if(!BookValidation.isValidYearPublished(txtYearPub.Text))
            {
                MessageBox.Show("Year Published: '" + txtYearPub.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearPub.Text = "";
                txtYearPub.Focus();
                return;
            } //End Validate Year Publish

            //Validate Year Range
            if(!BookValidation.isValidYearRange(txtYearPub.Text))
            {
                MessageBox.Show("Invalid Year Entered!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtYearPub.Text = "";
                txtYearPub.Focus();
                return;
            } //End Validate Year Range

            //Initiate Book Object
            Books aBook = new Books();
            aBook.setBookID(Convert.ToInt32(txtBookID.Text));
            aBook.setISBN(txtISBN.Text.Trim());
            aBook.setClassNo(txtClassNo.Text);
            aBook.setTitle(txtTitle.Text.Trim());
            aBook.setSubjectCode(strSubjectCode);
            aBook.setAuthor(txtAuthor.Text.Trim());
            aBook.setEdition(Convert.ToInt32(nudEdition.Value));
            aBook.setPrice(Convert.ToDouble(txtPrice.Text.Trim()));
            aBook.setPage(Convert.ToInt32(txtPages.Text.Trim()));
            aBook.setPubName(txtPName.Text.Trim());
            aBook.setCountry(strCountryCode);
            aBook.setYearPub(txtYearPub.Text);
            aBook.setPurcDate(Convert.ToString(DateTime.Today.ToString("dd-MMM-yyy")));
            aBook.setBookStatus('A');

            //Insert Book Record into Books Table
            aBook.regBook();

            //Display confirmation message
            MessageBox.Show("Book " + txtBookID.Text + " is Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtISBN.Text = "";
            txtClassNo.Text = "";
            txtTitle.Text = "";
            cmbSubject.SelectedIndex = -1;
            txtAuthor.Text = "";
            nudEdition.Value = 0;
            txtPrice.Text = "";
            txtPages.Text = "";
            txtPName.Text = "";
            cmbCountry.SelectedIndex = -1;
            txtYearPub.Text = "";

            txtBookID.Text = Books.getNextBookID().ToString("0000");
            txtISBN.Focus();  
        } //End Button Event

        //Check Empty Box
        private Boolean checkEmptyBox()
        {          
            //Empty ISBN
            if(txtISBN.Text == "")
            {
                //Display error message
                MessageBox.Show("ISBN Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtISBN.Focus();
                return false;
            }

            //Empty ClassNo
            if(txtClassNo.Text == "")
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
            if(cmbSubject.SelectedIndex == -1)
            {
                //Display Error Message
                MessageBox.Show("Subject ComboBox must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbSubject.Focus();
                return false;
            }

            //Empty Author
            //String.isNullOrWhileSpace indicate whether a specified string is null, empty, or consists only of whitespace character
            if(String.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                //Display error message
                MessageBox.Show("Author Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Focus();
                return false;
            }

            //Check Edition
            if(nudEdition.Value == 0)
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
            if(String.IsNullOrWhiteSpace(txtPName.Text))
            {
                //Display error message
                MessageBox.Show("Publisher Name Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPName.Focus();
                return false;
            }

            //Country ComboBox
            if(cmbCountry.SelectedIndex == -1)
            {
                //Display Error Message
                MessageBox.Show("Country ComboBox must be selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbCountry.Focus();
                return false;
            }

            //Empty Year Published
            if(txtYearPub.Text == "")
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
        
        //Load cmbSubject Combobox
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
        } //End loadSubjectCmn()

        //Load cmbCountry Combobox
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
