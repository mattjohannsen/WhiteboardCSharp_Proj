using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge87_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = 0;
            int b = 3;
            int expected = 6;

            //Act
            int actual = Challenge87.BlockPlayer(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int a = 0;
            int b = 8;
            int expected = 4;

            //Act
            int actual = Challenge87.BlockPlayer(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int a = 4;
            int b = 8;
            int expected = 0;

            //Act
            int actual = Challenge87.BlockPlayer(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int a = 2;
            int b = 5;
            int expected = 8;

            //Act
            int actual = Challenge87.BlockPlayer(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int a = 1;
            int b = 7;
            int expected = 4;

            //Act
            int actual = Challenge87.BlockPlayer(a, b);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}