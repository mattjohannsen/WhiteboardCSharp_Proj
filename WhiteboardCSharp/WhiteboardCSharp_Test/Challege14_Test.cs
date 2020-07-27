using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challege14_Test
    {
        [TestMethod]
        public void DoubleChar_FirstCase_ReturnsString()
        {
            //Arrange
            string initialString = "String";
            string expected = "SSttrriinngg";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoubleChar_SecondCase_ReturnsString()
        {
            //Arrange
            string initialString = "Hello World!";
            string expected = "HHeelllloo  WWoorrlldd!!";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoubleChar_ThirdCase_ReturnsString()
        {
            //Arrange
            string initialString = "1234!_ ";
            string expected = "11223344!!__  ";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoubleChar_FourthCase_ReturnsString()
        {
            //Arrange
            string initialString = "##^&%%*&%%$#@@!";
            string expected = "####^^&&%%%%**&&%%%%$$##@@@@!!";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoubleChar_SixthCase_ReturnsString()
        {
            //Arrange
            string initialString = "scandal";
            string expected = "ssccaannddaall";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoubleChar_SeventhCase_ReturnsString()
        {
            //Arrange
            string initialString = "economics";
            string expected = "eeccoonnoommiiccss";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoubleChar_EigthCase_ReturnsString()
        {
            //Arrange
            string initialString = " ";
            string expected = "  ";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoubleChar_NinthCase_ReturnsString()
        {
            //Arrange
            string initialString = "_______";
            string expected = "______________";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoubleChar_TenthCase_ReturnsString()
        {
            //Arrange
            string initialString = "equip gallon read";
            string expected = "eeqquuiipp  ggaalllloonn  rreeaadd";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void DoubleChar_EleventhCase_ReturnsString()
        {
            //Arrange
            string initialString = "baby increase";
            string expected = "bbaabbyy  iinnccrreeaassee";

            //Act
            string actual = Challenge14.DoubleChar(initialString);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
