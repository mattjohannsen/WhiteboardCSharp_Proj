using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge95_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int num = 838;
            bool expected = true;
            //Act
            bool actual = Challenge95.IsPalindrome(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int num = 77;
            bool expected = true;
            //Act
            bool actual = Challenge95.IsPalindrome(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int num = 95159;
            bool expected = true;
            //Act
            bool actual = Challenge95.IsPalindrome(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int num = 839;
            bool expected = false;
            //Act
            bool actual = Challenge95.IsPalindrome(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int num = 4234;
            bool expected = false;
            //Act
            bool actual = Challenge95.IsPalindrome(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int num = 13;
            bool expected = false;
            //Act
            bool actual = Challenge95.IsPalindrome(num);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
