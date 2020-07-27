using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge12_Test
    {
        [TestMethod]
        public void Last_Dig_ThreeOnes_ReturnTrue()
        {
            // Arrange
            int a = 1;
            int b = 1;
            int c = 1;
            bool expected = true;

            // Act
            bool actual = Challenge12.last_dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_2ndSet_ReturnTrue()
        {
            // Arrange
            int a = 12;
            int b = 15;
            int c = 10;
            bool expected = true;

            // Act
            bool actual = Challenge12.last_dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_3rdSet_ReturnTrue()
        {
            // Arrange
            int a = 15228;
            int b = 9209;
            int c = 72162;
            bool expected = true;

            // Act
            bool actual = Challenge12.last_dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_4thSet_ReturnFalse()
        {
            // Arrange
            int a = 15;
            int b = 1;
            int c = 1;
            bool expected = false;

            // Act
            bool actual = Challenge12.last_dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
