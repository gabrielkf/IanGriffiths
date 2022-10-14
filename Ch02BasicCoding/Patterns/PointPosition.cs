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
                case (_, _):
                    return "Anywhere";
            }
        } 
    }
}