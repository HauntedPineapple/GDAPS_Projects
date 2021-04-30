using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_InventorySystem
{
    public enum ArmorSlot
    {
        Head, Chest, Legs, Feet
    }
    class Armor : Item
    {
        private double durability;
        public double Durability { get { return durability; } }
        private double defense;
        public double Defense { get { return defense; } }
        private ArmorSlot slot;
        public ArmorSlot Slot { get { return slot; } }

        public Armor(string name, ArmorSlot slot, double durability, double defense, double weight = 1, string description = "") :
            base(name, weight, description)
        {
            category = ItemCategory.Armor;
            this.slot = slot;
            this.durability = durability;
            this.defense = defense;
        }

        public override void Use()
        {
            if (durability <= 0)
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
