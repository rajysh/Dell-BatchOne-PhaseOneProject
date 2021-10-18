using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    internal class ArrayExampleTwo
    {
        static void MainMethod(string[] args)
        {
            int[,] arr = new int[2, 3]; //Declaration

            //Assignments
            arr[0, 0] = 60;
            arr[0, 1] = 70;
            arr[0, 2] = 80;
            arr[1, 0] = 90;
            arr[1, 1] = 100;
            arr[1, 2] = 110;

            //Initialization
            int[,] array = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //Print Array Elements

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)                
                //for (int j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***********************************");

            for (int i = 0; i < arr.GetLength(0); i++)
            { 
                for (int j = 0; j < arr.GetLength(1); j++)
                //for (int j = 0; j < 3; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
