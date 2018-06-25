using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        internal int data;
        internal Node _next;
        public Node(int d)
        {
            data = d;
            _next = null;
        }
    }
    class Program
    {
        static Node head;
        static void Main(string[] args)
        {
            head = null;
            Insert(10);
            Insert(20);
            Insert(30);
            Insert(40);
            PrintNumber();

            Insert(5, 3);
            PrintNumber();
            Deleted(3);
            PrintNumber();
            Reverse();
            PrintNumber();

            Console.WriteLine("------------------ using recurrexion ------------");
            PrintUsingRcurresion(head);
            Console.Read();

        }

        private static void Insert(int x)
        {
            Node temp1 = new Node(x);
            temp1._next = head;
            head = temp1;


        }

        private static void Insert(int data, int position)
        {
            //creteing a new node
            Node temp = new Node(data);
            temp._next = null;

            //fidn nth node and insert
            Node temp1 = head;
            if (position > 1)
            {
                for (int i = 0; i < position - 2; i++)
                {
                    temp1 = temp1._next;
                }

                temp._next = temp1._next;
                temp1._next = temp;


            }

        }

        //Deleting a node fromnth postions
        private static void Deleted(int n)
        {
            Console.WriteLine();
            Console.WriteLine("Deleting a node ---------------");
            Node temp1 = head;

            if (n == 1)
            {
                head = temp1._next;
                return;
            }
            for (int i = 0; i < n - 2; i++)
            {
                temp1 = temp1._next;
            }

            Node temp2 = temp1._next;
            temp1._next = temp2._next;
        }
        private static void Reverse()
        {
            Console.WriteLine();

            Console.WriteLine("Reverse ------------------");
            Node current, next, prev;
            current = head;
            prev = null;
            next = null;

            while (current != null)
            {
                next = current._next;
                current._next = prev;
                prev = current;
                current = next;
            }
            head = prev;


        }

        private static void PrintNumber()
        {
            Node temp = head;
            Console.WriteLine();

            Console.WriteLine("---------- Printing ------------");
            while (temp != null)
            {
                Console.Write("\t" + temp.data);
                temp = temp._next;
            }

        }

        static void PrintUsingRcurresion(Node head)
        {
            if (head == null)
            {
                return;
            }
            PrintUsingRcurresion(head._next);
            Console.WriteLine(head.data);
        }
    }
}
