using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {


            //membuat insta class / ojek
            Time objTime = new Time();

           /* //memberi nilai property
            objTime.year = 2009;
            objTime.month = 5;
            objTime.date = 1;
            */

            //mengambil nilai dengan properti
            Console.WriteLine("year : {0}", objTime.year.ToString());
            Console.WriteLine("Month : {0}", objTime.month.ToString());
            Console.WriteLine("Date : {0}", objTime.date);
            Console.WriteLine("Hour : {0}", objTime.hour);
            Console.WriteLine("Minute : {0}", objTime.minute);
            Console.WriteLine("Second : {0}", objTime.second);

            /*//membuat method pada class tersebut
            objTime.DisplayCurrentTime();

            //bisa diakses karena akses modifier public
            objTime.year = 2020;*/

            Console.ReadKey();
        }
    }
}
