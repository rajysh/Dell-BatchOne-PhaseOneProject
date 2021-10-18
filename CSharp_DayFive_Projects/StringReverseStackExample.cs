using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{

    class StringReverse
    {
        public static String Reverse(String input)
        {
            Stack<char> stack = new Stack<char>();
            char[] charArr = input.ToCharArray();            

            foreach (char ch in charArr)
            {
                stack.Push(ch);
            }

            string reversed = String.Empty;

            while (stack.Count != 0)
                reversed += stack.Pop();

            return reversed.ToString();
        }
    }
    internal class StringReverseStackExample
    {
        public static void MainMethod(string[] args)
        {
            Console.WriteLine("HSEJAR : " + StringReverse.Reverse("HSEJAR"));
        }
    }
}
