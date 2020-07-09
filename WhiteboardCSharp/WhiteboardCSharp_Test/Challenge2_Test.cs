using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;


namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge2_Test
    {
        [TestMethod]
        public void CheckIfPalindrome_InputString_OddCharacters_True()
        {
            //Arrange
            Challenge2 challenge2 = new Challenge2();
            string stringToCheck = "madam";
            bool expected = true;

            //Act
            bool actual = challenge2.CheckIfPalindrome(stringToCheck);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckIfPalindrome_InputString_OddCharacters_False()
        {
            //Arrange
            Challenge2 challenge2 = new Challenge2();
            string stringToCheck = "maddm";
            bool expected = false;

            //Act
            bool actual = challenge2.CheckIfPalindrome(stringToCheck);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckIfPalindrome_InputString_EvenCharacters_True()
        {
            //Arrange
            Challenge2 challenge2 = new Challenge2();
            string stringToCheck = "abbaabba";
            bool expected = true;

            //Act
            bool actual = challenge2.CheckIfPalindrome(stringToCheck);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void CheckIfPalindrome_InputString_EvenCharacters_False()
        {
            //Arrange
            Challenge2 challenge2 = new Challenge2();
            string stringToCheck = "abbaabbb";
            bool expected = false;

            //Act
            bool actual = challenge2.CheckIfPalindrome(stringToCheck);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
