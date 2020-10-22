using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge122_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int expected = 17;
            //Act
            int actual = Challenge122.SumPrimes(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int[] arr = { 2, 3, 4, 11, 20, 50, 71 };
            int expected = 87;
            //Act
            int actual = Challenge122.SumPrimes(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int[] arr = { 19, 21, 24, 27, 30, 37 };
            int expected = 56;
            //Act
            int actual = Challenge122.SumPrimes(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int[] arr = { 69, 79, 87, 97, 101 };
            int expected = 277;
            //Act
            int actual = Challenge122.SumPrimes(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int[] arr = { 53, 59, 28, 50, 45, 33, 61 };
            int expected = 173;
            //Act
            int actual = Challenge122.SumPrimes(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int[] arr = { };
            int expected = 0;
            //Act
            int actual = Challenge122.SumPrimes(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int[] arr = { 11, 11, 11, 11, 11, 22, 22, 22 };
            int expected = 55;
            //Act
            int actual = Challenge122.SumPrimes(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int[] arr = { 67, 24, 58, 28, 71, 73, 99 };
            int expected = 211;
            //Act
            int actual = Challenge122.SumPrimes(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
