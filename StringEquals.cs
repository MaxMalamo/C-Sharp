using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringEquals
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pass = "123456";
            string compare = "123456";

            //Example 1
            /*
            if(pass == compare)
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Diff");
            }
            Console.ReadLine();
            */

            //Example 2
            /*
            if (pass.Equals(compare))
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Diff");
            }
            */

            //Example 3
            /*
            Console.Write("enter your name: ");
            string name = Console.ReadLine();

            if(!name.Equals("")) 
            {
                Console.WriteLine("Your name is " + name);
            }
            else
            {
                Console.WriteLine("Invalid name input");
            }
            */

            //Compare example
            string pass2 = "hello";
            char[] chars = new char[] {'h', 'e', 'l', 'o' };
            object newCompare = new string(chars);

            if (pass2.Equals(newCompare))
                Console.WriteLine("Same");
            else
                Console.WriteLine("Different");


            Console.ReadLine();
        }
    }
}
