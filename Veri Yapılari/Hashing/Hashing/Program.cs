using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
   class Program
    {
        static void Main(string[] args)
        {
            Table hasht = new Table(6);

            hasht.add(6,"Memo");
            hasht.add(3,"Adam");
            hasht.add(2,"John");
            hasht.add(1,"Ken");
            hasht.add(4,"Walter");
            hasht.add(5,"Hank");
            hasht.add(12,"Brook");
            hasht.print();
            hasht.remove(12);
            hasht.print();
            Console.ReadLine();

        }
    }
}
