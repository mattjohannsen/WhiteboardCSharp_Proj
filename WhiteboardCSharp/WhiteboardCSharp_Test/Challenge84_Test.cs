using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge84_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            int i = 12;
            int expected = 2;

            //Act
            int actual = Challenge84.CountOnes(i);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            // Arrange
            int i = 0;
            int expected = 0;

            //Act
            int actual = Challenge84.CountOnes(i);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Arrange
            int i = 100;
            int expected = 3;

            //Act
            int actual = Challenge84.CountOnes(i);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            // Arrange
            int i = 101;
            int expected = 4;

            //Act
            int actual = Challenge84.CountOnes(i);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            // Arrange
            int i = 999;
            int expected = 8;

            //Act
            int actual = Challenge84.CountOnes(i);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            // Arrange
            int i = 123456789;
            int expected = 16;

            //Act
            int actual = Challenge84.CountOnes(i);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            // Arrange
            int i = 1234567890;
            int expected = 12;

            //Act
            int actual = Challenge84.CountOnes(i);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
