﻿using System.Collections.Generic;
using DataStructures;

namespace DSOperations
{
    public interface ITreeOperations
    {
        bool Equals(object obj);
        int GetHashCode();
        List<BinaryTreeNode> IterativeInOrderTraversal();
        List<BinaryTreeNode> IterativePostOrderTraversal();
        List<BinaryTreeNode> IterativePreOrderTraversal();
        void PopulateBinarySearchTree(List<object> Data);
        List<BinaryTreeNode> RecursiveInOrderTraversal();
        List<BinaryTreeNode> RecursivePostOrderTraversal();
        List<BinaryTreeNode> RecursivePreOrderTraversal();
        string ToString();
    }
}