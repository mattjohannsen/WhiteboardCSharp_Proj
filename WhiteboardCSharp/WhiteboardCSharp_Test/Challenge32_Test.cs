using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge32_Test
    {
        [TestMethod]
        public void PowerRanger_First_Case()
        {
            // Arrange
            int n = 2;
            int a = 49;
            int b = 65;
            Challenge32 challenge32 = new Challenge32();
            int expected = 2;

            // Act
            int actual = challenge32.PowerRanger(n, a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PowerRanger_Second_Case()
        {
            // Arrange
            int n = 3;
            int a = 1;
            int b = 27;
            Challenge32 challenge32 = new Challenge32();
            int expected = 3;

            // Act
            int actual = challenge32.PowerRanger(n, a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PowerRanger_Third_Case()
        {
            // Arrange 
            int n = 10;
            int a = 1;
            int b = 5;
            Challenge32 challenge32 = new Challenge32();
            int expected = 1;

            // Act
            int actual = challenge32.PowerRanger(n, a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PowerRanger_Fourth_Case()
        {
            // Arrange 
            int n = 5;
            int a = 31;
            int b = 33;
            Challenge32 challenge32 = new Challenge32();
            int expected = 1;

            // Act
            int actual = challenge32.PowerRanger(n, a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void PowerRanger_Fifth_Case()
        {
            // Arrange 
            int n = 4;
            int a = 250;
            int b = 1300;
            Challenge32 challenge32 = new Challenge32();
            int expected = 3;

            // Act
            int actual = challenge32.PowerRanger(n, a, b);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void NthRoot_PerfectSquare_DividedBy_2_Power()
        {
            // Arrange 
            double A = 49;
            int N = 2;
            Challenge32 challenge32 = new Challenge32();
            double expected = 7;

            // Act
            double actual = challenge32.NthRoot(A, N);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
