using System;

namespace LinkedList
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program for creating Linked List");
            Operations operationsobj = new Operations();
            //Simple linked list is created
            //operationsobj.Add(56);
            //operationsobj.Add(30);
            //operationsobj.Add(70);
            //operationsobj.Display();

            //Elements are added to front
            //operationsobj.Add(70);
            //operationsobj.InsertFront(30);
            //operationsobj.InsertFront(56);
            //operationsobj.Display();

            //Appending elements
            //operationsobj.Add(56);
            //operationsobj.Append(30);
            //operationsobj.Append(70);
            //operationsobj.Display();

            //data inserted between particular position
            //operationsobj.Add(56);
            //operationsobj.Add(70);
            //operationsobj.Display();
            //operationsobj.InsertInBetween(2, 30);
            //Console.WriteLine("\n");
            //operationsobj.Display();

            //deleting first element
            //operationsobj.Pop();
            //operationsobj.Display();

            //operationsobj.Add(56);
            //operationsobj.Add(30);
            //operationsobj.Add(70);
            //operationsobj.Display();
            //operationsobj.PopLast();
            //operationsobj.Display();

            operationsobj.Add(56);
            operationsobj.Add(30);
            operationsobj.Add(70);
            operationsobj.Display();

            //searching for data
            operationsobj.Search(30);

            operationsobj.InsertInBetween(3, 40);
            Console.WriteLine("\nAdding 40 after 30 ");
            operationsobj.Display();

            //delete 40 from list
            operationsobj.Delete(40);
            Console.WriteLine("\n");
            operationsobj.Display();

            //getting size of linked list
            Console.WriteLine("\nsize of linked list: " + operationsobj.Size()); 
             Console.ReadKey();  

        }
    }
}
