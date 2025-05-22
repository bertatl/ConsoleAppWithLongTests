using Xunit;
using MathUtils;
using System;
namespace MathUtilsTestxUnit
{
    public class xUnitTests
    {
        [Fact]
        public void TestAdd()
        {
            var mo = new MathOperations();
            Assert.Equal(3, mo.Add(1, 2));
        }
        [Fact]
        public void TestSubtract()
        {
            var mo = new MathOperations();
            Assert.Equal(2, mo.Subtract(4, 2));
        }
        [Fact]
        public void LongTest()
        {
            for (var i = 0; i < 10; i++)
            {
                Console.WriteLine($"LongTest {i}");
                System.Threading.Thread.Sleep(1000);
            }
            Assert.True(true);
        }
    }
}
