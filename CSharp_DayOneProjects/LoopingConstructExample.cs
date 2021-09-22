using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Basics
{
    class LoopingConstructExample
    {
        static void Main(string[] args)
        {
            //while loop
            ////while (false)
            ////{
            ////    Console.WriteLine("Will not execute");
            ////}

            ////while (true)
            ////{
            ////    Console.WriteLine("Never stops");
            ////}

            //bool iNeedMoreCandles = true;
            //int candleCount = 0;

            //while (iNeedMoreCandles)
            //{
            //    Console.Write("Do you need one more candle? (Yes/No): ");
            //    string answer = Console.ReadLine();
            //    if (answer.ToLower() == "yes")
            //    {
            //        candleCount++;
            //    }
            //    else
            //    {
            //        iNeedMoreCandles = false;
            //    }
            //}


            //int candleCount = 0;
            //for (string input = ("Yes"); input == "Yes"; input = Console.ReadLine())
            //{
            //    candleCount++;
            //    Console.Write("Do you need one more candle? (Yes/No): ");
            //}

            //Console.WriteLine("Candles Needed: " + candleCount);

            //for loop
            //for(int i=0;i<5;i++)
            //{
            //    Console.WriteLine("Print Me");
            //}
            //Console.ReadKey();

            //int j = 0;
            //while(j<5)
            //{
            //    Console.WriteLine("Print Me");
            //    j++;
            //}

            //do while loop
            //string answer;
            //int candleCount = 0;
            //do
            //{
            //    candleCount++;
            //    Console.Write("Do you need one more candle? (Yes/No): ");
            //    answer = Console.ReadLine();
            //}
            //while (answer == "yes" || answer == "Y");

            //Console.WriteLine("Candles Needed: {0}", candleCount);



            string[] pets = { "dog", "cat", "bird" };

            for(int i=0;i<pets.Length; i++)
            {
                if (i == 1)
                    continue;
                Console.WriteLine(pets[i]);
            }

            Console.WriteLine("*****************");

            foreach(string pet in pets)
            {
                Console.WriteLine(pet);
            }
        }
    }
}
