using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge129_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int a = -1;
            int b = 0;
            int c = 25;
            double[] expected = { 0, 25d };
            //Act
            double[] actual = Challenge129.FindVertex(a, b, c);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int a = 1;
            int b = 10;
            int c = 25;
            double[] expected = { -5d, 0d };
            //Act
            double[] actual = Challenge129.FindVertex(a, b, c);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int a = 8;
            int b = 4;
            int c = 0;
            double[] expected = { -0.25d, -0.5d };
            //Act
            double[] actual = Challenge129.FindVertex(a, b, c);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int a = 4;
            int b = -200;
            int c = 1000;
            double[] expected = { 25d, -1500d };
            //Act
            double[] actual = Challenge129.FindVertex(a, b, c);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int a = 1;
            int b = -50;
            int c = -1000;
            double[] expected = { 25d, -1625d };
            //Act
            double[] actual = Challenge129.FindVertex(a, b, c);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int a = -1;
            int b = 20;
            int c = 600;
            double[] expected = { 10d, 700d };
            //Act
            double[] actual = Challenge129.FindVertex(a, b, c);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int a = 5;
            int b = 1;
            int c = 20;
            double[] expected = { -0.1d, 19.95d };
            //Act
            double[] actual = Challenge129.FindVertex(a, b, c);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
