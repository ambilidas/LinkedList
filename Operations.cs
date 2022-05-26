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
        public void Append(int Data)
        {
            Node newnode = new Node(Data);
            if(head == null)
            {
                head = newnode;
            }
            else
            {
                Node temp=head;
                while(temp.next != null)
                {
                    temp=temp.next;
                }
                temp.next=newnode;
            }
        }
        public void InsertInBetween(int position,int Data)
        {
            Node node = new Node(Data);
            if (position < 1)
                Console.WriteLine("Invalid Position");
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;

                while (position > 2)
                {
                    temp = temp.next;
                    position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
        }
        public void Pop()
        {
            if(this.head == null)
            {
                Console.WriteLine("Linked list is empty!!");
            }
            this.head = this.head.next;
            Console.WriteLine("\nFirst element is deleted from the list");
        }
        public void PopLast()
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is empty!!");
            }
            if(head.next == null)
            {
                Console.WriteLine("Linked list is empty!!");
            }
            Node newnode = head;
            while(newnode.next.next != null)
            {
                newnode = newnode.next;
            }
            newnode.next = null;
            Console.WriteLine("\nLast element is deleted from the list");

        }
        public Node Search(int value)
        {
            while (this.head != null)
            {
                if (this.head.data == value)
                {
                    return this.head;
                   // Console.WriteLine("\n {0} is present in linked list", value);
                }
                this.head = this.head.next;
            }
            return null;
            
        }
    }
}
