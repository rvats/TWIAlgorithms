using System.Collections.Generic;

namespace DataStructures
{
    public class Node
    {
        public object Value { get; set; }
        public List<Node> AdjacentNodes { get; set; }
        public Node()
        {
            AdjacentNodes = new List<Node>();
        }

        public Node(object value)
        {
            Value = value;
            AdjacentNodes = new List<Node>();
        }
    }
}
