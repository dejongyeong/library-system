using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace LibSYS
{
    public partial class frmRegMember : Form
    {
        frmMainMenu parent;

        public frmRegMember()
        {
            InitializeComponent();
        }

        public frmRegMember(frmMainMenu Parent)
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

        private void frmRegMember_Load(object sender, EventArgs e)
        {
            //Get next member Id
            txtMemberID.Text = Members.getNextMemberID().ToString("0000");

            //Asign default values for display
            dtpDOB.MaxDate = DateTime.Today;
            dtpDOB.Value = DateTime.Today;
            dtpRegisterDate.MaxDate = DateTime.Today;
            dtpRegisterDate.Value = DateTime.Today;

            //Calling method to set ToolTipText
            setToolTipText();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //Validation
            //Calling Method to ensures no textbox is empty
            if(!checkEmptyTextBox())
            {
                return;
            }

            //Validate PPS using MemberValidation class static method
            if(!MemberValidation.isValidPPS(txtPPS.Text))
            {
                MessageBox.Show("PPS Number: " + txtPPS.Text + " invalid format! 7 Digits followed by 1 or 2 Uppercase Letters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPPS.Text = "";
                txtPPS.Focus();
                return;
            } //End Validate PPS

            //Validate duplicate PPS MemberValidation class static method
            if (!MemberValidation.isDuplicatePPS(txtPPS.Text))
            {
                MessageBox.Show("PPS Number: " + txtPPS.Text + " is already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPPS.Text = "";
                txtPPS.Focus();
                return;
            } //End validate duplicate PPS

            //Validate Surname MemberValidation class static method
            if (!MemberValidation.isValidSurname(txtSurname.Text))
            {
                MessageBox.Show("Surname '" + txtSurname.Text + "' invalid! No digits allowed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Text = "";
                txtSurname.Focus();
                return;
            } //End Validate Surname

            //Validate Forename MemberValidation class static method
            if (!MemberValidation.isValidForename(txtForename.Text))
            {
                MessageBox.Show("Forename '" + txtForename.Text + "' invalid! No digits allowed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Text = "";
                txtForename.Focus();
                return;
            } //End Validate Forename

            //Validate Age MemberValidation class static method
            if (MemberValidation.calculateAge(dtpDOB.Value) < 16)
            {
                MessageBox.Show("Age must be over 16", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDOB.Focus();
                return;
            } //End Validate Age

            //Convert radio button value to char
            char chrGender = ' ';
            Boolean isChecked = radMale.Checked;

            if (isChecked)
            {
                chrGender = Convert.ToChar(radMale.Text.Substring(0, 1));
            }
            else
            {
                chrGender = Convert.ToChar(radFemale.Text.Substring(0, 1));
            } //End Convert

            //Validate Phone MemberValidation class static method
            if (!MemberValidation.isValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone '" + txtPhone.Text + "' invalid format! E.g. 083 5763489", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Text = "";
                txtPhone.Focus();
                return;
            } //End Validate Phone

            //Validate Email MemberValidation class static method
            if (!MemberValidation.isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email '" + txtEmail.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            } //End Validate Email

            //Validate Duplicate Email MemberValidation class static method
            if (!MemberValidation.isDuplicateEmail(txtEmail.Text))
            {
                MessageBox.Show("Email '" + txtEmail.Text + "' is already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            } //End Validate duplicate Email

            //Validate Street MemberValidation class static method
            if (!MemberValidation.isValidStreet(txtStreet.Text))
            {
                MessageBox.Show("Street '" + txtStreet.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Text = "";
                txtStreet.Focus();
                return;
            } //End Validate County

            //Validate Town MemberValidation class static method
            if (!MemberValidation.isValidTown(txtTown.Text))
            {
                MessageBox.Show("Town '" + txtTown.Text + "' invalid! No digits allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Text = "";
                txtTown.Focus();
                return;
            } //End Validate County

            //Validate County MemberValidation class static method
            if (!MemberValidation.isValidCounty(txtCounty.Text))
            {
                MessageBox.Show("County '" + txtCounty.Text + "' invalid! No digits allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Text = "";
                txtCounty.Focus();
                return;
            } //End Validate County

            //Instantiate Member object
            Members aMember = new Members();
            aMember.setMemID(Convert.ToInt32(txtMemberID.Text));
            aMember.setPpsNo(txtPPS.Text);
            aMember.setSurname(txtSurname.Text.Trim());
            aMember.setForename(txtForename.Text.Trim());
            aMember.setDOB(dtpDOB.Text);
            aMember.setGender(chrGender);
            aMember.setPhone(txtPhone.Text);
            aMember.setEmail(txtEmail.Text.Trim());
            aMember.setStreet(txtStreet.Text.Trim());
            aMember.setTown(txtTown.Text.Trim());
            aMember.setCounty(txtCounty.Text.Trim());
            aMember.setRegDate(dtpRegisterDate.Text);
            aMember.setMemStatus('A');

            //Insert Member record into member table
            aMember.regMember();

            //Display Confirmation Message
            MessageBox.Show("Member " + txtMemberID.Text + " Registered",
                            "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtPPS.Text = "";
            txtSurname.Text = "";
            txtForename.Text = "";
            dtpDOB.Value = DateTime.Today;
            radMale.Checked = true;
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtStreet.Text = "";
            txtTown.Text = "";
            txtCounty.Text = "";
            dtpRegisterDate.Value = DateTime.Today;

            txtMemberID.Text = Members.getNextMemberID().ToString("0000");
            txtPPS.Focus();
        } //End of btnRegister_Click()

        //Check Empty TextBox
        private Boolean checkEmptyTextBox()
        {
            //PPS Field
            if (txtPPS.Text == "")
            {  
                //Display error message
                MessageBox.Show("PPS Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPPS.Focus();
                return false;
            }

            //Surname Field
            //String.isNullOrWhileSpace indicate whether a specified string is null, empty, or consists only of whitespace character
            if (String.IsNullOrWhiteSpace(txtSurname.Text))
            {
                //Display error message
                MessageBox.Show("Surname Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Focus();
                return false;
            }

            //Forename Field
            //String.isNullOrWhileSpace indicate whether a specified string is null, empty, or consists only of whitespace character
            if (String.IsNullOrWhiteSpace(txtForename.Text))
            {
                //Display error message
                MessageBox.Show("Forename Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Focus();
                return false;
            }

            //Phone Field
            if (txtPhone.Text == "")
            {
                //Display error message
                MessageBox.Show("Phone Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
                return false;
            }

            //Email Field
            if (txtEmail.Text == "")
            {
                //Display error message
                MessageBox.Show("Email Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
                return false;
            }

            //Street Field
            //String.isNullOrWhileSpace indicate whether a specified string is null, empty, or consists only of whitespace character
            if (String.IsNullOrWhiteSpace(txtStreet.Text))
            {
                //Display error message
                MessageBox.Show("Street Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Focus();
                return false;
            }

            //Town Field
            //String.isNullOrWhileSpace indicate whether a specified string is null, empty, or consists only of whitespace character
            if (String.IsNullOrWhiteSpace(txtTown.Text))
            {
                //Display error message
                MessageBox.Show("Town Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Focus();
                return false;
            }

            //County Field
            //String.isNullOrWhileSpace indicate whether a specified string is null, empty, or consists only of whitespace character
            if (String.IsNullOrWhiteSpace(txtCounty.Text))
            {
                //Display error message
                MessageBox.Show("County Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Focus();
                return false;
            }

            return true;
        }

        //Private Method to set tool tip text
        private void setToolTipText()
        {
            //Create the ToolTip and associate with the Form container.
            ToolTip toolTip = new ToolTip();

            // Set up the delays for the ToolTip.
            toolTip.AutoPopDelay = 3000;
            toolTip.InitialDelay = 500;
            toolTip.ReshowDelay = 100;
            //Force the ToolTip text to be displayed whether or not the form is active.
            toolTip.ShowAlways = true;

            //Set up the ToolTip text for the Button and Checkbox.
            toolTip.SetToolTip(this.txtPPS, "PPS Format: 7 Digits follow by either 1 or 2 Characters");
            toolTip.SetToolTip(this.txtEmail, "Email Format: abc.123@gmail.com");
            toolTip.SetToolTip(this.txtPhone, "Phone Format: 083 1234567");
        }

        //End of Code
    }
}
