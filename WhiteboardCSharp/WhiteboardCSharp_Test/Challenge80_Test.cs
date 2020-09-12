using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge80_Test
    {
        [TestMethod]
        public void Square_Areas_Difference_FirstCase()
        {
            // Arrange
            int radius = 6;
            int expected = 72;

            // Act
            int actual = Challenge80.square_areas_difference(radius);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Square_Areas_Difference_SecondCase()
        {
            // Arrange
            int radius = 7;
            int expected = 98;

            // Act
            int actual = Challenge80.square_areas_difference(radius);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Square_Areas_Difference_ThirdCase()
        {
            // Arrange
            int radius = 17;
            int expected = 578;

            // Act
            int actual = Challenge80.square_areas_difference(radius);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Square_Areas_Difference_FourthCase()
        {
            // Arrange
            int radius = 5;
            int expected = 50;

            // Act
            int actual = Challenge80.square_areas_difference(radius);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
