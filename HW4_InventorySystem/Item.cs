using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_InventorySystem
{
    public enum ItemCategory
    {
        Weapon,
        Armor,
        Shield,
        Consumable
    }

    abstract class Item
    {
        protected string name;
        public string Name { get { return name; } }
        protected double weight;
        public double Weight { get { return weight; } }
        protected string description;
        public string Description { get { return description; } }
        protected ItemCategory category;
        public ItemCategory Category { get { return category; } }

        #region Constructors
        public Item(string name, double weight = 1, string description = "")
        {
            this.name = name;
            this.weight = weight;
            this.description = description;
        }

        public Item(string name, ItemCategory type, double weight = 1, string description = "")
        {
            this.name = name;
            category = type;
            this.weight = weight;
            this.description = description;
        }
        #endregion

        public abstract void Use();
        public override string ToString()
        {
            string output = "Name: " + name + "\tItem Category: " + category.ToString();
            output += "\nWeight: " + weight;
            output += "\n" + description;
            return output;
        }
    }
}
