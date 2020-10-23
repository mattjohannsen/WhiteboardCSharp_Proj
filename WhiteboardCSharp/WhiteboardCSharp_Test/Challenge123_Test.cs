using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge123_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "@edabit.com";
            bool expected = false;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "@edabit";
            bool expected = false;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "matt@edabit.com";
            bool expected = true;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "";
            bool expected = false;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "hello.gmail@com";
            bool expected = false;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "bill.gates@microsoft.com";
            bool expected = true;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "hello@email";
            bool expected = false;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "%^%$#%^%";
            bool expected = false;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string str = "www.email.com";
            bool expected = false;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string str = "email";
            bool expected = false;
            //Act
            bool actual = Challenge123.ValidateEmail(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
