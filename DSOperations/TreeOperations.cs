﻿using DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DSOperations
{
    public class TreeOperations : ITreeOperations
    {
        public BinaryTreeNode Current;

        public TreeOperations()
        {
            PreOrderTraversalPath = new List<BinaryTreeNode>();
            InOrderTraversalPath = new List<BinaryTreeNode>();
            PostOrderTraversalPath = new List<BinaryTreeNode>();
        }

        private List<BinaryTreeNode> PreOrderTraversalPath;
        private List<BinaryTreeNode> InOrderTraversalPath;
        private List<BinaryTreeNode> PostOrderTraversalPath;

        #region PopulateTreeOperations
        public void PopulateBinarySearchTree(List<object> Data)
        {
            var root = Current;

            while (Data.Count > 0)
            {
                root = Insert(root, Data.First());
                Data.RemoveAt(0);
            }

            Current = root;
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
        public List<BinaryTreeNode> RecursivePreOrderTraversal()
        {
            var root = Current;
            return RecursivePreOrderTraversal(Current);
        }

        private List<BinaryTreeNode> RecursivePreOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return PreOrderTraversalPath;
            PreOrderTraversalPath.Add(root);
            RecursivePreOrderTraversal(root.Left);
            RecursivePreOrderTraversal(root.Right);
            return PreOrderTraversalPath;
        }

        public List<BinaryTreeNode> RecursiveInOrderTraversal()
        {
            BinaryTreeNode root = Current;
            return RecursiveInOrderTraversal(Current);
        }

        private List<BinaryTreeNode> RecursiveInOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return InOrderTraversalPath;
            RecursiveInOrderTraversal(root.Left);
            InOrderTraversalPath.Add(root);
            RecursiveInOrderTraversal(root.Right);
            return InOrderTraversalPath;
        }

        public List<BinaryTreeNode> RecursivePostOrderTraversal()
        {
            BinaryTreeNode root = Current;
            return RecursivePostOrderTraversal(Current);
        }

        private List<BinaryTreeNode> RecursivePostOrderTraversal(BinaryTreeNode root)
        {
            if (root == null) return PostOrderTraversalPath;
            RecursivePostOrderTraversal(root.Left);
            RecursivePostOrderTraversal(root.Right);
            PostOrderTraversalPath.Add(root);
            return PostOrderTraversalPath;
        }
        #endregion

        #region IterativeTraversal
        public List<BinaryTreeNode> IterativePreOrderTraversal()
        {
            var preOrderPath = new List<BinaryTreeNode>();
            if (Current == null)
            {
                return preOrderPath;
            }
            var root = Current;

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
            if (Current == null)
            {
                return inOrderPath;
            }
            var root = Current;

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
            if (Current == null)
            {
                return postOrderPath;
            }
            var root = Current;

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

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        public int FindMaxLevel()
        {
            int maxLevel = 0;
            if (Current == null) return maxLevel;
            var mainQueue = new Queue<BinaryTreeNode>();
            var subQueue = new Queue<BinaryTreeNode>();
            mainQueue.Enqueue(Current);
            while (mainQueue.Count > 0)
            {
                var temp = mainQueue.Dequeue();
                if (temp.Left != null)
                {
                    subQueue.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    subQueue.Enqueue(temp.Right);
                }
                if (mainQueue.Count == 0)
                {
                    maxLevel++;
                    while (subQueue.Count > 0)
                    {
                        mainQueue.Enqueue(subQueue.Dequeue());
                    }
                }
            }
            return maxLevel;
        }

        public void PrintHierarchy()
        {
            if (Current == null) return;
            var mainQueue = new Queue<BinaryTreeNode>();
            var subQueue = new Queue<BinaryTreeNode>();
            mainQueue.Enqueue(Current);
            while (mainQueue.Count > 0)
            {
                var temp = mainQueue.Dequeue();
                Console.Write(temp.Value + " ");

                if (temp.Left != null)
                {
                    subQueue.Enqueue(temp.Left);
                }
                if (temp.Right != null)
                {
                    subQueue.Enqueue(temp.Right);
                }
                if (mainQueue.Count == 0)
                {
                    Console.WriteLine();
                    while (subQueue.Count > 0)
                    {
                        mainQueue.Enqueue(subQueue.Dequeue());
                    }
                }
            }
        }

        public BinaryTreeNode CreateMinimalBinarySearchTree(int[] array, int start, int end)
        {
            if (array == null)
            {
                return null;
            }       
            if(end < start)
            {
                return null;
            }
            int mid = (start + end) / 2;
            BinaryTreeNode root = new BinaryTreeNode();
            root.Value = array[mid];
            root.Left = CreateMinimalBinarySearchTree(array, start, mid - 1);
            root.Right = CreateMinimalBinarySearchTree(array, mid + 1, end);
            return root;
        }
    }
}
