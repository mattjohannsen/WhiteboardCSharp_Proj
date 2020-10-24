using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge125_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "A man, a plan, a cat, a ham, a yak, a yam, a hat, a canal-Panama!";
            bool expected = true;
            //Act
            bool actual = Challenge125.IsPalindrome(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "Neuquen";
            bool expected = true;
            //Act
            bool actual = Challenge125.IsPalindrome(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "Not a palindrome";
            bool expected = false;
            //Act
            bool actual = Challenge125.IsPalindrome(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
