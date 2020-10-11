using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge112_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string s = "1+1";
            int expected = 2;
            //Act
            int actual = Challenge112.Equation(s);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string s = "7*4-2";
            int expected = 26;
            //Act
            int actual = Challenge112.Equation(s);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string s = "1+1+1+1+1";
            int expected = 5;
            //Act
            int actual = Challenge112.Equation(s);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
