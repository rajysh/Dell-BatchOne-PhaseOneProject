using System;

namespace CSharp_DayFour_Projects
{
    class ExceptionHandlingDemoOne
    {
        static void MainMethod(string[] args)
        {
            try
            {
                Console.Write("Enter first number: ");
                int num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                int num2 = int.Parse(Console.ReadLine());
                int result = num1 / num2;
                Console.WriteLine("Result: " + result);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
