using System.Data;

namespace Ch03Types.Indexers
{
    public class Indexed
    {
        private int th = 5;
        private string s1 = "foo";
        private string s2 = "bar";
        
        public string this[int index] => index <= th ? s1 : s2;

        public int this[string a, string b]
        {
            set
            {
                th = value;
                s1 = a;
                s2 = b;
            }
        }
    }
}