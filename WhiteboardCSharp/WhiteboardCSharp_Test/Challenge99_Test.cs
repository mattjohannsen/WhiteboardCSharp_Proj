using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge99_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int[] values = { 19, 5, 42, 2, 77 };
            int expected = 7;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int[] values = { 10, 343445353, 3453445, 345354534 };
            int expected = 3453455;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int[] values = { 2, 9, 6, -1 };
            int expected = 8;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int[] values = { 879, 953, 694, -847, 342, 221, -91, -723, 791, -587 };
            int expected = 563;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int[] values = { 3683, 2902, 3951, -475, 1617, -2385 };
            int expected = 4519;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int[] values = { 280, 134, 108 };
            int expected = 242;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int[] values = { 280, 134, 108, 1 };
            int expected = 109;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            int[] values = { 321, 406, -176 };
            int expected = 727;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            int[] values = { 1, 1, 1, 1 };
            int expected = 2;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            int[] values = { -1, -1, 1, 1 };
            int expected = 2;
            //Act
            int actual = Challenge99.SumSmallest(values);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
