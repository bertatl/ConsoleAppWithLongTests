using MathUtils;
using NUnit.Framework;
using System;

namespace MathUtilsTestNUnit
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestAdd()
        {
            var mo = new MathOperations();
            Assert.AreEqual(3, mo.Add(1, 2));
        }
        [Test]
        public void TestSubtract()
        {
            var mo = new MathOperations();
            Assert.AreEqual(2, mo.Subtract(4, 2));
        }

        [Test]
        public void TestMultiply()
        {
            var mo = new MathOperations();
            Assert.AreEqual(8, mo.Multiply(4, 2));
        }

        [Test]
        public void LongTest()
        {
            for (var i = 0; i < 250; i++)
            {
                Console.WriteLine($"LongTest {i}");
                System.Threading.Thread.Sleep(1000);
            }
            Assert.IsTrue(true);
        }

    }
}