using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Time
    {
        
        //private variabel atau field

        public int year;
        public int month;
        public int date;
        public int hour;
        public int minute;
        public int second;


        //property
        public int Year
        {
            get { return Year; }
            set { Year = value; }
        }

        public int Month
        {
            get { return Month; }
            set { Month = value; }
        }

        public int Date
        {
            get { return Date; }
            set { Date = value; }
        }

        public int Hour
        {
            get { return hour; }
            set { hour = value; }
        }

        public int Minute
        {
            get { return minute; }
            set { minute = value; }
        }

        public int Second
        {
            get { return second; }
            set { second = value; }
        }

        public Time()
        {
            year = 2018;
            month = 10;
            date = 10;
            hour = 10;
            minute = 30;
            second = 40;
        }


        //public methods
        public void DisplayCurrentTime()
        {
            Console.WriteLine("Waktu sekarang : {0}", DateTime.Now.ToString());
        }
        

    }
}
