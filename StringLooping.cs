using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace StringLooping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = "Testing the code";

            //Char
            Console.WriteLine(message[0]); //T
            Console.WriteLine(message[1]); //e
            Console.WriteLine(message[2]); //s
            Console.WriteLine(message[3]); //t
            Console.WriteLine(message[4]); //i
            Console.WriteLine(message[5]); //n
            Console.WriteLine(message[6]); //g
            Console.WriteLine(message[7]); //
            Console.WriteLine(message[8]); //

            for (int i = 0; i < message.Length; i++) 
            {
                Console.WriteLine(message[i]);
                Thread.Sleep(100);
            }

            Console.WriteLine();

            bool contains = false;

            for(int i = 0; 1 < message.Length; i++)
            {
                if (message[0].Equals('T')) 
                {
                    contains = true;
                }
                /*
                else
                {
                    contains = false;
                }
                */
            }
            Console.WriteLine(contains);
            Console.ReadLine();
        }
    }
}
