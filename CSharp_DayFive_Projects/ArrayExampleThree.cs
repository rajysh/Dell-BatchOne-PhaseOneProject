using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    internal class ArrayExampleThree
    {
        static void MainMethod(string[] args)
        {
           //int[,] arr = new int[2,3]; //Declaration
            int[][] jArray = new int[2][];
            jArray[0] = new int[5] { 1, 2, 3, 4, 5 };
            jArray[1] = new int[3] { 1, 2, 3 };

            Console.WriteLine(jArray);

            Console.WriteLine("Array Elementes : ");
            for (int i = 0; i < jArray.GetLength(0); i++)
            {
                for (int j = 0; j < jArray[i].GetLength(0); j++)
                {
                    Console.Write("{0} ", jArray[i][j]);
                }
                Console.WriteLine();
            }


            Console.ReadKey();
        }
    }
}
