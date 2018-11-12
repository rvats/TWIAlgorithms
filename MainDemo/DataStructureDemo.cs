using DataStructures;
using DSOperations;
using System;
using System.Collections.Generic;

namespace MainDemo
{
    class DataStructureDemo : IDemo
    {
        public DataStructureDemo()
        {
        }

        public static void TreeTraversal()
        {
            TreeOperations treeOperations = new TreeOperations();
            var Data = new List<object> { 5, 3, 7, 2, 4, 6, 8, 1, 9 };
            treeOperations.PopulateBinarySearchTree(Data);
            Console.WriteLine("=========================================================================");
            var preOrderPath = treeOperations.RecursivePreOrderTraversal();
            DisplayPath(preOrderPath);
            preOrderPath = treeOperations.IterativePreOrderTraversal();
            DisplayPath(preOrderPath);
            Console.WriteLine("=========================================================================");
            var inOrderPath = treeOperations.RecursiveInOrderTraversal();
            DisplayPath(inOrderPath);
            inOrderPath = treeOperations.IterativeInOrderTraversal();
            DisplayPath(inOrderPath);
            Console.WriteLine("=========================================================================");
            var postOrderPath = treeOperations.RecursivePostOrderTraversal();
            DisplayPath(postOrderPath);
            postOrderPath = treeOperations.IterativePostOrderTraversal();
            DisplayPath(postOrderPath);
            Console.WriteLine("=========================================================================");
            Console.WriteLine("The Max Level for Leaf Node of The Tree is "+treeOperations.FindMaxLevel()+".\nHierarchical representation is shown below: ");
            treeOperations.PrintHierarchy();
            Console.WriteLine("=========================================================================");
        }

        private static void DisplayPath(List<BinaryTreeNode> path)
        {
            var pathLength = path.Count;
            for (int i = 0; i < pathLength; i++)
            {
                if (i < pathLength - 1)
                {
                    Console.Write(path[i].Value.ToString() + " -> ");
                }
                else
                {
                    Console.Write(path[i].Value.ToString());
                }

            }
            Console.WriteLine();
        }

        public static void DepthFirstTraversal()
        {
            GraphOperations graphOperations;
            Node nodeA, nodeH, nodeX, nodeY, nodeZ;
            SetupGraph(out graphOperations, out nodeA, out nodeH, out nodeX, out nodeY, out nodeZ);

            /// Traverse The Bi-Directional Graph at two nodes
            graphOperations.StartingNode = nodeA;
            var depthFirstPath = DisplayDepthFirstTraversal(graphOperations);

            graphOperations.StartingNode = nodeH;
            depthFirstPath = DisplayDepthFirstTraversal(graphOperations);

            /// Traverse The Uni-Directional Graph at various nodes
            graphOperations.StartingNode = nodeX;
            depthFirstPath = DisplayDepthFirstTraversal(graphOperations);

            graphOperations.StartingNode = nodeY;
            depthFirstPath = DisplayDepthFirstTraversal(graphOperations);

            graphOperations.StartingNode = nodeZ;
            depthFirstPath = DisplayDepthFirstTraversal(graphOperations);
        }

        public static void BreadthFirstTraversal()
        {
            GraphOperations graphOperations;
            Node nodeA, nodeH, nodeX, nodeY, nodeZ;
            SetupGraph(out graphOperations, out nodeA, out nodeH, out nodeX, out nodeY, out nodeZ);

            /// Traverse The Bi-Directional Graph at two nodes
            graphOperations.StartingNode = nodeA;
            var breadthFirstPath = DisplayBreadthFirstTraversal(graphOperations);

            graphOperations.StartingNode = nodeH;
            breadthFirstPath = DisplayBreadthFirstTraversal(graphOperations);

            /// Traverse The Uni-Directional Graph at various nodes
            graphOperations.StartingNode = nodeX;
            breadthFirstPath = DisplayBreadthFirstTraversal(graphOperations);

            graphOperations.StartingNode = nodeY;
            breadthFirstPath = DisplayBreadthFirstTraversal(graphOperations);

            graphOperations.StartingNode = nodeZ;
            breadthFirstPath = DisplayBreadthFirstTraversal(graphOperations);
        }

        private static void SetupGraph(out GraphOperations graphOperations, out Node nodeA, out Node nodeH, out Node nodeX, out Node nodeY, out Node nodeZ)
        {
            graphOperations = new GraphOperations();
            nodeA = new Node('A');
            var nodeB = new Node('B');
            var nodeC = new Node('C');
            var nodeD = new Node('D');
            var nodeE = new Node('E');
            var nodeF = new Node('F');
            var nodeG = new Node('G');
            nodeH = new Node('H');
            nodeX = new Node('X');
            nodeY = new Node('Y');
            nodeZ = new Node('Z');

            /// Following Demonstrate A Bi-Directional Graph
            nodeA.AdjacentNodes.Enqueue(nodeG);
            nodeA.AdjacentNodes.Enqueue(nodeD);
            nodeA.AdjacentNodes.Enqueue(nodeB);

            nodeB.AdjacentNodes.Enqueue(nodeF);
            nodeB.AdjacentNodes.Enqueue(nodeE);
            nodeB.AdjacentNodes.Enqueue(nodeA);

            nodeC.AdjacentNodes.Enqueue(nodeH);
            nodeC.AdjacentNodes.Enqueue(nodeF);

            nodeD.AdjacentNodes.Enqueue(nodeF);
            nodeD.AdjacentNodes.Enqueue(nodeA);

            nodeE.AdjacentNodes.Enqueue(nodeG);
            nodeE.AdjacentNodes.Enqueue(nodeB);

            nodeF.AdjacentNodes.Enqueue(nodeD);
            nodeF.AdjacentNodes.Enqueue(nodeC);
            nodeF.AdjacentNodes.Enqueue(nodeB);

            nodeG.AdjacentNodes.Enqueue(nodeE);
            nodeG.AdjacentNodes.Enqueue(nodeA);

            nodeH.AdjacentNodes.Enqueue(nodeC);

            /// Following Demonstrate A Unidirectional Graph X -> Y -> Z
            nodeX.AdjacentNodes.Enqueue(nodeY);
            //nodeY.AdjacentNodes.Add(nodeX);
            nodeY.AdjacentNodes.Enqueue(nodeZ);
            //nodeZ.AdjacentNodes.Add(nodeY);
        }

        private static List<Node> DisplayDepthFirstTraversal(GraphOperations graphOperations)
        {
            var path = graphOperations.DepthFirstTraversal();
            PrintPath(path);
            return path;
        }

        private static List<Node> DisplayBreadthFirstTraversal(GraphOperations graphOperations)
        {
            var path = graphOperations.BreadthFirstTraversal();
            PrintPath(path);
            return path;
        }

        private static void PrintPath(List<Node> path)
        {
            var pathLength = path.Count;
            for (int i = 0; i < pathLength; i++)
            {
                if (i < pathLength - 1)
                {
                    Console.Write(path[i].Value.ToString() + " -> ");
                }
                else
                {
                    Console.Write(path[i].Value.ToString());
                }

            }
            Console.WriteLine();
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
    }
}
