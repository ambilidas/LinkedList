using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Node
    {
        public int data;
        public Node next;
        public Node(int Data)
        {
            this.data = Data;
            this.next = null;
        }
    }
}
