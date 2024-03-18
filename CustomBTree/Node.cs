
namespace CustomBTree
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T>? LeftTree { get; set; }
        public Node<T>? RightTree { get; set; }
        public int? Depth { get; set; }
    }
}
