using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayThree_Projects
{
    class Calculator
    {
        public int Addition(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Addition(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        public float Addition(float num1, float num2, float num3)
        {
            return num1 + num2 + num3;
        }

        public float Addition(int num1, float num2)
        {
            return num1 + num2;
        }

        public float Addition(float num1, int num2)
        {
            return num1 + num2;
        }
    }
    class OverloadingExample
    {
        static void MainMethod(string[] args)
        {
            Calculator calc = new Calculator();
            Console.WriteLine(calc.Addition(2, 2));
            Console.WriteLine(calc.Addition(2, 2, 2));
            Console.WriteLine(calc.Addition(2, 2.9F));
            Console.WriteLine(calc.Addition(2.7F, 2));
            Console.WriteLine(calc.Addition(2.1F, 2.2F, 2.2F));

            Console.ReadKey();
        }
    }
}
