using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    //constant variables 
    enum empStatus { Pemenent, Temp, COnsultant, Trainee };
    class Person
    {

       public string Name;
        // public int status; // Pemenent=0 , Temp=1 , COnsultant=2 , Trainee=4

        public empStatus status;

        public int gender; //Male:0,Female:1
    }

    class enumsdemo
    {
        static void Main(string[] args)
        {
 Person per = new Person() { Name = "mukta", status =(empStatus)1, gender = 1 };
Console.WriteLine("EMployee name is " + per.Name + " and status is " + per.status);

            int iStatus = (int)per.status;
            Console.WriteLine(iStatus);
            Console.ReadLine();


        }

    }
}
