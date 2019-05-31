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
    public partial class frmDeRegMemberDetails : Form
    {
        frmDeRegMember parent;

        public frmDeRegMemberDetails()
        {
            InitializeComponent();
        }

        public frmDeRegMemberDetails(frmDeRegMember Parent)
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

        private void btnDeRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Member 0001 De-Registered", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //assign de-register date a value of system date

            //set member status to withdrawn

            this.Close();
            parent.Show();
        }
    }
}
