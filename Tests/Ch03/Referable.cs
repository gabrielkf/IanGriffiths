using Xunit;

namespace Tests.Ch03
{
    public class Referable
    {
        [Fact]
        public void ShouldNotInstanciate()
        {
            var referable = new Referable();
        }
    }
}