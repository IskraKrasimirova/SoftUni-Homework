﻿using System;
using System.Linq;

namespace _05.TopIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < arr.Length - 1; i++)
            {
                bool isBigger = true;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] <= arr[j])
                    {
                        isBigger = false;
                        
                    }
                }
                if (isBigger)
                {
                    Console.Write($"{arr[i]} ");
                }
            }
            Console.WriteLine(arr[arr.Length-1]);
        }
    }
}
