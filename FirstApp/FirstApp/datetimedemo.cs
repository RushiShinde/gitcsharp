using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class datetimedemo
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2019, 10, 31);

            Console.WriteLine(date1);

            DateTime date2 = DateTime.Now;

            Console.WriteLine(date2);

            DateTime date3 = DateTime.Now.AddMonths(1);

            Console.WriteLine(date3);

            Console.WriteLine(date3.Date);
            Console.WriteLine(date3.Month);
            Console.WriteLine(date3.Year);

            DateTime d1 = new DateTime(2019, 03, 05);
            DateTime d2 = new DateTime(2019, 03, 01);

            TimeSpan span = d1 - d2;

            Console.WriteLine(span);
            Console.Read();
        }
    }
}
