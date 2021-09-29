using System;

namespace CSharp_DayFour_Projects
{
    class ExceptionHandlingDemoThree
    {
        static void MainMethod(string[] args)
        {
            int num1, num2, result = 0;
            try
            {
                Console.Write("Enter first number: ");
                num1 = int.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                num2 = int.Parse(Console.ReadLine());
                result = num1 / num2;
                //Console.WriteLine("Result: " + result);
            }
            catch(ArithmeticException ex)
            {
                Console.WriteLine("ArithmeticException" + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("FormatException: " + ex.Message);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine("IndexOutOfRangeException: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: " + ex.Message);
            }
            finally
            {
                Console.WriteLine("Result: " + result);
            }
            Console.ReadKey();
        }
    }
}
