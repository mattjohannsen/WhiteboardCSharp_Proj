using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge120_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            object[] arr = new object[] { 1, 2, "a", "b" };
            string[] expected = new string[] { "1", "2", "a", "b" };
            //Act
            string[] actual = Challenge120.ParseArray(arr);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            object[] arr = new object[] { "a", "b", 10, 115 };
            string[] expected = new string[] { "a", "b", "10", "115" };
            //Act
            string[] actual = Challenge120.ParseArray(arr);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            object[] arr = new object[] { };
            string[] expected = new string[] { };
            //Act
            string[] actual = Challenge120.ParseArray(arr);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            object[] arr = new object[] { -4, "k", 0 };
            string[] expected = new string[] { "-4", "k", "0" };
            //Act
            string[] actual = Challenge120.ParseArray(arr);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            object[] arr = new object[] { "Hell000!", 5 };
            string[] expected = new string[] { "Hell000!", "5" };
            //Act
            string[] actual = Challenge120.ParseArray(arr);
            //Assert
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
