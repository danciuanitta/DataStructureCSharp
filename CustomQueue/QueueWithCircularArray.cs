namespace CustomQueue
{
    public class QueueWithCircularArray<T>
    {
        private T[] _items;
        private int _index = 0;
        private int _size = 0;
        private int _capacity = 0;
        private int _head;
        private int _tail;
    }
}