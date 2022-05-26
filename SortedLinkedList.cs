using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class SortedLinkedList
    {
        internal Node head;
        //Adding Elements with Sorting
        public void Add(int data)
        {
            Node node = new Node(data);
            Node current = head, previous = null;
            while (current != null && current.data < node.data)
            {
                previous = current;
                current = current.next;
            }
            if (previous == null)
                head = node;
            else
            {
                previous.next = node;
            }
            node.next = current;

        }
        //Display LinkedList
        internal void Display()
        {
            if (this.head == null)
                Console.WriteLine("The list is empty.");
            else
            {
                Node temp = head;
                while (temp != null)
                {
                    Console.WriteLine("Element : " + temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
