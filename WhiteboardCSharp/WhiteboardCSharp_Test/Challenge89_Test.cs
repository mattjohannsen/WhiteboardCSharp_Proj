using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge89_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int num = 23;
            bool expected = false;

            //Act
            bool actual = Challenge89.IsSymmetrical(num);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int num = 9562;
            bool expected = false;

            //Act
            bool actual = Challenge89.IsSymmetrical(num);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int num = 10019;
            bool expected = false;

            //Act
            bool actual = Challenge89.IsSymmetrical(num);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int num = 1;
            bool expected = true;

            //Act
            bool actual = Challenge89.IsSymmetrical(num);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            int num = 3223;
            bool expected = true;

            //Act
            bool actual = Challenge89.IsSymmetrical(num);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            int num = 95559;
            bool expected = true;

            //Act
            bool actual = Challenge89.IsSymmetrical(num);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            int num = 66566;
            bool expected = true;

            //Act
            bool actual = Challenge89.IsSymmetrical(num);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
