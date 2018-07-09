using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    class BstNode
    {
        public int Data { get; set; }
        public BstNode left { get; set; }
        public BstNode Rigth { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            BstNode root = null;
            root = Insert(root, 5);
            root = Insert(root, 2);
            root = Insert(root, 3);
            root = Insert(root, 1);
            root = Insert(root, 6);
            root = Insert(root, 10);
            root = Insert(root, 4);
            root = Insert(root, 11);
            root = Insert(root, 9);

            Console.WriteLine(Search(root, 10));
            Console.WriteLine($"Minimum number with Recurrsion is { FindMinNumberWithRecusion(root) }");
            Console.WriteLine($"Maximum number with Recurrsion is { FindMaxNumberWithRecusion(root) }");
            Console.WriteLine($"Minimum number is { FindMinNumber(root) }");
            Console.WriteLine($"Maximum number is { FindMaxNumber(root) }");
            Console.WriteLine($"height of tree is {FindHeight(root)}");

            Console.Read();
        }
        static BstNode Insert(BstNode node, int data)
        {
            //code for first node
            if (node == null)
            {
                node = CreateNode(data);
            }
            //Move item to the left
            else if (data <= node.Data)
            {
                node.left = Insert(node.left, data);
            }
            //move item to the right
            else
            {
                node.Rigth = Insert(node.Rigth, data);
            }
            return node;
        }

        static BstNode CreateNode(int data)
        {
            BstNode node = new BstNode()
            {
                Data = data,
                left = null,
                Rigth = null
            };
            return node;
        }

        static string Search(BstNode node, int data)
        {
            string result = "NOT FOUND";
            if (node == null) return result;
            else if (data == node.Data)
            {
                result = "FOUND";
            }
            else if (data < node.Data)
            {
                result = Search(node.left, data);
            }
            else
            {
                result = Search(node.Rigth, data);
            }

            return result;

        }
        static int FindMinNumberWithRecusion(BstNode node)
        {
            if (node.left == null)
            {
                return node.Data;
            }
            return FindMinNumberWithRecusion(node.left);

        }
        static int FindMaxNumberWithRecusion(BstNode node)
        {
            if (node.Rigth == null)
            {
                return node.Data;
            }
            return FindMaxNumberWithRecusion(node.Rigth);

        }


        //without Recursion
        static int FindMinNumber(BstNode node)
        {
            if (node == null)
            {
                return -1;
            }
            while (node.left != null)
            {
                node = node.left;
            }
            return node.Data;
        }

        //Without Recursion
        static int FindMaxNumber(BstNode node)
        {
            if (node == null)
            {
                return -1;
            }
            while (node.Rigth != null)
            {
                node = node.Rigth;
            }
            return node.Data;
        }

        static int FindHeight(BstNode node)
        {
            if (node == null)
            {
                return -1;
            }

            return Maximum(FindHeight(node.left), FindHeight(node.Rigth)) + 1;
        }

        private static int Maximum(int v1, int v2)
        {
            return v1 > v2 ? v1 : v2;
        }
    }
}
