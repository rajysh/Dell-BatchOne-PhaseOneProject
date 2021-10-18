using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_DayFive_Projects
{
    internal class QueueExample
    {
        static void MainMethod(string[] args)
        {
            Queue queue = new Queue();
            Queue<int> queue2 = new();

            //Adding items

            queue.Enqueue(100);
            queue.Enqueue(200);
            queue.Enqueue(300);
            queue.Enqueue(400);
            queue.Enqueue("Sarah");

            Console.WriteLine(queue.Count);
            Console.WriteLine("---------------------------------------");
            // Print Queue Items
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("---------------------------------------");
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());

            while(queue.Count != 0)
            {
                Console.WriteLine(queue.Dequeue());
            }
            Console.WriteLine("---------------------------------------");
            //
            //Console.WriteLine(queue.Peek());
            Console.WriteLine(queue.Count == 0 ? "Queue is Empty" : "Queue is not Empty");
        }
    }
}
