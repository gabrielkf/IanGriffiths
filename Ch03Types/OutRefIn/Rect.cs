using System;

namespace Ch03Types.OutRefIn
{
    public readonly struct Rect
    {
        public double X { get; }
        public double Y { get; }
        public double Width { get; }
        public double Height { get; }
        
        
        public Rect(double x, double y, double width, double height)
        {
            X = x;
            Y = y;
            Width = width;
            Height = height;
        }
    }
}