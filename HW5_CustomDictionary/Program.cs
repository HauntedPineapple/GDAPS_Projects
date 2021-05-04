using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5_CustomDictionary
{
    class Program
    {
        static int ValidateIntInput(string message)
        {
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(message);
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int number))
                {
                    return number;
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR: Invalid input! Please try again!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            bool isUsing = true;
            bool validInput = false;
            string userInput = "";

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Chester", "Dog");
            dictionary.Add("Mei Mei", "Cat");
            dictionary.Add("Poppy", "Rat");
            dictionary.Add("Cheyenne", "Horse");
            dictionary.Add("Georgie", "Snake");
            dictionary.Add("Gonzo", "Bird");


            while (isUsing)
            {
                validInput = false;
                Console.WriteLine("Commands: ");
                Console.WriteLine("- Count   - Add   - Remove   - Get");
                Console.WriteLine("- Set   - Clear   - Print   - ContainsKey");
                Console.WriteLine("- ContainsValue   - Clear   - Print   - Quit");
                Console.Write("Enter a command: ");
                userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "quit":
                        Console.WriteLine("Goodbye!");
                        isUsing = false;
                        break;

                    case "print":
                        Console.WriteLine("Dictionary Contents: ");
                        foreach (var item in dictionary)
                        {
                            Console.Write("Key: " + item.Key + " Value: " + item.Value + "\n");
                        }
                        break;

                    case "count":
                        Console.WriteLine("");
                        break;

                    case "add":
                        Console.Write("Please enter the word you wish to add: ");
                        userInput = Console.ReadLine();
                        break;

                    case "remove":
                        Console.Write("Please enter the word you wish to remove: ");
                        userInput = Console.ReadLine();

                        if (dictionary.ContainsKey(userInput))
                        {
                            dictionary.Remove(userInput);
                            Console.WriteLine("Removed " + userInput + " from the list.");
                        }
                        //else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: The list does not contain the word " + userInput);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "clear":
                        Console.WriteLine("Cleared Dictionary");
                        dictionary.Clear();
                        break;

                    case "get":
                        Console.WriteLine("");
                        break;

                    case "set":
                        Console.WriteLine("");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Command not recognized!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
