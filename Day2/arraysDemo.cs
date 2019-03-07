using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class arraysDemo
    {
        static void Main(string[] args)
        {
            //This is array of size 3
            //array index starts with 0
            int[] array1 = new int[3];

            array1[0] = 100;
            array1[1] = 200;
            array1[2] = 300;

            string[] array2 = {  "java","python", "C#" }; 

            for(int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine("Array Values " + array1[i]);
            }

            Array.Sort(array2);
            foreach (string item in array2)
            {
                Console.WriteLine(item);
            }

            // string value = array2[4];

            // Two dimensional array

            int[,] marks = new int[2,3];

            marks[0,0] = 900;
            marks[0,1] = 100;
            marks[0, 2] = 200;

            marks[1, 0] = 30;
            marks[1, 1] = 40;
            marks[1, 2] = 50;

            //marks.GetLength(0)
            //marks.GetLength(1)

            for (int i = 0; i < marks.GetLength(0); i++)
            {
                for (int j = 0; j < marks.GetLength(1); j++)
                {
                    Console.WriteLine(marks[i, j]);
                }
            }
            //Console.WriteLine(array2.Length);

            ////Jagged arrays
            int[] array4 = new int[2];

            array4[0] = 100;
            array4[1] = 200;

            int[][] array3 = new int[2][];

            array3[0] = new int[] { 10, 20, 30 };

            array3[1] = new int[] { 100, 200, 300, 400 };

            for (int i = 0; i < array3.Length; i++)
            {
                for (int j = 0; j < array3[i].Length; j++)
                {
                    Console.WriteLine(array3[i][j]);
                }
            }
           
            Console.ReadLine();
        }

    }
}
