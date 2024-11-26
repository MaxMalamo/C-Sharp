using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 50;
            int num3 = 500;


            //Example Hard coded
            /*
            numbers[0] = 1;
            numbers[1] = 2;
            numbers[1] = 2;
            numbers[2] = 3;
            */
            /*
            Console.Write("Enter a number: ");
            numbers[0] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a second number: ");
            numbers[1] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a third number: ");
            numbers[2] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a fourth number: ");
            numbers[3] = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter a fifth number: ");
            numbers[4] = Convert.ToInt32(Console.ReadLine()); 
            */

            //Console.WriteLine($"{num1}, {num2}, {num3}");
            //Console.WriteLine($"{numbers[0]}, {numbers[1]}, {numbers[2]}");

            // Example 2 Loop Array Length

            // Example 2 Loop Array length
            int[] numbers = new int[5];

            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write("Enter a number: ");
                numbers[x] = Convert.ToInt32(Console.ReadLine());
            }

            //Loop the length
            for (int y = 0; y < numbers.Length; y++)
            {
                Console.Write($"{numbers[y]} ");
            }

            Console.WriteLine();

            // For Each
            foreach (int num in numbers)
            {
                Console.WriteLine($"{num} ");
            }



            Console.ReadLine();

        }
    }
}
 