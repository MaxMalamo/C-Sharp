using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Loop Example 
            /*
            for(int i = 0; i < 6;  i++)
            {
                Console.WriteLine(i);
            }
            for(int i = 1; i <= 10; i +=2)
            {
                Console.WriteLine(i);
            }
            */
            //Loop Example 2
            /*
            Console.Write("How many times do you want to loop? ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());
            if (loopCounter > 0)
            {
                Console.WriteLine("Sorry, Please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine("Loop: " + i);
                }
            }
            */
            Console.Write("How do you want to repeat? ");
            string message = Console.ReadLine();

            Console.Write("How many times do you want to repeat the message? ");
            int loopCounter = Convert.ToInt32(Console.ReadLine());

            if (loopCounter <= 0)
            {
                Console.WriteLine("Sorry, Please enter a value above 0");
            }
            else
            {
                for (int i = 0; i < loopCounter; i++)
                {
                    Console.WriteLine(message);
                }
            }
            Console.ReadLine();
        }
    }
}
