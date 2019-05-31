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
    public partial class frmUpdateMemberDetails : Form
    {
        frmUpdateMember parent;

        public frmUpdateMemberDetails()
        {
            InitializeComponent();
        }

        public frmUpdateMemberDetails(frmUpdateMember Parent)
        {
            InitializeComponent();
            parent = Parent;

            txtPPS.Focus();

            //get data from Member File and set txtMemberID  
            //get data from Member File and set txtPPS
            //get data from Member File and set txtSurname
            //get data from Member File and set txtForename
            //get data from Member File and set dtpDOB
            //get data from Member File and set optMale/optFemale
            //get data from Member File and set txtStreet
            //get data from Member File and set txtTown
            //get data from Member File and set txtCounty
            //get data from Member File and set txtContact
            //get data from Member File and set txtEmail
            //get data from Member File and set dtpRegisterDate
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //validate input

            MessageBox.Show("Member 0001 Profile Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            parent.Show();
        }
    }
}
