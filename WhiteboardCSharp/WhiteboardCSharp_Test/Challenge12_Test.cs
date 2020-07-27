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
            bool actual = Challenge12.Last_Dig(a, b, c);

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
            bool actual = Challenge12.Last_Dig(a, b, c);

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
            bool actual = Challenge12.Last_Dig(a, b, c);

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
            bool actual = Challenge12.Last_Dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_5thSet_ReturnFalse()
        {
            // Arrange
            int a = 123;
            int b = 15;
            int c = 10;
            bool expected = false;

            // Act
            bool actual = Challenge12.Last_Dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_6thSet_ReturnFalse()
        {
            // Arrange
            int a = 5213;
            int b = 99219;
            int c = 6165;
            bool expected = false;

            // Act
            bool actual = Challenge12.Last_Dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_7thSet_ReturnFalse()
        {
            // Arrange
            int a = 1523;
            int b = 513;
            int c = 513;
            bool expected = false;

            // Act
            bool actual = Challenge12.Last_Dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_8thSet_ReturnFalse()
        {
            // Arrange
            int a = -15;
            int b = 1;
            int c = 1;
            bool expected = false;

            // Act
            bool actual = Challenge12.Last_Dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_9thSet_ReturnFalse()
        {
            // Arrange
            int a = 123;
            int b = -15;
            int c = 10;
            bool expected = false;

            // Act
            bool actual = Challenge12.Last_Dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_10thSet_ReturnTrue()
        {
            // Arrange
            int a = -12;
            int b = 15;
            int c = -10;
            bool expected = true;

            // Act
            bool actual = Challenge12.Last_Dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Last_Dig_11thSet_ReturnTrue()
        {
            // Arrange
            int a = 15228;
            int b = -9209;
            int c = -72162;
            bool expected = true;

            // Act
            bool actual = Challenge12.Last_Dig(a, b, c);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
