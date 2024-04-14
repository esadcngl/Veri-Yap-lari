using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListBasedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListStack stack = new LinkedListStack();
            stack.push(1);
            stack.push(2);
            stack.push(3);
            stack.push(4);
            stack.push(5);
            stack.push(6);
            stack.print();
            stack.pop();
            stack.print();
            Console.WriteLine(stack.peek()) ;
            Console.ReadLine();

        }
    }
}
