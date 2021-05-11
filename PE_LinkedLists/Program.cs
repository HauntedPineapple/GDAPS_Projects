using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE_LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomLinkedList<string> items = new CustomLinkedList<string>();

            for (int i = 0; i < 5; i++)
            {
                Console.Write("What are you adding to the list?  ");
                items.Add(Console.ReadLine());
            }

            Console.WriteLine("\nHere is your list:");
            for (int i = 0; i < items.Count; i++)
            {
                Console.WriteLine(items[i].Data);
            }

            Console.ReadLine();
        }
    }
}
