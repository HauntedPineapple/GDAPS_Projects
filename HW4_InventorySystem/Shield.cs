using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_InventorySystem
{
    class Shield : Item
    {
        private double durability;
        public double Durability { get { return durability; } }
        private double defense;
        public double Defense { get { return defense; } }

        public Shield(string name, double durability, double defense, double weight = 1, string description = "") :
            base(name, weight, description)
        {
            category = ItemCategory.Shield;
            this.durability = durability;
            this.defense = defense;
        }

        public override void Use()
        {
            if(durability <= 0)
            {
                Console.WriteLine("Cannot use item!");
                return;
            }
        }

        public override string ToString()
        {
            string output = base.ToString();
            return output;
        }
    }
}
