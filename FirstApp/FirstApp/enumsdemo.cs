using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    enum status
    {
        permanent,
        temporary,
        consultant,
        trainee
    }
    enum gender
    {
        male,
        female
    }
    class Person
    {
        public string empname;
        public status empstat;
        public gender empgen;
    }
    class enumsdemo
    {
        static void Main(string[] args)
        {
            Person per = new Person();
            per.empname = "Rushikesh Shinde";
            per.empstat = status.permanent;
            per.empgen = gender.male;

            Console.WriteLine("Name : "+per.empname+", Status :"+ per.empstat +", Gender : "+per.empgen);
            Console.Read();
        }
    }
}
