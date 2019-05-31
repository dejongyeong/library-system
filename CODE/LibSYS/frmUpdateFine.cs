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

namespace LibSYS
{
    public partial class frmUpdateFine : Form
    {
        //Global Variables
        frmMainMenu parent;
        private Members aMember;

        public frmUpdateFine()
        {
            InitializeComponent();
        }

        public frmUpdateFine(frmMainMenu Parent)
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

        private void frmUpdateFine_Load(object sender, EventArgs e)
        {
            //Calling method to set MemList GridView
            setMemListStyle();         
        }

        //Search button event
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get Searched Surname
            String strSurname = txtSname.Text;

            //Validate strSearch
            if (strSurname == "")
            {
                MessageBox.Show("Search field must not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSname.Focus();
            }
            else
            {
                DataSet ds = new DataSet();

                //Load Data onto data grid
                grdMemList.DataSource = Members.getMember(ds, strSurname).Tables["mem"];

                //Check if any data source return, if no data return display message
                if (grdMemList.DataSource == null || grdMemList.RowCount == 0)
                {
                    MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSname.Text = "";
                    txtSname.Focus();
                }
                else
                {
                    //Set Visibility
                    grdMemList.Visible = true;

                    //Disable Sorting when clicking Column Header
                    foreach (DataGridViewColumn column in grdMemList.Columns)
                    {
                        column.SortMode = DataGridViewColumnSortMode.NotSortable;
                    }
                }
            }
        } //End Search Event

        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset UI
            grdMemList.Visible = false;
            txtSname.Text = "";
            txtSname.Focus();
            grpFine.Visible = false;
        } //End Clear event

        private void grdMemList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Instantiate Members object
            aMember = new Members();

            //Extract MemID from column 0 of selected row
            //Retrieve details from this member item from DB
            aMember.getMember(Convert.ToInt32(grdMemList.Rows[grdMemList.CurrentCell.RowIndex].Cells[0].Value));

            //Load instance variables into form
            txtMemID.Text = aMember.getMemID().ToString("0000");
            txtPPS.Text = aMember.getPpsNo();
            txtSurname.Text = aMember.getSurname();
            txtForename.Text = aMember.getForename();
            txtTFine.Text = aMember.getFineAmount().ToString("0.00");

            //Check if Fine Amount of the selected Member = 0
            if(aMember.getFineAmount() == 0)
            {
                //Display error message
                MessageBox.Show("Member '" + txtForename.Text + " " + txtSurname.Text + "' does not have any fine recorded!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Return
                grdMemList.Visible = false;
                grpFine.Visible = false;
                txtSname.Text = "";
                txtSname.Focus();
            }
            else
            {
                //Display Fine Details
                grpFine.Visible = true;
            }
        } //End Cell Click event

        private void btnPay_Click(object sender, EventArgs e)
        {
            //txtAmtPaid must not be empty
            if(txtAmtPaid.Text == "")
            {
                MessageBox.Show("Field must not be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmtPaid.Focus();
                return;
            }
            
            //Validate Amount Paid
            if(!MemberValidation.isValidFine(txtAmtPaid.Text))
            {
                MessageBox.Show("Invalid Amount entered!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmtPaid.Text = "";
                txtAmtPaid.Focus();
                return;
            }

            if(!isValidFinePaid(txtTFine.Text, txtAmtPaid.Text))
            {
                MessageBox.Show("Amount Paid should not greater than Total Fine", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAmtPaid.Text = "";
                txtAmtPaid.Focus();
                return;
            }

            //Update Fine Balance in Member File
            aMember.updFinePaid(Convert.ToDouble(txtAmtPaid.Text));

            //Display confirmation message
            MessageBox.Show("Member '" + txtForename.Text + " " + txtSurname.Text + "' Fine Amount Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Clear UI
            grpFine.Visible = false;
            grdMemList.Visible = false;
            txtSname.Text = "";
            txtAmtPaid.Text = "";
            txtSname.Focus();
        }

        //Validate Amount of Fine Paid
        private Boolean isValidFinePaid(String strTotalFine, String strAmtPaid)
        {
            double dblTotalFine = Convert.ToDouble(strTotalFine);
            double dblAmtPaid = Convert.ToDouble(strAmtPaid);

            //Check if Amount Paid <= Fine 
            if(dblAmtPaid <= dblTotalFine)
            {
                return true;
            }
            else
            {
                return false;
            }
        } //End of isValidFinePaid

        //Set MemList Style
        private void setMemListStyle()
        {
            //Set Style
            grdMemList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdMemList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdMemList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdMemList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdMemList.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdMemList.DefaultCellStyle.BackColor = Color.Empty;
            grdMemList.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdMemList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdMemList.GridColor = SystemColors.ControlDarkDark;
            grdMemList.DefaultCellStyle.ForeColor = Color.Black;
        } //End

        //End of Code
    }
}
