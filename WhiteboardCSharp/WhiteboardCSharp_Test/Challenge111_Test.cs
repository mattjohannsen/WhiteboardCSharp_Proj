using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge111_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int year = 1756;
            string expected = "18th century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int year = 1555;
            string expected = "16th century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int year = 1000;
            string expected = "10th century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int year = 1001;
            string expected = "11th century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int year = 2005;
            string expected = "21st century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int year = 1789;
            string expected = "18th century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int year = 1510;
            string expected = "16th century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int year = 1615;
            string expected = "17th century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            int year = 2000;
            string expected = "20th century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            int year = 1997;
            string expected = "20th century";
            //Act
            string actual = Challenge111.Century(year);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}