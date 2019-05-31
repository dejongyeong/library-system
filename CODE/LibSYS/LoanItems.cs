using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibSYS
{
    class LoanItems
    {
        private int intLoanID;
        private int intBookID;
        private String strReturnDate;
        private double dblFine;

        public LoanItems()
        {
            intLoanID = 0;
            intBookID = 0;
            strReturnDate = "Unknown";
            dblFine = 0.0;
        }

        //Mutator Methods
        public void setLoanID(int intLoanID)
        {
            this.intLoanID = intLoanID;
        }

        public void setBookID(int intBookID)
        {
            this.intBookID = intBookID;
        }

        public void setReturnDate(String strReturnDate)
        {
            this.strReturnDate = strReturnDate;
        }

        public void setFineAmount(double dblFine)
        {
            this.dblFine = dblFine;
        }

        public int getLoanID()
        {
            return intLoanID;
        }

        public int getBookID()
        {
            return intBookID;
        }

        public String getReturnDate()
        {
            return strReturnDate;
        }

        public double getFineAmount()
        {
            return dblFine;
        }

        //Register Loan Items
        public void regLoanItems()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query to Insert
            String strSQL = "INSERT INTO BookRentalItems(LoanID,BookID)" +
                            "VALUES(" + this.intLoanID.ToString() + "," + this.intBookID.ToString() + ")";

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();

        } //End Register Loan Items

        //List Loan Item Details of Member
        public static DataSet getLoanItemsHistory(DataSet ds, int intMemID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT ISBN, Title " +
                            "FROM Members M, Rentals R, BookRentalItems I, Books B " +
                            "WHERE M.MemID = R.MemID AND " +
                                  "R.LoanID = I.LoanID AND " +
                                  "I.BookID = B.BookID AND " +
                                  "M.MemID = " + intMemID +
                            "GROUP BY ISBN, Title " +
                            "ORDER BY ISBN";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "loan");

            //Close Connection
            conn.Close();

            return ds;

        } //End static getLoanItems() method

        //Get Book Rental Items
        public static DataSet getLoanItems(DataSet ds, int intMemID)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT R.LoanID, I.BookID, ISBN, Title " +
                            "FROM Members M, Rentals R, BookRentalItems I, Books B " +
                            "WHERE M.MemID = R.MemID AND " +
                                  "R.LoanID = I.LoanID AND " +
                                  "I.BookID = B.BookID AND " +
                                  "M.MemID = " + intMemID + " AND " +
                                  "M.Mem_Status = 'A' AND " +
                                  "I.ReturnDate IS NULL " +
                            "ORDER BY R.LoanID, B.BookID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "loan");

            //Close Connection
            conn.Close();

            return ds;

        } //End

        //Get LoanItems method (Regular Method)
        public void getLoanItems(int intLoanID)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT I.BookID " +
                            "FROM Rentals R, BookRentalItems I " +
                            "WHERE R.LoanID = I.LoanID AND " +
                                  "R.LoanID = " + intLoanID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Instantiate the instance variables of the object with dr
            //Execute Oracle Command
            OracleDataReader dr = cmd.ExecuteReader();
            dr.Read();

            this.intBookID = dr.GetInt32(0);

            //Close DB Connection
            conn.Close();

        } //End Get LoanItems method

        //Update Loan Items Return Date
        public static void updLoanItems(int intLoanID, int intBookID, String strReturnDate)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE BookRentalItems " +
                            "SET ReturnDate = '" + String.Format("{0:dd-MMM-yy}", strReturnDate) + "' " +
                            "WHERE LoanID = " + intLoanID + " AND BookID = " + intBookID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();

        } //End

        //Update Loan Items Fine if Fine Detected
        public static void updLoanItemFine(int intLoanID, int intBookID, double dblFine)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE BookRentalItems " +
                            "SET FineAmount = " + String.Format("{0:0.00}", dblFine) + " " +
                            "WHERE LoanID = " + intLoanID + " AND " + 
                                  "BookID = " + intBookID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();

        } //End

        //End of Code
    }
}
