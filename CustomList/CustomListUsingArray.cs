
namespace CustomList
{
    public class CustomListUsingArray<T>
    {
        private T[] _items;
        private int _index = 0;
        private int _size = 0;
        private int _capacity = 0;


        public CustomListUsingArray()
        {
            _items = new T[0];
        }

        public CustomListUsingArray(int capacity)
        {
            _capacity = capacity;
            _items= new T[capacity];
        }

        public void Add(T item)
        {
            if (_items.Length == _capacity)
                EnsureCapacity(_items.Length);
            _size++;
            _items[_size] = item;
        }

        private void EnsureCapacity(int neededSize)
        {
            if (neededSize == 0)
            {
                _capacity = 4;
                _items = new T[4];
            }
            else
            {
                _capacity = _capacity + _items.Length * 2;
            }
        }
    }
}
