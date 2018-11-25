using DataStructures;
using System;
using System.Collections.Generic;

namespace DSOperations
{
    public static class HelperUtil
    {
        public static void DisplayList(List<BinaryTreeNode> list)
        {
            for(int i = 0; i < list.Count; i++)
            {
                if (i == list.Count - 1)
                {
                    Console.Write(list[i].Value);
                }
                else
                {
                    Console.Write(list[i].Value + " -> ");
                }
            }
            Console.WriteLine();
        }
    }
}
