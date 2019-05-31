using DGVPrinterHelper;
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
    public partial class frmSearchBook : Form
    {
        frmMainMenu parent;
        DataSet ds;
        DataView dv;

        public frmSearchBook()
        {
            InitializeComponent();
        }

        public frmSearchBook(frmMainMenu Parent)
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

        //Form Load
        private void frmSearchBook_Load(object sender, EventArgs e)
        {
            //Instantiate DataSet Object
            ds = new DataSet();

            //Load Data onto grid view
            grdBookList.DataSource = Books.getAllBook(ds).Tables["book"];

            //Display Error Message if no details was found
            if(grdBookList.DataSource == null || grdBookList.RowCount == 0)
            {
                //Display error message
                MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Calling method to set style of the BookList GridView
            setBookListStyle();
            
        } //End Form Load

        //Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            //Get Search Book Title
            String strTitle = txtTitle.Text;

            //Validate Search Title if is empty
            if (strTitle.Equals(""))
            {
                //Display error message
                MessageBox.Show("Search field must not be empty", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Focus();
            }
            else
            {
                //Instantiate DataSet Object
                ds = new DataSet();

                //Declare Variable
                String strOrder="";

                //Check if Radio Button is checked
                if(radBookID.Checked)
                {
                    strOrder = "BookID";
                } 
                else if(radSubject.Checked)
                {
                    strOrder = "SubjectCode";
                }
                else if(radTitle.Checked)
                {
                    strOrder = "Title";
                }

                //Search Title and Load Data onto data grid
                grdBookList.DataSource = Books.getBook(ds, strTitle, strOrder).Tables["book"];

                //Check if any data source return, if no data return display message
                if (grdBookList.DataSource == null || grdBookList.RowCount == 0)
                {
                    //Display Error Message
                    MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    //Reload Data onto grid view
                    grdBookList.DataSource = Books.getAllBook(ds).Tables["book"];

                    //Reset search box
                    txtTitle.Text = "";
                    txtTitle.Focus();
                    radBookID.Checked = true;
                } 
            } //End Validate Search Title    
        } //End Search

        //Reset UI
        private void btnClear_Click(object sender, EventArgs e)
        {
            //Reset UI
            txtTitle.Text = "";
            txtTitle.Focus();
            radBookID.Checked = true;
            radAll.Checked = true;

            //Display all Books
            //Instantiate DataSet Object
            DataSet ds = new DataSet();

            //Load Data onto grid view
            grdBookList.DataSource = Books.getAllBook(ds).Tables["book"];

        } //End Clear Event

        //All Radio Button Click
        /*****************************************************
        * Title: Clear RowFilter DataView
        * Author: Ken Tucker
        * Site owner/sponsor: social.msdn.microsoft.com
        * Date: Not Stated
        * Availability: https://social.msdn.microsoft.com/Forums/windows/en-US/d3a7b208-e5d0-4e6f-b2c0-b83cdaddccbe/clear-row-filter-dataview?forum=winformsdatacontrols (Accessed 06 APRIL 2017)
        * Modified: -
        * *****************************************************/
        private void radAll_Click(object sender, EventArgs e)
        {
            //Disable Filter
            dv.RowFilter = "";

            //End of [non-original or refactored] code
        }

        //Available Radio Button Click
        /*****************************************************
        * Title: DataGridView Sorting and Filtering
        * Author: raps mk
        * Site owner/sponsor: net-informations.com
        * Date: 2016
        * Availability: http://csharp.net-informations.com/datagridview/csharp-datagridview-filter.htm (Accessed 06 APRIL 2017)
        * Modified: Identifiers rename
        * *****************************************************/
        private void radAvailable_Click(object sender, EventArgs e)
        {
            //Variable to store OrderByValue by Calling getOrderByValue()
            String strOrderByValue = getOrderByValue();

            //Display DataView in grdBookList
            dv = new DataView(ds.Tables["book"], "Book_Status = 'A'", strOrderByValue, DataViewRowState.CurrentRows);
            grdBookList.DataSource = dv;

            //Check if any data source return, if no data return display message
            if (grdBookList.DataSource == null || grdBookList.RowCount == 0)
            {
                //Display Error Message
                MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Reload Data onto grid view
                grdBookList.DataSource = Books.getAllBook(ds).Tables["book"];

                //Reset search box
                txtTitle.Text = "";
                txtTitle.Focus();
                radBookID.Checked = true;
                radAll.Checked = true;
            }
            //End of [non-original or refactored] code
        }

        //Unavailable Radio Button click
        /*****************************************************
        * Title: DataGridView Sorting and Filtering
        * Author: raps mk
        * Site owner/sponsor: net-informations.com
        * Date: 2016
        * Availability: http://csharp.net-informations.com/datagridview/csharp-datagridview-filter.htm (Accessed 06 APRIL 2017)
        * Modified: Identifiers rename
        * *****************************************************/
        private void radUnavailable_Click(object sender, EventArgs e)
        {
            //Variable to store OrderByValue by Calling getOrderByValue()
            String strOrderByValue = getOrderByValue();

            //Display DataView in grdBookList
            dv = new DataView(ds.Tables["book"], "Book_Status = 'U'", strOrderByValue, DataViewRowState.CurrentRows);
            grdBookList.DataSource = dv;

            //Check if any data source return, if no data return display message
            if (grdBookList.DataSource == null || grdBookList.RowCount == 0)
            {
                //Display Error Message
                MessageBox.Show("No details found", "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //Reload Data onto grid view
                grdBookList.DataSource = Books.getAllBook(ds).Tables["book"];

                //Reset search box
                txtTitle.Text = "";
                txtTitle.Focus();
                radBookID.Checked = true;
                radAll.Checked = true;
            }
            //End of [non-original or refactored] code
        }

        //Method to get the value of OrderBy Options
        private String getOrderByValue()
        {
            String strOrderByValue = "";

            if(radBookID.Checked)
            {
                strOrderByValue = "BookID ASC";
            }
            else if(radTitle.Checked)
            {
                strOrderByValue = "Title ASC";
            }
            else if(radSubject.Checked)
            {
                strOrderByValue = "SubjectCode ASC";
            }

            return strOrderByValue;
        }

        //Set Book List Style
        private void setBookListStyle()
        {
            //Set BookList GridView Style
            grdBookList.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdBookList.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdBookList.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdBookList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdBookList.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdBookList.DefaultCellStyle.BackColor = Color.Empty;
            grdBookList.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdBookList.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdBookList.GridColor = SystemColors.ControlDarkDark;
            grdBookList.DefaultCellStyle.ForeColor = Color.Black;
            grdBookList.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            //Disable Sorting when clicking Column Header
            foreach (DataGridViewColumn column in grdBookList.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        } //End Style

        //Print Method
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //String Header
            String strHeader = "";
            if(radAll.Checked)
            {
                strHeader = "Book Listing";
            }
            else if(radAvailable.Checked)
            {
                strHeader = "Available Book Listing";
            }
            else if(radUnavailable.Checked)
            {
                strHeader = "Unavailable Book Listing";
            }

            //DataGridView Printer Java Class
            /*****************************************************
            * Title: C# Tutorial - Print DataGridView with Header & Footer with Landscape | FoxLearn
            * Author: FoxLearn
            * Site owner/sponsor: youtube.com
            * Date: 07 Nov 2016
            * Availability: https://www.youtube.com/watch?v=-UB5mDPxAmo (Accessed 19 MARCH 2017)
            * Modified: Identifiers rename
            * *****************************************************/

            //Print Book Listing
            //Instance of DGVPrinter
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.Title = strHeader; //Header
            dgvPrinter.SubTitle = String.Format("Date: {0}", DateTime.Now.Date.ToString("dd/MM/yyyy")); //Sub-Header
            dgvPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dgvPrinter.PageNumbers = true;
            dgvPrinter.PageNumberInHeader = false;
            dgvPrinter.PorportionalColumns = true;
            dgvPrinter.HeaderCellAlignment = StringAlignment.Near;
            dgvPrinter.Footer = "Library";
            dgvPrinter.FooterSpacing = 15;
            dgvPrinter.printDocument.DefaultPageSettings.Landscape = true;
            dgvPrinter.PrintDataGridView(grdBookList);

            //End of [non-original or refactored] code
        }

        //End of Code
    }
}
