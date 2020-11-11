using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge130_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int[] arr = { 1, 2, 3, 4, 0, 0, -3, -2 };
            int expected = 10;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int[] arr = { -4, -8, -12, -3, 4, 7, 1, 3, 0, 0, 0, 0 };
            int expected = -27;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int[] arr = { 0, 0, 0, 0, 0, 1, 2, -3 };
            int expected = 5;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int[] arr = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int expected = 11;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int[] arr = { 0 };
            int expected = 1;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int[] arr = { 1 };
            int expected = 1;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int[] arr = { -1 };
            int expected = -1;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int[] arr = { 10, -12, 4, 0, -3, -7, -91, 45 };
            int expected = -113;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            int[] arr = { 0, 1, 0, 1, 0, 1, 0, 1, 0 };
            int expected = 5;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            int[] arr = { -1, -1, -1, -1, -1, 1, 1, 1, 1, 0, 0, 0, 0 };
            int expected = -5;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            int[] arr = { 1, 2, 3, 4, -5, -4, -3, -2, -1, 0 };
            int expected = -15;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            int[] arr = { 0, 1, -2 };
            int expected = -2;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            int[] arr = { 2, 0, -1 };
            int expected = 2;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            int[] arr = { 2, 0, 0, 0, -1 };
            int expected = 3;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            int[] arr = { 2, 0, 0, 0, 0, -1 };
            int expected = 4;
            //Act
            int actual = Challenge130.MajorSum(arr);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
