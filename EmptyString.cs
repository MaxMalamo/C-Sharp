using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            // if name input is not empty do this
            if(name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}");
            }
            // If name input is empty do this
            else
            {
                Console.WriteLine("Name is empty");
            }
            Console.ReadLine();

        }
    }
}
