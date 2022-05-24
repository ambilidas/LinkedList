using System;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for creating Linked List");
            Operations operationsobj = new Operations();
            //operationsobj.Add(56);
            //operationsobj.Add(30);
            //operationsobj.Add(70);
            //operationsobj.Display();
            //Console.WriteLine("----------------");
            //operationsobj.Add(70);
            //operationsobj.InsertFront(30);
            //operationsobj.InsertFront(56);
            //operationsobj.Display();
            operationsobj.Add(56);
            operationsobj.Append(30);
            operationsobj.Append(70);
            operationsobj.Display();

        }
    }
}
