using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Data;

namespace LibSYS
{
    class Books
    {
        //Instance Variable
        private int intBookID;
        private String strISBN;
        private String strClassNo;
        private String strTitle;
        private String strSubjectCode;
        private String strAuthor;
        private int intEdition;
        private double dblPrice;
        private int intNoPages;
        private String strPubName;
        private String strCountryCode;
        private String strYearPub;
        private String strPurcDate;
        private char chrBookStatus;

        //Constructor
        public Books()
        {
            intBookID = 0;
            strISBN = "Unknown";
            strClassNo = "Unknown";
            strTitle = "Unknown";
            strSubjectCode = "Unknown";
            strAuthor = "Unknown";
            intEdition = 0;
            dblPrice = 0.0;
            intNoPages = 0;
            strPubName = "Unknown";
            strCountryCode = "Unknown";
            strYearPub = "Unknown";
            strPurcDate = "Unknown";
            chrBookStatus = 'U';
        } //End Constructor

        //Mutator Method
        public void setBookID(int intBookID)
        {
            this.intBookID = intBookID;
        }

        public void setISBN(String strISBN)
        {
            this.strISBN = strISBN;
        }

        public void setClassNo(String strClassNo)
        {
            this.strClassNo = strClassNo;
        }

        public void setTitle(String strTitle)
        {
            this.strTitle = strTitle;
        }

        public void setSubjectCode(String strSubjectCode)
        {
            this.strSubjectCode = strSubjectCode;
        }

        public void setAuthor(String strAuthor)
        {
            this.strAuthor = strAuthor;
        }

        public void setEdition(int intEdition)
        {
            this.intEdition = intEdition;
        }

        public void setPrice(double dblPrice)
        {
            this.dblPrice = dblPrice;
        }

        public void setPage(int intNoPages)
        {
            this.intNoPages = intNoPages;
        }

        public void setPubName(String strPubName)
        {
            this.strPubName = strPubName;
        }

        public void setCountry(String strCountryCode)
        {
            this.strCountryCode = strCountryCode;
        }

        public void setYearPub(String strYearPub)
        {
            this.strYearPub = strYearPub;
        }

        public void setPurcDate(String strPurcDate)
        {
            this.strPurcDate = strPurcDate;
        }

        public void setBookStatus(char chrBookStatus)
        {
            this.chrBookStatus = chrBookStatus;
        } //End Mutator Method

        //Accessor Method
        public int getBookID()
        {
            return intBookID;
        }

        public String getISBN()
        {
            return strISBN;
        }

        public String getClassNo()
        {
            return strClassNo;
        }

        public String getTitle()
        {
            return strTitle;
        }

        public String getSubjectCode()
        {
            return strSubjectCode;
        }

        public String getAuthor()
        {
            return strAuthor;
        }

        public int getEdition()
        {
            return intEdition;
        }

        public double getPrice()
        {
            return dblPrice;
        }

        public int getPage()
        {
            return intNoPages;
        }

        public String getPubName()
        {
            return strPubName;
        }

        public String getCountry()
        {
            return strCountryCode;
        }

        public String getYearPub()
        {
            return strYearPub;
        }

        public String getPurcDate()
        {
            return strPurcDate;
        }

        public char getBookStatus()
        {
            return chrBookStatus;
        } //End Accessor Method

        //Static method to get back subject name from reference table
        public static String getSubjectName(String strSCode)
        {
            //Declare Variable
            String strSName="";

            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT SubjectName FROM Subjects WHERE SubjectCode = '" + strSCode + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute SQL Query
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Populate Value to cmbCountry
                strSName = dr["SubjectName"].ToString();
            }

            //Close Connection
            conn.Close();

            return strSName;    
        } //End Get SubjectName Method

        //Static method to get back coutry name from reference table
        public static String getCountryName(String strCountryCode)
        {
            //Declare Variable
            String strCName = "";

            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT CountryName FROM Countries WHERE CountryCode = '" + strCountryCode + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute SQL Query
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Populate Value to cmbCountry
                strCName = dr["CountryName"].ToString();
            }

            //Close Connection
            conn.Close();

