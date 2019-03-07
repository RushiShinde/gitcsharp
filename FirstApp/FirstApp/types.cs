using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class types
    {
        static void Main(string[] args)
        {
            int i = 100;
            Console.WriteLine("Value before pass by value : " +i);
            passbyvalue(i);
            Console.WriteLine("Value after pass by value : " + i);

            Employee emp = new Employee() { empId = 100, empName = "rushikesh" };
            Console.WriteLine("Value before pass by reference : " + emp.empId + ";" + emp.empName);
            passbyreference(emp);
            Console.WriteLine("Value after pass by reference : " + emp.empId + ";" + emp.empName);
            Console.Read();
        }
        static void passbyvalue(int num)
        {
            num = 200;
        }
        static void passbyreference(Employee emp)
        {
            emp.empId = 200;
            emp.empName = "jay";
        }
    }
}
