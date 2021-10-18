using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    internal class ArrayListExample
    {
        static void MainMethod(string[] args)
        {
            //Declared an ArrayList
            ArrayList arrayList = new ArrayList();
            Console.WriteLine("Initial Capacity : " + arrayList.Capacity);

            arrayList.Add(100);

            Console.WriteLine("Initial Capacity : " + arrayList.Capacity);

            arrayList.Add("King Kochhar");
            arrayList.Add(true);
            arrayList.Add(12000.56F);

            Console.WriteLine("Initial Capacity : " + arrayList.Capacity);

            arrayList.Add("John Smith");
            Console.WriteLine("Array List Capacity : " + arrayList.Capacity);
            Console.WriteLine("Array List Count : " + arrayList.Count);
            Console.WriteLine("-----------------------------------------------");

            for (int i = 0; i < arrayList.Count; i++)
            {
                Console.WriteLine(arrayList[i]);
            }
            Console.WriteLine("-----------------------------------------------");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            arrayList.Remove("King Kochhar");
            arrayList.RemoveAt(0);
            arrayList.RemoveRange(0, 2);

            arrayList.Insert(0, "Rajesh");
            arrayList.InsertRange(0, arrayList);
            Console.WriteLine("-----------------------------------------------");

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
