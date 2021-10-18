using System;

namespace CSharp_DayFive_Projects
{
    internal class ArrayExampleOne
    {
        static void MainMethod(string[] args)
        {
            int[] marks = new int[5]; //Declaration

            //Assignments
            marks[0] = 60;
            marks[1] = 70;
            marks[2] = 80;
            marks[3] = 90;
            marks[4] = 100;
            marks[4] = 110;

            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write(marks[i] + "\t");
            }
            Console.WriteLine("\n\n");

            //Initialization
            int[] marksArray =  new int[5] {10,20,30,40,50};

            foreach (var item in marksArray)
            {
                Console.Write(item + "\t");

            } 
            Console.ReadKey();
            
        }
    }
}
