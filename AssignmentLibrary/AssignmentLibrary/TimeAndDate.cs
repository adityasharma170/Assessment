using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentLibrary
{
   public class TimeAndDate
    {
        public static DateTime FromDate()
        {
            Console.WriteLine("Enter FromDate : eg YYYY MM DD -");
            DateTime fromDateTime = DateTime.Parse(Console.ReadLine());
            return fromDateTime;
        }

        public static DateTime ToDate()
        {
            Console.WriteLine("Enter Todate :  : eg YYYY MM DD -");
            DateTime toDateTime = DateTime.Parse(Console.ReadLine());
            return toDateTime;

        }

        public static void Calculation(DateTime From, DateTime To)
        {
            int years = From.Year - To.Year;
            int months = From.Month - To.Month;
            int days = From.Day - To.Day;
            int totalDays = (From.Date - To.Date).Days;
            int totalMonths = totalDays / 30;

            Console.WriteLine("Days : " + totalDays);
            Console.WriteLine(totalMonths + " Months " + days + " days ");
            Console.WriteLine(years + " Years " + months + " Months " + days + " days ");
        }
    }
}
