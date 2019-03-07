using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class methods
    {
        static void Main(string[] args)
        {
            // test1();

            int num1 = 100;
            int num2 = 200;
            // test2(num1,num2);


            // int result=  test3(num1, num2);

            //Console.WriteLine(result);

            //  test4();

            //int result;
            //bool status;
            //test5(out result, out status);

            //Console.WriteLine(result + " " + status);

            test6("mukta",1, 2, 3, 4, 56, 8);

            //test6();
            //test6(1, 2);

            Console.ReadLine();
        }

        //pattern1
       static void test1()
        {
            Console.WriteLine("test1 is called");
        }
        //pattern2

        static void test2(int num1,int num2)
        {
            Console.WriteLine("test2  is called with params "+num1+ " "+num2);
        }
        //pattern 3:method with return type

        static int test3(int num1,int num2)
        {
            int result = num1 + num2;

            return result;
        }

        //pattern 4: method returning in between abruptly
        static void test4()
        {
            //test3(100,200); from one method call another
            Console.WriteLine("Enter first number");

            string strnum1=  Console.ReadLine();
            int num1;
            int.TryParse(strnum1, out num1);

            //if num1 is 0 then return from here.
            
            if(num1 == 0)
            {
                return;
            }
            Console.WriteLine("Enter second number");

            string strnum2 = Console.ReadLine();
            int num2;
            int.TryParse(strnum2, out num2);


            Console.WriteLine(num1 / num2);

            
        }

        //pattern 5: with out parameter
        static void test5(out int outresult,out bool status)
        {
            Console.WriteLine("Enter first number");
            string strnum1 = Console.ReadLine();
            int num1;
            int.TryParse(strnum1, out num1);
            //if num1 is 0 then return from here.
            //if (num1 == 0)
            //{
            //    return;
            //}
            Console.WriteLine("Enter second number");

            string strnum2 = Console.ReadLine();
            int num2;
            int.TryParse(strnum2, out num2);

            outresult =  num1 / num2;

            if (outresult > 5)
                status = true;
            else

                status = false;



            //outresult 

                //  return result;
        }

        //pattern 6: params: for vraibale length argumnets
            //we can pass 0 or more values
        static void test6(string name1, params int[] values)
        {

        }
    }
}