            return strCName;
        } //End Get SubjectName Method

        //Static method to get back subject code from reference table if subject is not been updated
        public static String getSubjectCode(String strSName)
        {
            //Declare Variable
            String strSCode = "";

            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT SubjectCode FROM Subjects WHERE SubjectName = '" + strSName + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute SQL Query
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Populate Value to cmbCountry
                strSCode = dr["SubjectCode"].ToString();
            }

            //Close Connection
            conn.Close();

            return strSCode;
        } //End Get SubjectName Method

        //Static method to get back subject name from reference table
        public static String getCountryCode(String strCName)
        {
            //Declare Variable
            String strCountryCode = "";

            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT CountryCode FROM Countries WHERE CountryName = '" + strCName + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute SQL Query
            OracleDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                //Populate Value to cmbCountry
                strCountryCode = dr["CountryCode"].ToString();
            }

            //Close Connection
            conn.Close();

            return strCountryCode;
        } //End Get SubjectName Method

        //Get nextBookID method
        public static int getNextBookID()
        {
            //Initialize variable
            int intNextBookID;

            //connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL query to get MAX MemberID used
            String strSQL = "SELECT MAX(BookID) FROM Books";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //Read the first (only) value returned
            //If first MemID, assign value 1, else add 1 to max value
            dr.Read();

            if (dr.IsDBNull(0))
                intNextBookID = 1;
            else
                intNextBookID = Convert.ToInt32(dr.GetValue(0)) + 1;

            //close connection
            conn.Close();

            return intNextBookID;
        } //End Get nextBookID method

        //Register Book Method
        public void regBook()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query to insert
            String strSQL = "INSERT INTO Books " +
                            "VALUES(" + this.intBookID.ToString() + ",'" + this.strISBN + "','" +
                            this.strClassNo + "','" + this.strTitle.ToUpperInvariant() + "','" +
                            this.strSubjectCode + "','" + this.strAuthor.ToUpperInvariant() + "'," + 
                            this.intEdition + "," + String.Format("{0:0.00}", this.dblPrice) + "," +
                            this.intNoPages + ",'" + this.strPubName.ToUpperInvariant() + "','" + this.strCountryCode + "','" +
                            this.strYearPub + "','" + String.Format("{0:dd-MMM-yy}", this.strPurcDate) + "','" + 
                            this.chrBookStatus + "')";

            //Execute command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            conn.Close();
        } //End regBook()

        //Get Book Method
        public static DataSet getBook(DataSet ds)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //define sql query
            String strSQL = "SELECT * FROM Books ORDER BY BookID";

            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //execute query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "book");

            //close connection
            conn.Close();

            return ds;
        } //end static getBook(DataSet) method

        //Overload Get Book Method
        public void getBook(int intBookID)
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL Query
            String strSQL = "SELECT * FROM Books WHERE BookID = " + intBookID;
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Oracle Command
            OracleDataReader dr = cmd.ExecuteReader();

            //Instantiate the instance variables of the object with dr
            dr.Read();

            this.intBookID = dr.GetInt32(0);
            this.strISBN = dr.GetString(1).Trim();
            this.strClassNo = dr.GetString(2).Trim();
            this.strTitle = dr.GetString(3).Trim();
            this.strSubjectCode = dr.GetString(4).Trim();
            this.strAuthor = dr.GetString(5);
            this.intEdition = Convert.ToInt32(dr.GetInt32(6));
            this.dblPrice = Convert.ToDouble(dr.GetDouble(7));
            this.intNoPages = Convert.ToInt32(dr.GetInt32(8));
            this.strPubName = dr.GetString(9).Trim();
            this.strCountryCode = dr.GetString(10);
            this.strYearPub = dr.GetString(11).Trim();

            //Close DB Connection
            conn.Close();
        } //End Overload Get Book Method

        //Overload getBook() to search for Book
        public static DataSet getBook(DataSet ds, String strTitle)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT BookID, ISBN, ClassNo, Title " +
                            "FROM Books " +
                            "WHERE Title LIKE '" + strTitle.ToUpperInvariant() + "%'" +
                            "AND Book_Status = 'A'" +
                            "ORDER BY BookID";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "book");

            //Close Connection
            myConn.Close();

            return ds;
        } //end static getBook(DataSet) method

        //Get All Book. Different SQL Statement
        public static DataSet getAllBook(DataSet ds)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //define sql query
            String strSQL = "SELECT * FROM Books WHERE Book_Status = 'A' OR Book_Status = 'U' ORDER BY BookID";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "book");

            //close connection
            myConn.Close();

            return ds;
        } //end static getMember(DataSet) method

        //Overload getBook() to search for Book and order the list
        public static DataSet getBook(DataSet ds, String strTitle, String strOrder)
        {
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);

            //Define SQL Query
            String strSQL = "SELECT *" +
                            "FROM Books " +
                            "WHERE Title LIKE '%" + strTitle.ToUpperInvariant() + "%'" +
                                  "AND (Book_Status = 'A' OR Book_Status = 'U')" + 
                            "ORDER BY " + strOrder;

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            ds.Clear();
            da.Fill(ds, "book");

            //Close Connection
            myConn.Close();

            return ds;
        } //end static getBook(DataSet) method

        //Update Book Method
        public void updBook()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL to Update
            String strSQL = "UPDATE Books SET ISBN = '" + this.strISBN.Trim() + "', ClassNo = '" +
                            this.strClassNo.ToUpperInvariant() + "', SubjectCode = '" +
                            this.strSubjectCode + "', Title = '" + this.strTitle.ToUpperInvariant() +
                            "', Author = '" + this.strAuthor.ToUpperInvariant() + "', Edition = " + this.intEdition +
                            ", Price = " + dblPrice + ", NoPages = " + intNoPages + ", PubName = '" + this.strPubName.ToUpperInvariant() + 
                            "', CountryCode = '" + this.strCountryCode +  "', YearPublish = '" + strYearPub + "' " + 
                            "WHERE BookID = " + this.intBookID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close Connection
            conn.Close();
        } //End Update Book

        //Remove Book Method
        public void rmvBook()
        {
            //Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Define SQL to deregister member
            String strSQL = "UPDATE Books " +
                            "SET Book_Status = 'R' " +
                            "WHERE BookID = " + this.intBookID;

            //Execute Command
            OracleCommand cmd = new OracleCommand(strSQL, conn);
            cmd.ExecuteNonQuery();

            //Close connection
            conn.Close();
        } //End deregMember()

        //End of Code
    }
}
