﻿using System;

namespace _07.ConcatNames
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            //Console.WriteLine($"{firstName}{delimiter}{secondName}");

            string result = firstName + delimiter + secondName;
            Console.WriteLine(result);
        }
    }
}