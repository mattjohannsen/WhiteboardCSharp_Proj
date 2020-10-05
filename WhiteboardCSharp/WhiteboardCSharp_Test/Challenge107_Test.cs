using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge107_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "(123) 456-7890";
            bool expected = true;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "(1111)555 2345";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "(098) 123 4567";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "(123)456-7890";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "abc(123)456-7890";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "(123)456-7890abc";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "abc(123)456-7890abc";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "abc(123) 456-7890";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string str = "(123) 456-7890abc";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string str = "abc(123) 456-7890abc";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            string str = "(123)_456-7890";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            string str = "(123)_456-7890 ";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            string str = "-123) 456-7890";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            string str = "(519) 505-6498";
            bool expected = false;
            //Act
            bool actual = Challenge107.IsValidPhoneNumber(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
