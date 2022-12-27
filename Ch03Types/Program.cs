using System;

namespace Ch03Types
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintText("Chapter 03. Run tests");
        }

        static void PrintText(string? text)
        {
            Console.WriteLine(text ?? "Text is null");
        }
    }
}