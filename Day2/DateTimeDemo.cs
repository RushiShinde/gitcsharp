using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class DateTimeDemo
    {
        static void Main(string[] args)
        {
            //DateTime date1 = new DateTime(2019, 10, 12);


            //Console.WriteLine(date1);


            //DateTime date2 = DateTime.Now;

            //Console.WriteLine(date2);


            DateTime date3 = DateTime.Now.AddMonths(1);
            Console.WriteLine(date3);

            Console.WriteLine(date3.Date);

            //Console.WriteLine(date3.Month);

            //Console.WriteLine(date3.Year);

            //string strDate = "10/12/2019";

            // DateTime date4=DateTime.Parse(strDate);

            //Console.WriteLine(date4);



            DateTime d1 = new DateTime(2019, 03, 05);

            DateTime d2 = new DateTime(2019, 06, 05);

            TimeSpan span = d2 - d1;

            Console.WriteLine(span);

            Console.ReadLine();

        }

    }
}
