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
    }
}
