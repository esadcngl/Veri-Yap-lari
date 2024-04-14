using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDoublyLinkedListt
{
     class Program
    {
        static void Main(string[] args)
        {
            CircularDoublyLinkedList list = new CircularDoublyLinkedList();
            list.addFirst(1);
            list.addFirst(2);
            list.addFirst(3);
            list.addFirst(4);
            list.addFirst(5);
            list.print();
            list.printReverse();
            list.removeFirst();
            list.print();
            list.removeLast();
            list.print();
            list.insert(0, 2);
            list.print();
            list.discard(1);
            list.print();
            Console.ReadLine();
        }
    }
}
