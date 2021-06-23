using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable // Defines a generalized type-specific comparison method that a value type or class
    {                                         // implements to order or sort its instances.
        Node<T> Root;
        Node<T> Current;
        int count;
        bool result = false;
        /// <summary>
        /// Inserts the data in Binary search tree.
        /// </summary>
        /// <param name="data">The data.</param>
        public void InsertData(T data)
        {
            ///Checks the root node is null or not.
            if (Root == null)
            {
                this.Root = new Node<T>(data);
                this.Current = Root;
                count++;
                return;
            }
            ///If data is less than data in root then current position node will point to left.
            if (this.Current.data.CompareTo(data) > 0) //  Compares the current instance with another object of the same type
            {
                ///Checks if left node is null.
                if (this.Current.leftNode == null)
                {
                    this.Current.leftNode = new Node<T>(data);
                    this.Current = Root;
                    count++;

                }
                else
                {
                    this.Current = this.Current.leftNode;
                    InsertData(data);
                }
            }
            else
            {
                ///Checks if right node is null.
                if (this.Current.rightNode == null)
                {
                    this.Current.rightNode = new Node<T>(data);
                    this.Current = Root;
                    count++;
                }
                else
                {
                    this.Current = this.Current.rightNode;
                    InsertData(data);
                }
            }

        }
        /// <summary>
        /// Gets the root node.
        /// </summary>
        /// <returns></returns>
        public Node<T> GetRoot()
        {
            return this.Root;
        }
        /// <summary>
        /// Displays the node elements from BST.
        /// </summary>
        /// <param name="node">The node.</param>
        public void Display(Node<T> node)
        {
            if (node != null)
            {
                Display(node.leftNode);
                Console.WriteLine("Element in binary search tree is: " + node.data);
                Display(node.rightNode);
            }

        }
        /// <summary>
        /// Gets the size of binary search tree..
        /// </summary>
        public int GetSize()
        {
            return count;
        }
        /// <summary>
        /// Search for the node in the binary search tree.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="node">The node.</param>
        /// <returns></returns>
        public bool SearchTree(int data, Node<T> node)
        {
            ///Checks for node is null.
            if (node == null)
            {
                return false;
            }
            else
            {
                ///Checks if current data is equal to data.
                if (this.Current.data.Equals(data))
                {
                    result = true;
                }
                ///If current data is less than data in root then current position node
                ///will point to left else to right.
                else if (this.Current.data.CompareTo(data) > 0)
                {
                    this.Current = this.Current.leftNode;
                    SearchTree(data, Current);
                }
                else
                {
                    this.Current = this.Current.rightNode;
                    SearchTree(data, Current);
                }
                return result;
            }
        }
    }
}
