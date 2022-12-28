using System;

namespace Ch03Types.OutRefIn
{
    public static class StaticMethods
    {
        public static int DivideInt(int x, int y, out int remainder)
        {
            remainder = x % y;
            return x / y;
        }

        public static double GetRectArea(Rect rect)
        {
            return rect.Height * rect.Width;
        }
        
        public static double GetInRectArea(in Rect rect)
        {
            return rect.Width * rect.Height;
        }
    }
}