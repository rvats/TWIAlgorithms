using DataStructures;
using System.Collections.Generic;
using System.Linq;

namespace DSOperations
{
    public class GraphOperations
    {
        public Node StartingNode;

        public List<Node> DepthFirstTraversal()
        {
            var DepthFirstPath = new List<Node>();
            var stack = new Stack<Node>();
            stack.Push(StartingNode);
            while (stack.Count > 0)
            {
                var nodeAtTopOfStack = stack.Pop();
                if (!DepthFirstPath.Contains(nodeAtTopOfStack))
                {
                    DepthFirstPath.Add(nodeAtTopOfStack);
                    foreach(var neighbour in nodeAtTopOfStack.AdjacentNodes)
                    {
                        if (!DepthFirstPath.Contains(neighbour))
                        {
                            stack.Push(neighbour);
                        }
                    }
                }
                
                
            }
            return DepthFirstPath;
        }
    }
}
