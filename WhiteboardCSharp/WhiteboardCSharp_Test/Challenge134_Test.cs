using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge134_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            object str = "Cat, dog, and mouse.";
            string expected = ".at, dog, and mouseC";
            //Act
            string actual = Challenge134.FlipEndChars(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            object str = "Anna, Banana";
            string expected = "anna, BananA";
            //Act
            string actual = Challenge134.FlipEndChars(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            object str = "[]";
            string expected = "][";
            //Act
            string actual = Challenge134.FlipEndChars(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            object str = "";
            string expected = "Incompatible.";
            //Act
            string actual = Challenge134.FlipEndChars(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            object str = new int[] { 1, 2, 3 };
            string expected = "Incompatible.";
            //Act
            string actual = Challenge134.FlipEndChars(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            object str = "dfdkf49824fdfdfjhd";
            string expected = "Two's a pair.";
            //Act
            string actual = Challenge134.FlipEndChars(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            object str = "#343473847#";
            string expected = "Two's a pair.";
            //Act
            string actual = Challenge134.FlipEndChars(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
