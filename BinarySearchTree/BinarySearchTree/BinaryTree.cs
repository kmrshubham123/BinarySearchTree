﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class BinaryTree<T> where T : IComparable // Defines a generalized type-specific comparison method that a value type or class
    {                                         // implements to order or sort its instances.
        Node<T> Root;
        Node<T> Current;
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

                }
                else
                {
                    this.Current = this.Current.leftNode;
                    InsertData(data);
                }
                Console.WriteLine("{0} Inserted in Left Node ",data);
            }
            else
            {
                ///Checks if right node is null.
                if (this.Current.rightNode == null)
                {
                    this.Current.rightNode = new Node<T>(data);
                    this.Current = Root;
                }
                else
                {
                    this.Current = this.Current.rightNode;
                    InsertData(data);
                }
                Console.WriteLine("{0} Inserted in Right Node ", data);
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
    }
}
