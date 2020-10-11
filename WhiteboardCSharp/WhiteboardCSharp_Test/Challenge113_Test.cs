using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge113_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string phrase = "What went wrong?????????";
            string expected = "What went wrong?";
            //Act
            string actual = Challenge113.NoYelling(phrase);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string phrase = "Oh my goodness!!!";
            string expected = "Oh my goodness!";
            //Act
            string actual = Challenge113.NoYelling(phrase);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string phrase = "WHAT!";
            string expected = "WHAT!";
            //Act
            string actual = Challenge113.NoYelling(phrase);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string phrase = "WHAT?";
            string expected = "WHAT?";
            //Act
            string actual = Challenge113.NoYelling(phrase);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string phrase = "Oh my goodness!?";
            string expected = "Oh my goodness!?";
            //Act
            string actual = Challenge113.NoYelling(phrase);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string phrase = "I just cannot believe it.";
            string expected = "I just cannot believe it.";
            //Act
            string actual = Challenge113.NoYelling(phrase);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string phrase = "I just!!! can!!! not!!! believe!!! it!!!";
            string expected = "I just!!! can!!! not!!! believe!!! it!";
            //Act
            string actual = Challenge113.NoYelling(phrase);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string phrase = "That's a ton!! of cheese!!!!";
            string expected = "That's a ton!! of cheese!";
            //Act
            string actual = Challenge113.NoYelling(phrase);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
