using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge118_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string sentence = "I am Ne mo Nemo !";
            string expected = "I found Nemo at 5!";
            //Act
            string actual = Challenge118.FindNemo(sentence);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string sentence = "N e m o is NEMO NeMo Nemo !";
            string expected = "I found Nemo at 8!";
            //Act
            string actual = Challenge118.FindNemo(sentence);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string sentence = "I am Nemo's dad Nemo senior .";
            string expected = "I found Nemo at 5!";
            //Act
            string actual = Challenge118.FindNemo(sentence);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string sentence = "Oh, hello !";
            string expected = "I can't find Nemo :(";
            //Act
            string actual = Challenge118.FindNemo(sentence);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string sentence = "Is it Nemos, Nemona, Nemoor or Garfield?";
            string expected = "I can't find Nemo :(";
            //Act
            string actual = Challenge118.FindNemo(sentence);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string sentence = "Nemo is a clown fish, he has white and orange stripes. Nemo , come back!";
            string expected = "I found Nemo at 1!";
            //Act
            string actual = Challenge118.FindNemo(sentence);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
