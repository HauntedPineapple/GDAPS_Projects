using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_InventorySystem
{
    class Inventory
    {
        public int Count { get { return items.Count; } }
        private List<Item> items;
        public List<Item> Items { get { return items; } }

        public Inventory()
        {
            items = new List<Item>();
        }

        public void Add(Item item)
        {
            items.Add(item);
            Console.WriteLine("Added " + item.Name + " to inventory");
        }
        public Item RemoveRandomItem()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("ERROR: No items in the current inventory!");
            }
            Random rng = new Random();
            int randomNum = rng.Next(items.Count);
            Console.WriteLine("Removed " + items[randomNum] + " from inventory");
            items.RemoveAt(randomNum);
            return null;
        }
        public Item RemoveRandomItem(ItemCategory category)
        {
            return null;
        }

        public Item this[int index]
        {
            get
            {
                if (items.Count == 0)
                {
                    throw new InvalidOperationException("ERROR: No items in the current inventory!");
                }
                if (index < 0 || index > items.Count)
                {
                    throw new ArgumentException("ERROR: Invalid inventory index!");
                }
                return items[index];
            }
        }

        public void RemoveItem(int index)
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("ERROR: No items in the current inventory!");
            }
            items.RemoveAt(index);
        }
        public double TotalWeight()
        {
            double total = 0;
            for (int i = 0; i < items.Count; i++)
            {
                total += items[i].Weight;
            }
            return total;
        }
        public void PrintInventory()
        {
            Console.WriteLine("Inventory contains: ");
            Console.WriteLine(this.ToString());
        }

        public override string ToString()
        {
            string output = "";
            if (items.Count == 0)
            {
                output = " No items";
                return output;
            }

            for (int i = 0; i < items.Count; i++)
            {
                output += " " + (i + 1) + ") ";
                output += items[i].Name + "\n";
            }
            return output;
        }
    }
}