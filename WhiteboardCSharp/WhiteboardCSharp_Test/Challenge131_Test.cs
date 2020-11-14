using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge131_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "Reverse";
            string expected = "esreveR";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "This is a typical sentence.";
            string expected = "This is a lacipyt .ecnetnes";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "The dog is big.";
            string expected = "The dog is big.";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "Reverse the order of every word greater than or equal to five characters.";
            string expected = "esreveR the redro of yreve word retaerg than or lauqe to five .sretcarahc";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "Lets all be unique together until we realise we are all the same.";
            string expected = "Lets all be euqinu rehtegot litnu we esilaer we are all the .emas";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "The old apple revels in its authority.";
            string expected = "The old elppa slever in its .ytirohtua";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "The shooter says goodbye to his love.";
            string expected = "The retoohs says eybdoog to his .evol";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "Please wait outside of the house.";
            string expected = "esaelP wait edistuo of the .esuoh";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string str = "Two seats were vacant.";
            string expected = "Two staes were .tnacav";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string str = "Sixty-Four comes asking for bread.";
            string expected = "ruoF-ytxiS semoc gniksa for .daerb";
            //Act
            string actual = Challenge131.Reverse(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
