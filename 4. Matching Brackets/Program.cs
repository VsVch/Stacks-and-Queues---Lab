using System;
using System.Collections;
using System.Collections.Generic;

namespace _4._Matching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> index = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    index.Push(i);

                }
                if (expression [i] == ')')
                {
                    int endIndex = index.Pop();
                    Console.WriteLine(expression.Substring(endIndex, i - endIndex + 1));
                }
            }



        }
    }
}
