using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge83_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            object object1 = 1;
            object object2 = true;
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            object object1 = 0;
            object object2 = "0";
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            object object1 = 1;
            object object2 = 1;
            bool expected = true;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            object object1 = true;
            object object2 = true;
            bool expected = true;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            object object1 = "nmv";
            object object2 = "nmv";
            bool expected = true;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            object object1 = 0;
            object object2 = "";
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            object object1 = 1;
            object object2 = "1";
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            object object1 = 'h';
            object object2 = 'm';
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            object object1 = 'a';
            object object2 = 'a';
            bool expected = true;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            object object1 = 0;
            object object2 = false;
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            object object1 = 1.0;
            object object2 = 1.0;
            bool expected = true;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            object object1 = "str";
            object object2 = "rts";
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            object object1 = 'c';
            object object2 = "test";
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            object object1 = true;
            object object2 = "true";
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            object object1 = true;
            object object2 = false;
            bool expected = false;

            //Act
            bool actual = Challenge83.CheckEquality(object1, object2);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
