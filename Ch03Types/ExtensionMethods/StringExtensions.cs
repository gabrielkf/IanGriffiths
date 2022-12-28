using System;

namespace Ch03Types.ExtensionMethods
{
    public static class StringExtensions
    {
        public static string MfAppend(this string s) => $"{s}, MOTHERFUCKER";

        public static int CountDashes(this string s)
        {
            var split = s.Split("-");
            return split.Length - 1;
        }

        //* Checking if class is relevant
        public static int PlusOne(this int n) => n + 1;
    }
}