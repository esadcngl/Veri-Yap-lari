using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedStack
{
     class Program
    {
        static void Main(string[] args)
        {
            ArrayStack arrStack = new ArrayStack(10);
            arrStack.push(1);
            arrStack.push(2);
            arrStack.push(3);
            arrStack.push(4);
            arrStack.push(5);
            arrStack.Print();
            arrStack.pop();
            arrStack.Print();
            Console.WriteLine( arrStack.peek());
            Console.WriteLine(arrStack.IsEmpty());
            Console.ReadLine();


        }
    }
}
