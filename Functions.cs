using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions // Defines the namespace for the program
{

    class test // Class names test containing a static method
    {
        public static void something() // Static method called "Something" that prints a blank line to teh console
        {
            Console.WriteLine("Test");
            Console.WriteLine();
        }
    }
    
    internal class Program // Main Program
    {
        
        static void Main(string[] args) // The start point of the program
        {
            // Calls the static method "something" from the test class
            test.something();

            WelcomeMessage();

            // Keeps console open until next press
            Console.ReadLine();
        }

        // Static method that prints a welcome message to the console
        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome let's code some C#");
        }
    }
}
