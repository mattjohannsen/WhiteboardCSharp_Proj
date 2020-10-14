using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge114_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "1/2";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "7/4";
            bool expected = true;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "10/10";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "12/30";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "28/3";
            bool expected = true;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "35/31";
            bool expected = true;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "11/27";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "42/32";
            bool expected = true;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string str = "34/15";
            bool expected = true;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string str = "16/16";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            string str = "38/41";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            string str = "45/43";
            bool expected = true;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            string str = "13/38";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            string str = "43/2";
            bool expected = true;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            string str = "16/31";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod16()
        {
            //Arrange
            string str = "16/31";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod17()
        {
            //Arrange
            string str = "2/38";
            bool expected = false;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod18()
        {
            //Arrange
            string str = "37/21";
            bool expected = true;
            //Act
            bool actual = Challenge114.GreaterThanOne(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
