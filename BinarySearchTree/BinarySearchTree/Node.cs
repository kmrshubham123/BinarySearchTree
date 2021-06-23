using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchTree
{
    class Node<T>
    {
        public T data;
        public Node<T> leftNode;
        public Node<T> rightNode;
        /// <summary>
        ///constructor to initialize data
        ///binary search tree contains definition of three parameters- data, left and right node.
        /// </summary>
        /// <param name="data"></param>
        public Node(T data)
        {
            this.data = data;
            this.leftNode = null;
            this.rightNode = null;
        }
    }
}
