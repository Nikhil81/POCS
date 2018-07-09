using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    class Node
    {
        public Node(int data)
        {
            this.data = data;
        }
        public int data;
        public Node _next;
        public Node _prev;
    }

    class Program
    {
        static Node head;
        static void Main(string[] args)
        {
            InsertAtHead(5);
            InsertAtHead(4);
            InsertAtHead(3);
            InsertAtHead(2);
            Print();
            Console.Read();
        }

        static void Print()
        {
            Node temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp._next = temp;
            }

        }
        static void InsertAtHead(int x)
        {
            Node newNode = CreateNode(x);
            if (head == null)
            {
                head = newNode;
                return;
            }
            newNode._next = head;
           
            head = newNode;
        }

        private static Node CreateNode(int x)
        {
            Node newNode = new Node(x);
            newNode._next = null;
            newNode._prev = null;
            return newNode;
        }
    }




}
