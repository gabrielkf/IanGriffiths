using Ch03Types.ExtensionMethods;
using Xunit;

namespace Tests.Ch03
{
    public class Operators
    {
        private readonly Counter _a;
        private readonly Counter _b;

        public Operators()
        {
            _a = new Counter(2);
            _b = new Counter(1);  
        }
        
        [Fact]
        public void Counter_ShouldSumCounters_ToNewCounter()
        {
            var c = _a + _b;
            Assert.Equal(4, c.GetNextValue());
        }
        
        [Fact]
        public void Counter_ShouldSubtractCounters_ToNewCounter()
        {
            var c = _a - _b;
            Assert.Equal(2, c.GetNextValue());
        }
    }
}