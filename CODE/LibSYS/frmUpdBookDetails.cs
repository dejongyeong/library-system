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
    public partial class frmUpdBookDetails : Form
    {
        frmUpdBook parent;

        public frmUpdBookDetails()
        {
            InitializeComponent();
        }

        public frmUpdBookDetails(frmUpdBook Parent)
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //validate input

            MessageBox.Show("Book 0001 Updated", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
            parent.Show();
        }
    }
}
