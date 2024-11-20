
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*for(i = 0; 1 < 10; i++)
            {
                Console.WriteLine(i);
            }
            */

            /*
            int i = 0;

            while(i < 10)
            {
                i++;
                Console.WriteLine(i); 
            }
            */

            Console.Write("Enter the first number: ");
            string numberAinput = Console.ReadLine();
            int numberA = Convert.ToInt32(numberAinput);

            Console.Write("Enter the second number: ");
            string numberBinput = Console.ReadLine();
            int numberB = Convert.ToInt32(numberAinput);
            Console.WriteLine();

            int answer = numberA + numberB;
            int actualAnswer = 0;

            Console.WriteLine("Value of " + numberA + " + " + numberB + ": ");
            Console.WriteLine();

            //While example
            //While will check the condition first and then execute the statement
            /*
            while(answer != actualAnswer)
            {
                Console.Write("Enter your answer: ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput);

                if(answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong!"); 
                }
            }
            */
            //Do while example
            //Do while will execute the statement at least once and then check
            do
            {
                Console.Write("Enter your answer:  ");
                string answerInput = Console.ReadLine();
                actualAnswer = Convert.ToInt32(answerInput)
                if(answer != actualAnswer)
                {
                    Console.WriteLine("Close but it was wrong!");
                    Console.WriteLine();

                }
            } while (answer != actualAnswer);

            Console.WriteLine("Well done!");
            Console.ReadLine();
        }
    }
}
