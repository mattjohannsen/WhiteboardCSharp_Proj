using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge82_Test
    {
        [TestMethod]
        public void ReverseCase_TwoWordsCapitalized_ReturnsInverseCase()
        {
            // Arrange
            string input = "Happy Birthday";
            string expected = "hAPPY bIRTHDAY";

            // Act
            string actual = Challenge82.ReverseCase(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReverseCase_ALLCAPS_ReturnsAllLowerCase()
        {
            // Arrange
            string input = "MANY THANKS";
            string expected = "many thanks";

            // Act
            string actual = Challenge82.ReverseCase(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReverseCase_AlternateingLowerUpper_ReturnsAlternatingUpperLower()
        {
            // Arrange
            string input = "sPoNtAnEoUs";
            string expected = "SpOnTaNeOuS";

            // Act
            string actual = Challenge82.ReverseCase(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void ReverseCase_MixedCaseWithPunctuation_ReturnsPunctuation()
        {
            // Arrange
            string input = "eXCELLENT, yOuR mAJESTY";
            string expected = "Excellent, YoUr Majesty";

            // Act
            string actual = Challenge82.ReverseCase(input);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
