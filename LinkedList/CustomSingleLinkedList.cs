
namespace SingleLinkedList
{
    public class CustomSingleLinkedList<T>
    {
        private LinkedListNode<T>? FirstNode;
        private int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }

        //Given it is a single linked list, a new item will always be added as last
        //O(n) because it has to go through all existing nodes
        public void Add(T value)
        {
            if (FirstNode is null)
            {
                FirstNode = new LinkedListNode<T>()
                {
                    CurrentValue = value
                };

                count++;

                return;
            }

            AddLast(FirstNode, value);

        }

        private void AddLast(LinkedListNode<T> node, T value)
        {
            if (node.NextNode is null)
            {
                LinkedListNode<T> newNode = new LinkedListNode<T>()
                {
                    CurrentValue = value
                };
                node.NextNode = newNode;
                count++;
            }
            else
            {
                AddLast(node.NextNode, value);
            }
        }
    }
}
