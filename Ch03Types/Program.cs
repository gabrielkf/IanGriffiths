using System;
using System.Collections.Generic;
using Ch03Types.Structs;

namespace Ch03Types
{
    class Program
    {
        static void Main(string[] args)
        {
            CompareHashCode();
            PrintText("Chapter 03. Run tests");
        }

        static void PrintText(string? text)
        {
            Console.WriteLine(text ?? "Text is null");
        }

        static void CompareHashCode()
        {
            var arr1 = new int[] { 1, 2 };
            var arr2 = new int[] { 1, 2 };
            // Console.WriteLine(arr1.GetHashCode());
            // Console.WriteLine(arr2.GetHashCode());

            var t1 = (1, 2);
            var t2 = (1, 2);
            Console.WriteLine((uint)t1.GetHashCode());
            Console.WriteLine((uint)t2.GetHashCode());
            
            var dict = new Dictionary<int[], int>
            {
                { new int[] { 1, 2 }, 0 },
                { new int[] { 1, 2 }, 1 }
            };
            foreach (var entry in dict)
            {
                Console.WriteLine(entry.Key.GetHashCode());
            }
        }
    }
}