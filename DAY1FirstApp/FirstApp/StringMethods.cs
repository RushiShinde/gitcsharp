using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class StringMethods
    {
        static void Main(string[] args)
        {

            //1. String comparsion

            string str1 = "Hello world";
            string str2 = "hello World";
            ////== operator
            //if(str1 == str2)
            //{
            //    Console.WriteLine("Strings are equal");
            //}
            //else
            //{
            //    Console.WriteLine("Strings are not equal");
            //}


            //2. Changing case of strings


            if(str1.ToLower() == str2.ToLower())
            {
                Console.WriteLine("Strings are equal");
            }

            else
            {
                Console.WriteLine("Strings are not equal");
            }

 ////1. String comparsion

            //string str1 = "Hello world";
            //string str2 = "hello World";
            //////== operator
            ////if(str1 == str2)
            ////{
            ////    Console.WriteLine("Strings are equal");
            ////}
            ////else
            ////{
            ////    Console.WriteLine("Strings are not equal");
            ////}


            ////2. Changing case of strings


            //if (str1.ToLower() == str2.ToLower())
            //{
            //    Console.WriteLine("Strings are equal");
            //}

            //else
            //{
            //    Console.WriteLine("Strings are not equal");
            //}


            ////3. Trimming strings


            //string empName = " sachin";

            //if(empName.Trim() == "sachin")
            //{
            //    Console.WriteLine("Names are equal");

            //}

            //4. Compare,CompraeTo

            //CompareTo"
            //0: if 2 strings are equal
            //-1: If first string is small to that of second one
            //1: if first string is grtaer than second

            //string str1 = "a Hello world";

            //string str2 = "hello world";


            //Console.WriteLine(str1.CompareTo(str2));


            //Console.WriteLine( String.Compare(str1, str2,true));


            //5 String to int conversions

            //Console.WriteLine("Enter first number");

            // string strnume1=  Console.ReadLine();
            ////convert string to int
            ////  int num1 = int.Parse(strnume1);
            //int num1 ;
            //int.TryParse(strnume1, out num1);
            //Console.WriteLine(num1);
            ////int num1=  Convert.ToInt32(strnume1);
            //Console.WriteLine("Enter second Number");
            //string strnum2 = Console.ReadLine();

            //int num2 = int.Parse(strnum2);

            //int result = num1 / num2;

            //Console.WriteLine("result is " + result);


            //6. Convert int to string

            //int price = 1000;
            //string strprice = price.ToString();

            //7. Padding

            //string strLangName = "python";

            //strLangName= strLangName.PadLeft(10, '#');

            //Console.WriteLine(strLangName);


            // 8 : Splitting string


            string names = "C#,java,python,typescript,javascript";

            //string[] aar1=  names.Split(',','?');

            string[] aar1 = names.Split(',');

            //foreach(string item in aar1)
            //{
            //    Console.WriteLine(item);
            //}

            //9. Join strings

            string name1 = "C#";
            string name2 = "java";
            string name3 = "python";

          string strfullstring=  String.Join("#", name1, name2, name3);
          Console.WriteLine(strfullstring);



            Console.ReadLine();
        }

    }
}
