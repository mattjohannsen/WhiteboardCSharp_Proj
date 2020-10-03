using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge102_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int num = 123;
            int expected = 321;
            //Act
            int actual = Challenge102.SortDescending(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int num = 670276097;
            int expected = 977766200;
            //Act
            int actual = Challenge102.SortDescending(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int num = 2619805;
            int expected = 9865210;
            //Act
            int actual = Challenge102.SortDescending(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int num = 81294;
            int expected = 98421;
            //Act
            int actual = Challenge102.SortDescending(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int num = 0;
            int expected = 0;
            //Act
            int actual = Challenge102.SortDescending(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int num = 321;
            int expected = 321;
            //Act
            int actual = Challenge102.SortDescending(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int num = 628904;
            int expected = 986420;
            //Act
            int actual = Challenge102.SortDescending(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int num = 289327560;
            int expected = 987653220;
            //Act
            int actual = Challenge102.SortDescending(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            int num = 6456;
            int expected = 6654;
            //Act
            int actual = Challenge102.SortDescending(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
