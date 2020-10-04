using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge105_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 6;
            bool expected = true;
            //Act
            bool actual = Challenge105.IsFactorial(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 16;
            bool expected = false;
            //Act
            bool actual = Challenge105.IsFactorial(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int n = 24;
            bool expected = true;
            //Act
            bool actual = Challenge105.IsFactorial(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int n = 36;
            bool expected = false;
            //Act
            bool actual = Challenge105.IsFactorial(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int n = 120;
            bool expected = true;
            //Act
            bool actual = Challenge105.IsFactorial(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int n = 721;
            bool expected = false;
            //Act
            bool actual = Challenge105.IsFactorial(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
