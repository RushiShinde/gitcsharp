using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class methodoverloading
    {
        static void Main(string[] args)
        {
            car cr = new car();
            Console.WriteLine(cr.getFuelDetails());
            Console.WriteLine(cr.ToString());
            Console.ReadLine();
        }
    }

    class vehicle
    {
        public int getFuelDetails()
        {
            return 700;
        }
    }

    class car : vehicle
    {
        public new int getFuelDetails()
        {
            return 1000;
        }

        public override string ToString()
        {
            return "ToString is overrided";
        }
    }
}
