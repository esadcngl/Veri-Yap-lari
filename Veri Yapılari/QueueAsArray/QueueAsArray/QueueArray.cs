using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace QueueAsArray
{
    class QueueArray
    {
        private int[] queue;
        public int front;
        public int rear;
        public int capacity;

        public QueueArray(int capacity)
        {
            front = rear = 0;
            this.capacity = capacity;
            queue = new int[capacity];
        }

        public void enqueue(int data)
        {
            if (capacity == rear)
            {
                Console.WriteLine("Queue is full");
                return;
            }
            else
            {
                queue[rear] = data;
                rear++;
            }
            return;
        }
        public void dequeue()
        {
            if (rear == front)
            {
                Console.WriteLine("queue is empty");
            }
            else
            {
                for (int i = 0; i < rear - 1; i++)
                {
                    queue[i] = queue[i + 1];

                }
                queue[rear - 1] = 0;
                rear--;

            }
        }

        public void Display()
        {
            int i;
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }

            for (i = front; i < rear; i++)
            {
                Console.Write(" {0} <-- ", queue[i]);
            }
            return;
        }


        public void queueFront()
        {
            if (front == rear)
            {
                Console.Write("\nQueue is Empty\n");
                return;
            }
            Console.Write("\nFront Element is: {0}",
                          queue[front]);
            return;
        }
    }

}
