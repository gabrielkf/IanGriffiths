namespace Ch03Types.ExtensionMethods
{
    public class Counter
    {
        private int _count;

        public Counter(int initialCount = 0)
        {
            _count = initialCount;
        }

        public int GetNextValue()
        {
            _count++;
            return _count;
        }

        public static Counter operator +(Counter x, Counter y) =>
            new Counter() { _count = x._count + y._count };

        public static Counter operator -(Counter x, Counter y) =>
            new Counter() { _count = x._count - y._count };

        public static bool operator ==(Counter x, Counter y) => x._count == y._count;

        public static bool operator !=(Counter x, Counter y) => x._count != y._count;

        public static bool operator >(Counter x, Counter y) => x._count > y._count;

        public static bool operator <(Counter x, Counter y) => x._count < y._count;
        
        public static bool operator >=(Counter x, Counter y) => x._count >= y._count;

        public static bool operator <=(Counter x, Counter y) => x._count <= y._count;

        public static explicit operator int(Counter c) => c._count;

        public static explicit operator bool(Counter c) => c._count > 0;

        public static explicit operator Counter(int value) => new Counter { _count = value };
    }
}