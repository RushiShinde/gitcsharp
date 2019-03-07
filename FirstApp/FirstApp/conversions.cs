using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class conversions
    {
        static void Main(string[] args)
        {
            // boxing is converting value type to ref type

            int j = 100;
            object obj1 = j; //implicit casting

            // unboxing is converting ref type to value type

            object obj2 = 100;
            int x = (int)obj2; //explicit casting

        }
    }
}
