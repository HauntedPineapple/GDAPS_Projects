using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_InventorySystem
{
    public enum CharacterClass
    {
        Rogue,
        Warrior,
        Ranger,
        Barbarian
    }
    class Player
    {
        #region Members
        private bool isAlive;
        private string name;
        private CharacterClass playerClass;
        private int level;
        private double hp;
        private double stamina;
        private double equipLoad;
        private Inventory playerInventory;
        private EquippedInventory equipped;
        #endregion

        #region Properties
        public bool IsAlive { get { return isAlive; } }
        public string Name { get { return name; } }
        public CharacterClass PlayerClass { get { return playerClass; } }
        public int Level { get { return level; } }
        public double HP { get { return hp; } }
        public double Stamina { get { return stamina; } }
        public double EquipLoad { get { return equipLoad; } }
        public Inventory PlayerInventory { get { return playerInventory; } }
        public EquippedInventory Equipped { get { return equipped; } }

        public double Defense
        {
            get
            {
                double sum = 0;
                if (equipped.Head != null)
                {
                    sum += equipped.Head.Defense;
                }
                if (equipped.Chest != null)
                {
                    sum += equipped.Chest.Defense;
                }
                if (equipped.Legs != null)
                {
                    sum += equipped.Legs.Defense;
                }
                if (equipped.Feet != null)
                {
                    sum += equipped.Feet.Defense;
                }
                return sum;
            }
        }
        #endregion

        #region Constructors
        public Player(string name, CharacterClass pClass, int level = 10, double hp = 100, double stamina = 50, double equipLoad = 75, Inventory playerInv = null, EquippedInventory equipment = null)
        {
            isAlive = true;
            this.name = name;
            playerClass = pClass;
            this.level = level;
            this.hp = hp;
            this.stamina = stamina;
            this.equipLoad = equipLoad;

            if (playerInv == null)
            {
                playerInventory = new Inventory();
            }
            else
            {
                playerInventory = playerInv;
            }

            if (equipment == null)
            {
                equipped = new EquippedInventory();
            }
            else
            {
                equipped = equipment;
            }
        }
        #endregion

        #region Methods
        public void GiveItem(Item item)
        {
            if (playerInventory.TotalWeight() >= equipLoad
                || playerInventory.TotalWeight() + item.Weight >= equipLoad)
            {
                Console.WriteLine("Cannot add item to inventory");
            }
            else
            {
                playerInventory.Add(item);
            }
        }
        public void EquipItem(Item item)
        {
            equipped.EquipItem(item);
        }
        public void PrintInventory()
        {
            string output = name + "'s inventory: \n";
            output += playerInventory.ToString();
            output = "\nEquipped Items: ";
            output += equipped.ToString();
            Console.WriteLine(output);
        }
        public void TakeDamge(double damage)
        {
            /// Possible damage equations:
            ///damage = damage * (1 - (0.06 * Defense) / (1 + 0.06 * Defense));
            ///damage = damage * (0.052 * Defense) / (0.9 + 0.048 * Defense);
            ///damage = damage - (100 / 100 + Defense);

            damage = damage * (1 - (0.06 * Defense) / (1 + 0.06 * Defense));
            hp -= damage;
            if (hp <= 0)
            {
                hp = 0;
                isAlive = false;
            }
        }
        public override string ToString()
        {
            string output = name;
            output += "\nLevel: " + level + "  " + playerClass.ToString() + "";
            output += "\nHP: " + Math.Round(hp,2) + "  Stamina: " + Math.Round(stamina,2);
            return output;
        }
        #endregion
    }
}
