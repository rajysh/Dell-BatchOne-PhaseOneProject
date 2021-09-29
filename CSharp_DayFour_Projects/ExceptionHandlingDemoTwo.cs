using System;

namespace CSharp_DayFour_Projects
{
    class ExceptionHandlingDemoTwo
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
            catch(ArithmeticException ex)
            {
                Console.WriteLine("ArithmeticException" + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException" + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception" + ex.Message);
            }
            Console.ReadKey();
        }
    }
}
