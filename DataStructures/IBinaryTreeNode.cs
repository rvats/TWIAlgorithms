namespace DataStructures
{
    public interface IBinaryTreeNode
    {
        BinaryTreeNode Left { get; set; }
        BinaryTreeNode Right { get; set; }
        object Value { get; set; }

        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}