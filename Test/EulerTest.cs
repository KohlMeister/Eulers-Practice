using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class EulerTest
    {
        [TestMethod]
        public void Problem1()
        {
            // Arrange
            int expected = 23;
            int range = 10;

            // Act
            int actual = Eulers_Practice.Problems.problemOne(range);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
