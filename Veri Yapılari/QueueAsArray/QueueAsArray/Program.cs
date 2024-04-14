using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueAsArray
{
     class Program
    {
        static void Main(string[] args)
        {
            QueueArray queue = new QueueArray(5);
            queue.enqueue(1);   
            queue.enqueue(2);   
            queue.enqueue(3);   
            queue.enqueue(4);
            queue.enqueue(5);
            queue.dequeue();
            queue.dequeue();
            queue.enqueue(123);
            
            queue.Display();
            Console.ReadLine();
        }
    }
}
