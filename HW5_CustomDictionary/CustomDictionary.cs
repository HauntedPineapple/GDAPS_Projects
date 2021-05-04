using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_CustomDictionary
{
    class CustomDictionary<TKey, TValue>
    {
        private CustomPair<TKey, TValue>[] pairs;
        private int count;

        public int Count { get { return count; } }
        public TValue this[TKey key]
        {
            get
            {
                return default(TValue);
            }

            set
            {

            }
        }

        public CustomDictionary(int size)
        {
            pairs = new CustomPair<TKey, TValue>[size];
        }
        public CustomDictionary() : this(100) { }

        public bool ContainsKey(TKey key)
        {
            return false;
        }
        public void Add(TKey key, TValue value)
        {

        }
        public bool Remove(TKey key)
        {
            return false;
        }
        public void Clear()
        {
            for (int i = 0; i < count; i++)
            {
                pairs[i].Key = default(TKey);
                pairs[i].Value = default(TValue);
            }
            count = 0;
        }
    }
}
