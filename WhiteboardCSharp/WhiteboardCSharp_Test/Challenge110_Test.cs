using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge110_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int num = 152;
            int expected = 10;
            //Act
            int actual = Challenge110.MysteryFunc(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int num = 832;
            int expected = 48;
            //Act
            int actual = Challenge110.MysteryFunc(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int num = 5511;
            int expected = 25;
            //Act
            int actual = Challenge110.MysteryFunc(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int num = 19;
            int expected = 9;
            //Act
            int actual = Challenge110.MysteryFunc(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int num = 133;
            int expected = 9;
            //Act
            int actual = Challenge110.MysteryFunc(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
