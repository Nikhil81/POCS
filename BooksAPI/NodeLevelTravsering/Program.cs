using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeLevelTravsering
{
    class BstNode
    {
        public int data { get; set; }
        public BstNode left { get; set; }
        public BstNode right { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            BstNode root = null;
            Console.WriteLine("Inert node into treee");
            root = Insert(root, 5);
            root = Insert(root, 2);
            root = Insert(root, 3);
            root = Insert(root, 1);
            root = Insert(root, 6);
            root = Insert(root, 10);
            root = Insert(root, 4);
            root = Insert(root, 11);
            root = Insert(root, 9);

            PrintNodeData(root);
            Console.Read();
        }

        private static void PrintNodeData(BstNode root)
        {
            Queue<BstNode> q = new Queue<BstNode>();
            q.Enqueue(root);
            while (q.Any())
            {
                var node = q.Dequeue();
                Console.WriteLine($"{node.data}");
                if (node.left != null)
                {
                    q.Enqueue(node.left);
                }
                if (node.right != null)
                {
                    q.Enqueue(node.right);
                }

            }
        }

        private static BstNode Insert(BstNode node, int data)
        {
            if (node == null)
            {
                node = CreateNode(data);
            }
            //move item to the left
            else if (data < node.data)
            {
                node.left = Insert(node.left, data);
            }
            //mode item to rigth
            else if (node.data < data)
            {
                node.right = Insert(node.right, data);
            }

            return node;
        }

        private static BstNode CreateNode(int data)
        {
            BstNode node = new BstNode
            {
                data = data,
                left = null,
                right = null
            };
            return node;
        }
    }
}
