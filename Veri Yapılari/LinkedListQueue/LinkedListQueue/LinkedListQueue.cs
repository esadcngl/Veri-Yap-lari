using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListQueue
{
   class LinkedListQueue
    {
        public Node front;  
        public Node rear; 

        public LinkedListQueue() 
        {
            this.front = null;
            this.rear = null;
        }   

        public void enQueue(int data)
        {
            Node newNode = new Node(data);
            if (front == null)
            {
                front = rear = newNode;
            }
            else
            {
                    rear.next = newNode;
                rear = newNode;
                Console.WriteLine("added");
            }
        }
        public int deQueue()
        {
            if (front ==null)
            {
                Console.WriteLine("Queue empty.");
                return -1;
            }
            else
            {
                int data = front.data;
                front = front.next;
                Console.WriteLine("Dequeued");
                return data;
            }
        }

        public void print()
        {
            if (front == null)
            {
                Console.WriteLine("Queue empty.");
            }
            else
            {
                Node temp = front;
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                    temp = temp.next;
                }
            }
        }
    }
}
