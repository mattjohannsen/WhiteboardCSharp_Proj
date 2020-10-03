using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge103_Test
    {
        [TestMethod]
        public void TestMethod0()
        {
            //Arrange
            int n = 0;
            decimal expected = 3;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 1;
            decimal expected = 3.1m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 2;
            decimal expected = 3.14m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int n = 3;
            decimal expected = 3.142m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int n = 4;
            decimal expected = 3.1416m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int n = 5;
            decimal expected = 3.14159m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int n = 6;
            decimal expected = 3.141593m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int n = 7;
            decimal expected = 3.1415927m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int n = 8;
            decimal expected = 3.14159265m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            int n = 9;
            decimal expected = 3.141592654m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            int n = 10;
            decimal expected = 3.1415926536m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            int n = 11;
            decimal expected = 3.14159265359m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            int n = 12;
            decimal expected = 3.141592653590m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            int n = 13;
            decimal expected = 3.1415926535898m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            int n = 14;
            decimal expected = 3.14159265358979m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            int n = 15;
            decimal expected = 3.141592653589793m;
            //Act
            decimal actual = Challenge103.MyPi(n);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
