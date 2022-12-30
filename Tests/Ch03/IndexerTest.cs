using System;
using Ch03Types.Indexers;
using Xunit;

namespace Tests.Ch03
{
    public class IndexerTest
    {
        [Fact]
        public void Index_ReturnsInt()
        {
            var indexed = new Indexed();
            for (int i = 1; i < 10; i++)
            {
                var expected = i <= 5 ? "foo" : "bar";
                Assert.Equal(expected, indexed[i]);
            }
        }

        [Fact]
        public void IndexSetter_ShouldSetNewFields()
        {
            var th = 69;
            var s1 = "hello";
            var s2 = "motherfucker";

            var indexed = new Indexed();
            indexed[s1, s2] = th;
            for (int i = th - 2; i < th + 3; i++)
            {
                var expected = i <= th ? s1 : s2;
                Assert.Equal(expected, indexed[i]);
            }
        }
    }
}