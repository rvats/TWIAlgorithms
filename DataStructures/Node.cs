using System.Collections.Generic;

namespace DataStructures
{
    public class Node : INode
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
