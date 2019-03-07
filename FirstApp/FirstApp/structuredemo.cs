using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstApp
{
    class structuredemo
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[3];

            arr1[0]= 100;
            arr1[1]= 200;
            arr1[2]= 300;

            string[] arr2 = { "C#", "Java", "Python" };

            int[,] arr3 = new int[2, 3];

            arr3[0, 0] = 900;
            arr3[0,1]= 100;
            arr3[0, 2] = 200;

            arr3[1, 0] = 300;
            arr3[1, 1] = 120;
            arr3[1, 2] = 180;

            for (int i=0;i<arr1.Length;i++)
            {
                Console.WriteLine("i'm from integer array : "+arr1[i]);
            }

            foreach(string item in arr2)
            {
                Console.WriteLine("I'm from string array : "+item);
            }

            for(int j=0;j<arr3.GetLength(0);j++)
            {
                for(int k=0;k<arr3.GetLength(1);k++)
                {
                    Console.WriteLine("I'm from Multidimensional array : "+arr3[j,k]);
                }
            }

            Console.Read();
        }
    }
}
