namespace DataStructures
{
    public class BinaryTreeNode : IBinaryTreeNode
    {
        public object Value { get; set; }
        public BinaryTreeNode Left { get; set; }
        public BinaryTreeNode Right { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
