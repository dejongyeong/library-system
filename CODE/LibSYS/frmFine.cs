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
    public partial class frmFine : Form
    {
        frmReturn parent;

        public frmFine()
        {
            InitializeComponent();
        }

        public frmFine(frmReturn Parent)
        {
            InitializeComponent();
            parent = Parent;

            cmbStatus.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /* assign payment date
             * 
             * if payment status = owe, assign date time = empty string
             * else if payment status = paid, assign date time = system date
             * 
             * */
            
            //display confirmation message
            MessageBox.Show("Details Saved!", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //save fine details in Fine File

            //back to UI
            this.Close();
            parent.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //back to UI
            this.Close();
            parent.Show();
        }
    }
}
