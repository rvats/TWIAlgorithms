using DataStructures;
using DSOperations;
using System;
using System.Collections.Generic;

namespace MainDemo
{
    class Demo
    {
        public static void TreeTraversal()
        {
            TreeOperations treeOperations = new TreeOperations();
            var Data = new List<object> { 5, 3, 7, 2, 4, 6, 8, 1, 9 };
            treeOperations.PopulateBinarySearchTree(Data);
            Console.WriteLine("=========================================================================");
            treeOperations.PreOrderTraversal();
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
            treeOperations.InOrderTraversal();
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
            treeOperations.PostOrderTraversal();
            Console.WriteLine();
            Console.WriteLine("=========================================================================");
        }

        public static void DepthFirstTraversal()
        {
            GraphOperations graphOperations = new GraphOperations();
            var nodeA = new Node('A');
            var nodeB = new Node('B');
            var nodeC = new Node('C');
            var nodeD = new Node('D');
            var nodeE = new Node('E');
            var nodeF = new Node('F');
            var nodeG = new Node('G');
            var nodeH = new Node('H');
            var nodeX = new Node('X');
            var nodeY = new Node('Y');
            var nodeZ = new Node('Z');

            /// Following Demonstrate A Bi-Directional Graph
            nodeA.AdjacentNodes.Add(nodeB);
            nodeA.AdjacentNodes.Add(nodeG);
            nodeA.AdjacentNodes.Add(nodeD);

            nodeB.AdjacentNodes.Add(nodeA);
            nodeB.AdjacentNodes.Add(nodeE);
            nodeB.AdjacentNodes.Add(nodeF);

            nodeC.AdjacentNodes.Add(nodeF);
            nodeC.AdjacentNodes.Add(nodeH);

            nodeD.AdjacentNodes.Add(nodeA);
            nodeD.AdjacentNodes.Add(nodeF);

            nodeE.AdjacentNodes.Add(nodeB);
            nodeE.AdjacentNodes.Add(nodeG);

            nodeF.AdjacentNodes.Add(nodeB);
            nodeF.AdjacentNodes.Add(nodeC);
            nodeF.AdjacentNodes.Add(nodeD);

            nodeG.AdjacentNodes.Add(nodeA);
            nodeG.AdjacentNodes.Add(nodeE);

            nodeH.AdjacentNodes.Add(nodeC);

            /// Following Demonstrate A Unidirectional Graph X -> Y -> Z
            nodeX.AdjacentNodes.Add(nodeY);

            nodeY.AdjacentNodes.Add(nodeZ);

            /// Traverse The Bi-Directional Graph at two nodes
            graphOperations.StartingNode = nodeA;
            var depthFirstPath = DisplayTraversal(graphOperations);

            graphOperations.StartingNode = nodeH;
            depthFirstPath = DisplayTraversal(graphOperations);

            /// Traverse The Uni-Directional Graph at various nodes
            graphOperations.StartingNode = nodeX;
            depthFirstPath = DisplayTraversal(graphOperations);

            graphOperations.StartingNode = nodeY;
            depthFirstPath = DisplayTraversal(graphOperations);

            graphOperations.StartingNode = nodeZ;
            depthFirstPath = DisplayTraversal(graphOperations);
        }

        private static List<Node> DisplayTraversal(GraphOperations graphOperations)
        {
            var path = graphOperations.DepthFirstTraversal();
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
            return path;
        }
    }
}
