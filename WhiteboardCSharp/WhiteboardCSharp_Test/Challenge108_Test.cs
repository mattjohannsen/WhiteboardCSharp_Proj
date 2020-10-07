using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge108_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string n = "4";
            int k = 2;
            bool expected = true;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string n = "387420489";
            int k = 9;
            bool expected = true;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string n = "302875106592253";
            int k = 13;
            bool expected = true;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string n = "341427877364219557396646723584";
            int k = 22;
            bool expected = true;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string n = "1330877630632711998713399240963346255985889330161650994325137953641";
            int k = 41;
            bool expected = true;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string n = "369729637649726772657187905628805440595668764281741102430259972423552570455277523421410650010128232727940978889548326540119429996769494359451621570193644014418071060667659301384999779999159200499899";
            int k = 99;
            bool expected = true;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string n = "3124";
            int k = 5;
            bool expected = false;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string n = "17";
            int k = 3;
            bool expected = false;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string n = "823544";
            int k = 7;
            bool expected = false;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string n = "443426488243037769948249630619149892801";
            int k = 27;
            bool expected = false;
            //Act
            bool actual = Challenge108.KToK(n, k);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
