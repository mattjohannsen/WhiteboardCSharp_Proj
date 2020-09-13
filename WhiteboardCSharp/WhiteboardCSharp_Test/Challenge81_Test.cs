using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge81_Test
    {
        [TestMethod]
        public void FindLargest_AllPositiveWholeNumbers_ReturnsAllPositiveWholeNumbers()
        {
            //Arrange
            double[][] input = new double[][] { new double[] { 4, 2, 7, 1 }, new double[] { 20, 70, 40, 90 }, new double[] { 1, 2, 0 } };
            double[] expected = new double[] { 7, 90, 2 };

            //Act
            double[] actual = Challenge81.FindLargest(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargest_MixedWholeNumbersAndDecimals_ReturnsWholeAndDecimalNumbers()
        {
            //Arrange
            double[][] input = new double[][] { new double[] { 0.4321, 0.7634, 0.652 }, new double[] { 1.324, 9.32, 2.5423, 6.4314 }, new double[] { 9, 3, 6, 3 } };
            double[] expected = new double[] { 0.7634, 9.32, 9 };

            //Act
            double[] actual = Challenge81.FindLargest(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargest_ContainsNegativeNumbers_ReturnsPositiveandNegativeNumbers()
        {
            //Arrange
            double[][] input = new double[][] { new double[] { -34, -54, -74 }, new double[] { -32, -2, -65 }, new double[] { -54, 7, -43 } };
            double[] expected = new double[] { -34, -2, 7 };

            //Act
            double[] actual = Challenge81.FindLargest(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FindLargest_ContainsNegativesAndDecimals_ReturnsPositiveAndNegativeDecimalsAndWhole()
        {
            //Arrange
            double[][] input = new double[][] { new double[] { 0.34, -5, 1.34 }, new double[] { -6.432, -1.762, -1.99 }, new double[] { 32, 65, -6 } };
            double[] expected = new double[] { 1.34, -1.762, 65 };

            //Act
            double[] actual = Challenge81.FindLargest(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double[][] input = new double[][] { new double[] { 0, 0, 0, 0 }, new double[] { 3, 3, 3, 3 }, new double[] { -2, -2 } };
            double[] expected = new double[] { 0, 3, -2 };

            //Act
            double[] actual = Challenge81.FindLargest(input);

            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
