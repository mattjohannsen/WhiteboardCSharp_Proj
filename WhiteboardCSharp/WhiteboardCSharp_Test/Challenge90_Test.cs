using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge90_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int n = 1;
            int expected = 1;

            //Act
            int actual = Challenge90.StackBoxes(n);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int n = 2;
            int expected = 4;

            //Act
            int actual = Challenge90.StackBoxes(n);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int n = 0;
            int expected = 0;

            //Act
            int actual = Challenge90.StackBoxes(n);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int n = 5;
            int expected = 25;

            //Act
            int actual = Challenge90.StackBoxes(n);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int n = 27;
            int expected = 729;

            //Act
            int actual = Challenge90.StackBoxes(n);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int n = 196;
            int expected = 38416;

            //Act
            int actual = Challenge90.StackBoxes(n);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int n = 512;
            int expected = 262144;

            //Act
            int actual = Challenge90.StackBoxes(n);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
