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
    public partial class frmRecordFine : Form
    {
        frmMainMenu parent;

        public frmRecordFine()
        {
            InitializeComponent();
        }

        public frmRecordFine(frmMainMenu Parent)
        {
            InitializeComponent();
            parent = Parent;

            this.ActiveControl = txtPPSSearch;
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //search Fine File
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //set pay date to current date (system date)

            //set fine status to 'paid'

            //update fine balance in Member File

            //update fine details in File File

            //display confirmation message
            MessageBox.Show("Loan Details Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //clear UI
            txtPPSSearch.Clear();
            txtPPSFine.Clear();
            txtMemberID.Clear();
            txtSurname.Clear();
            txtForename.Clear();
            txtFine.Clear();
            txtPPSSearch.Focus();
        }
    }
}
