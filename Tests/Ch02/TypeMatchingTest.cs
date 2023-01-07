using System.Collections.Generic;
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
            var result = TypeMatching.FindType(false);
            Assert.Equal($"It's a boolean, and it's {boolean.ToString()}", result);
        }

        [Fact]
        public void FindType_ShouldReturnOtherType()
        {
            float number = 0;
            var result = TypeMatching.FindType(number);
            Assert.Equal("It's not a string, integer nor boolean", result);
        }

        [Fact]
        public void FindType_ShouldIndicateEmptyString()
        {
            var result = TypeMatching.FindType(string.Empty);
            Assert.Equal("It's an empty string", result);
        }

        [Fact]
        public void FindType_ShouldIndicateCollection()
        {
            var result = TypeMatching.FindType(new List<int>());
            Assert.Equal("It's a Collection", result);
        }
    }
}