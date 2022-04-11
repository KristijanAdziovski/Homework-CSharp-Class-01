using System;
using System.Collections.Generic;

namespace Task_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            do
            {
                Console.WriteLine("Enter a name, press x to end");
                string name = Console.ReadLine();
                if (name.ToLower() == "x")
                {
                    break;
                }
                names.Add(name);
            }
            while (true);

            Console.WriteLine("Enter a text");
            string text = Console.ReadLine();

            string[] words = text.Split(' ');
            int counter = 0;

            foreach (string name in names)
            {
                foreach (string word in words)
                {
                    if(word.ToLower() == name.ToLower())
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"{name} number of repeat: {counter}");
                
            }
        }
    }
}
