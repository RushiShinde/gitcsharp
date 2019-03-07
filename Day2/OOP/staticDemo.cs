using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Static methods can access only static memebers(fields+methods)
//Non static methods can access static as well as non static members
//Static memebers are accessed just by using className( do not create instance of a class)
namespace Day2.OOP
{
    class PerEMployee
    {

        public static int counter;

        public int counter1;

        public PerEMployee()
        {
            counter++;
            counter1++;
        }
             
        public static void getEMpstatus()
        {

        }

         public string EMpNAme;

        public void getSalary()
        {

        }

    }


    class staticDemo
    {
        static void Main(string[] args)
        {
            //method1();
            //method2();

            Console.WriteLine(PerEMployee.counter); //Access static member

            PerEMployee.getEMpstatus();


            PerEMployee emp1 = new PerEMployee();
            PerEMployee emp2 = new PerEMployee();
            PerEMployee emp3 = new PerEMployee();


            Console.WriteLine(PerEMployee.counter);

            Console.ReadLine();
        }

        static void method2()
        {

        }

        void method1()
        {
            method2();
        }

    }
}
