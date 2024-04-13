using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
     class Node
    {
        public int Data;
        public Node next;

        public Node(int data)
        {
            this.Data = data;
            next = null;
        }

    }
}
