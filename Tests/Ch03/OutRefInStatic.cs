using Ch03Types.OutRefIn;
using Xunit;

namespace Tests.Ch03
{
    public class OutRefInStatic
    {
        [Fact]
        public void Divide_ShouldReturnRemainder_InOutVariable()
        {
            var remainder = 420; //* pre-existing variable can be used
            var quotient = StaticMethods.DivideInt(69, 4, out remainder);
            Assert.Equal(17, quotient);
            Assert.Equal(1, remainder);
        }
    }
}