using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge117_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 132;
            string expected = "H";
            //Act
            string actual = Challenge117.Moran(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 133;
            string expected = "M";
            //Act
            string actual = Challenge117.Moran(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int n = 134;
            string expected = "Neither";
            //Act
            string actual = Challenge117.Moran(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int n = 3033;
            string expected = "M";
            //Act
            string actual = Challenge117.Moran(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int n = 3030;
            string expected = "H";
            //Act
            string actual = Challenge117.Moran(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int n = 491423;
            string expected = "Neither";
            //Act
            string actual = Challenge117.Moran(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int n = 20937;
            string expected = "M";
            //Act
            string actual = Challenge117.Moran(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
