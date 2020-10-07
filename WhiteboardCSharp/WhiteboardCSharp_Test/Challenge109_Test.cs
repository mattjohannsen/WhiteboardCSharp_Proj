using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge109_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int num = 1000;
            string expected = "1,000";
            //Act
            string actual = Challenge109.FormatNum(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int num = 1000000;
            string expected = "1,000,000";
            //Act
            string actual = Challenge109.FormatNum(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int num = 20;
            string expected = "20";
            //Act
            string actual = Challenge109.FormatNum(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int num = 0;
            string expected = "0";
            //Act
            string actual = Challenge109.FormatNum(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int num = 12948;
            string expected = "12,948";
            //Act
            string actual = Challenge109.FormatNum(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
