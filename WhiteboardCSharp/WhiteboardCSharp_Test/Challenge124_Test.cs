using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge124_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "I am a title";
            string expected = "I Am A Title";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "I AM A TITLE";
            string expected = "I AM A TITLE";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "i aM a tITLE";
            string expected = "I AM A TITLE";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "the first letter of every word is capitalized";
            string expected = "The First Letter Of Every Word Is Capitalized";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "I Like Pizza";
            string expected = "I Like Pizza";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "Don't count your ChiCKens BeFore They HatCh";
            string expected = "Don't Count Your ChiCKens BeFore They HatCh";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "All generalizations are false, including this one";
            string expected = "All Generalizations Are False, Including This One";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "Me and my wife lived happily for twenty years and then we met.";
            string expected = "Me And My Wife Lived Happily For Twenty Years And Then We Met.";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string str = "There are no stupid questions, just stupid people.";
            string expected = "There Are No Stupid Questions, Just Stupid People.";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string str = "1f you c4n r34d 7h15, you r34lly n33d 2 g37 l41d";
            string expected = "1f You C4n R34d 7h15, You R34lly N33d 2 G37 L41d";
            //Act
            string actual = Challenge124.MakeTitle(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
