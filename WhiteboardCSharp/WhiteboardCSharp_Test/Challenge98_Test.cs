using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge98_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "4 5 29 54 4 0 -214 542 -64 1 -3 6 -6";
            string expected = "542 -214";
            //Act
            string actual = Challenge98.HighLow(str);;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "1 -1";
            string expected = "1 -1";
            //Act
            string actual = Challenge98.HighLow(str);;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "-1 -1";
            string expected = "-1 -1";
            //Act
            string actual = Challenge98.HighLow(str);;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "1 -1 0";
            string expected = "1 -1";
            //Act
            string actual = Challenge98.HighLow(str);;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "1 1 0";
            string expected = "1 0";
            //Act
            string actual = Challenge98.HighLow(str);;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "-1 -1 0";
            string expected = "0 -1";
            //Act
            string actual = Challenge98.HighLow(str);;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "42";
            string expected = "42 42";
            //Act
            string actual = Challenge98.HighLow(str);;
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "1 1";
            string expected = "1 1";
            //Act
            string actual = Challenge98.HighLow(str);;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
