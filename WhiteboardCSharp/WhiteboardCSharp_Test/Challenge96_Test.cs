using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge96_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            double[] arr = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, -11, -12, -13, -14, -15 };
            int[] expected = new int[] { 10, -65 };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            double[] arr = new double[] { 92, 6, 73, -77, 81, -90, 99, 8, -85, 34 };
            int[] expected = new int[] { 7, -252 };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            double[] arr = new double[] { 91, -4, 80, -73, -28 };
            int[] expected = new int[] { 2, -105 };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            double[] arr = new double[] { };
            int[] expected = new int[] { };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            double[] arr = new double[] { 69, 100, 28, 47, 53, -61, -24 };
            int[] expected = new int[] { 5, -85 };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            double[] arr = new double[] { 5, 7, 9, -3, -7, 61, -24 };
            int[] expected = new int[] { 4, -34 };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            double[] arr = new double[] { 0 };
            int[] expected = new int[] { 0, 0 };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            double[] arr = new double[] { 98, 51, -19, -97 };
            int[] expected = new int[] { 2, -116 };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            double[] arr = new double[] { -42, 3, -51, -64, 69, 77, -20, -5, 68, -76 };
            int[] expected = new int[] { 4, -258 };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            double[] arr = new double[] { 0, 0, 0 };
            int[] expected = new int[] { 0, 0 };
            //Act
            int[] actual = Challenge96.CountPosSumNeg(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
