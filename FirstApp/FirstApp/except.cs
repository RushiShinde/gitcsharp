using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class except
    {
        static void Main(string[] args)
        {
            div();
            Console.Read();
        }

        static void div()
        {
            string a = "";
            string b = "";

            try
            {
                Console.WriteLine("Enter First number : ");
                a = Console.ReadLine();

                Console.WriteLine("Enter second number : ");
                b = Console.ReadLine();

                int num1, num2;

                num1 = Convert.ToInt32(a);
                num2 = Convert.ToInt32(b);

                int res = num1 / num2;
                Console.WriteLine(res);
            }
            catch
            {

            }
        }
    }
}
