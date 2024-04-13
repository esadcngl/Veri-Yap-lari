using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 10, 15, 17, 20, 26, 30};
            int target =8;
            Console.WriteLine("The Target number's index is : " + BinarySearch(numbers,target));
            Console.ReadLine();
        }
        static int BinarySearch(int[]arr , int target)
        {
            int low = 0;
            int high = arr.Length - 1;
            while (low <= high)
            {
                int mid = low + (high - low) / 2;
                if (arr[mid] == target)
                
                    return mid;
                
                else if (arr[mid] < target)
                
                    low = mid + 1;
                
                else
                
                    high = mid - 1;
               
            }
            return -1;

        }
    }
}
