using DataStructures;
using DSOperations;
using System;
using System.Collections.Generic;

namespace MainDemo
{
    class Program
    {
        static void Main(string[] args)
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

            graphOperations.StartingNode = nodeA;
            var depthFirstPath = graphOperations.DepthFirstTraversal();

            foreach(var node in depthFirstPath)
            {
                Console.WriteLine(node.Value);
            }
        }
    }
}
