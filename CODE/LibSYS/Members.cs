using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibSYS
{
    class Members
    {
        //instance variable
        private int intMemID;
        private String strPpsNo;
        private String strSurname;
        private String strForename;
        private String strDob;
        private char chrGender;
        private String strStreet;
        private String strTown;
        private String strCounty;
        private String strPhone;
        private String strEmail;
        private String strRegDate;
        private char chrMemStatus;
        private double dblFineAmount;
        private int intBooksBorrow;

        //Constructor
        public Members()
        {
            intMemID = 0;
            strPpsNo = "Unassigned";
            strSurname = "Unknown";
            strForename = "Unknown";
            strDob = "Unassigned";
            chrGender = 'U';
            strStreet = "Unknown";
            strTown = "Unknown";
            strCounty = "Unknown";
            strPhone = "Unknown";
            strEmail = "Unknown";
            strRegDate = "Unassigned";
            chrMemStatus = 'U';
        }

        //set methods
        public void setMemID(int intMemID)
        {
            this.intMemID = intMemID;
        }

        public void setPpsNo(String strPpsNo)
        {
            this.strPpsNo = strPpsNo;
        }

        public void setSurname(String strSurname)
        {
            this.strSurname = strSurname;
        }

        public void setForename(String strForename)
        {
            this.strForename = strForename;
        }

        public void setDOB(String strDob)
        {
            this.strDob = strDob;
        }

        public void setGender(char chrGender)
        {
            this.chrGender = chrGender;
        }

        public void setStreet(String strStreet)
        {
            this.strStreet = strStreet;
        }

        public void setTown(String strTown)
        {
            this.strTown = strTown;
        }

        public void setCounty(String strCounty)
        {
            this.strCounty = strCounty;
        }

        public void setPhone(String strPhone)
        {
            this.strPhone = strPhone;
        }

        public void setEmail(String strEmail)
        {
            this.strEmail = strEmail;
        }

        public void setRegDate(String strRegDate)
        {
            this.strRegDate = strRegDate;
        }

        public void setMemStatus(char chrMemStatus)
        {
            this.chrMemStatus = chrMemStatus;
        }

        public void setFineAmount(double dblFineAmount)
        {
            this.dblFineAmount = dblFineAmount;
        }

        //get methods
        public int getMemID()
        {
            return intMemID;
        }

        public String getPpsNo()
        {
            return strPpsNo;
        }

        public String getSurname()
        {
            return strSurname;
        }

        public String getForename()
        {
            return strForename;
        }

        public String getDob()
        {
            return strDob;
        }

        public char getGender()
        {
            return chrGender;
        }

        public String getStreet()
        {
            return strStreet;
        }

        public String getTown()
        {
            return strTown;
        }

        public String getCounty()
        {
            return strCounty;
        }

        public String getPhone()
        {
            return strPhone;
        }

        public String getEmail()
        {
            return strEmail;
        }

        public String getRegDate()
        {
            return strRegDate;
        }

        public char getMemStatus()
        {
            return chrMemStatus;
        }

        public double getFineAmount()
        {
            return dblFineAmount;
        }

        public int getBooksBorrow()
        {
            return intBooksBorrow;
        }

        //getNextMemberID method 
        public static int getNextMemberID()
        {
            //initialize variable
            int intNextMemberID;

            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to get MAX MemberID used
            String strSQL = "SELECT MAX(MemID) FROM Members";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the first (only) value returned
            //If first MemID, assign value 1, else add 1 to max value
            dr.Read();

            if (dr.IsDBNull(0))
                intNextMemberID = 1;
            else
                intNextMemberID = Convert.ToInt32(dr.GetValue(0)) + 1;

            //close connection
            conn.Close();

            return intNextMemberID;

        } //end of getNextMemberID()

        //regMember method
        public void regMember()
        {
            //Connect to DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query to insert
            String strSQL = "INSERT INTO Members(MemID, PPSNo, Surname, Forename, DOB, Gender, " +
                            "Street, Town, County, Phone, Email, Reg_Date, Mem_Status) " +
                            "VALUES(" + this.intMemID.ToString() + ",'" + this.strPpsNo.ToUpper() + "','" +
                            this.strSurname.ToUpperInvariant().Trim() + "','" + this.strForename.ToUpperInvariant().Trim() + "','" +
                            String.Format("{0:dd-MMM-yy}", this.strDob) + "','" + this.chrGender + "','" +
                            this.strStreet.ToUpperInvariant().Trim() + "','" + this.strTown.ToUpperInvariant().Trim() + "','" + 
                            this.strCounty.ToUpperInvariant().Trim() + "','" +
                            this.strPhone.Trim() + "','" + this.strEmail.Trim() + "','" + 
                            String.Format("{0:dd-MMM-yy}", this.strRegDate) + "','" + this.chrMemStatus + "')";

            //Execute command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            myConn.Close();
        } //end of regMember()

        //getMember method
        public static DataSet getMember(DataSet ds)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //define sql query
            String strSQL = "SELECT * FROM Members ORDER BY MemID";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "mem");

            //close connection
            myConn.Close();

            return ds;
        } //end static getMember(DataSet) method

        //Overload getMember() for searching (surname)
        public static DataSet getMember(DataSet ds, String strSurname)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT MemID, PPSNo, Surname, Forename " +
                            "FROM Members " +
                            "WHERE Surname LIKE '" + strSurname.ToUpperInvariant() + "%'" +
                            "AND Mem_Status = 'A'" +
                            "ORDER BY MemID, Surname, Forename";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "mem");

            //Close Connection
            myConn.Close();

            return ds;
        } //end static getMember(DataSet) method

        //Overload getMember() for searching (surname and forename)
        public static DataSet getMember(DataSet ds, String strSurname, String strForename)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT MemID, PPSNo, Surname, Forename " +
                            "FROM Members " +
                            "WHERE Surname = '" + strSurname.ToUpperInvariant() + "'" +
                            "AND Forename = '" + strForename.ToUpperInvariant() + "'" +
                            "ORDER BY MemID";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "mem");

            //Close Connection
            myConn.Close();

            return ds;
        } //end static getMember(DataSet) method

        //Overload getMember() for filtering
        public static DataSet getMemberSort(DataSet ds, String strFilter)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT * " +
                            "FROM Members " +
                            "WHERE Mem_Status = '" + strFilter + "'" +
                            "ORDER BY MemID, Surname, Forename";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "mem");

            //Close Connection
            myConn.Close();

            return ds;
        } //End static getMember() method

        //Overload getMember()
        public void getMember(int intMemID)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Members WHERE MemID = " + intMemID;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Oracle Command
            OracleDataReader dr = cmd.ExecuteReader();

            //Instantiate the instance variables of the object with dr
            dr.Read();

            this.intMemID = dr.GetInt32(0);
            this.strPpsNo = dr.GetString(1).Trim();
            this.strSurname = dr.GetString(2).Trim();
            this.strForename = dr.GetString(3).Trim();
            this.strDob = dr.GetDateTime(4).ToString("dd/MM/yyyy");
            this.chrGender = Convert.ToChar(dr.GetString(5));
            this.strStreet = dr.GetString(6).Trim();
            this.strTown = dr.GetString(7).Trim();
            this.strCounty = dr.GetString(8).Trim();
            this.strPhone = dr.GetString(9).Trim();
            this.strEmail = dr.GetString(10).Trim();
            this.strRegDate = dr.GetDateTime(11).ToString("dd/MM/yyyy");
            this.intBooksBorrow = dr.GetInt32(12);
            this.dblFineAmount = Convert.ToDouble(dr.GetDouble(13));

            //Close DB Connection
            conn.Close();
        } //End Method Overloading

        //Update Member Details
        public void updMember()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL to Update
            String strSQL = "UPDATE Members SET PPSNo = '" + this.strPpsNo.ToUpper().Trim() + "', Surname = '" +
                            this.strSurname.ToUpperInvariant().Trim() + "', Forename = '" + this.strForename.ToUpperInvariant().Trim() + "', DOB = '" +
                            String.Format("{0:dd-MMM-yy}", this.strDob) + "', Gender = '" + this.chrGender + "', Phone = '" +
                            this.strPhone.Trim() + "', Email = '" + this.strEmail.Trim() + "', Street = '" + this.strStreet.ToUpperInvariant().Trim() + "', Town = '" +
                            this.strTown.ToUpperInvariant().Trim() + "', County = '" + this.strCounty.ToUpperInvariant().Trim() + "' " +
                            "WHERE MemID = " + this.intMemID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();
        } //End of updMember()

        //Deregister Member 
        public void deregMember()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL to deregister member
            String strSQL = "UPDATE Members " + 
                            "SET Dereg_Date = '" + String.Format("{0:dd-MMM-yy}", DateTime.Today) + "', Mem_Status = 'D' " +
                            "WHERE MemID = " + this.intMemID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        } //End deregMember()

        //Update Fine Amount
        public static void updFineAmount(int intMemID, double dblFine)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE Members " +
                            "SET Fine_Bal = " + String.Format("{0:0.00}", dblFine) + " " +
                            "WHERE MemID = " + intMemID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();
        } //End

        //Update Fine Paid
        public void updFinePaid(double dblAmtPaid)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "UPDATE Members " +
                            "SET Fine_Bal = Fine_Bal - " + dblAmtPaid + " " +
                            "WHERE MemID = " + this.intMemID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();
        } //End Update Fine Paid

        //End of Code
    }
}
