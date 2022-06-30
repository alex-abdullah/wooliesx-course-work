using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace MathTest
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Add_AddNumbersCorrectly()
        {
            Assert.AreEqual(14, Test.Math.Add(10, 4));
            Assert.AreEqual(-2, Tests.Math.Add(-8, 6));
            Assert.AreEqual(1300, CodeProject.Math.Add(1000, 300));
            Assert.AreEqual(20, CodeProject.Math.Add(10, 10));
        }

        [TestMethod]
        public void Divide_DivideNumbersCorrectly()
        {
            Assert.AreEqual(6, CodeProject.Math.Divide(12, 2));
            Assert.AreEqual(3, CodeProject.Math.Divide(9, 3));
            Assert.AreEqual(0.5, CodeProject.Math.Divide(1, 2));
        }

        [TestMethod]
        public void Divide_DivideByZero()
        {
            Assert.ThrowsException<DivideByZeroException>(() => CodeProject.Math.Divide(5, 0));
        }
    }
}
