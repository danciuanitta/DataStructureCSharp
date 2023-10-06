
namespace SingleLinkedList
{
    public class CustomSingleLinkedListWithLast<T>
    {
        private LinkedListNode<T>? FirstNode;
        private LinkedListNode<T>? LastNode;
        private int _count = 0;

        public int Count
        {
            get
            {
                return _count;
            }
        }

        public void Add(T value)
        {
            if (value is null)
                throw new ArgumentNullException(nameof(T));

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

                _count++;
            }
            else if (FirstNode.NextNode is null)
            {
                //second element
                LinkedListNode<T> newNode = new LinkedListNode<T>()
                {
                    CurrentValue = value
                };
                FirstNode.NextNode = newNode;
                LastNode = newNode;

                _count++;
            }
            else
            {
                AddLast(value);
            }
        }

        public void AddLast(T value)
        {
            LinkedListNode<T> newNode = new LinkedListNode<T>()
            {
                CurrentValue = value
            };

            if (FirstNode is null)
            {
                //for the first item added, first and last node are the same
                FirstNode = newNode;

                LastNode = newNode;
            }
            else if (LastNode is null)
            {
                LastNode = newNode;
            }
            else
            {
                LastNode!.NextNode = newNode;

                LastNode = newNode;
            }

            _count++;
        }

        public void AddFirst(T value)
        {
            var newNode = new LinkedListNode<T>()
            {
                CurrentValue = value
            };

            if (FirstNode is null)
            {
                FirstNode = newNode;
                LastNode ??= newNode;
            }
            else
            {
                newNode.NextNode = FirstNode;
                FirstNode = newNode;
            }

            _count++;
        }

        public bool Contains(T value)
        {
            if (FirstNode == null || FirstNode.CurrentValue is null)
                return false;

            if (FirstNode!.CurrentValue!.Equals(value))
                return true;

            return Contains(FirstNode!.NextNode, value);
        }

        public LinkedListNode<T>? Find(T value)
        {
            if (FirstNode == null || FirstNode.CurrentValue is null)
                return null;

            if (FirstNode!.CurrentValue!.Equals(value))
                return FirstNode;

            return Find(FirstNode!.NextNode, value);
        }

        public void Remove(T value)
        {
            if (FirstNode == null || FirstNode.CurrentValue is null)
                throw new ArgumentNullException(nameof(FirstNode));
            if (FirstNode.CurrentValue.Equals(value))
            {
                RemoveFirst();
            }
            else if (FirstNode.NextNode is null)
            //only one node in collection
            {
                FirstNode = null;
                LastNode = null;
            }
            else
            {
                var node = Find(value);

                if (node is null)
                    return;

                var previousNode = FindByNodeWhichReferences(FirstNode!.NextNode, node);
                if (previousNode is null)
                {
                    throw new ArgumentNullException(nameof(previousNode));
                }
                else
                {
                    previousNode.NextNode = node.NextNode;
                }
            }
        }

        public void RemoveFirst()
        {
            if (FirstNode == null || FirstNode.CurrentValue is null)
                throw new ArgumentNullException(nameof(FirstNode));

            var newNode = FirstNode.NextNode;
            FirstNode = newNode;
        }

        public void RemoveLast()
        {
            if (LastNode == null || LastNode.CurrentValue is null)
                throw new ArgumentNullException(nameof(LastNode));

            if (FirstNode == null || FirstNode.CurrentValue is null)
                throw new ArgumentNullException(nameof(FirstNode));

            if (FirstNode.NextNode is null)
            //only one node in collection
            {
                FirstNode = null;
                LastNode = null;
            }
            else if (FirstNode.NextNode.Equals(LastNode))
            {
                LastNode.NextNode = null;
                LastNode = FirstNode;
            }
            else
            {
                var node = FindByNodeWhichReferences(FirstNode!.NextNode, LastNode);
                if (node is null)
                    Console.WriteLine("no node found");
                else
                {
                    node.NextNode = null;
                    LastNode = node;
                }
            }
        }

        public void DisplayNodes()
        {
            if (FirstNode is null)
            {
                Console.WriteLine("No nodes");
            }

            var node = FirstNode;

            while (node is not null)
            {
                //nok
                Console.WriteLine($"node is: {node.CurrentValue}");

                node = node.NextNode;
            }
        }

        private LinkedListNode<T>? FindByNodeWhichReferences(LinkedListNode<T> nextNode, LinkedListNode<T> lastNode)
        {
            if (nextNode is null || nextNode!.NextNode is null)
                return null;

            if (nextNode!.NextNode!.Equals(lastNode))
                return nextNode;

            return FindByNodeWhichReferences(nextNode.NextNode, lastNode);
        }

        private LinkedListNode<T>? Find(LinkedListNode<T>? nextNode, T? value)
        {
            if (nextNode is null || nextNode.CurrentValue is null)
                return null;

            if (nextNode!.CurrentValue!.Equals(value))
                return nextNode;

            if (nextNode.NextNode == null)
                return null;

            return Find(nextNode.NextNode, value);
        }

        private bool Contains(LinkedListNode<T>? nextNode, T value)
        {
            if (nextNode is null || nextNode.CurrentValue is null)
                return false;

            if (nextNode!.CurrentValue!.Equals(value))
                return true;

            if (nextNode.NextNode == null)
                return false;

            return Contains(nextNode.NextNode, value);
        }
    }
}
