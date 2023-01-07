using System.Collections;

namespace Ch02BasicCoding.Patterns
{
    public static class TypeMatching
    {
        public static string FindType(object input)
        {
            return input switch
            {
                string { Length: 0 } => "It's an empty string",
                string s => $"It's a string, and it says: {s}",
                int n => $"It's an integer with value: {n}",
                bool b => $"It's a boolean, and it's {b}",
                ICollection _ => "It's a Collection",
                _ => "It's not a string, integer nor boolean"
            };
        }
    }
}