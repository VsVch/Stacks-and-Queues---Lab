using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            Queue<int> evenNum = new Queue<int>();
            List<int> evenNumbers = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                evenNum.Enqueue(numbers[i]);
            }
            while (evenNum.Count > 0)
            {
                int curNum = evenNum.Peek();
                if (curNum % 2 == 0)
                {
                    evenNumbers.Add(curNum);
                }


                evenNum.Dequeue();
            }
            Console.WriteLine(string.Join(", ", evenNumbers));
        }
    }
}
