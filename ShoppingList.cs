using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Introduction
            Console.WriteLine("This is a shopping list.");
            Console.WriteLine("You can print out the list at any moment by typing 'print'.");
            Console.WriteLine("Type 'exit' to quit the program.");

            List<string> shoppingList = new List<string>();

            // Loop
            while (true) 
            {
                Console.Write("Enter an item you would like to add to your shopping list: ");
                string input = Console.ReadLine();

                if (input.ToLower() == "print")
                {
                    Console.WriteLine("\nYour Shopping List:");
                    if (shoppingList.Count == 0)
                    {
                        Console.WriteLine("The list is empty.");
                    }
                    else
                    {
                        foreach (string item in shoppingList)
                        {
                            Console.WriteLine($"- {item}");
                        }
                    }
                    Console.WriteLine();
                }
                else if (input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;
                }
                else
                {
                    shoppingList.Add(input);
                    Console.WriteLine($"Added \"{input}\" to your shopping list.");
                }
            }
        }
    }
}
