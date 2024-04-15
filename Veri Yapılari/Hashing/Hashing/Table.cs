using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
    class Table
    {
        public int size;
        Node[] array;
        public Table(int size)
        {
            this.size = size;
            array = new Node[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = new Node();
            }
        }

        public int hashing(int key)
        {
            return key % array.Length;
        }
        public void add(int key, string isim)
        {
            Node newNode = new Node(key, isim);
            int newIndex = hashing(key);
            Node temp = array[newIndex];
            if (temp.next == null)
            {
                temp.next = newNode;
            }
            else
            {
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;

            }
        }
        public void remove(int key)
        {
            bool answer = false;
            int index = hashing(key);
            Node temp = array[index];

            if (temp.next == null)
            {
                Console.WriteLine(key + " not find ");
                answer = true;
            }
            else if (temp.next.next == null && temp.next.key == key)
            {
                temp.next = null;
                answer = true;
            }
            else
            {
                Node temp2 = temp;
                while (temp.next != null)
                {
                    if (temp.key == key)
                    {
                        temp2.next = temp.next;
                        answer = true;
                    }

                    temp2 = temp;
                    temp = temp.next;
                }
                if (temp.next == null && answer == false)
                {
                    temp2.next = null;
                    answer = true;
                    Console.WriteLine("Deleted");
                }
                else if (answer == false)
                {
                    Console.WriteLine("Not find");
                }
            }

        }
        public void print()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Node temp = array[i];
                Console.Write("array[{0}] --> ", i);
                while (temp.next != null)
                {
                    temp = temp.next;
                    Console.Write(temp.key + " " + temp.name + " -> ");
                }
                Console.WriteLine();
            }


        }
    }
}
