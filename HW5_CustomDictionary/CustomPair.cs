using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_CustomDictionary
{
    class CustomPair<keyType, valueType>
    {
        private keyType key;
        private valueType value;

        public keyType Key
        {
            get { return key; }
            set { key = value; }
        }
        public valueType Value
        {
            get { return value; }
            set { this.value = value; }
        }

        public CustomPair(keyType key, valueType value)
        {
            this.key = key;
            this.value = value;
        }
    }
}
