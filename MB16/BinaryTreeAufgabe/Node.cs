namespace MB16.BinaryTreeAufgabe
{
    public sealed class Node<TNode> where TNode : IComparable<TNode>
    {
        // TNode muss IComparable implementieren
        public TNode Item { get; set; }

        public Node<TNode> Left { get; set; }
        public Node<TNode> Right { get; set; }

        public int CompareTo(TNode other)
        {
            return Item.CompareTo(other);
        }
    }
}
