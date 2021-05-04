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
            DefaultTest();
            //CustomTest();

            Console.ReadLine();
        }

        static void DefaultTest()
        {
            bool isUsing = true;
            bool validInput = false;
            string userInput, newKey, newValue;

            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Chester", "Dog");
            dictionary.Add("Mei Mei", "Cat");
            dictionary.Add("Poppy", "Rat");
            dictionary["Cheyenne"] = "Horse";
            dictionary["Georgie"] = "Snake";
            dictionary["Gonzo"] = "Bird";

            Console.WriteLine("Commands: ");
            Console.WriteLine("- Count   - Add   - Remove   - Get");
            Console.WriteLine("- Set   - Clear   - Print");
            Console.WriteLine("- Help   - Quit");

            while (isUsing)
            {
                validInput = false;

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
                            Console.Write("Key: " + item.Key + "\tValue: " + item.Value + "\n");
                        }
                        break;

                    case "count":
                        Console.WriteLine(dictionary.Count);
                        break;

                    case "add":
                        Console.Write("Please enter the new key: ");
                        newKey = Console.ReadLine();

                        if (dictionary.ContainsKey(newKey))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: The dictionary already contains the key " + newKey);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }

                        Console.Write("Please enter the new value: ");
                        newValue = Console.ReadLine();
                        try
                        {
                            dictionary.Add(newKey, newValue);
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: " + e.Message);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "remove":
                        Console.Write("Please enter the key of the entry you wish to remove: ");
                        userInput = Console.ReadLine();

                        if (dictionary.ContainsKey(userInput))
                        {
                            dictionary.Remove(userInput);
                            Console.WriteLine("Removed " + userInput + " from the list.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: The dictionary does not contain the key " + userInput);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "clear":
                        Console.WriteLine("Cleared Dictionary");
                        dictionary.Clear();
                        break;

                    case "get":
                        Console.Write("Please enter the key you wish to retrieve: ");
                        userInput = Console.ReadLine();
                        if (dictionary.ContainsKey(userInput))
                        {
                            Console.WriteLine("Value is: " + dictionary[userInput]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: The dictionary does not contain the key " + userInput);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "set":
                        Console.Write("Please enter the key: ");
                        userInput = Console.ReadLine();

                        Console.Write("Please enter the new value: ");
                        newValue = Console.ReadLine();

                        try
                        {
                            dictionary[userInput] = newValue;
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: " + e.Message);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "help":
                        Console.WriteLine("Commands: ");
                        Console.WriteLine("- Count   - Add   - Remove   - Get");
                        Console.WriteLine("- Set   - Clear   - Print   - ContainsKey");
                        Console.WriteLine("- ContainsValue   - Help   - Quit");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Command not recognized!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
                Console.WriteLine();
            }
        }

        static void CustomTest()
        {
            bool isUsing = true;
            bool validInput = false;
            string userInput, newKey, newValue;

            CustomDictionary<string, string> dictionary = new CustomDictionary<string, string>();
            dictionary.Add("Chester", "Dog");
            dictionary.Add("Mei Mei", "Cat");
            dictionary.Add("Poppy", "Rat");
            dictionary["Cheyenne"] = "Horse";
            dictionary["Georgie"] = "Snake";
            dictionary["Gonzo"] = "Bird";

            Console.WriteLine("Commands: ");
            Console.WriteLine("- Count   - Add   - Remove   - Get");
            Console.WriteLine("- Set   - Clear   - Print");
            Console.WriteLine("- Help   - Quit");

            while (isUsing)
            {
                validInput = false;

                Console.Write("Enter a command: ");
                userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "quit":
                        Console.WriteLine("Goodbye!");
                        isUsing = false;
                        break;

                    case "print":
                        //Console.WriteLine("Dictionary Contents: ");
                        //foreach (var item in dictionary)
                        //{
                        //    Console.Write("Key: " + item.Key + "\tValue: " + item.Value + "\n");
                        //}
                        break;

                    case "count":
                        Console.WriteLine(dictionary.Count);
                        break;

                    case "add":
                        Console.Write("Please enter the new key: ");
                        newKey = Console.ReadLine();

                        if (dictionary.ContainsKey(newKey))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: The dictionary already contains the key " + newKey);
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }

                        Console.Write("Please enter the new value: ");
                        newValue = Console.ReadLine();
                        try
                        {
                            dictionary.Add(newKey, newValue);
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: " + e.Message);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "remove":
                        Console.Write("Please enter the key of the entry you wish to remove: ");
                        userInput = Console.ReadLine();

                        if (dictionary.ContainsKey(userInput))
                        {
                            dictionary.Remove(userInput);
                            Console.WriteLine("Removed " + userInput + " from the list.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: The dictionary does not contain the key " + userInput);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "clear":
                        Console.WriteLine("Cleared Dictionary");
                        dictionary.Clear();
                        break;

                    case "get":
                        Console.Write("Please enter the key you wish to retrieve: ");
                        userInput = Console.ReadLine();
                        if (dictionary.ContainsKey(userInput))
                        {
                            Console.WriteLine("Value is: " + dictionary[userInput]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: The dictionary does not contain the key " + userInput);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "set":
                        Console.Write("Please enter the key: ");
                        userInput = Console.ReadLine();

                        Console.Write("Please enter the new value: ");
                        newValue = Console.ReadLine();

                        try
                        {
                            dictionary[userInput] = newValue;
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: " + e.Message);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "help":
                        Console.WriteLine("Commands: ");
                        Console.WriteLine("- Count   - Add   - Remove   - Get");
                        Console.WriteLine("- Set   - Clear   - Print   - ContainsKey");
                        Console.WriteLine("- ContainsValue   - Help   - Quit");
                        break;

                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("ERROR: Command not recognized!");
                        Console.ForegroundColor = ConsoleColor.Gray;
                        break;
                }
                Console.WriteLine();
            }
        }

    }
}

