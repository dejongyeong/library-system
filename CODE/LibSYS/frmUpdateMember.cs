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
    public partial class frmUpdateMember : Form
    {
        frmMainMenu parent;

        public frmUpdateMember()
        {
            InitializeComponent();
        }

        public frmUpdateMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;
        }

        private void frmUpdateMember_Load(object sender, EventArgs e)
        {
            //Asign default values for display
            dtpDOB.MaxDate = DateTime.Today;
            dtpDOB.Value = DateTime.Today;
            dtpRegisterDate.MaxDate = DateTime.Today;
            dtpRegisterDate.Value = DateTime.Today;

            //Call Method to set MemberList Grid style
            setMemberListStyle();

            //Calling method to set tool tip text
            setToolTipText();
            
        } //End form load even

        //Exit MenuBar
        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Back MenuBar
        private void mnuBack_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Show();
        }

        //Clear Button 
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtSname.Clear();
            txtSname.Focus();
            grdMemberList.Visible = false;
            grpUpdMemDetails.Visible = false;
        }

        //Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get searched Surname
            String strSearch = txtSname.Text;

            //Validate strSearch
            if(strSearch == "")
            {
                MessageBox.Show("Search field must not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSname.Focus();
            }
            else
            {
                DataSet ds = new DataSet();

                //Load Data onto data grid
                grdMemberList.DataSource = Members.getMember(ds, strSearch).Tables["mem"];

                //Check if any data source return, if no data return display message
                if (grdMemberList.DataSource == null || grdMemberList.RowCount == 0)
                {
                    MessageBox.Show("No such record found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        } //End btnSearch_Click

        //MemberList Cell Click Event
        private void grdMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Instantiate Members object
            Members aMember = new Members();

            //Extract MemID from column 0 of selected row
            //Retrieve details from this member item from DB
            aMember.getMember(Convert.ToInt32(grdMemberList.Rows[grdMemberList.CurrentCell.RowIndex].Cells[0].Value));

            //Load instance variable values onto form
            txtMemID.Text = aMember.getMemID().ToString("0000");
            txtPPS.Text = aMember.getPpsNo();
            txtSurname.Text = aMember.getSurname();
            txtForename.Text = aMember.getForename();
            dtpDOB.Value = Convert.ToDateTime(aMember.getDob());

            //Declaring a variable to check gender
            char gender = aMember.getGender();
            if (gender == 'M')
                radMale.Checked = true;
            else if (gender == 'F')
                radFemale.Checked = true;

            txtStreet.Text = aMember.getStreet();
            txtTown.Text = aMember.getTown();
            txtCounty.Text = aMember.getCounty();
            txtPhone.Text = aMember.getPhone();
            txtEmail.Text = aMember.getEmail();
            dtpRegisterDate.Value = Convert.ToDateTime(aMember.getRegDate());

            //Display Member details
            grpUpdMemDetails.Visible = true;
        } //End grdMemberList_CellClick();

        //Update Button Event
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Instance of Members
            Members aMember = new Members();

            //Retrieve details from this member item from DB
            aMember.getMember(Convert.ToInt32(grdMemberList.Rows[grdMemberList.CurrentCell.RowIndex].Cells[0].Value));

            //Calling Method to check empty textbox
            if (!checkEmptyTextBox())
            {
                return;
            }

            //Validate PPS
            if (!MemberValidation.isValidPPS(txtPPS.Text))
            {
                MessageBox.Show("PPS Number: " + txtPPS.Text + " invalid format! 7 Digits followed by 2 Uppercase Letters", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPPS.Text = "";
                txtPPS.Focus();
                return;
            } //End Validate PPS

            //Validate PPS only if the PPS No has changed, check for duplicate PPS in DB
            if(!aMember.getPpsNo().Equals(txtPPS.Text))
            {
                //Validate duplicate PPS
                if (!MemberValidation.isDuplicatePPS(txtPPS.Text))
                {
                    MessageBox.Show("PPS Number: " + txtPPS.Text + " is already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPPS.Text = "";
                    txtPPS.Focus();
                    return;
                } //End validate duplicate PPS
            }

            //Validate Surname
            if (!MemberValidation.isValidSurname(txtSurname.Text))
            {
                MessageBox.Show("Surname '" + txtSurname.Text + "' invalid! No digits allowed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSurname.Text = "";
                txtSurname.Focus();
                return;
            } //End Validate Surname

            //Validate Forename
            if (!MemberValidation.isValidForename(txtForename.Text))
            {
                MessageBox.Show("Forename '" + txtForename.Text + "' invalid! No digits allowed!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtForename.Text = "";
                txtForename.Focus();
                return;
            } //End Validate Forename

            //Validate Age
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

            //Validate Phone
            if (!MemberValidation.isValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone '" + txtPhone.Text + "' invalid format! E.g. 083 5763489", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Text = "";
                txtPhone.Focus();
                return;
            } //End Validate Phone

            //Vaidate Email
            if (!MemberValidation.isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email '" + txtEmail.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Text = "";
                txtEmail.Focus();
                return;
            } //End Validate Email

            //Validate only if the email has changed, check for duplicate email in DB
            if(!aMember.getEmail().Equals(txtEmail.Text))
            {
                if(!MemberValidation.isDuplicateEmail(txtEmail.Text))
                {
                    MessageBox.Show("Email '" + txtEmail.Text + "' is already exists", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Text = "";
                    txtEmail.Focus();
                    return;
                }
            }

            //Validate Street
            if(!MemberValidation.isValidStreet(txtStreet.Text))
            {
                MessageBox.Show("Street '" + txtStreet.Text + "' invalid!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtStreet.Text = "";
                txtStreet.Focus();
                return;
            }

            //Validate Town
            if(!MemberValidation.isValidTown(txtTown.Text))
            {
                MessageBox.Show("Town '" + txtTown.Text + "' invalid! No digits allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTown.Text = "";
                txtTown.Focus();
                return;
            }

            //Validate County
            if(!MemberValidation.isValidCounty(txtCounty.Text))
            {
                MessageBox.Show("County '" + txtCounty.Text + "' invalid! No digits allowed", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCounty.Text = "";
                txtCounty.Focus();
                return;
            }

            //Update Member Details in DB
            aMember.setMemID(Convert.ToInt32(txtMemID.Text));
            aMember.setPpsNo(txtPPS.Text);
            aMember.setSurname(txtSurname.Text.Trim());
            aMember.setForename(txtForename.Text.Trim());
            aMember.setDOB(dtpDOB.Value.ToString("dd-MMM-yy"));
            aMember.setGender(chrGender);
            aMember.setPhone(txtPhone.Text.Trim());
            aMember.setEmail(txtEmail.Text.Trim());
            aMember.setStreet(txtStreet.Text.Trim());
            aMember.setTown(txtTown.Text.Trim());
            aMember.setCounty(txtCounty.Text.Trim());

            aMember.updMember(); //Update Member

            //Display Confirmation Message
            MessageBox.Show("Member Details " + txtMemID.Text + " Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            grpUpdMemDetails.Visible = false;
            grdMemberList.Visible = false;
            txtSname.Text = "";
            txtSname.Focus();
        } //End btnUpd_Click    

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

        private void setMemberListStyle()
        {
            //Set MemberList GridView Style
            grdMemberList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdMemberList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdMemberList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdMemberList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMemberList.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdMemberList.DefaultCellStyle.BackColor = Color.Empty;
            grdMemberList.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdMemberList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdMemberList.GridColor = SystemColors.ControlDarkDark;
            grdMemberList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            grdMemberList.DefaultCellStyle.ForeColor = Color.Black;
        } //End

        //Method to set tool tip text
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