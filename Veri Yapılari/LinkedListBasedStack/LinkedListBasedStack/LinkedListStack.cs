using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBasedStack
{
    class LinkedListStack
    {
        Node top;
        public LinkedListStack()
        {
            top = null;    
        }
        public void push(int data)
        {
            Node newNode = new Node(data);
            if (top ==null)
            {
                top=newNode;
            }
            else
            {
                newNode.next = top;
                top = newNode;
            }
        }
        public int pop()
        {
            if (top ==null)
            {
                Console.WriteLine("Stack is empty");
                return -1;
            }
            else
            {
                int data = top.data;
                top = top.next;
                Console.WriteLine(data + " removed from stack  ");
                return data;

            }
        }
        public int peek()
        {
            if (top ==null)
            {
                Console.WriteLine("stack is empty");
                return -1;
            }
            else
            {
                int data = top.data;
                return data;
            }
        }
        public void print()
        {
            if (top ==null)
            {
                Console.WriteLine("stack is empty");
            }
            else
            {
                Node temp = top;
                while (temp !=null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
               
            }
        }
    }
}
