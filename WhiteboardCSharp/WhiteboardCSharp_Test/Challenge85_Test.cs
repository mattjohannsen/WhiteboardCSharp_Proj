using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge85_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string txt = "There is a bomb.";
            string expected = "Duck!!!";

            //Act
            string actual = Challenge85.Bomb(txt);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod2()
        {
            //Arrange
            string txt = "Hey, did you find it?";
            string expected = "Hey, did you find it?";

            //Act
            string actual = Challenge85.Bomb(txt);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod3()
        {
            //Arrange
            string txt = "Hey, did you think there is a bomb?";
            string expected = "Duck!!!";

            //Act
            string actual = Challenge85.Bomb(txt);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod4()
        {
            //Arrange
            string txt = "Hey, did you think there is a bomb?";
            string expected = "Hey, did you find it?";

            //Act
            string actual = Challenge85.Bomb(txt);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod5()
        {
            //Arrange
            string txt = "Hey, did you find the BoMb?";
            string expected = "Duck!!!";

            //Act
            string actual = Challenge85.Bomb(txt);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        public void TestMethod6()
        {
            //Arrange
            string txt = "Commotion in the third, a bomb is found!";
            string expected = "Duck!!!";

            //Act
            string actual = Challenge85.Bomb(txt);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
