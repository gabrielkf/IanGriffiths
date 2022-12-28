using System.Drawing;
using Ch03Types.OutRefIn;
using Xunit;

namespace Tests.Ch03
{
    public class ReferableTest
    {
        private readonly Referable _referable = new Referable();
        // [Fact]
        // public void ShouldNotInstanciate()
        // {
        //     var referable = new Referable();
        // }

        [Fact]
        public void ReturnsIntVariableRef()
        { 
            var i = 69;
            var sameRef = _referable.GetSameRef(ref i);
            var intRef = _referable.GetIntRef(ref i);
            
            Assert.Equal(69, sameRef);
            Assert.Equal(69, intRef);
        }

        [Fact]
        public void ShouldReturnArrayRef_WithZeroValue()
        {
            int fieldRef = _referable.GetArrayElementRef(0);
            Assert.Equal(0, fieldRef);
        }
    }
}