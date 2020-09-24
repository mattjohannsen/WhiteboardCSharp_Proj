using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge93_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            object[] arr = new object[] { 1, 2, "a", "b" };
            int[] expected = new int[] { 1, 2 };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            object[] arr = new object[] { 1, "a", "b", 0, 15 };
            int[] expected = new int[] { 1, 0, 15 };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            object[] arr = new object[] { 1, 2, "aasf", "1", "123", 123 };
            int[] expected = new int[] { 1, 2, 123 };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            object[] arr = new object[] { "jsyt", 4, "yt", 6 };
            int[] expected = new int[] { 4, 6 };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            object[] arr = new object[] { "r", 5, "y", "e", 8, 9 };
            int[] expected = new int[] { 5, 8, 9 };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            object[] arr = new object[] { "a", "e", "i", "o", "u" };
            int[] expected = new int[] {  };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            object[] arr = new object[] { 4, "z", "f", 5 };
            int[] expected = new int[] { 4, 5 };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            object[] arr = new object[] { "abc", 123 };
            int[] expected = new int[] { 123 };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            object[] arr = new object[] { "$%^", 567, "&&&" };
            int[] expected = new int[] { 567 };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            object[] arr = new object[] { "w", "r", "u", 43, "s", "a", 76, "d", 88 };
            int[] expected = new int[] { 43, 76, 88 };
            //Act
            int[] actual = Challenge93.FilterArray(arr);
            //Assert
            CollectionAssert.AreEqual(actual, expected);
        }
    }
}
