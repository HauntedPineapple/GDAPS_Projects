using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW4_InventorySystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory myInventory = new Inventory();
            myInventory.PrintInventory();
            Armor boots = new Armor("Iron Boots", ArmorSlot.Feet, 25, 3, 2.5);
            myInventory.Add(boots);
            myInventory.PrintInventory();

            //InvTesting();

            //PlayerTesting();
            Console.ReadLine();
        }

        static public void InvTesting()
        {
            bool isUsing = true;

            Inventory myInventory = new Inventory();
            myInventory.PrintInventory();
            Armor boots = new Armor("Iron Boots", ArmorSlot.Feet, 25, 3, 2.5);
            myInventory.Add(boots);
            myInventory.PrintInventory();

            while (isUsing)
            {
                Console.WriteLine("Controls: Input command or command number to execute");
                Console.WriteLine("0 (exit) - Exit\n1 (exam) - Examine item");
                Console.WriteLine("2 (print) - Show inventory\n3 (use)- Use item");
                Console.WriteLine("4 (rem)- Remove Item\n5 (add) - Add item");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "exit":
                        Console.WriteLine("Goodbye!");
                        isUsing = false;
                        break;
                    case "0":
                        Console.WriteLine("Goodbye!");
                        isUsing = false;
                        break;

                    case "exam":
                        Examine(myInventory);
                        break;
                    case "1":
                        Examine(myInventory);
                        break;

                    case "print":
                        myInventory.PrintInventory();
                        break;
                    case "2":
                        myInventory.PrintInventory();
                        break;

                    case "use":
                        Use(myInventory);
                        break;
                    case "3":
                        Use(myInventory);
                        break;

                    case "rem":
                        Use(myInventory);
                        break;
                    case "4":
                        Use(myInventory);
                        break;

                    case "add":
                        Use(myInventory);
                        break;
                    case "5":
                        Use(myInventory);
                        break;

                    default:
                        Console.WriteLine("Error: Invalid input, please try again");
                        break;
                }
            }
        }

        static public void Examine(Inventory inv)
        {
            Console.Write("Please enter the index of the item you would like to examine: ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                default:
                    Console.WriteLine("Error: Invalid input!");
                    break;
            }
        }
        static public void Use(Inventory inv)
        {
            Console.Write("Please enter the index of the item you would like to use: ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                default:
                    Console.WriteLine("Error: Invalid input!");
                    break;
            }
        }
        static public void Remove(Inventory inv)
        {
            Console.Write("Please enter the index of the item you would like to remove: ");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                default:
                    Console.WriteLine("Error: Invalid input!");
                    break;
            }
        }
        static public void Add(Inventory inv)
        {
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                default:
                    Console.WriteLine("Error: Invalid input!");
                    break;
            }
        }

        static public void PlayerTesting()
        {
            Player myPlayer = new Player("Audrey", CharacterClass.Rogue);
            Console.WriteLine(myPlayer.ToString());
            myPlayer.PrintInventory();
        }

    }
}
