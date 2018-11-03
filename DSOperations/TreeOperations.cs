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
            Console.Write(root.Value.ToString() + " ");
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
                root = stack.Pop();
                preOrderPath.Add(root);
                if (root.Right != null)
                {
                    stack.Push(root.Right);
                }
                if (root.Left != null)
                {
                    stack.Push(root.Left);
                }
            }
            return preOrderPath;
        }

        public List<BinaryTreeNode> IterativeInOrderTraversal()
        {
            var inOrderPath = new List<BinaryTreeNode>();
            if (current == null)
            {
                return inOrderPath;
            }
            var root = current;

            var stack = new Stack<BinaryTreeNode>();

            while (stack.Count > 0 || root != null)
            {
                while (root != null)
                {
                    stack.Push(root);
                    root = root.Left;
                }
                root = stack.Pop();
                inOrderPath.Add(root);
                root = root.Right;
            }
            return inOrderPath;
        }

        public List<BinaryTreeNode> IterativePostOrderTraversal()
        {
            var postOrderPath = new List<BinaryTreeNode>();
            if (current == null)
            {
                return postOrderPath;
            }
            var root = current;

            var stack1 = new Stack<BinaryTreeNode>();
            var stack2 = new Stack<BinaryTreeNode>();

            // push root to first stack 
            stack1.Push(root);

            // Run while first stack is not empty 
            while (stack1.Count > 0)
            {
                // Pop an item from s1 and push it to s2 
                var temp = stack1.Pop();
                stack2.Push(temp);

                // Push left and right children of 
                // removed item to s1 
                if (temp.Left != null)
                    stack1.Push(temp.Left);
                if (temp.Right != null)
                    stack1.Push(temp.Right);
            }

            // Print all elements of second stack 
            while (stack2.Count > 0)
            {
                postOrderPath.Add(stack2.Pop());
            }
            return postOrderPath;
        }
        #endregion
    }
}
