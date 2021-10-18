using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    internal class ArrayExampleFour
    {
        static void MainMethod(string[] args)
        {
            //Declared an Array
            int[] arr = { 17, 23, 4, 59, 27, 36, 96, 1, 3 };
           
            // Print the array elements
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("****************************");
            //Sorting the array elements
            Array.Sort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("****************************");

            //Reverse the sorted array for descending order
            Array.Reverse(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("****************************");

            int[] newArray = new int[9];
            Array.Copy(arr, newArray, 9);
            //Print the array elements of copied array
            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine();
            Console.WriteLine("new Array Length: "+ newArray.Length);
            Console.WriteLine("new Array Length: "+ newArray.GetLength(0));
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
