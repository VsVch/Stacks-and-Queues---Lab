using System;
using System.Collections;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            Queue<string> peopleInShop = new Queue<string>(); 
            
            while (name  != "End")
            {
                if (name == "Paid")
                {
                    while (peopleInShop.Count > 0)
                    {
                        Console.WriteLine(peopleInShop.Dequeue());
                    }
                   
                    
                }
                else
                {
                    peopleInShop.Enqueue(name);
                }


                name = Console.ReadLine();
            }
            Console.WriteLine($"{peopleInShop.Count} people remaining.");
        }
    }
}
