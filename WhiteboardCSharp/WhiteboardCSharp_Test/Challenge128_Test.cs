using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge128_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "lorem ipsum";
            string expected = "LEREM EPSEM";
            //Act
            string actual = Challenge128.ToScottishScreaming(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "Leeroy jenkins!";
            string expected = "LEEREY JENKENS!";
            //Act
            string actual = Challenge128.ToScottishScreaming(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "A, wonderful, day, don't, you, think?";
            string expected = "E, WENDERFEL, DEY, DEN'T, YEE, THENK?";
            //Act
            string actual = Challenge128.ToScottishScreaming(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "Hello world";
            string expected = "HELLE WERLD";
            //Act
            string actual = Challenge128.ToScottishScreaming(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "start queueing you oafs";
            string expected = "STERT QEEEEENG YEE EEFS";
            //Act
            string actual = Challenge128.ToScottishScreaming(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
