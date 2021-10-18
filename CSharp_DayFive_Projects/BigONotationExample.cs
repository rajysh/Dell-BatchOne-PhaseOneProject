using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    internal class BigONotationExample
    {
        static void Print(int[] numbers)
        {
            ////O(1) + O(1) = O(1+1) = O(2) => O(1) numbers are fixed so always it is equals to O(1)
            ////Constant Notation
            //Console.WriteLine(numbers[0]); // O(1)
            //Console.WriteLine(numbers[1]); //O(1)

            //Linear Notation O(n)
            foreach(int n in numbers)
            {
                Console.WriteLine(n); //O(n)

            }

            //Linear Notation O(n) + O(2) = O(n)
            Console.WriteLine("Hello Everyone"); //O(n)

            //(n)+O(n)=O(2n)
            foreach (int n in numbers)
            {
                Console.WriteLine(n); //O(n)

            }

            foreach (int n in numbers)
            {
                Console.WriteLine(n); //O(n)

            }
            Console.WriteLine("Bye Everyone"); // O(1)
            
            //O(n^2) --- Quadratic Notation
            foreach (int first in numbers)//O(n)
            {
                foreach (int second in numbers) //O(n)
                {
                    Console.WriteLine(first + second); //O(n)
                }

            }

        }
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5 };
            Print(numbers);

            Console.ReadKey();
        }
    }
}
