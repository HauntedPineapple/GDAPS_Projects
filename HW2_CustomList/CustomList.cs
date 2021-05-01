using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_CustomList
{
    class CustomList <T>
    {
        private T[] array;
        private int count;
        public int Count { get { return count; } }
        public int Capacity { get { return array.Length; } }
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    return default(T);
                }
                return array[index];
            }
            set
            {
                if (index < 0 || index >= count)
                {
                    return;
                }
                array[index] = value;
            }
        }

        public CustomList()
        {

        }

        public void Add(T item)
        {

        }
        public int IndexOf(T item)
        {
            return -1;
        }
        public bool Contains(T item)
        {
            return false;
        }
        public void RemoveAt(int index)
        {

        }
        public bool Remove(T item)
        {
            return false;
        }
        public void Insert(int index,T item)
        {

        }
        public void Clear()
        {

        }
    }
}
