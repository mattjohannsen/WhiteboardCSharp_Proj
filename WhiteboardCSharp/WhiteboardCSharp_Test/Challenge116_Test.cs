using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge116_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int num = 6;
            bool expected = true;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int num = 28;
            bool expected = true;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int num = 496;
            bool expected = true;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int num = 8128;
            bool expected = true;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int num = 33550336;
            bool expected = true;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int num = 12;
            bool expected = false;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int num = 97;
            bool expected = false;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int num = 481;
            bool expected = false;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            int num = 1001;
            bool expected = false;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            int num = 55555;
            bool expected = false;
            //Act
            bool actual = Challenge116.CheckPerfect(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
