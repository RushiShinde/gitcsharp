using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class customexception
    {
        static void Main(string[] args)
        {
            try
            {
                EvenNoProcessing();
            }
            catch (OddException ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.Read();
        }

        static void EvenNoProcessing()
        {
            Console.WriteLine("Enter even Number : ");
            string strnum1 = Console.ReadLine();
            int num1 = int.Parse(strnum1);

            if((num1%2) != 0)
            {
                throw new OddException("The number is odd");
            }
            else
            {
                Console.WriteLine("Even Number");
            }
        }
    }
}
