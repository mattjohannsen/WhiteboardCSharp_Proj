using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge94_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "potato";
            int expected = 1;
            //Act
            int actual = Challenge94.Potatoes(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "potatopotatocherry";
            int expected = 2;
            //Act
            int actual = Challenge94.Potatoes(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "potatopotatopotatoorange";
            int expected = 3;
            //Act
            int actual = Challenge94.Potatoes(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "potatopotatobananapotatopotato";
            int expected = 4;
            //Act
            int actual = Challenge94.Potatoes(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "potatopotatomangopotatopotatopotato";
            int expected = 5;
            //Act
            int actual = Challenge94.Potatoes(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "potatocucumberpotatopotatopotatopotatopotato";
            int expected = 6;
            //Act
            int actual = Challenge94.Potatoes(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
