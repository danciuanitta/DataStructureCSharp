
namespace CustomBTree
{
    internal class SelfBalancedBinarySearchTree<T>
    {
        Node<T> Root;

        public void Insert(T value)
        {
            if (Root is null)
            {
                Root = new Node<T>();
                Root.Value = value;
            }

        }
    }
}
