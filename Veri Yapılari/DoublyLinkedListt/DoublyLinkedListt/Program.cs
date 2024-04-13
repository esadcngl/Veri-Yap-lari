using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListt
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList liste = new DoublyLinkedList();
            liste.addFirst(1);
            liste.addLast(2);
            liste.addLast(3);   
            liste.addLast(4);
            liste.print();
            liste.insert(0,4);
            liste.print();
            liste.discard(4);
            liste.print();
            
            Console.ReadLine();
        }


    }
}
