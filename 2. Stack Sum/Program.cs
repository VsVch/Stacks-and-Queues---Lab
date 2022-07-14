using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> stack = new Stack<int>(numbers);
            int sum = 0;
            string command = Console.ReadLine().ToLower();
            while (command != "end")
            {
                string commandArray = command.Split()[0];
                if (commandArray == "add")
                {
                    int first = int.Parse(command.Split()[1]);
                    int second = int.Parse(command.Split()[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                if (commandArray == "remove")
                {
                    int count = int.Parse(command.Split()[1]);
                    if (count <= stack.Count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }

                    }

                }


                command = Console.ReadLine().ToLower();
            }

            while (stack.Count > 0)
            {
                sum += stack.Pop();
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
