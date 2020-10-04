using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge104_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n1 = 32;
            int n2 = 8;
            int expected = 8;
            //Act
            int actual = Challenge104.GCD(n1, n2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n1 = 8;
            int n2 = 12;
            int expected = 4;
            //Act
            int actual = Challenge104.GCD(n1, n2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int n1 = 17;
            int n2 = 13;
            int expected = 1;
            //Act
            int actual = Challenge104.GCD(n1, n2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int n1 = 14;
            int n2 = 7;
            int expected = 7;
            //Act
            int actual = Challenge104.GCD(n1, n2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int n1 = 32;
            int n2 = 16;
            int expected = 16;
            //Act
            int actual = Challenge104.GCD(n1, n2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int n1 = 17;
            int n2 = 100;
            int expected = 1;
            //Act
            int actual = Challenge104.GCD(n1, n2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int n1 = 55;
            int n2 = 20;
            int expected = 5;
            //Act
            int actual = Challenge104.GCD(n1, n2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int n1 = 55;
            int n2 = 22;
            int expected = 11;
            //Act
            int actual = Challenge104.GCD(n1, n2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
