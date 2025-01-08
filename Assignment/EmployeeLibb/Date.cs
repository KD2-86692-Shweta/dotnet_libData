using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibb
{
    public class Date
    {

        private int day;
        private int month;
        private int year;

        public int Year
        {
            get { return year; }
            set { year = value; }
        }


        public int Month
        {
            get { return month; }
            set { month = value; }
        }

        public int Day
        {
            get { return day; }
            set { day = value; }
        }

        public Date()
        {

        }

        public Date(int day, int month, int year)
        {
            this.day = day;
            this.month = month;
            this.year = year;
        }

        public void acceptDate()
        {
            Console.WriteLine("Enter day");
            day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter month");
            month = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter year");
            year = Convert.ToInt32(Console.ReadLine());



        }

        public String PrintDate()
        {
            return day.ToString() + month.ToString() + year.ToString();
        }

        public bool isValid(Date date)
        {
            if (date.day < 31 && date.day > 0 && date.month > 0 && date.month < 13)
            {
                return true;
            }

            return false;
        }

        public static int differenceofDates(Date d1, Date d2)
        {

            return d1.year - d2.year;
        }

        public static int operator -(Date d1, Date d2)
        {

            return differenceofDates(d1,d2);
        }

        public string ToString()
        {
            return day.ToString() + month.ToString() + year.ToString();
        }

    }
}
