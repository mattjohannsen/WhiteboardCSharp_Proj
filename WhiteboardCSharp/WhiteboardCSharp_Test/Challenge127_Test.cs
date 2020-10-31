using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge127_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int[] values = { 1, 2, 3, 4, 5 };
            int[] expected = { 2, 3, 4, 5 };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int[] values = { 5, 3, 2, 1, 4 };
            int[] expected = { 5, 3, 2, 4 };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int[] values = { 2, 2, 1, 2, 1 };
            int[] expected = { 2, 2, 2, 1 };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int[] values = { 3, 1, 6, 7, 3, 7, 6 };
            int[] expected = { 3, 6, 7, 3, 7, 6 };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int[] values = { 4, 4, 4, 1 };
            int[] expected = { 4, 4, 4 };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int[] values = { 5, 4, 5, 3, 1, 1 };
            int[] expected = { 5, 4, 5, 3, 1 };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int[] values = { 1, 5, 3 };
            int[] expected = { 5, 3 };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int[] values = { };
            int[] expected = { };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            int[] values = { 6, 2, 5, 4, 8, 6, 3, 2, 7 };
            int[] expected = { 6, 5, 4, 8, 6, 3, 2, 7 };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            int[] values = { 3 };
            int[] expected = { };
            //Act
            int[] actual = Challenge127.RemoveSmallest(values);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
