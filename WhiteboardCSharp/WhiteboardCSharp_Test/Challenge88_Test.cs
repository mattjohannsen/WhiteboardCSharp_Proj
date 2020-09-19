using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge88_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string left = "maga";
            string right = "zine";
            string expected = "Magazine";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string left = "reli";
            string right = "able";
            string expected = "Reliable";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string left = "impl";
            string right = "icit";
            string expected = "Implicit";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string left = "docu";
            string right = "ment";
            string expected = "Document";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string left = "oppo";
            string right = "site";
            string expected = "Opposite";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string left = "offi";
            string right = "cial";
            string expected = "Official";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string left = "disa";
            string right = "gree";
            string expected = "Disagree";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string left = "sssssssss";
            string right = "sssssssss";
            string expected = "sssssssss";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string left = "acci";
            string right = "dent";
            string expected = "Accident";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string left = "omis";
            string right = "sion";
            string expected = "Omission";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            string left = "vigo";
            string right = "rous";
            string expected = "Vigorous";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod12()
        {
            //Arrange
            string left = "pred";
            string right = "ator";
            string expected = "Predator";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod13()
        {
            //Arrange
            string left = "prog";
            string right = "ress";
            string expected = "Progress";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod14()
        {
            //Arrange
            string left = "inva";
            string right = "sion";
            string expected = "Invasion";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod15()
        {
            //Arrange
            string left = "fare";
            string right = "well";
            string expected = "Farewell";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod16()
        {
            //Arrange
            string left = "majo";
            string right = "rity";
            string expected = "Majority";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod17()
        {
            //Arrange
            string left = "pers";
            string right = "onal";
            string expected = "Personal";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod18()
        {
            //Arrange
            string left = "sequ";
            string right = "ence";
            string expected = "Sequence";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod19()
        {
            //Arrange
            string left = "gove";
            string right = "rnor";
            string expected = "Governor";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod20()
        {
            //Arrange
            string left = "igno";
            string right = "rant";
            string expected = "Ignorant";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod21()
        {
            //Arrange
            string left = "fini";
            string right = "shed";
            string expected = "Finished";
            //Act
            string actual = Challenge88.GetWord(left, right);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
