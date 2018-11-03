using System.Collections.Generic;

namespace DataStructures
{
    public class Node
    {
        public object Value { get; set; }
        public Queue<Node> AdjacentNodes { get; set; }
        public Node()
        {
            AdjacentNodes = new Queue<Node>();
        }

        public Node(object value)
        {
            Value = value;
            AdjacentNodes = new Queue<Node>();
        }
    }
}
