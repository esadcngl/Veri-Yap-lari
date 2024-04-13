using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListt
{
    class DoublyLinkedList
    {
        public Node head;
        public Node tail;

        public DoublyLinkedList()
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
                Console.WriteLine("List created. First member added.");
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
                Console.WriteLine("Added element to the beginning of the list");
            }

        }
        public void addLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = tail = newNode;
                Console.WriteLine("List created. First member added.");
            }
            else
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
                Console.WriteLine("Added element to the end of the list");
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
                while (temp != null)
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.next;
                }
                Console.WriteLine("null");
            }
        }
        public void printReverse()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty.");
            }
            else
            {
                Node temp = tail;
                while (temp != null)
                {
                    Console.Write(temp.Data + " -> ");
                    temp = temp.prev;
                }
                Console.WriteLine("null");
            }
        }
        public void removeFirst()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
            }
            else if (head.next == null)
            {
                head = tail = null;
                Console.WriteLine("The last member removed from list");
            }
            else
            {
                head = head.next;
                head.prev = null;
                Console.WriteLine("The first member removed from list");
            }
        }
        public void removeLast()
        {
            if (head == null)
            {
                Console.WriteLine("List is empty.");
            }
            else if (head.next == null)
            {
                head = tail = null;
                Console.WriteLine("The last member removed from list");
            }
            else
            {
                tail = tail.prev;
                tail.next = null;
                Console.WriteLine("The last member removed from list");
            }
        }
        public void insert(int data,int index)
        {
            Node newNode = new Node(data);
            if (head == null && index==0)
            {
                head = tail = newNode;
                return;
            }
            else if (head != null && index ==0)
            {
                head.prev = newNode;
                newNode.next = head;
                head = newNode;
            }
            else
            {
                int i = 0;
                Node temp = head;
                while (temp != null)
                {
                    if (i == index)
                    {
                        temp.prev.next = newNode;
                        newNode.prev = temp.prev;
                        newNode.next = temp;
                        temp.prev = newNode;
                        Console.WriteLine("inserted");
                        return;
                    }
                    i++;
                    if (temp.next ==null && i ==index)
                    {
                        tail.next = newNode;
                        newNode.prev = tail;
                        tail = newNode;
                        return;
                    }
                    temp = temp.next;
                    
                }

            }
            Console.WriteLine("Wrong index");
        }
        public void discard(int index)
        {
            if (head ==null && index==0)
            {
                Console.WriteLine("list is empty");
            }
            else if (head != null && index == 0)
            {
                head = head.next;
                head.prev = null;
            }
            else
            {
                Node temp = head;
                int i = 0;
                while (temp!=null)
                {
                    if (i == index)
                    {
                        temp.prev.next = temp.next;
                        temp.next.prev = temp.prev;
                        return;
                    }
                    i++;
                    temp = temp.next;
                    if (temp.next==null && i == index)
                    {
                        tail = tail.prev;
                        tail.next = null;
                        Console.WriteLine("The last member removed from list");
                        return;
                    }
                }
            }
        }
    }
}
