using System;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******Welcome to Binary Search Tree Problem*******");
            BinaryTree<int> tree = new BinaryTree<int>();
            //UC1:-
            tree.InsertData(56);
            tree.InsertData(30);
            tree.InsertData(70);
            tree.Display(tree.GetRoot());

        }
    }
}
