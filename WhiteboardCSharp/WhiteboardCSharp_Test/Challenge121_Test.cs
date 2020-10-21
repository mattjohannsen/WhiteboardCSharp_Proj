using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge121_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "The quick brown fox!";
            string expected = "The quick brown fox";
            //Act
            string actual = Challenge121.RemoveSpecialCharacters(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "%fd76$fd(-)6GvKlO.";
            string expected = "fd76fd-6GvKlO";
            //Act
            string actual = Challenge121.RemoveSpecialCharacters(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "D0n$c sed 0di0 du1";
            string expected = "D0nc sed 0di0 du1";
            //Act
            string actual = Challenge121.RemoveSpecialCharacters(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "cat_pic.jpeg";
            string expected = "cat_picjpeg";
            //Act
            string actual = Challenge121.RemoveSpecialCharacters(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "519-555-8093";
            string expected = "519-555-8093";
            //Act
            string actual = Challenge121.RemoveSpecialCharacters(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "h-d+=rf[]_{}<>.,`~!@#$%^&*(|)";
            string expected = "h-drf_";
            //Act
            string actual = Challenge121.RemoveSpecialCharacters(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "Etiam#!!!!!,,, [`po%rta ~sem!] {male*su-ada} (ma*gna) mo^llis... eui$smod???";
            string expected = "Etiam porta sem malesu-ada magna mollis euismod";
            //Act
            string actual = Challenge121.RemoveSpecialCharacters(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
