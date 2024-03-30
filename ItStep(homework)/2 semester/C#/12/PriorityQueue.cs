using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12
{
    public class PriorityQueue<T>
    {
        private List<T>[] _items;
        private int _size;

        public PriorityQueue(int size)
        {
            _size = size;
            _items = new List<T>[size];
            for (int i = 0; i < size; i++)
            {
                _items[i] = new List<T>();
            }
        }

        public void Enqueue(T item, int priority)
        {
            if (priority < 0 || priority >= _size)
                throw new ArgumentOutOfRangeException("Priority is out of range.");

            _items[priority].Add(item);
        }

        public T Dequeue()
        {
            for (int i = _size - 1; i >= 0; i--)
            {
                if (_items[i].Count > 0)
                {
                    T item = _items[i][0];
                    _items[i].RemoveAt(0);
                    return item;
                }
            }
            throw new InvalidOperationException("Queue is empty.");
        }

        public bool IsEmpty()
        {
            foreach (var list in _items)
            {
                if (list.Count > 0)
                    return false;
            }
            return true;
        }
    }
}
