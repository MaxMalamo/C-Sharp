using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Literal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string speech = "He said \"Something\"";
            // Pathing
            string path = "C:\\Users\\JavascriptCode\\Desktop\\C# Course\nNew Line";

            Console.WriteLine(path);
            Console.WriteLine(speech);
            //  Pathing Version 2
            path = @"C:\Users\admin\Documents\Text" + "\nNew Line";
            Console.WriteLine(path);

            string name = @"Hello ""Someone""";
            Console.WriteLine(name);

            name = "Hello 'someone'";
            Console.WriteLine(name);

            Console.ReadLine();
        }
    }
} 
