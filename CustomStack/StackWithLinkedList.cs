using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomStack
{
    internal class StackWithLinkedList<T>
    {
        private LinkedList<T> _internalLinkedList;

        public StackWithLinkedList()
        {
            _internalLinkedList = new LinkedList<T>();
        }

        public void Push(T value)
        {
            var newNode = _internalLinkedList.AddLast(value);
        }

        public LinkedListNode<T> Pop()
        {
            _internalLinkedList.RemoveLast(); //this throws exception if first is null
            return _internalLinkedList!.Last!;
        }

        public LinkedListNode<T>? Peek()
        {
            return _internalLinkedList.Last;
        }
    }
}
