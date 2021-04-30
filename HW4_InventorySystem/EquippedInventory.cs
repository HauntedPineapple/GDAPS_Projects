using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_InventorySystem
{
    class EquippedInventory
    {
        private Armor headSlot;
        public Armor Head { get { return headSlot; } }
        private Armor chestSlot;
        public Armor Chest { get { return chestSlot; } }
        private Armor legSlot;
        public Armor Legs { get { return legSlot; } }
        private Armor feetSlot;
        public Armor Feet { get { return feetSlot; } }
        private Weapon melee_weapon;
        public Weapon MeleeWeapon { get { return melee_weapon; } }
        private Weapon ranged_weapon;
        public Weapon RangedWeapon { get { return ranged_weapon; } }
        private Shield shield;
        public Shield Shield { get { return shield; } }


        public EquippedInventory(Armor head = null, Armor chest = null, Armor legs = null, Armor feet = null,
                                 Weapon mWeapon = null, Weapon rWeapon = null, Shield shield = null)
        {
            headSlot = head;
            chestSlot = chest;
            legSlot = legs;
            feetSlot = feet;
            melee_weapon = mWeapon;
            ranged_weapon = rWeapon;
            this.shield = shield;

        }

        public void EquipItem(Item item)
        {
            switch (item.Category)
            {
                case ItemCategory.Armor:
                    Armor armor = item as Armor;
                    if (armor != null)
                    {
                        switch (armor.Slot)
                        {
                            case ArmorSlot.Head:
                                break;

                            case ArmorSlot.Chest:
                                break;

                            case ArmorSlot.Legs:
                                break;

                            case ArmorSlot.Feet:
                                break;
                        }
                    }
                    break;

                case ItemCategory.Shield:
                    Shield s = item as Shield;
                    if (s != null)
                    {
                        shield = s;
                    }
                    break;

                case ItemCategory.Weapon:
                    Weapon weapon = item as Weapon;
                    if (weapon != null)
                    {
                        if (weapon.IsMelee)
                        {
                            melee_weapon = weapon;
                        }
                        else
                        {
                            ranged_weapon = weapon;
                        }
                    }
                    break;

                default:
                    throw new ArgumentException("Cannot equip item of type " + item.Category.ToString());
            }
            Console.WriteLine("");
        }

        public override string ToString()
        {
            string output = "";

            output += "Head: ";
            if (headSlot == null)
            {
                output += "Nothing equipped in this slot\n";
            }
            else
            {
                output += headSlot.Name + "\n";
            }

            output += "Chest: ";
            if (chestSlot == null)
            {
                output += "Nothing equipped in this slot\n";
            }
            else
            {
                output += chestSlot.Name + "\n";
            }

            output += "Legs: ";
            if (legSlot == null)
            {
                output += "Nothing equipped in this slot\n";
            }
            else
            {
                output += legSlot.Name + "\n";
            }

            output += "Feet: ";
            if (feetSlot == null)
            {
                output += "Nothing equipped in this slot\n";
            }
            else
            {
                output += feetSlot.Name + "\n";
            }

            output += "Melee Weapon: ";
            if (melee_weapon == null)
            {
                output += "Nothing equipped in this slot\n";
            }
            else
            {
                output += melee_weapon.Name + "\n";
            }

            output += "Ranged Weapon: ";
            if (ranged_weapon == null)
            {
                output += "Nothing equipped in this slot\n";
            }
            else
            {
                output += ranged_weapon.Name + "\n";
            }

            output += "Shield: ";
            if (shield == null)
            {
                output += "Nothing equipped in this slot\n";
            }
            else
            {
                output += shield.Name + "\n";
            }

            return output;
        }
    }
}
