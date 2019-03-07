using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ExceptionHandlingDemo
    {
        static void Main(string[] args)
        {
        //  int result=  method1();

            // Console.WriteLine(result);

            callingmethod();
            Console.ReadLine();
        }
        static void callingmethod()
        {
            try
            {
                method1();
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message + " Inout data in correct fromat");
            }
        }


        static void method1()
        {
            try
            {
                Console.WriteLine("Enter first number");

                string strnum1 = Console.ReadLine();

                int num1 = int.Parse(strnum1);

                Console.WriteLine("ENter second number");

                string strnum2 = Console.ReadLine();

                int num2 = int.Parse(strnum2);
                int result = num1 / num2;

                Console.WriteLine(result);
                //return result;
            }
            catch(FormatException ex) 
            {

                throw ex;
                //Console.WriteLine(ex.Message);
                //return 0;
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
               // return 0;
            }

            catch
            {
                //return 0;
            }
            //finally block gets executed in any condition
            finally
            {
                Console.WriteLine("finally is executed");
            }
        }
    }
}
