using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    internal class Operations
    {
        public Node head;
        public void Add(int Data)
        {
            Node newnode=new Node(Data);
            if(this.head == null)
            {
                this.head = newnode;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newnode;
            }
            
        }
        public void Display()
        {
            Node temp=this.head;
            if(temp == null)
            {
                Console.WriteLine("Linked List is empty!!");
                return;
            }
            while(temp != null)
            {
                Console.Write(temp.data + " -> ");
                temp = temp.next;
            }

        }
        public void InsertFront(int Data)
        {
            Node newnode = new Node(Data);
            newnode.next = head;
            this.head = newnode;
        }
    }
}
