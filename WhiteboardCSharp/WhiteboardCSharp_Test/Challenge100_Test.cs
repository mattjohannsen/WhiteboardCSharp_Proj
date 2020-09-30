using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge100_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "Algorism";
            bool expected = true;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "PasSword";
            bool expected = false;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "Dermatoglyphics";
            bool expected = true;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "Cat";
            bool expected = true;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "Filmography";
            bool expected = true;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "Consecutive";
            bool expected = false;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "Bankruptcies";
            bool expected = true;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "Unforgivable";
            bool expected = true;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string str = "Unpredictably";
            bool expected = true;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string str = "Moose";
            bool expected = false;
            //Act
            bool actual = Challenge100.IsIsogram(str);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
