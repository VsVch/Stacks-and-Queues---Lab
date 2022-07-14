using System;
using System.Collections;
using System.Collections.Generic;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int numCarsPass = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            Queue<string> carsPassed = new Queue<string>();
            int count = 0;
            while (command != "end")
            {
                if (command == "green")
                {
                    //if (carsPassed.Count>= numCarsPass)
                    {
                        for (int i = 0; i < numCarsPass; i++)
                        {

                            if (carsPassed.Count==0)
                            {
                                break;
                            }
                            count++;
                            Console.WriteLine($"{carsPassed.Dequeue()} passed!");
                        }
                        
                    }
                }
                else
                {
                    carsPassed.Enqueue(command);
                }



                command = Console.ReadLine();
            }
            Console.WriteLine($"{count} cars passed the crossroads.");
        }
    }
}
