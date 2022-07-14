using System;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Reverse().ToArray();
            Stack<string> calc = new Stack<string>();
            for (int i = 0; i < input.Length; i++)
            {
                calc.Push(input[i]);
            }
            while (calc.Count >1)
            {
                int first = int.Parse(calc.Pop());
                string mathSigh = calc.Pop();
                int second = int.Parse(calc.Pop());

                int sum = 0;
                if (mathSigh == "+")
                {
                    sum = first + second;
                }
                else if (mathSigh == "-")
                {
                    sum = first - second;
                }

                calc.Push(sum.ToString());
            }

            Console.WriteLine(calc.Pop());

        }
    }
}
