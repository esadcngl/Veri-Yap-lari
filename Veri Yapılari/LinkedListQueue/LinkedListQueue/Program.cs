using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
   class Program
    {
        static void Main(string[] args)
        {
            LinkedListQueue que = new LinkedListQueue();
            que.enQueue(1);
            que.enQueue(2);
            que.enQueue(3);
            que.enQueue(4);
            que.print();
            que.deQueue();
            que.print();
            que.enQueue(5);
            que.print();
            Console.ReadLine();
        }
    }
}
