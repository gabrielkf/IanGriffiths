using Ch02BasicCoding.Patterns;
using Xunit;

namespace Tests.Ch02
{
    public class PointPositionTest
    {
        [Fact]
        public void GetDescription_ShouldIndicateOrigin()
        {
            (float, float) point = (0, 0);
            var result = PointPosition.GetDescription(point);
            Assert.Equal("Origin", result);
        }
        
        [Fact]
        public void GetDescription_ShouldIndicateYAxis()
        {
            (float, float) point = (0, 22);
            var result = PointPosition.GetDescription(point);
            Assert.Equal("Y axis", result);
        }
        
        [Fact]
        public void GetDescription_ShouldIndicateXAxis()
        {
            (float, float) point = (22, 0);
            var result = PointPosition.GetDescription(point);
            Assert.Equal("X axis", result);
        }

        [Fact]
        public void GetDescription_ShouldAppointQuadrant()
        {
            (float, float) point = (22, 22);
            var result = PointPosition.GetDescription(point);
            Assert.Equal("On the 1st quadrant", result);

            point = (-22, 22);
            result = PointPosition.GetDescription(point);
            Assert.Equal("On the 2nd quadrant", result);

            point = (-22, -22);
            result = PointPosition.GetDescription(point);
            Assert.Equal("On the 3rd quadrant", result);

            point = (22, -22);
            result = PointPosition.GetDescription(point);
            Assert.Equal("On the 4th quadrant", result);
        }
    }
}