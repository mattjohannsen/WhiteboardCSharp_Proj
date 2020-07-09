using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge1_Test
    {
        [TestMethod]
        public void GetIndeces_FirstValue_Equals_3()
        {
            //Arrange
            Challenge1 challenge1 = new Challenge1();
            int[] expected = { 3, 0 };
            int[] inputArray = { 5, 17, 77, 50 };
            int target = 55;

            //Act
            int[] actual = challenge1.GetIndeces(inputArray, target);

            //Assert
            Assert.AreEqual(expected[0], actual[0]);
        }
        [TestMethod]
        public void GetIndeces_SecondValue_Equals_0()
        {
            //Arrange
            Challenge1 challenge1 = new Challenge1();
            int[] expected = { 3, 0 };
            int[] inputArray = { 5, 17, 77, 50 };
            int target = 55;

            //Act
            int[] actual = challenge1.GetIndeces(inputArray, target);

            //Assert
            Assert.AreEqual(expected[1], actual[1]);
        }
    }
}
