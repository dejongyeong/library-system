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
    public partial class frmMainMenu : Form
    {
        public frmMainMenu()
        {
            InitializeComponent();

            //Call method to start timer for DateTime
            tmrDateTime.Start();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuRegMember_Click(object sender, EventArgs e)
        {
            frmRegMember frmNext = new frmRegMember(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuListMember_Click(object sender, EventArgs e)
        {
            frmListMembers frmNext = new frmListMembers(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuDeRegMember_Click(object sender, EventArgs e)
        {
            frmDeRegMember frmNext = new frmDeRegMember(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuUpdMember_Click(object sender, EventArgs e)
        {
            frmUpdateMember frmNext = new frmUpdateMember(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuViewMember_Click(object sender, EventArgs e)
        {
            frmViewMembersHistory frmNext = new frmViewMembersHistory(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuRegisterBook_Click(object sender, EventArgs e)
        {
            frmRegisterBook frmNext = new frmRegisterBook(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuRemoveBook_Click(object sender, EventArgs e)
        {
            frmRemoveBook frmNext = new frmRemoveBook(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuUpdateBook_Click(object sender, EventArgs e)
        {
            frmUpdBook frmNext = new frmUpdBook(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuSearchBook_Click(object sender, EventArgs e)
        {
            frmSearchBook frmNext = new frmSearchBook(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuBorrowBook_Click(object sender, EventArgs e)
        {
            frmBorrow frmNext = new frmBorrow(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuReturnBook_Click(object sender, EventArgs e)
        {
            frmReturn frmNext = new frmReturn(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuRecordFine_Click(object sender, EventArgs e)
        {
            frmUpdateFine frmNext = new frmUpdateFine(this);
            this.Hide();
            frmNext.Show();
        }

        private void mnuRevenue_Click(object sender, EventArgs e)
        {
            frmRevenueAnalysis frmNext = new frmRevenueAnalysis(this);
            this.Hide();
            frmNext.Show();
        }

        //Form Load Event
        private void frmMainMenu_Load(object sender, EventArgs e)
        {
            //Calling Method to check DB Connection
            checkConnection();
        }

        //Method to Check Connection before invoking MainMenu
        private void checkConnection()
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            DialogResult result = DialogResult.Cancel;
            Boolean valid = false;

            //check for connection during startup
            do
            {
                try
                {
                    conn.Open();
                    valid = true;
                }
                catch (OracleException ex)
                {
                    result = MessageBox.Show("Connection Failed\n" + ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            } while (result == DialogResult.Retry);

            if (valid == false)
            {
                MessageBox.Show("Connection Failed, Closing Program", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        } //End

        //Timer (DateTime) Tick Event
        /*****************************************************
        * Title: C# Tutorial 16: Dynamically Display (Running) Current DateTime
        * Author: ProgrammingKnowledge
        * Site owner/sponsor: youtube.com
        * Date: 10 APR 2013
        * Availability: https://www.youtube.com/watch?v=V-n6lJ-M-oo (Accessed 17 MARCH 2017)
        * Modified: Code refactored (method renamed)
        * *****************************************************/
        private void tmrDateTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            lblTime.Text = dateTime.ToString("dddd, dd/MM/yyyy HH:mm:ss");
        } //End

        //End of Code
    }
}
