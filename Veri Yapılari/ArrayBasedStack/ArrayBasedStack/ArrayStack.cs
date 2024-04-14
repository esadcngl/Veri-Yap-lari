using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedStack
{
    class ArrayStack
    {
        private int[] items;
        private int top;
        private int maxSize;

        public ArrayStack(int maxSize)
        {
            this.maxSize = maxSize;
            this.items = new int[maxSize];
            this.top = -1; // Stack is empty so we started from -1
        }

        public void push(int data)
        {
            if (top == maxSize - 1)
            {
                Console.WriteLine("Stack is full");
                return;
            }
            top++;
            items[top] = data;
        }
        public int pop()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                throw new InvalidOperationException("Stack is empty");
            }
            int poppedItem = items[top];
            top--;
            return poppedItem;

        }
        public int peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty.");
                throw new InvalidOperationException("Stack is empty");
            }
            return items[top];
        }
        public bool IsEmpty()
        {
            return top == -1;
        }

        public bool IsFull()
        {
            return top == maxSize - 1;
        }
        public void Print()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.Write("Stack: \n");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(items[i] );
            }
            Console.WriteLine();
        }

    }
}
