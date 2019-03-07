using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class boxing_unboxing
    {
        static void Main(string[] args)
        {

            //Unboxing: COnverting Ref type to Value Types

            //var name = "ancc";
          //  name = 1900;
            object obj = 100;

            int i =(int) obj; //Explicit Casting


            //Boxing :Converting Values Types to Ref Types

            int j = 100;

            object obj1 = j;  //Implicit Casting
        }

    }
}
