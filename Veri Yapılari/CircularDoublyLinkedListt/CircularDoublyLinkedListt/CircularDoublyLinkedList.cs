using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularDoublyLinkedListt
{
    class CircularDoublyLinkedList
    {
        Node head;
        Node tail;
        public CircularDoublyLinkedList()
        {
            head = null;
            tail = null;
        }

        public void addFirst(int data)
        {
            Node newNode = new Node(data);
            if (head==null)
            {
                head = tail = newNode;
                tail.next = head;
                tail.prev = head;
                head.next = tail;
                head.prev = tail;
                Console.WriteLine("List created . First member added.");
            }
            else
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
                head.prev = tail;
                tail.next = head;
                Console.WriteLine("first member added");
            }
        }
        public void addLast(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = tail = newNode;
                tail.next = head;
                tail.prev = head;
                head.next = tail;
                head.prev = tail;
                Console.WriteLine("List created . First member added.");
            }
            else
            {
               tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
                tail.next = head;
                head.prev = tail;
                Console.WriteLine("added last");
            }
        }
        public void print()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node temp = head;
                while (temp != tail)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.next;
                }
                Console.WriteLine(temp.data  + " end ");
            }
        }
        public void printReverse()
        {
            if (head == null)
            {
                Console.WriteLine("list is empty");
            }
            else
            {
                Node temp = tail;
                while (temp != head)
                {
                    Console.Write(temp.data + " -> ");
                    temp = temp.prev;
                }
                Console.WriteLine(temp.data + " end ");
            }
        }
        public void removeFirst()
        {
            if (head ==null)
            {
                Console.WriteLine("list is emptpy");
            }
            else if (head == tail)
            {
                head = tail = null;
                Console.WriteLine("last member is deleted.");
            }
            else 
            {
                head = head.next;
                head.prev = tail;
                tail.next = head;
                Console.WriteLine("deleted from first");
            }
        }
        public void removeLast()
        {
            if (head == null)
            {
                Console.WriteLine("list is emptpy");
            }
            else if (head.next == head)
            {
                head = tail = null;
                Console.WriteLine("last member is deleted.");
            }
            else
            {
                tail = tail.prev;
                tail.next = head;
                head.prev = tail;
                Console.WriteLine("deleted from last");
            }
        }

        public void insert(int data, int index )
        {

            Node newNode = new Node(data);
            if (head == null && index == 0)
            {
                head = tail = newNode;
                head.prev = tail;
                tail.next = head;
            }
            else if (head!= null && index ==0)
            {
                head.prev = newNode;
                newNode.next = head;
                head = newNode;
                head.prev = tail;
                tail.next = head;
            }
            else
            {
                int i = 0;
                Node temp = head;
                Node temp2 = temp;
                while (temp != tail)
                {
                    if (i == index)
                    {
                        temp2.next = newNode;
                        newNode.prev = temp2;
                        newNode.next = temp;
                        temp.prev = newNode;
                        i++;
                        return;
                    }
                    i++;
                    temp2 = temp;
                    temp = temp.next;
                }
                if (i == index)
                {
                    temp2.next = newNode;
                    newNode.prev = temp2;
                    newNode.next = temp;
                    temp.prev = newNode;
                    return;
                }
            }
        }
        public void discard(int index)
        {
            if (head==null)
            {
                Console.WriteLine("list is empty.");
            }
            else if (head.next ==head && index ==0)
            {
                head = tail = null;
                Console.WriteLine("last member deleted.");
            }
            else if (head !=null && index ==0)
            {
                head = head.next;
                head.prev = tail;
                tail.next = head;
                Console.WriteLine("deleted from first");
            }
            else
            {
                int i = 0;
                Node temp = head;
                while (temp != tail)
                {
                    if (i == index)
                    {
                        temp.prev.next = temp.next;
                        temp.next.prev = temp.prev;
                        return;
                    }
                    i++;
                    temp = temp.next;
                }
                if (i == index)
                {
                    tail = tail.prev;
                    tail.next = head;
                    head.prev = tail;
                }
            }
        }
    }
}
