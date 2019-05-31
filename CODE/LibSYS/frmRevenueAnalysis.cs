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
using DGVPrinterHelper;

namespace LibSYS
{
    public partial class frmRevenueAnalysis : Form
    {
        frmMainMenu parent;

        public frmRevenueAnalysis()
        {
            InitializeComponent();
        }

        public frmRevenueAnalysis(frmMainMenu Parent)
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

        private void frmRevenueAnalysis_Load(object sender, EventArgs e)
        {
            //Call Method
            viewBookReport(dtpBook.Text);
            viewFineReport(dtpFine.Text);

            //Set Maximum Year for DateTimePicker
            dtpBook.MaxDate = DateTime.Today;
            dtpFine.MaxDate = DateTime.Today;
        }

        //View Book Report if DateTimePicker Value Changed
        private void dtpBook_ValueChanged(object sender, EventArgs e)
        {
            //Calling Method
            viewBookReport(dtpBook.Text);
        }

        //View Fine Report if DateTimePicker Value Changed
        private void dtpFine_ValueChanged(object sender, EventArgs e)
        {
            //Calling Method
            viewFineReport(dtpFine.Text);
        }

        //Method to Load Book Price Report Data to Grid
        private void viewBookReport(String strBookReportYear)
        {
            //Instance of DataSet
            DataSet ds;

            //Load DataSet into DataTable
            ds = new DataSet();
            DataTable price = RevenueAnalysis.getBookPriceAnalysis(ds, strBookReportYear).Tables["bookAnalysis"];

            ds = new DataSet();
            String strColumnName = "Total Price";
            DataTable month = RevenueAnalysis.getMonthReference(ds, strColumnName).Tables["monthReference"];

            //Compare price DataTable and month DataTable
            for(int priceRow = 0; priceRow < price.Rows.Count; priceRow++)
            {
                for(int monthRow = 0; monthRow < month.Rows.Count; monthRow++)
                {
                    //Check if price DataTable row is equals to month DataTable row
                    if(price.Rows[priceRow][0].Equals(month.Rows[monthRow][0]))
                    {
                        //Replace the value of column 1 (Total) in month DataTable
                        //with the value of column 1 in price DataTable
                        month.Rows[monthRow][1] = price.Rows[priceRow][1];
                    }
                }
            }

            //Set GridView DataSource to month DataTable
            grdBookReport.DataSource = month;
            grdBookReport.Visible = true;

            //Disable Sorting when clicking Column Header
            foreach (DataGridViewColumn column in grdBookReport.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Calculate Total 
            double dblTotalBookPrice = calculateAnnual(grdBookReport);
            txtTotalBookPrice.Text = dblTotalBookPrice.ToString("0.00");

            //Calling method to set GridView Style
            setBookPriceReportGridStyle();      
        } 

        //Method to Load Fine Report Data to Grid
        private void viewFineReport(String strFineReportYear)
        {
            //Instance of DataSet
            DataSet ds;

            //Load DataSet into DataTable
            ds = new DataSet();
            DataTable fine = RevenueAnalysis.getFineAnalysis(ds, strFineReportYear).Tables["fineAnalysis"];

            ds = new DataSet();
            String strColumnName = "Total Fine";
            DataTable month = RevenueAnalysis.getMonthReference(ds, strColumnName).Tables["monthReference"];

            //Compare fine DataTable and month DataTable
            for (int fineRow = 0; fineRow < fine.Rows.Count; fineRow++)
            {
                for (int monthRow = 0; monthRow < month.Rows.Count; monthRow++)
                {
                    //Check if price DataTable row is equals to month DataTable row
                    if (fine.Rows[fineRow][0].Equals(month.Rows[monthRow][0]))
                    {
                        //Replace the value of column 1 (Total) in month DataTable
                        //with the value of column 1 in price DataTable
                        month.Rows[monthRow][1] = fine.Rows[fineRow][1];
                    }
                }
            }

            //Display Data
            grdFineReport.DataSource = month;
            grdFineReport.Visible = true;

            //Disable Sorting when clicking Column Header
            foreach (DataGridViewColumn column in grdFineReport.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }

            //Calculate Total Fine by calling method
            double dblTotalFine = calculateAnnual(grdFineReport);
            txtTotalFine.Text = dblTotalFine.ToString("0.00");

            //Calling Set GridStyle Method               
            setFineReportGridStyle();
        } //End

        //Method to calculate Annual Report
        private double calculateAnnual(DataGridView grdDataGridView)
        {
            double dblTotal = 0;

            for(int row = 0; row < grdDataGridView.Rows.Count; row++)
            {
                //Get value from column 2 (index 1)
                dblTotal += Convert.ToDouble(grdDataGridView.Rows[row].Cells[1].Value);
            }

            return dblTotal;
        } //End Method

        //Method to Reset UI
        private void Reset_Click(object sender, EventArgs e)
        {
            //Reset UI
            dtpBook.Value = DateTime.Today;
            dtpFine.Value = DateTime.Today;

            //Calling Method
            viewBookReport(DateTime.Today.Year.ToString());
            viewFineReport(DateTime.Today.Year.ToString());
        }

        //Method to set FineReport Grid
        private void setFineReportGridStyle()
        {
            grdFineReport.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdFineReport.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdFineReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdFineReport.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdFineReport.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdFineReport.DefaultCellStyle.BackColor = Color.Empty;
            grdFineReport.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdFineReport.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdFineReport.GridColor = SystemColors.ControlDarkDark;
            grdFineReport.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Method to set BookReport Grid
        private void setBookPriceReportGridStyle()
        {
            grdBookReport.ColumnHeadersDefaultCellStyle.Font = new Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point);
            grdBookReport.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
            grdBookReport.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            grdBookReport.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grdBookReport.DefaultCellStyle.Font = new Font("Tahoma", 8, FontStyle.Regular, GraphicsUnit.Point);
            grdBookReport.DefaultCellStyle.BackColor = Color.Empty;
            grdBookReport.AlternatingRowsDefaultCellStyle.BackColor = SystemColors.ControlLight;
            grdBookReport.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            grdBookReport.GridColor = SystemColors.ControlDarkDark;
            grdBookReport.DefaultCellStyle.ForeColor = Color.Black;
        }

        //Print Book Price Analysis Report
        private void btnPrintBookPriceAnalysis_Click(object sender, EventArgs e)
        {
            //DataGridView Printer Java Class
            /*****************************************************
            * Title: C# Tutorial - Print DataGridView with Header & Footer with Landscape | FoxLearn
            * Author: FoxLearn
            * Site owner/sponsor: youtube.com
            * Date: 07 Nov 2016
            * Availability: https://www.youtube.com/watch?v=-UB5mDPxAmo (Accessed 19 MARCH 2017)
            * Modified: Identifiers rename
            * *****************************************************/

            //Print Revenue Analysis
            //Instance of DGVPrinter
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.Title = "Book Price Analysis Report"; //Header

            //\u20ac - Euro Symbol
            dgvPrinter.SubTitle = String.Format("Year: " + dtpBook.Text + "\nTotal Book Price: \u20ac" + txtTotalBookPrice.Text); //Sub-Header

            //StringFormatFlags specifies the display and layout information for text strings
            dgvPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;
            dgvPrinter.PageNumbers = true;
            dgvPrinter.PageNumberInHeader = false;
            dgvPrinter.PorportionalColumns = true;
            dgvPrinter.HeaderCellAlignment = StringAlignment.Near;
            dgvPrinter.Footer = "Revenue Analysis";
            dgvPrinter.FooterSpacing = 15;
            dgvPrinter.printDocument.DefaultPageSettings.Landscape = false;
            dgvPrinter.PrintDataGridView(grdBookReport);

            //End of [non-original or refactored] code
        }

        //Print Fine Analysis Report
        private void btnPrintFineAnalysisReport_Click(object sender, EventArgs e)
        {
            //DataGridView Printer Java Class
            /*****************************************************
            * Title: C# Tutorial - Print DataGridView with Header & Footer with Landscape | FoxLearn
            * Author: FoxLearn
            * Site owner/sponsor: youtube.com
            * Date: 07 Nov 2016
            * Availability: https://www.youtube.com/watch?v=-UB5mDPxAmo (Accessed 19 MARCH 2017)
            * Modified: Identifiers rename
            * *****************************************************/

            //Print Fine Analysis Report
            //Instance of DGVPrinter
            DGVPrinter dgvPrinter = new DGVPrinter();
            dgvPrinter.Title = "Fine Analysis Report"; //Header

            //\u20ac - Euro Symbol
            dgvPrinter.SubTitle = String.Format("Year: " + dtpFine.Text + "\nTotal Fine: \u20ac" + txtTotalFine.Text); //Sub-Header

            //StringFormatFlags specifies the display and layout information for text strings
            dgvPrinter.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip; 
            dgvPrinter.PageNumbers = true;
            dgvPrinter.PageNumberInHeader = false;
            dgvPrinter.PorportionalColumns = true;
            dgvPrinter.HeaderCellAlignment = StringAlignment.Near;
            dgvPrinter.Footer = "Revenue Analysis";
            dgvPrinter.FooterSpacing = 15;
            dgvPrinter.printDocument.DefaultPageSettings.Landscape = false;
            dgvPrinter.PrintDataGridView(grdFineReport);

            //End of [non-original or refactored] code
        }

        //End Code
    }
}
