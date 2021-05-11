using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_LinkedLists
{
    class CustomLinkedList<T> // : IEnumerable<T>
    {
        private int count;
        private CustomLinkedNode<T> head;
        private CustomLinkedNode<T> tail;

        public int Count { get { return count; } }

        public CustomLinkedList()
        {
            count = 0;
            head = null;
            tail = null;
        }

        public void Add(T data)
        {
            if (count == 0)
            {
                CustomLinkedNode<T> n = new CustomLinkedNode<T>(data);
                head = n;
                tail = n;
            }
            else
            {
                CustomLinkedNode<T> n = new CustomLinkedNode<T>(data);
                tail.Next = n;
                tail = n;
            }

            count++;
        }
        public T GetData(int index)
        {
            return this[index].Data;
        }

        public CustomLinkedNode<T> this[int index]
        {
            get
            {
                if (count == 0)
                {
                    throw new NullReferenceException();
                }
                if (index >= count || index < 0)
                {
                    throw new IndexOutOfRangeException();
                }

                if (index == 0)
                {
                    return head;
                }
                if (index == count - 1)
                {
                    return tail;
                }

                CustomLinkedNode<T> current = head;
                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current;
            }
        }
    }
}
