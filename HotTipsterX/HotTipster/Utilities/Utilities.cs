using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace HotTipster.Utilities
{
    public class Utilities
    {

        //Trim any blank or empty chars from beginning or end of strings in an array
        public static string[] TrimArrayStrings(string[] myarr)
        {
            for (int i = 0; i < myarr.Length; i++)
            {
                string b = myarr[i];
                myarr[i] = b.Trim();
            }
            return myarr;
        }

        public string formatDate(DateTime dateAndTime)
        {
            decimal year = dateAndTime.Year;
            decimal month = dateAndTime.Month;
            decimal day = dateAndTime.Day;

            var date = string.Format($"({year}, {month}, {day})");
            return date;
        }

        public string ValidRaceDate(string date)
        {
            if (!Regex.IsMatch(date, @"^(19|20)\d\d[, \/.](0[1-9]|1[012])[, \/.](0[1-9]|[12][0-9]|3[01])$"))
            {
                throw new FormatException("Invalid date.");
            }

            else
            {
                return date;
            }
        }
    }
}
