using System;
using Xunit;
using Net.Erabbit.CSL;

namespace CSL.Tests
{
    public class CSLUtility_Test
    {
        [Fact]
        public void ToIntLE_Test()
        {
            Assert.Equal(0x030201, CSLUtility.ToIntLE(new byte[] { 1,2,3 }, 0, 3));
            Assert.Equal(0x0201, CSLUtility.ToIntLE(new byte[] { 1,2,3 }, 0, 2));
            Assert.Equal(0x0302, CSLUtility.ToIntLE(new byte[] { 1,2,3 }, 1, 2));
        }

        [Fact]
        public void ToIntBE_Test()
        {
            Assert.Equal(0x010203, CSLUtility.ToIntBE(new byte[] { 1,2,3 }, 0, 3));
            Assert.Equal(0x0102, CSLUtility.ToIntBE(new byte[] { 1,2,3 }, 0, 2));
            Assert.Equal(0x0203, CSLUtility.ToIntBE(new byte[] { 1,2,3 }, 1, 2));
        }

        [Fact]
        public void ToHexString_Test()
        {
            Assert.Equal("010AFF", CSLUtility.ToHexString(new byte[] { 1,10,255 }, 0, 3, ""));
            Assert.Equal("01-0A-FF", CSLUtility.ToHexString(new byte[] { 1,10,255 }, 0, 3, "-"));
            Assert.Equal("01-0A", CSLUtility.ToHexString(new byte[] { 1,10,255 }, 0, 2, "-"));
            Assert.Equal("0A-FF", CSLUtility.ToHexString(new byte[] { 1,10,255 }, 1, 2, "-"));
        }

    }
}
