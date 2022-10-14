using System;

namespace Ch03Types
{
    class Program
    {
        static void Main(string[] args)
        {
            var text = "args.ToString()";
            PrintText(text);
        }

        static void PrintText(string? text)
        {
            Console.WriteLine(text ?? "Text is null");
        }
    }
}