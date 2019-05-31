using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibSYS
{
    class RevenueAnalysis
    {
        //Static method to get Book Price Analysis (Monthly)
        public static DataSet getBookPriceAnalysis(DataSet ds, String strYear)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query
            //Use 'MM' Date Format to Order data -> 'MM' Data Format (Jan - 01)
            String strSQL = "SELECT TO_CHAR(PurchaseDate,'MONTH') AS \"MONTH\", SUM(Price) AS \"TOTAL PRICE\" " +
                            "FROM Books " +
                            "WHERE TO_CHAR(PurchaseDate,'yyyy') = '" + strYear + "' " +
                            "GROUP BY TO_CHAR(PurchaseDate,'MONTH'), TO_CHAR(PurchaseDate,'MM') " +
                            "ORDER BY TO_CHAR(PurchaseDate,'MM')";
                              
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "bookAnalysis");

            //Close connection
            conn.Close();

            return ds;
        } //End

        //Static method to get Fine Analysis (Monthly)
        public static DataSet getFineAnalysis(DataSet ds, String strYear)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query
            //Use 'MM' Date Format to Order data -> 'MM' Data Format (Jan - 01)
            String strSQL = "SELECT TO_CHAR(ReturnDate,'MONTH') AS MONTH, SUM(FineAmount) AS \"TOTAL FINE\" " +
                            "FROM BookRentalItems " +
                            "WHERE TO_CHAR(ReturnDate,'yyyy') = '" + strYear + "' " +
                            "GROUP BY TO_CHAR(ReturnDate,'MONTH'), TO_CHAR(ReturnDate,'MM') " +
                            "ORDER BY TO_CHAR(ReturnDate,'MM')";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "fineAnalysis");

            //Close connection
            conn.Close();

            return ds;
        } //End

        //Get Months_Reference Table
        public static DataSet getMonthReference(DataSet ds, String strColumnName)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT Months AS \"MONTH\", Value AS \"" + strColumnName + "\" " +
                            "FROM Month_Reference";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execure Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "monthReference");

            //Close Connection
            conn.Close();

            return ds;
        } //End

    }
}
