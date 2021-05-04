using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_CustomDictionary
{
    class CustomPair<TKey, TValue>
    {
        private TKey key;
        private TValue value;

        public TKey Key
        {
            get { return key; }
            set { key = value; }
        }
        public TValue Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public CustomPair(TKey key, TValue value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
