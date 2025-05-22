using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MathUtils;

namespace MathUtilsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdd()
        {
            var mo = new MathOperations();
            Assert.AreEqual(10, mo.Add(5, 5));
        }
        [TestMethod]
        public void TestSubtract()
        {
            var mo = new MathOperations();
            Assert.AreEqual(5, mo.Subtract(10, 5));
        }
        [TestMethod]
        public void LongTest()
        {
            for (var i = 0; i < 250; i++)
            {
                Console.WriteLine($"LongTest {i}");
                System.Threading.Thread.Sleep(1000);
            }
            Assert.AreEqual(1, 1);
        }
    }
}
