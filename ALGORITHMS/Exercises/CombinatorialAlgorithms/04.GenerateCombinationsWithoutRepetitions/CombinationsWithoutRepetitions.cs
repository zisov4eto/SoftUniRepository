﻿using System;

namespace _04.GenerateCombinationsWithoutRepetitions
{
    class CombinationsWithoutRepetitions
    {
        static int n;
        static int k;
        static int[] array;

        static void Main()
        {
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            array = new int[k];

            GenerateCombinations(0, 1);
        }

        private static void GenerateCombinations(int index, int start)
        {
            if (index == k)
            {
                Print();
            }
            else
            {
                for (int i = start; i <= n; i++)
                {
                    array[index] = i;
                    GenerateCombinations(index + 1, i + 1);
                }
            }
        }

        private static void Print()
        {
            Console.WriteLine($"({string.Join(", ", array)})");
        }
    }
}