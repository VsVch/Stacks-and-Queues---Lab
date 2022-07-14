using System;
using System.Collections;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int count = int.Parse(Console.ReadLine());
            Queue<string> namesInGame = new Queue<string>(names);
            int curKid = 1;

            while (namesInGame.Count > 1)
            {
                string kidWithPotato = namesInGame.Dequeue();
                if (curKid != count)
                {
                    curKid++;
                    namesInGame.Enqueue(kidWithPotato);
                }
                else
                {
                    curKid = 1;
                    Console.WriteLine($"Removed {kidWithPotato}");
                }




            }
            Console.WriteLine($"Last is {namesInGame.Dequeue()}");

        }
    }
}
