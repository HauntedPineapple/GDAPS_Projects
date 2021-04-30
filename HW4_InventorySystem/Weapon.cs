using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_InventorySystem
{
    class Weapon : Item
    {
        private bool isMelee;
        public bool IsMelee { get { return isMelee; } }
        private double durability;
        public double Durability { get { return durability; } }
        private double damage;
        public double Damage { get { return damage; } }

        public Weapon(string name, bool melee, double durability, double damage, double weight = 1, string description = "") :
            base(name, weight, description)
        {
            category = ItemCategory.Weapon;
            isMelee = melee;
            this.durability = durability;
            this.damage = damage;
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
