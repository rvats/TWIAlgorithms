using System.Collections.Generic;

namespace DataStructures
{
    public interface INode
    {
        Queue<Node> AdjacentNodes { get; set; }
        object Value { get; set; }

        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}