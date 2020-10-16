using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge115_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 1;
            int expected = 1;
            //Act
            int actual = Challenge115.Tetra(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 2;
            int expected = 4;
            //Act
            int actual = Challenge115.Tetra(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int n = 3;
            int expected = 10;
            //Act
            int actual = Challenge115.Tetra(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int n = 4;
            int expected = 20;
            //Act
            int actual = Challenge115.Tetra(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int n = 5;
            int expected = 35;
            //Act
            int actual = Challenge115.Tetra(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int n = 6;
            int expected = 56;
            //Act
            int actual = Challenge115.Tetra(n);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetTriangular_1()
        {
            //Arrange
            int num = 1;
            int expected = 1;
            //Act
            int actual = Challenge115.GetTriangular(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetTriangular_2()
        {
            //Arrange
            int num = 2;
            int expected = 3;
            //Act
            int actual = Challenge115.GetTriangular(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetTriangular_3()
        {
            //Arrange
            int num = 2;
            int expected = 3;
            //Act
            int actual = Challenge115.GetTriangular(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetTriangular_4()
        {
            //Arrange
            int num = 2;
            int expected = 3;
            //Act
            int actual = Challenge115.GetTriangular(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetTriangular_5()
        {
            //Arrange
            int num = 2;
            int expected = 3;
            //Act
            int actual = Challenge115.GetTriangular(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetTriangular_6()
        {
            //Arrange
            int num = 6;
            int expected = 21;
            //Act
            int actual = Challenge115.GetTriangular(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
