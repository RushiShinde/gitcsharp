using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{

    class A { }  //Parent 
    class B : A { } //Child class

    class Conversions
    {
        static void Main(string[] args)
        {

            //implicit conversions

            //wheneverwe try to convert smaller data type to larger data type
            //there is no data loss
           

            int i = 100;

            float f = i;

            Console.WriteLine(f);
            //explicit conversions
            // We need to convert them explicitly

            //Whenever we try to convert larger data types to smaller data type

            float f2 = 123.66f;

            int j = (int)f2;


            B objb = new B();


            A a = objb;//implicit conversion

            //int j1 = Convert.ToInt32(f2);


            //Casting Employee object to Object

            // Employee emp = new Employee();

            Object obj = getEMp();
           

            if(obj is Employee)
            {
               // Employee emp = (Employee)obj;
                Employee emp1 = obj as Employee;
            }

            //Employee emp1 =(Employee) obj;
           
            Console.WriteLine(j);
            Console.ReadLine();

        }
       // String string
        static object getEMp()
        {
            Object obj = new Employee();
            return obj;
        }
    }
}
