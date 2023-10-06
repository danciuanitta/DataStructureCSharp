namespace DoublyLinkedList
{
    public class CustomDoubleLinkedList<T>
    {
        private LinkedListNode<T>? FirstNode;
        private LinkedListNode<T>? LastNode;
        private int count = 0;

        public int Count
        {
            get
            {
                return count;
            }
        }

        public void Add(T value)
        {
            if (FirstNode is null)
            {
                //for the first item added, first and last node are the same
                FirstNode = new LinkedListNode<T>()
                {
                    CurrentValue = value
                };

                LastNode = new LinkedListNode<T>()
                {
                    CurrentValue = value
                };

                count++;

                return;
            }
            else if (FirstNode.NextNode is null)
            {
                //second element
                LinkedListNode<T> newNode = new LinkedListNode<T>()
                {
                    CurrentValue = value
                };
               
                LastNode = newNode;
                FirstNode.NextNode = newNode;
                LastNode.PreviousNode = FirstNode;

                count++;
            }
            else
            {
                AddLast(value);
            }
        }

        public void AddFirst(T value)
        {
            if (FirstNode is null)
            {
                //for the first item added, first and last node are the same
                FirstNode = new LinkedListNode<T>()
                {
                    CurrentValue = value
                };

                LastNode = new LinkedListNode<T>()
                {
                    CurrentValue = value
                };

                count++;

                return;
            }
            else
            {
                var newNode = new LinkedListNode<T>()
                {
                    CurrentValue = value,
                    NextNode = FirstNode
                };

                FirstNode = newNode;
            }
        }

        public void AddLast(T? value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>()
            {
                CurrentValue = value
            };

            LastNode!.NextNode = newNode;
            newNode.PreviousNode = LastNode;

            LastNode = newNode;
            count++;
        }
    }
}