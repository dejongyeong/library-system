using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace LibSYS
{
    class Loans
    {
        //Constant for Fine
        public const double PENALTY = 0.20;

        //Variables
        private int intLoanID;
        private int intMemID;
        private String strBorrowDate;
        private String strReturnDate;

        //Constructor
        public Loans()
        {
            intLoanID = 0;
            intMemID = 0;
            strBorrowDate = "Unknown";
            strReturnDate = "Unknown";
        }
        
        //Mutator Methods
        public void setLoanID(int intLoanID)
        {
            this.intLoanID = intLoanID;
        }

        public void setMemID(int intMemID)
        {
            this.intMemID = intMemID;
        }

        public void setBorrowDate(String strBorrowDate)
        {
            this.strBorrowDate = strBorrowDate;
        }

        public void setReturnDate(String strReturnDate)
        {
            this.strReturnDate = strReturnDate;
        }
        //End Mutator Method

        //Accessor Method
        public int getLoanID()
        {
            return intLoanID;
        }

        public int getMemID()
        {
            return intMemID;
        }

        public String getBorrowDate()
        {
            return strBorrowDate;
        }

        public String getReturnDate()
        {
            return strReturnDate;
        }
        //End Accessor Method

        //Static method get next Loan ID
        public static int getNextLoanID()
        {
            //Initialize variable
            int intNextLoanID;

            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to get MAX MemberID used
            String strSQL = "SELECT MAX(LoanID) FROM Rentals";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the first (only) value returned
            //If first MemID, assign value 1, else add 1 to max value
            dr.Read();

            if (dr.IsDBNull(0))
                intNextLoanID = 1;
            else
                intNextLoanID = Convert.ToInt32(dr.GetValue(0)) + 1;

            //close connection
            conn.Close();

            return intNextLoanID;
        } //End getNextLoanID()
        
        //Get Number of Books Borrow
        public static int getNumBooksBorrow(int intMemID)
        {
            //Initialize variable
            int intBookBorrow;

            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT Books_Borrow FROM Members WHERE MemID = " + intMemID;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //Read
            dr.Read();

            //Validate
            if (dr.IsDBNull(0))
                return -1;
            else
                intBookBorrow = Convert.ToInt32(dr.GetValue(0));
            
            return intBookBorrow;
        }       
        
        //Update Book Status to 'U' if borrowed or 'A' if returned
        public static void updBookStatus(int intBookID, char chStatus)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL to Update
            String strSQL = "UPDATE Books " +
                            "SET Book_Status = '" + chStatus + "' " +
                            "WHERE BookID = " + intBookID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();
        } //End Update Book Status

        //Update Total Books Borrow of a Member (+1)
        public static void updBooksBorrowIncrement(int intMemID)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL to Update
            String strSQL = "UPDATE Members " +
                            "SET Books_Borrow = Books_Borrow + 1 " +
                            "WHERE MemID = " + intMemID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();
        } //End Update Total Books Borrow

        //Update Total Books Borrow (-1)
        public static void updBooksBorrowDecrement(int intMemID)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL to Update
            String strSQL = "UPDATE Members " +
                            "SET Books_Borrow = Books_Borrow - 1 " +
                            "WHERE MemID = " + intMemID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();
        } //End Update Total Books Borrow Decrement

        //Register Loans
        public void regLoan()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query to Insert
            String strSQL = "INSERT INTO Rentals " +
                            "VALUES(" + this.intLoanID.ToString() + "," + this.intMemID.ToString() + ",'" +
                            String.Format("{0:dd-MMM-yy}", this.strBorrowDate) + "','" + 
                            String.Format("{0:dd-MMM-yy}", this.strReturnDate) + "')";

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();
        } //End of Register Loan

        //Get Loan method to get Loan Details
        public void getLoan(int intLoanID)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT R.* " + 
                            "FROM Rentals R, BookRentalItems I " + 
                            "WHERE R.LoanID = I.LoanID AND " + 
                                  "R.LoanID = " + intLoanID;

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Instantiate the instance variables of the object with dr
            //Execute Oracle Command
            OracleDataReader dr = cmd.ExecuteReader();            
            dr.Read();

            this.intLoanID = dr.GetInt32(0);
            this.intMemID = dr.GetInt32(1);
            this.strBorrowDate = dr.GetDateTime(2).ToString("dd/MM/yyyy");
            this.strReturnDate = dr.GetDateTime(3).ToString("dd/MM/yyyy");

            //Close DB Connection
            conn.Close();
        } //End Loan method

        //End of Code
    }
}
