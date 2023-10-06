using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    public class ListWithICollection<T> :ICollection<T>
    {
        public int Count { get; }

        public bool IsReadOnly { get; }


        public void Add(T item)
        {

        }

        public void Clear()
        {

        }

        public bool Contains(T item)
        {
            return false;
        }
        
        public void CopyTo(T[] array, int arrayIndex)
        {

        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        public bool Remove(T item)
        {
            return false;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
