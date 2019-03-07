using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class stringbuilderdemo
    {
        static void Main(string[] args)
        {
            string list = "first";

            list = list + "second";

            list = list + "third";

            Console.WriteLine(list);

            StringBuilder sb = new StringBuilder("Rushikesh ");

            sb.Append("Prakash ");
            sb.Append("Shinde");

            sb.Insert(0,"Mr. ");

            Console.WriteLine(sb);
            Console.Read();
        }
    }
}
