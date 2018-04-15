using System;
using Xunit;
using Net.Erabbit.CSL;

namespace CSL.Tests
{
    public class CSLUtility_Test
    {
        [Fact]
        public void ToIntLE()
        {
            var result = CSLUtility.ToIntLE(new byte[] { 1, 2, 3 }, 0, 3);
            Assert.Equal(0x030201, result);

            result = CSLUtility.ToIntLE(new byte[] { 1, 2, 3 }, 0, 2);
            Assert.Equal(0x0201, result);

            result = CSLUtility.ToIntLE(new byte[] { 1, 2, 3 }, 1, 2);
            Assert.Equal(0x0302, result);
        }
    }
}
