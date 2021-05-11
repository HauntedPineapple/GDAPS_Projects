using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_CustomList
{
    class CustomList<T>
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

        public CustomList() : this(4) { }
        public CustomList(int size)
        {
            array = new T[size];
            count = 0;
        }

        public void Add(T item)
        {
            if (count == Capacity)
            {
                T[] oldArray = array;
                array = new T[Capacity * 2];
                for (int i = 0; i < oldArray.Length; i++)
                {
                    array[i] = oldArray[i];
                }
            }
            array[count] = item;
            count++;
        }

        public int IndexOf(T item)
        {
            if (!Contains(item))
            {
                return -1;
            }

            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return i;
                }
            }

            return -1;
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < count; i++)
            {
                if (array[i].Equals(item))
                {
                    return true;
                }
            }
            return false;
        }

        public void RemoveAt(int index)
        {
            if (index >= count || index < 0)
            {
                return;
            }

            T[] values = new T[Capacity - index - 1];
            int temp = 0;
            for (int i = index + 1; i < count; i++)
            {
                values[temp] = array[i];
                temp++;
            }

            count--;
        }

        public bool Remove(T item)
        {
            if (!Contains(item))
            {
                return false;
            }

            int index = IndexOf(item);
            RemoveAt(index);

            return true;
        }

        public void Insert(int index, T item)
        {
            if (index < 0)
            {
                return;
            }
            if (index >= count)
            {
                Add(item);
                return;
            }
            if (count + 1 == Capacity)
            {
                T[] oldArray = array;
                array = new T[Capacity * 2];
                for (int i = 0; i < oldArray.Length; i++)
                {
                    array[i] = oldArray[i];
                }
            }

            for (int i = count + 1; i > index; i--)
            {
                array[i] = array[i - 1]; // move values over to next spot in array
            }

            array[index] = item;

            count++;
        }

        public void Clear()
        {
            count = 0;
        }
    }
}
