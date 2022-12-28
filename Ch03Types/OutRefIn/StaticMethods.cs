namespace Ch03Types.OutRefIn
{
    public static class StaticMethods
    {
        public static int DivideInt(int x, int y, out int remainder)
        {
            remainder = x % y;
            return x / y;
        }
    }
}