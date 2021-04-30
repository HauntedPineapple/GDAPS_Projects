using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_InventorySystem
{
    class Consumable : Item
    {
        public Consumable(string name, ItemCategory type, double weight = 1, string description = "") :
            base(name, type, weight, description)
        {
            category = ItemCategory.Consumable;
        }

        public override void Use()
        {

        }
        public override string ToString()
        {
            string output = base.ToString();
            return output;
        }
    }
}
