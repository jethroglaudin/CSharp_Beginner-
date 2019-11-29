﻿using System;

namespace Arrays_Lists
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 3, 5, 9, 2, 14, 6 };
            Console.WriteLine("Array: " + numbers);

            // Length
            Console.WriteLine("Length: " + numbers.Length);

            // IndexOf
            var index = Array.IndexOf(numbers, 9);
            Console.WriteLine("Index of 9: " + index);

            // Clear()
            Array.Clear(numbers, 0, 2);


            Console.WriteLine("Effect of Clear()");
            foreach (var n in numbers)
                Console.WriteLine(n);

            // Copy()
            int[] another = new int[3];
            Array.Copy(numbers, another, 3);

            Console.WriteLine("Effect of Copy");
            foreach(var n in another)
                Console.WriteLine(n);
        }
    }
}
