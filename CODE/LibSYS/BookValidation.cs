using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LibSYS
{
    class BookValidation
    {
        //Validate ISBN
        public static Boolean isValidISBN(String strISBN)
        {
            Regex pattern = new Regex(@"^\d{10}|\d{13}");

            if (pattern.IsMatch(strISBN))
                return true;
            else
                return false;
        } //End Validate ISBN

        //Validate ClassNo
        public static Boolean isValidClassNo(String strClassNo)
        {
            Regex pattern = new Regex(@"^\d{3}-[A-Z]{3}$");

            if (pattern.IsMatch(strClassNo))
                return true;
            else
                return false;
        } //End Validate Class No

        //Validate Title
        public static Boolean isValidTitle(String strTitle)
        {
            Regex pattern = new Regex(@"^[a-zA-Z0-9\s\W]*$");

            if (pattern.IsMatch(strTitle) && Char.IsLetter(strTitle[0]))
                return true;
            else
                return false;
        } //End Validate Title

        //Validate Author
        public static Boolean isValidAuthor(String strAuthor)
        {
            Regex pattern = new Regex(@"^[a-zA-Z\s]*$");

            if (pattern.IsMatch(strAuthor))
                return true;
            else
                return false;
        } //End Validate Author
        
        //Validate Price
        public static Boolean isValidPrice(String strPrice)
        {
            Regex pattern = new Regex(@"^[1-9][0-9]{0,2}(\.\d{1,2})?$");

            if (pattern.IsMatch(strPrice))
                return true;
            else
                return false;
        } //End Validate Price

        //Validate NoPages
        public static Boolean isValidNoPages(String strNoPages)
        {
            Regex pattern = new Regex(@"^[1-9]{1,3}");

            if (pattern.IsMatch(strNoPages))
                return true;
            else
                return false;
        } //End Validate NoPages

        //Validate PubName
        public static Boolean isValidPubName(String strPubName)
        {
            Regex pattern = new Regex(@"^[a-zA-Z\s\W]*");

            if (pattern.IsMatch(strPubName) && Char.IsLetter(strPubName[0]))
                return true;
            else
                return false;
        } //End Validate Publisher Name

        //Validate YearPublish
        public static Boolean isValidYearPublished(String strYearPub)
        {
            Regex pattern = new Regex(@"^[1-2]\d{3}");

            if (pattern.IsMatch(strYearPub))
                return true;
            else
                return false;
        } //End Validate Year Published

        //Validate Year Range
        public static Boolean isValidYearRange(String strYear)
        {
            if (Convert.ToInt32(strYear) > Convert.ToInt32(DateTime.Today.ToString("yyyy")))
            {
                return false;
            }
            else
            {
                return true;
            }
        } //End Validate Year Range

        //End Of Code
    }
}
