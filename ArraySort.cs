using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySort
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Sort Array numbers
            int[] numbers = { 10, 2, 30, 46, 5, 6, 78, 800, 9 };

            Array.Sort(numbers);

            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();


        }
    }
}
