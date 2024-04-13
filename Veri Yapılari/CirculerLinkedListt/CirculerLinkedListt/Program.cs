using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CirculerLinkedListt
{
    class Program
    {
        static void Main(string[] args)
        {
            CircularLinkedList list = new CircularLinkedList();



            list.addFirst(1);
            list.addFirst(2);
            list.addFirst(3);
            list.addFirst(4);
            list.addFirst(5);

            list.print();
            list.insert(0,4);
            list.print();
            Console.ReadLine();
        }
    }
}
