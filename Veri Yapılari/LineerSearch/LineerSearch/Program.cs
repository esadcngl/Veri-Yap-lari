using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineerSearch
{
     class Program
    {
        static void Main(string[] args)
        {

            int[] numbers = { 21, 3, 7, 0, 67, 5, 43, 98, 13, 17, 11, 4 };
            int index = LineerSearch(numbers, 5);
            Console.WriteLine("The number 3 is in index: "+ index);
            Console.ReadLine();
        }
        static int LineerSearch(int[] numbers,int wanted)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == wanted)
                {
                    return i; 
                }
            }
            return -1;
        }
    }
}
