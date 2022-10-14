using System.Runtime.InteropServices.ComTypes;

namespace Ch02BasicCoding.Patterns
{
    public static class PointPosition
    {
        public static string GetDescription((float x, float y) point)
        {
            switch (point)
            {
                case (0, 0):
                    return "Origin";
                case (_, 0):
                    return "X axis";
                case(0,_):
                    return "Y axis";
                case var (x, y) when x > 0 && y > 0:
                    return "On the 1st quadrant";
                case var (x, y) when x < 0 && y > 0:
                    return "On the 2nd quadrant";
                case var (x, y) when x < 0 && y < 0:
                    return "On the 3rd quadrant";
                case var (x, y) when x > 0 && y < 0:
                    return "On the 4th quadrant";
            }
            return "Anywhere";
        } 
    }
}