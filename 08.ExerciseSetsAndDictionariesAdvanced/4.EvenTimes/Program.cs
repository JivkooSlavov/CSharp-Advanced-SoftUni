﻿namespace _4.EvenTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> numberCounts = new Dictionary<int, int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (!numberCounts.ContainsKey(number))
                {
                    numberCounts.Add(number, 0);
                }
                numberCounts[number]++;
            }
            int result = numberCounts.Single(x => x.Value % 2 == 0).Key;
            Console.WriteLine(result);
        }
    }
}