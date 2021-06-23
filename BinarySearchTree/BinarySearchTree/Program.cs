using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Welcome to Binary Search Tree Problem*******");
            BinaryTree<int> tree = new BinaryTree<int>();
            //UC1:-create BST by adding Elements 56,30,70
            tree.InsertData(56);
            tree.InsertData(30);
            tree.InsertData(70);
            tree.Display(tree.GetRoot());
            Console.WriteLine("===========================================");
            //UC2:-create a binary tree by various Element
            tree.InsertData(22);
            tree.InsertData(40);
            tree.InsertData(11);
            tree.InsertData(3);
            tree.InsertData(16);
            tree.InsertData(60);
            tree.InsertData(95);
            tree.InsertData(65);
            tree.InsertData(63);
            tree.InsertData(67);
            tree.Display(tree.GetRoot());
            Console.WriteLine("Count of elements in Binary search tree is: " + tree.GetSize());
            Console.WriteLine("================================================");
            //UC3:-Search element
            bool result = tree.SearchTree(63, tree.GetRoot());
            Console.WriteLine("Status " + result);
        }
    }
}
