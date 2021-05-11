using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_LinkedLists
{
    class CustomLinkedNode<T>
    {
        private T data;
        private CustomLinkedNode<T> next;

        public T Data { get { return data; } set { data = value; } }
        public CustomLinkedNode<T> Next { get { return next; } set { next = value; } }

        public CustomLinkedNode(T data)
        {
            this.data = data;
        }
    }
}
