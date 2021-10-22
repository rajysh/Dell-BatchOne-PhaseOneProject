using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DaySeven_Misc_Projects
{
    public delegate void myDelegate(int number1, int number2);

    public class Calculation
    {

        public void Addition(int num1, int num2)
        {
            Console.WriteLine("Addition of two numbers : " + num1 + num2);
        }

        public void Substraction(int num1, int num2)
        {
            Console.WriteLine("Substraction of two numbers : " + (num1 - num2));
        }

            public void Product(int num1, int num2)
        {
            Console.WriteLine("Division of two numbers : " + num1 * num2);
        }

        public void Divide(int num1, int num2)
        {
            Console.WriteLine("Division of two numbers : " + num1/num2);
        }
    }
    internal class DelegateExample
    {
        static void MainMethod(String[] args)
        {
            Calculation cal = new Calculation();

            myDelegate del1 = new myDelegate(cal.Addition);
            myDelegate del2 = new myDelegate(cal.Substraction);
            myDelegate del3 = new myDelegate(cal.Product);
            myDelegate del4 = new myDelegate(cal.Divide);
            
        }
    }
}
