using System.Collections.Generic;
using DataStructures;

namespace DSOperations
{
    public interface IGraphOperations
    {
        List<Node> BreadthFirstTraversal();
        List<Node> DepthFirstTraversal();
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}