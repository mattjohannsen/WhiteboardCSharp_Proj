using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge132_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int num = 43;
            string expected = "Oddish";
            //Act
            string actual = Challenge132.OddishOrEvenish(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int num = 373;
            string expected = "Oddish";
            //Act
            string actual = Challenge132.OddishOrEvenish(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int num = 55551;
            string expected = "Oddish";
            //Act
            string actual = Challenge132.OddishOrEvenish(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int num = 694;
            string expected = "Oddish";
            //Act
            string actual = Challenge132.OddishOrEvenish(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int num = 4433;
            string expected = "Evenish";
            //Act
            string actual = Challenge132.OddishOrEvenish(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int num = 11;
            string expected = "Evenish";
            //Act
            string actual = Challenge132.OddishOrEvenish(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int num = 211112;
            string expected = "Evenish";
            //Act
            string actual = Challenge132.OddishOrEvenish(num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
