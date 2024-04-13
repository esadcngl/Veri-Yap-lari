using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class SinglyLinkedList
    {
        public Node head;
        public SinglyLinkedList()
        {
            head = null;
        }
        public void addLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("List created , First Node added.");
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine("Added to the last");
            }
        }
        public void addFirst(int Data)
        {
            Node newNode = new Node(Data);
            if (head == null)
            {
                head = newNode;
                Console.WriteLine("List created , First Node added.");
            }
            else
            {
                newNode.next = head;
                head = newNode;
                Console.WriteLine("added to the first");
            }
        }

        public void removeFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                head = head.next;
                Console.WriteLine("Removed from first");
            }
        }
        public void removeLast()
        {
            if (head==null)
            {
                Console.WriteLine("List is empty.");
            }
            else if (head.next ==null)
            {
                head = null;
                Console.WriteLine("Last node deleted.");
            }
            else
            {
                Node temp = head;
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
                Console.WriteLine("node Deleted.");
            }
        }

        public void insert(int data, int index)
        {
            
            bool isAdded = false;
            Node newNode = new Node(data);
            if (head == null && index == 0)
            {
                isAdded = true;
                head = newNode;
                Console.WriteLine("added");
            }
            else if (head != null && index == 0)
            {
                isAdded = true;
                newNode.next = head;
                head = newNode;
                Console.WriteLine("added");
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while (temp != null)
                {
                    if (i == index)
                    {
                        temp2.next = newNode;
                        newNode.next = temp;
                        Console.WriteLine("inserted.");
                        isAdded = true;
                        i++;
                        break;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
                if (i == index) 
                {
                    isAdded = true;
                    temp2.next = newNode;
                    newNode.next = temp;
                    Console.WriteLine("Added");
                }
            }
            if (!isAdded)
            {
                Console.WriteLine("Wrong index try again");
            }
        }
        public void discard(int index)
        {
            bool isDeleted = false;
            if (head == null && index ==0)
            {
                Console.WriteLine("List is empty");
            }
            else if (head != null && index ==0)
            {
                head = head.next;
                Console.WriteLine("Discard from first");
                isDeleted = true;
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while (temp !=null)
                {
                    if (i==index)
                    {
                       temp2.next = temp.next;
                        Console.WriteLine("Discard from middle");
                        isDeleted=true;
                    }
                    temp2 = temp;
                    temp = temp.next;
                    i++;
                }
            }
            if (!isDeleted)
            {
                Console.WriteLine("Wrong index");
            }
        }
        public void getLength()
        {
                int count = 0;
            if (head ==null)
            {
                Console.WriteLine("Length : "+ count);
            }
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    temp = temp.next;
                    count++;
                }
                Console.WriteLine("Length : " + count);
            }
        }

        public void print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.Write(temp.Data + " -> ");
                temp = temp.next;
            }
            Console.WriteLine("Null");
        }
    }
}
