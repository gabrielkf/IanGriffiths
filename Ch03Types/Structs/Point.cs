namespace Ch03Types.Structs
{
    public struct Point
    {
        private readonly double _x;
        private readonly double _y;

        public Point(double x, double y)
        {
            _x = x;
            _y = y;
        }

        public double X => _x;
        public double Y => _y;

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }

        public override bool Equals(object obj)
        {
            return obj is Point p && this.X == p.X && this.Y == p.Y;
        }

        public override int GetHashCode()
        {
            return (_x, _y).GetHashCode();
        }

        public void Deconstruct(out double x, out double y)
        {
            x = _x;
            y = _y;
        }
    }
}