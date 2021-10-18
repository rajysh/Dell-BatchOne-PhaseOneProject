using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    internal class StackExample
    {
        static void Mainmethod(string[] args)
        {
            Stack stack= new Stack();

            stack.Push(100);
            stack.Push(200);
            stack.Push(30);
            stack.Push(04);
            stack.Push("King");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("---------------------------------");
            Console.WriteLine("Element Popped Out:" + stack.Pop());
            Console.WriteLine("---------------------------------");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");

            Console.WriteLine("Element ready to Pop Out:" + stack.Peek());
            Console.WriteLine("---------------------------------");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------");
            
            //remove all elements in stack
            while (stack.Count > 0)
                stack.Pop();

            Console.WriteLine(stack.Count > 0 ? "Stack is not Empty:" : "Stack is Empty");
            Console.ReadKey();
        }
    }
}
