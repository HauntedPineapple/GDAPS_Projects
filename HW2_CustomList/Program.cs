using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_CustomList
{
    class Program
    {
        static void wrapper()
        {
            bool isUsing = true;
            bool validInput = false;
            int index = 0;
            string userInput = "";

            while (!validInput)
            {
                Console.Write("Please enter the desired size of your list: ");
                userInput = Console.ReadLine();
                if (int.TryParse(userInput, out int size))
                {
                    validInput = true;
                    break;
                }
                Console.WriteLine("ERROR: Invalid input! Please try again!");
            }

            CustomList<string> words = new CustomList<string>(int.Parse(userInput));

            Console.WriteLine("Commands: ");
            Console.WriteLine("- done   - print");
            Console.WriteLine("- indexOf   - contains");
            Console.WriteLine("- removeAt   - remove");
            Console.WriteLine("- insert   - clear");
            Console.WriteLine("- get   - set");
            Console.WriteLine("- count   - size");
            Console.WriteLine("- help");
            Console.WriteLine();

            while (isUsing)
            {
                validInput = false;
                Console.Write("Enter a word or command: ");
                userInput = Console.ReadLine();

                switch (userInput.ToLower())
                {
                    case "done":
                        Console.WriteLine("Goodbye!");
                        isUsing = false;
                        break;

                    case "print":
                        Console.WriteLine("The list contains: ");
                        for (int i = 0; i < words.Count; i++)
                        {

                            Console.WriteLine(words[i]);
                        }
                        break;

                    case "indexof":
                        Console.Write("Please enter the word you wish to find the index of: ");
                        userInput = Console.ReadLine();
                        if (words.Contains(userInput))
                        {
                            Console.WriteLine("The index of " + userInput + " is at " + words.IndexOf(userInput));
                        }
                        else
                        {
                            Console.WriteLine("That word is not in this list");
                        }
                        break;

                    case "contains":
                        Console.Write("Please enter the word to search for: ");
                        userInput = Console.ReadLine();
                        if (words.Contains(userInput))
                        {
                            Console.WriteLine("That word IS in this list");
                        }
                        else
                        {
                            Console.WriteLine("That word is NOT in this list");
                        }
                        break;

                    case "removeat":
                        while (!validInput)
                        {
                            Console.Write("Please enter the index you wish to remove: ");
                            userInput = Console.ReadLine();
                            if (int.TryParse(userInput, out index))
                            {
                                validInput = true;
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Invalid input! Please try again!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        index = int.Parse(userInput);

                        if (words.Count > index || index < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Invalid index");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }
                        else
                        {
                            words.RemoveAt(index);
                            Console.WriteLine("Removed " + userInput + " from the list.");
                        }
                        break;

                    case "remove":
                        Console.Write("Please enter the word you wish to remove: ");
                        userInput = Console.ReadLine();
                        if (words.Contains(userInput))
                        {
                            words.Remove(userInput);
                            Console.WriteLine("Removed " + userInput + " from the list.");
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: The list does not contain the word " + userInput);
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        break;

                    case "insert":
                        Console.Write("Please enter the word you wish to add: ");
                        userInput = Console.ReadLine();

                        string number = "";
                        while (!validInput)
                        {
                            Console.Write("Please enter the index you wish to add your word at: ");
                            number = Console.ReadLine();
                            if (int.TryParse(number, out index))
                            {
                                validInput = true;
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Invalid input! Please try again!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        index = int.Parse(number);

                        Console.WriteLine("Added \"" + userInput + "\" to the list at index " + index + ".");
                        words.Insert(index, userInput);
                        break;

                    case "clear":
                        Console.WriteLine("Cleared list");
                        words.Clear();
                        break;

                    case "get":
                        while (!validInput)
                        {
                            Console.Write("Please enter the index you wish to retrieve: ");
                            userInput = Console.ReadLine();
                            if (int.TryParse(userInput, out index))
                            {
                                validInput = true;
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Invalid input! Please try again!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        index = int.Parse(userInput);

                        if (words.Count > index || index < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Invalid index");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("The word at index " + index + "is " + words[index]);
                        }
                        break;

                    case "set":
                        while (!validInput)
                        {
                            Console.Write("Please enter the index you wish to set: ");
                            userInput = Console.ReadLine();
                            if (int.TryParse(userInput, out index))
                            {
                                validInput = true;
                                break;
                            }
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Invalid input! Please try again!");
                            Console.ForegroundColor = ConsoleColor.Gray;
                        }
                        index = int.Parse(userInput);

                        if (words.Count > index || index < 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("ERROR: Invalid index");
                            Console.ForegroundColor = ConsoleColor.Gray;
                            break;
                        }
                        else
                        {
                            Console.Write("Please enter the word you wish to add: ");
                            userInput = Console.ReadLine();

                            Console.WriteLine("Set the word at index " + index + " to " + userInput);
                        }
                        break;

                    case "help":
                        Console.WriteLine("Commands: ");
                        Console.WriteLine("- done   - print");
                        Console.WriteLine("- indexOf   - contains");
                        Console.WriteLine("- removeAt   - remove");
                        Console.WriteLine("- insert   - clear");
                        Console.WriteLine("- get   - set");
                        Console.WriteLine("- help");
                        break;

                    case "size":
                        Console.WriteLine(words.Capacity.ToString());
                        break;

                    case "count":
                        Console.WriteLine(words.Count.ToString());
                        break;

                    default:
                        words.Add(userInput);
                        Console.WriteLine("Added " + userInput + " to the list.");
                        break;
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            wrapper();

            Console.ReadLine();
        }
    }
}
