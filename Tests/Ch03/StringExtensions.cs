using Ch03Types.ExtensionMethods;
using Xunit;

namespace Tests.Ch03
{
    public class StringExtensions
    {
        [Fact]
        public void MfAppend_ShouldAppendMf()
        {
            var hello = "Hello";
            Assert.Equal("Hello, MOTHERFUCKER", hello.MfAppend());
        }

        [Fact]
        public void CountDashes_ShouldCountDashes()
        {
            var s0 = "hi";
            var s1 = "hi-there";
            var s2 = "hi-there-yall";
            
            Assert.Equal(0, s0.CountDashes());
            Assert.Equal(1, s1.CountDashes());
            Assert.Equal(2, s2.CountDashes());
        }

        [Fact]
        public void PlusOne_ShouldAddOne()
        {
            var n = 1;
            Assert.Equal(2, n.PlusOne());
        }
    }
}