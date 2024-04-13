using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListt
{
     class Node
    {
        public int Data;
        public Node next;
        public Node prev;
        public Node(int data)
        {
            this.Data = data;
            this.next = null;
            this.prev = null;
        }
    }
}
