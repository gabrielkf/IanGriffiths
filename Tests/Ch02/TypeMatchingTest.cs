using Ch02BasicCoding.Patterns;
using Xunit;

namespace Tests.Ch02
{
    public class TypeMatchingTest
    {
        [Fact]
        public void FindType_ShouldIdentifyInteger()
        {
            int number = 22;
            var result = TypeMatching.FindType(number);
            Assert.Equal($"It's an integer with value: {number}", result);
        }
        
        [Fact]
        public void FindType_ShouldIdentifyString()
        {
            string text = "Houston, we got no problem";
            var result = TypeMatching.FindType(text);
            Assert.Equal($"It's a string, and it says: {text}", result);
        }
        
        [Fact]
        public void FindType_ShouldIdentifyBoolean()
        {
            bool boolean = false;
            var result = TypeMatching.FindType(boolean);
            Assert.Equal($"It's a boolean, and it's {boolean}", result);
        }

        [Fact]
        public void FindType_ShouldReturnOtherType()
        {
            float number = 0;
            var result = TypeMatching.FindType(number);
            Assert.Equal("It's not a string, integer or boolean", result);
        }
    }
}