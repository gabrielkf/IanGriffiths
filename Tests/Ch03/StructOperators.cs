using Ch03Types.Structs;
using Xunit;

namespace Tests.Ch03
{
    public class StructOperators
    {
        private Point p1;
        private Point p2;
        private Point p3;
        
        public StructOperators()
        {
            p1 = new Point(6.9, 4.20);
            p2 = new Point(6.9, 4.20);
            p3 = new Point(69.420, 69.420);
        }
        
        [Fact]
        public void SimplePoint_ShouldBeAbleToCompare_Equality()
        {
            Assert.True(p1 == p2);
            Assert.False(p1 == p3);
            Assert.False(p2 == p3);
        }

        [Fact]
        public void SimplePoint_ShouldBeAbleToCompare_Inequality()
        {
            Assert.True(p1 != p3);
            Assert.True(p2 != p3);
            Assert.False(p1 != p2);
        }
    }
}