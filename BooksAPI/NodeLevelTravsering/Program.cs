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
            Console.WriteLine("Inert node into tree");
            root = Insert(root, 5);
            root = Insert(root, 2);
            root = Insert(root, 3);
            root = Insert(root, 1);
            root = Insert(root, 6);
            root = Insert(root, 10);
            root = Insert(root, 4);
            root = Insert(root, 11);
            root = Insert(root, 9);
            root = Insert(root, 14);
            root = Insert(root, 12);

            PrintNodeData(root);
            Console.WriteLine("PreOder search");
            PreOrder(root);

            Console.WriteLine("PostOrder search");
            PostOrder(root);
            Console.WriteLine("InOrder search");
            InOrder(root);

            //Delete the node
            Console.WriteLine("Deleting the node");
            root = Delete(root, 10);
            InOrder(root);

            //Is BinarSerachtree
            Console.WriteLine($"is binary tree {IsBinaryTree(root)}");
            Console.WriteLine($"node find {GetSuccessor(root, 4)}");
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

        //DFS : Preorder
        private static void PreOrder(BstNode node)
        {

            if (node == null) return;
            Console.WriteLine($"{node.data}");
            PreOrder(node.left);
            PreOrder(node.right);

        }

        //DFS : Inorder traversal
        static void InOrder(BstNode node)
        {
            if (node == null) return;
            InOrder(node.left);
            Console.WriteLine($"{node.data}");
            InOrder(node.right);
        }

        //DFS : PostOrder traversal
        static void PostOrder(BstNode node)
        {
            if (node == null) return;
            PostOrder(node.left);
            PostOrder(node.right);
            Console.WriteLine($"{node.data}");

        }

        //if a tree is bst
        static bool IsBinaryTree(BstNode node)
        {
            return IsBinarySearchTree(node, null, null);
        }

        private static bool IsBinarySearchTree(BstNode node, BstNode minValue, BstNode maxValue)
        {
            if (node == null) return true;

            if ((minValue != null && node.data <= minValue.data)
                || (maxValue != null && node.data >= maxValue.data))
            {
                return false;
            }
            return IsBinarySearchTree(node.left, minValue, node) && IsBinarySearchTree(node.right, node, maxValue);

        }

        static BstNode Delete(BstNode node, int data)
        {
            //search
            if (node == null) return node;
            else if (node.data < data)
            {
                //go to left
                node.left = Delete(node.left, data);
            }
            else if (node.data > data)
            {
                //go to right
                node.right = Delete(node.right, data);
            }
            //if we found that
            else
            {
                //case 1: no child
                if (node.left == null && node.right == null)
                {
                    node = null;
                }
                //case 2: if single child left or right
                else if (node.left == null)
                {
                    node = node.right;
                }
                else if (node.right == null)
                {
                    node = node.left;
                }
                //if have both child
                else
                {
                    BstNode temp = FindMin(node.right);
                    node.data = temp.data;
                    node.right = Delete(node.right, temp.data);
                }
            }



            return node;
        }

        private static BstNode FindMin(BstNode node)
        {
            if (node == null) return null;
            while (node.left != null)
            {
                node = node.left;

            }
            return node;
        }
        //private static BstNode DeleteNode(BstNode root, int x)
        //{
        //    BstNode deleteNode = new BstNode { data = x, left = null, right = null };
        //    return Delete(root, deleteNode);
        //}

        //find Inorder successor of a node
        static BstNode GetSuccessor(BstNode node, int data)
        {
            if (node == null) return null;
            //find the node
            BstNode current = SearchNode(node, data);
            if (current == null) return null;
            //Case 1: have right child
            if (current.right != null)
            {
                return FindMin(current.right);
            }
            //Case 2 : have no right child 
            else
            {
                BstNode succeossr = null;
                BstNode ancestor = node;
                while (ancestor != current)
                {
                    if (current.data < ancestor.data)
                    {
                        succeossr = ancestor;//So far this is the deepest node  for which current node is in left
                        ancestor = ancestor.left;
                    }

                    else
                    {
                        ancestor = ancestor.right;
                    }

                }
                return succeossr;

            }

        }

        private static BstNode SearchNode(BstNode node, int data)
        {
            if (node == null) return node;
            if (node.data == data)
            {
                return node;
            }
            if (node.data < data)
            {
                node = SearchNode(node.right, data);
            }
            else
            {
                node = SearchNode(node.left, data);
            }
            return node;
        }
    }
}
