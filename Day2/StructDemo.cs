using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{

    //Difference
    //STructure can not have parameterless contr
    //Structure are value types whereas classes are ref types
    // STructure can not have inhertence but they can implement interfaces
    
    struct Book
    {
      public  string BookName;
        public int NoOfPages;

      public  Book(string name,int page)
        {
            BookName = name;
            NoOfPages = page;
        }
      
        public void readBook()
        {
            Console.WriteLine("readBook is called");
        }
    }
      class StructDemo
    {
        static void Main(string[] args)
        {
            Book bk = new Book("C#", 100);
            bk.readBook();
        }
    }
}
