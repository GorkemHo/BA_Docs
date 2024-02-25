

using BABank.BaseEntities;
using System.Collections;

namespace BABank.Shared.Queues
{
    public abstract class BaseQueue<T> : Queue<T> ,ICollection<T> where T : Human
    {
        protected Queue<T> _list;

        

        public BaseQueue()
        {
            _list = new Queue<T>();  
        }
		

        public int Count => _list.Count;

        public bool IsReadOnly => ((ICollection<T>)_list).IsReadOnly;    

        

        public void Add(T item)
        {
            _list.ToList().Add(item);
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(T item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public bool Remove(T item)
        {
            return _list.ToList().Remove(item);
        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _list.GetEnumerator();
        }
    }
}
