using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //int answer = menu();
            //int number;
            SinglyLinkedList liste = new SinglyLinkedList();
            //while (answer != 0)
            //{
            //    switch (answer)
            //    {
            //        case 1:
            //            Console.WriteLine("Number: ");
            //            number = int.Parse(Console.ReadLine());
            //            liste.addFirst(number);
            //            break;
            //        case 2:
            //            Console.WriteLine("Number: ");
            //            number = int.Parse(Console.ReadLine());
            //            liste.addLast(number);
            //            break;
            //        case 3:
            //            liste.removeFirst();
            //            break;
            //        case 4:
            //            liste.removeLast();
            //            break;
            //        case 5:
            //            Console.WriteLine("Number: ");
            //            number = int.Parse(Console.ReadLine());
            //            int index;
            //            Console.WriteLine("Index: ");
            //            index = int.Parse(Console.ReadLine());
            //            liste.insert(number, index);
            //            break;
            //        case 0:
            //            break;
            //        default:
            //            Console.WriteLine("Wrong Choice");
            //            break;
            //    }
            //    Console.Clear();
            //    liste.print();
            //    answer = menu();
            //}
            liste.addFirst(1);
            liste.addLast(2);
            liste.addLast(3);
            liste.addLast(4);
            liste.removeLast();
            liste.insert(4, 3);
            liste.print();
            liste.getLength();
            liste.discard(1);
            liste.print();
            Console.ReadLine();


        }
        public static int menu()
        {
            Console.WriteLine("Which operation do you want for SinglyLinkedList?");
            Console.WriteLine("1-Add first");
            Console.WriteLine("2-Add Last");
            Console.WriteLine("3-Remove first");
            Console.WriteLine("4-Remove last");
            Console.WriteLine("5-Insert");
            Console.WriteLine("Your Choice: ");
            int answer = int.Parse(Console.ReadLine());
            return answer;
        }
    }
}
