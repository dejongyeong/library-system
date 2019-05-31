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
    public partial class frmDeRegMember : Form
    {
        frmMainMenu parent;

        public frmDeRegMember()
        {
            InitializeComponent();
        }

        public frmDeRegMember(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

            this.ActiveControl = txtSname;
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
        private void frmDeRegMember_Load(object sender, EventArgs e)
        {
            //Calling Method to Set MemberList GridView Style
            setMemberListStyle();
        } 

        //Clear Button Event
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Hide Member List and Member details and clear text
            grdMemberList.Visible = false;
            grpDeregMemberDetails.Visible = false;
            txtSname.Text = "";
            txtSname.Focus();
        }

        //Search Button Event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get searched Surname
            String strSearch = txtSname.Text;

            //Validate strSearch
            if (strSearch == "")
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
                    MessageBox.Show("No details found for '" + strSearch + "'", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
        } //End btnSearch_Click()

        //MemberList CellClick Event
        private void grdMemberList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Extract MemID from column 0 of selected row
            Members aMember = new Members();

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
            dtpRegDate.Value = Convert.ToDateTime(aMember.getRegDate());

            //Display Member details
            grpDeregMemberDetails.Visible = true;
        }

        //Dereg Button Event
        private void btnDereg_Click(object sender, EventArgs e)
        {
            //Dereg Member
            //Instance of Members
            Members aMember = new Members();

            //Retrieve details from this member item from DB
            aMember.getMember(Convert.ToInt32(grdMemberList.Rows[grdMemberList.CurrentCell.RowIndex].Cells[0].Value));

            int intBooksBorrow = aMember.getBooksBorrow();

            //Check if Books_Borrow is equals to 0
            if(intBooksBorrow == 0)
            {
                //Dereg Member only if Books_Borrow is equals to 0
                aMember.deregMember();

                //Display Confirmation Message
                MessageBox.Show("Member " + txtMemID.Text + " Deregistered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reset UI
                grpDeregMemberDetails.Visible = false;
                grdMemberList.Visible = false;
                txtSname.Text = "";
                txtSname.Focus();
            }
            else
            {
                //Display Error Message
                String message = intBooksBorrow + " books currently borrowed by '" + txtForename.Text + " " + txtSurname.Text + "'";
                MessageBox.Show(message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Return all books before Deregister Member", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Reset UI
                grpDeregMemberDetails.Visible = false;
                grdMemberList.Visible = false;
                txtSname.Text = "";
                txtSname.Focus();
            }          
        }

        //Method to Set MemberList GridView Style
        private void setMemberListStyle()
        {
            //Set GridView Style
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
        } //End

        //End of Code
    }
}
