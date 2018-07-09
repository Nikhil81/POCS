using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        int top = -1;
        private const int MAXVALUE = 101;
        int[] stack = new int[MAXVALUE];

        static void Main(string[] args)
        {
            Program p = new Program();
            p.Push(5);
            p.Print();
            p.Push(10);
            p.Print();
            p.Push(15);
            p.Print();
            p.Push(20);
            p.Print();
            p.Push(25);
            p.Print();
            p.Pop();
            p.Pop();
            p.Print();
            Console.WriteLine(p.IsEmpty());
            Console.WriteLine(p.Top());
            Console.Read();
        }

        //push
        void Push(int x)
        {
            if (top == MAXVALUE - 1)
            {
                throw new IndexOutOfRangeException();
            }
            stack[++top] = x;
        }
        //pop
        void Pop()
        {
            if (top == -1)
            {
                throw new IndexOutOfRangeException();
            }
            top--;

        }
        //top
        int Top()
        {
            return stack[top];
        }
        //IsEmpty
        bool IsEmpty()
        {
            return top == -1;
        }
        void Print()
        {
            for (int i = 0; i < top; i++)
            {
                Console.WriteLine(stack[i]);
            }
        }
    }
}
