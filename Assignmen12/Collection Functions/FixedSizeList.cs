using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmen12.Collection_Functions
{
    internal class FixedSizeList<T>
    {
        private T[] list;
        private int count;

        public int Count => count;

        public FixedSizeList(int capacity)
        {
            if (capacity <= 0)
            {
                throw new ArgumentException("Capacity must be more than zero.");
            }

            list = new T[capacity];
            count = 0;
        }

        public void Add(T item)
        {
            if (count >= list.Length)
            {
                throw new Exception("list is full");
            }

            list[count++] = item;
        }

        public T Get(int index)
        {
            if (index >= count || index < 0)
                throw new IndexOutOfRangeException("index out of range");

            return list[index];
        }
    }
}
