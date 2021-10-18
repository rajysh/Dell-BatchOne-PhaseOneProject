using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{

    class StringReverseQueueExample
    {
        public static void Reverse(Queue queue)
        {
            Stack stack = new Stack();

            while(queue.Count != 0)
            {
                stack.Push(queue.Dequeue());
            }           

            string reversed = String.Empty;

            while (stack.Count != 0)
                queue.Enqueue(stack.Pop());
            
        }

        public static string Reverse(string word)
        {
            Queue queue= new Queue();   

            char[] ch = word.ToCharArray();

            for (int i = ch.Length - 1; i >= 0; i--)
            {
                queue.Enqueue(ch[i]);
            }
            
            string reversed = String.Empty;

            while (queue.Count != 0)
            {
               reversed += queue.Dequeue();
            }

            return reversed.ToString();        

        }
    }
    internal class StringReverseExample
    {
        public static void MainMethod(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);

            StringReverseQueueExample.Reverse(queue);

            foreach(var item in queue)
            {
                Console.WriteLine(item);
            }

            
            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("HSEJAR : " + StringReverseQueueExample.Reverse("HSEJAR"));

            Console.ReadKey();

        }
    }
}
