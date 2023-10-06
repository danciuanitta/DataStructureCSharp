
namespace CustomQueue
{
    public class QueueWithLinkedList<T>
    {
        private LinkedList<T> _internalLinkedList;

        public QueueWithLinkedList()
        {
            _internalLinkedList= new LinkedList<T>();
        }

        public void Enqueue(T value)
        {
            var newNode = _internalLinkedList.AddFirst(value);
        }

        public LinkedListNode<T> Dequeue()
        {
            _internalLinkedList.RemoveFirst(); //this throws exception if first is null
            return _internalLinkedList!.First!;
        }

        public LinkedListNode<T>? Peek()
        {
            return _internalLinkedList.First;
        }
    }
}
