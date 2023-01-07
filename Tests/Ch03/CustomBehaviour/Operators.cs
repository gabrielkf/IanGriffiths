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
        public void Counter_ShouldAddAndSubtractCounters_ToNewCounter()
        {
            var c = _a + _b;
            var d = _a - _b;

            Assert.Equal(4, c.GetNextValue());
            Assert.Equal(2, d.GetNextValue());
        }

        [Fact]
        public void Counter_ShouldCompare_EqualAndDifferent()
        {
            var c = _a - _b;
            c.GetNextValue();
            Assert.True(_a != _b);
            Assert.False(_a == _b);
            Assert.True(_a == c);
        }
    }
}