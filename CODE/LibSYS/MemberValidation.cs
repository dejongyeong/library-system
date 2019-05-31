using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using System.Text.RegularExpressions;
using System.Data;

namespace LibSYS
{
    class MemberValidation
    {
        //Validate PPS
        public static bool isValidPPS(String strPpsNo)
        {
            Regex pattern = new Regex(@"^[0-9]{7}[A-Z]{1,2}");

            if (pattern.IsMatch(strPpsNo))
                return true;
            else
                return false;
        } //End isValidPPS()

        //Validate Surname
        public static bool isValidSurname(String strSurname)
        {
            Regex pattern = new Regex(@"^[a-zA-Z\s]*$");

            if (pattern.IsMatch(strSurname))
                return true;
            else
                return false;
        } //End isValidSurname()

        //Validate Forename
        public static bool isValidForename(String strForename)
        {
            Regex pattern = new Regex(@"^[a-zA-Z\s]*$");

            if (pattern.IsMatch(strForename))
                return true;
            else
                return false;
        } //End isValidForename()

        //calulate age method
        /*****************************************************
        * Title: How to calculate age from Date of Birth C#
        * Author: Upendra Pratap Shahi
        * Site owner/sponsor: c-sharpcorner.com
        * Date: 25 May 2015
        * Availability: http://www.c-sharpcorner.com/code/961/how-to-calculate-age-from-date-of-birth-in-c-sharp.aspx (Accessed 3 FEB 2017)
        * Modified: Code refactored (method renamed)
        * *****************************************************/
        public static int calculateAge(DateTime dtpDOB)
        {
            int age = 0;
            age = DateTime.Now.Year - dtpDOB.Year;
            if (DateTime.Now.DayOfYear < dtpDOB.DayOfYear)
            {
                age--;
            }

            return age;
        } //End calculateAge()

        //Validate Phone
        public static bool isValidPhone(String strPhone)
        {
            Regex pattern = new Regex(@"^\d{3}\s\d{7,10}");

            if (pattern.IsMatch(strPhone))
                return true;
            else
                return false;
        } //End of isValidPhone()

        //Validate Email
        public static bool isValidEmail(String strEmail)
        {
            if (Regex.IsMatch(strEmail, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" + @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$", RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                return true;
            }
            else
            {
                return false;
            }
        } //end validEmail() method

        //Validate street method
        public static bool isValidStreet(String strStreet)
        {
            Regex pattern = new Regex(@"^[a-zA-Z0-9\s]*$");

            if (pattern.IsMatch(strStreet))
                return true;
            else
                return false;
        } //end of isValidStreet()

        //validate town method
        public static bool isValidTown(String strTown)
        {
            Regex pattern = new Regex(@"^[a-zA-Z\s]*$");

            if (pattern.IsMatch(strTown))
                return true;
            else
                return false;
        } //end of isValidTown()

        //validate county method
        public static bool isValidCounty(String strCounty)
        {
            Regex pattern = new Regex(@"^[a-zA-Z\s]*$");

            if (pattern.IsMatch(strCounty))
                return true;
            else
                return false;
        } //end of isValidCounty()

        //Check for Duplication email
        public static bool isDuplicateEmail(String strEmail)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            DataSet ds = new DataSet();

            //Defind SQL query
            String strSQL = "SELECT * FROM Members WHERE Email = '" + strEmail + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);

            //Declare i and check for duplication, if duplicated, return integer
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
                return false;
            else
                return true;
        } //end isDuplicateEmail()

        //Check for Duplication PPS
        public static bool isDuplicatePPS(String strPPS)
        {
            OracleConnection conn = new OracleConnection(DBConnect.oradb);

            DataSet ds = new DataSet();

            //Defind SQL query
            String strSQL = "SELECT * FROM Members WHERE PPSNo = '" + strPPS + "'";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Execute Query
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            da.Fill(ds);

            //Declare i and check for duplication, if duplicated, return integer
            int i = ds.Tables[0].Rows.Count;

            if (i > 0)
                return false;
            else
                return true;
        } //end isDuplicateEmail()

        //Validate Fine
        public static Boolean isValidFine(String strFine)
        {
            Regex pattern = new Regex(@"^[0-9]{0,2}(\.\d{1,2})?$");

            if (pattern.IsMatch(strFine))
                return true;
            else
                return false;
        } //End Validate Price

        //End of Code
    }
}
