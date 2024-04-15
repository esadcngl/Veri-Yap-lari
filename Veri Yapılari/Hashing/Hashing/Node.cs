using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashing
{
     class Node
    {
        public int key;
        public string name;
        public Node next;
        public Node()
        {
                this.next = null;
        }
        public Node(int key , string name)
        {
            this.key = key;
            this.name = name;
            this.next=null;
        }
    }
}
