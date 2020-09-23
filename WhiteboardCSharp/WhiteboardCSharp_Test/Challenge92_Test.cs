using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge92_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string pin = "1234";
            bool expected = true;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string pin = "12345";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string pin = "a234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string pin = "";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string pin = "%234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string pin = "`234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string pin = "@234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string pin = "#234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string pin = "$234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string pin = "*234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            string pin = "5678";
            bool expected = true;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            string pin = "^234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            string pin = "(234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            string pin = ")234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            string pin = "123456";
            bool expected = true;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod16()
        {
            //Arrange
            string pin = "-234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod17()
        {
            //Arrange
            string pin = "_234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod18()
        {
            //Arrange
            string pin = "+234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod19()
        {
            //Arrange
            string pin = "=234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod20()
        {
            //Arrange
            string pin = "?234";
            bool expected = false;
            //Act
            bool actual = Challenge92.ValidatePIN(pin);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
