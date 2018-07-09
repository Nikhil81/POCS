using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListImplementationOfStack
{
    class Node
    {
        public int data;
        public Node next;

        public Node(int input)
        {
            data = input;
        }
    }
    class Program
    {
        static Node top = null;
        static void Main(string[] args)
        {
            Console.WriteLine(IsEmpty());
            Push(5);
            Push(10);
            Push(15);
            Push(20);
            Print();
            Pop();
            Console.WriteLine("----- TOP -----");
            Top();

            Print();
            Console.ReadKey();
        }

        //push
        static void Push(int x)
        {
            Node temp = new Node(x);
            temp.next = top;
            top = temp;
        }
        static void Print()
        {
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        static void Pop()
        {
            top = top.next;
        }
        static void Top()
        {
            Console.WriteLine(top.data);
        }
        static bool IsEmpty()
        {
            return top == null || top.data == 0 ;
        }
    }
}
