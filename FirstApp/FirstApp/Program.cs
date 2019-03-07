using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C# Session");
            //Console.WriteLine("Press Enter to exit...");
            //Console.Read();

            Employee emp = new Employee();
            Console.WriteLine(emp.empName);
            Console.WriteLine(emp.empId);

            Product prd = new Product();
            Console.WriteLine(prd.prodId);
            Console.WriteLine(prd.prodName);
            Console.ReadLine();
        }
    }

    class Employee
    {
        public string empName = "Rushikesh";
        public int empId = 62;
    }
}
