using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge13_Test
    {
        [TestMethod]
        public void HackerSpeak_StringOne_ReturnsString()
        {
            //Arrange
            string initialString = "javascript is cool";
            string expected = "j4v45cr1pt 15 c00l";

            //Act
            string actual = Challenge13.HackerSpeak(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HackerSpeak_StringTwo_ReturnsString()
        {
            //Arrange
            string initialString = "become a coder";
            string expected = "b3c0m3 4 c0d3r";

            //Act
            string actual = Challenge13.HackerSpeak(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HackerSpeak_StringThree_ReturnsString()
        {
            //Arrange
            string initialString = "hi there";
            string expected = "h1 th3r3";

            //Act
            string actual = Challenge13.HackerSpeak(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HackerSpeak_StringFour_ReturnsString()
        {
            //Arrange
            string initialString = "programming is fun";
            string expected = "pr0gr4mm1ng 15 fun";

            //Act
            string actual = Challenge13.HackerSpeak(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void HackerSpeak_StringFive_ReturnsString()
        {
            //Arrange
            string initialString = "keep on practicing";
            string expected = "k33p 0n pr4ct1c1ng";

            //Act
            string actual = Challenge13.HackerSpeak(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
