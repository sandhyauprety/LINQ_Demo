// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Linq;



namespace LINQ_Demo
{
    class program
    {
        static void Main(string[] args)
        {
            //int[] age = { 34, 45, 24, 10, 67, 3, 12, 18 };
            //var a = from i in age where i > 18 orderby i select i;

            string[] name = { "sandhyakumari", "sajal", "saloja", "bishal", "pravat" };
            var a = from names in name where names.Length >8 select names;

            foreach (string item in a)

            {
                Console.WriteLine(item);

            }
            Console.ReadLine();

        }
    }
}
