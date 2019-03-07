using DataAcces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Each Console application will have one entry point
//Class will have
// variables
//methods
//Contr
//events
//delagtes

namespace FirstApp
{
    class Program
    {
        //static void Main()
       static void Main(string[] args)
        {
            //Write/Writeline: Will write data to the console
            //read/Readline will read data from console
            Console.WriteLine("Welcome to the C# session");
            //Console.Write("My ");
            //Console.Write("Name ");


            // string EmpName = "";


            // Console.WriteLine("ENter your Name");


            //EmpName=Console.ReadLine();

            // Console.WriteLine("Welcome " + EmpName);


            // Console.WriteLine("Enter a charcter");


            // int j=Console.Read();

            // Console.WriteLine("Value of j " + j);
            // //Console.WriteLine("Press enter to exit...");
            // Console.Read();



            Employee emp = new Employee();

            Console.WriteLine(emp.EmpName);
                Console.WriteLine(emp.EMpID);

            Product prd = new Product();

            Console.WriteLine(prd.ProdName);
            Console.WriteLine(prd.ProdId);
            Console.ReadLine();

        }
    }


    class Employee
    {
        public string EmpName = "Sachin";
        public int EMpID = 1900;
    }
}
