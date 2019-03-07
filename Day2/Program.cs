using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    TYpes is C#:

    Value Types:

    Primitive data types except string

    int,float,double bool enums,struct


    Reference Types:

    classes,arrays,interface ,String*/






namespace Day2
{
    class Employee
    {
       public string name;
       public int id;

      public  Employee()
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Value Type
            int i = 100;
            Console.WriteLine("Before calling method " + i);//100
            PassByValue(ref i);

            Console.WriteLine("After calling method " + i);

            //Ref type

            //Employee emp = new Employee();
            //emp.name = "sachin";
            //emp.id = 100;

            Employee emp1 = new Employee(){ id = 200, name = "virat"};
            Console.WriteLine("before "+emp1.name + " " + emp1.id);
            PassByref(emp1);
            Console.WriteLine("after " + emp1.name + " " + emp1.id);
            Console.ReadLine();
        }
        //Whenever we pass ref types a mem address is passed
        static void PassByref(Employee emp)
        {
            emp.name = "laxman";
            emp.id = 300;
        }

        //wheenver we pass value types to method a copy of that type is passed
        //static void PassByValue(int inum)
        //{
        //    inum = 200;
        //}


            //Pass by ref
        static void PassByValue(ref int inum)
        {
            inum = 200;
        }


    }
}
