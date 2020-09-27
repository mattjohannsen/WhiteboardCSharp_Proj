using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge97_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int x = 31;
            bool expected = true;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int x = 18;
            bool expected = false;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int x = 11;
            bool expected = true;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int x = 12;
            bool expected = false;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int x = 1;
            bool expected = false;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int x = 3;
            bool expected = true;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int x = 48;
            bool expected = false;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int x = 10;
            bool expected = false;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            int x = 5;
            bool expected = true;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            int x = 77;
            bool expected = false;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            int x = 7;
            bool expected = true;
            //Act
            bool actual = Challenge97.IsPrime(x);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
