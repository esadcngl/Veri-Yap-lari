using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CirculerLinkedListt
{
    class CircularLinkedList
    {
        public Node head;
        public Node tail;
        public CircularLinkedList()
        {
            head = null;
            tail = null;
        }

        public void addFirst(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = tail = newNode;
                tail.next = head;
                Console.WriteLine("List created.First member added.");
            }
            else
            {
                newNode.next = head;
                head = newNode;
                tail.next = newNode;
                Console.WriteLine("Member added first");
            }
        }
        public void addLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = tail = newNode;
                tail.next = newNode;
                Console.WriteLine("List created.First member added.");
            }
            else
            {
                tail.next = newNode;
                tail = newNode;
                tail.next = head;
                Console.WriteLine("added member to last.");
            }
        }

        public void print()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else
            {
                Node temp = head;
                while (temp != tail)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data + " end ");

            }
        }
        public void removeFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty");
            }
            else if (head == head.next)
            {
                head = tail = null;
                Console.WriteLine("last member deleted list is empty");
            }
            else
            {
                head = head.next;
                tail.next = head;
                Console.WriteLine("first member deleted.");

            }
        }
        public void removeLast()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else if (head == head.next)
            {
                head = tail = null;
                Console.WriteLine("last member deleted.");
            }
            else
            {
                Node temp = head;
                while (temp.next != tail)
                {
                    temp = temp.next;
                }
                temp.next = null;
                tail = temp;
                tail.next = head;
                Console.WriteLine("Removed from last.");
            }
        }
       
        public void insert(int data, int index)
        {
            Node newNode = new Node(data);

            if (index < 0)
            {
                Console.WriteLine("Invalid index. Please enter a non-negative index.");
                return;
            }

            if (head == null && index == 0)
            {
                head = tail = newNode;
                tail.next = head;
                return;
            }

            if (index == 0)
            {
                newNode.next = head;
                head = newNode;
                tail.next = newNode; 
                return;
            }

            int i = 0;
            Node temp = head;
            Node temp2 = temp;
            while (temp != tail)
            {
                if (i == index)
                {
                    temp2.next = newNode;
                    newNode.next = temp;
                    Console.WriteLine("added between");
                    i++;
                    break;
                }
                temp2 = temp;
                temp = temp.next;
                i++;
            }
            if (i==index)
            {
                temp2.next = newNode;
                newNode.next = temp;
                Console.WriteLine("added between");
               
            }
        }

    }
}
