using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DSOperations
{
    public class TreeOperations
    {
        private BinaryTreeNode current;

        #region PopulateTreeOperations
        public void PopulateBinarySearchTree(List<object> Data)
        {
            var root = current;

            while (Data.Count > 0)
            {
                root = Insert(root, Data.First());
                Data.RemoveAt(0);
            }

            current = root;
        }

        private BinaryTreeNode Insert(BinaryTreeNode root, Object v)
        {
            if (root == null)
            {
                root = new BinaryTreeNode();
                root.Value = v;
            }
            else if ((int)v < (int)root.Value)
            {
                root.Left = Insert(root.Left, v);
            }
            else
            {
                root.Right = Insert(root.Right, v);
            }

            return root;
        }
        #endregion

        #region RecursiveTraversal
        public void RecursivePreOrderTraversal()
        {
            BinaryTreeNode root = current;
            RecursivePreOrderTraversal(current);
        }

        private void RecursivePreOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return;
            Console.Write(root.Value.ToString()+" ");
            RecursivePreOrderTraversal(root.Left);
            RecursivePreOrderTraversal(root.Right);
        }

        public void RecursiveInOrderTraversal()
        {
            BinaryTreeNode root = current;
            RecursiveInOrderTraversal(current);
        }

        private void RecursiveInOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return;
            RecursiveInOrderTraversal(root.Left);
            Console.Write(root.Value.ToString() + " ");
            RecursiveInOrderTraversal(root.Right);
        }

        public void RecursivePostOrderTraversal()
        {
            BinaryTreeNode root = current;
            RecursivePostOrderTraversal(current);
        }

        private void RecursivePostOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return;
            RecursivePostOrderTraversal(root.Left);
            RecursivePostOrderTraversal(root.Right);
            Console.Write(root.Value.ToString() + " ");
        }
        #endregion

        #region IterativeTraversal
        public List<BinaryTreeNode> IterativePreOrderTraversal()
        {
            var preOrderPath = new List<BinaryTreeNode>();
            if (current == null)
            {
                return preOrderPath;
            }
            var root = current;
            
            var stack = new Stack<BinaryTreeNode>();
            stack.Push(root);
            while (stack.Count > 0)
            {
                preOrderPath.Add(stack.Pop());
                if (root.Right != null)
                {
                    stack.Push(root.Right);
                }
                if(root.Left != null)
                {
                    stack.Push(root.Left);
                }
            }
            return preOrderPath;
        }
        #endregion
    }
}
