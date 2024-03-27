using System;
using System.Collections.Generic;
using System.Linq;

namespace Count_Same_Values_in_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numbersCount = new();
            double[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse)
                .ToArray();

            for (int i = 0; i < numbers.Length; i++)
            {
                double currentNumber = numbers[i];

                if (!numbersCount.ContainsKey(currentNumber))
                {
                    numbersCount.Add(currentNumber, 0);
                }

                numbersCount[currentNumber]++;
            }

            foreach (KeyValuePair<double, int> numberCount in numbersCount)
            {
                Console.WriteLine($"{numberCount.Key} - {numberCount.Value} times");
            }
        }
    }
}
