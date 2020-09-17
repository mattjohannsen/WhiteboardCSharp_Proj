using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge86_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "test";
            string expected = "es";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "testing";
            string expected = "t";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "middle";
            string expected = "dd";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "A";
            string expected = "A";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "inhabitant";
            string expected = "bi";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "brown";
            string expected = "o";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "pawn";
            string expected = "aw";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "cabinet";
            string expected = "i";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string str = "fresh";
            string expected = "e";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string str = "shorts";
            string expected = "or";

            //Act
            string actual = Challenge86.GetMiddle(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
//[TestCase("test", Result = "es")]
//[TestCase("testing", Result = "t")]
//[TestCase("middle", Result = "dd")]
//[TestCase("A", Result = "A")]
//[TestCase("inhabitant", Result = "bi")]
//[TestCase("brown", Result = "o")]
//[TestCase("pawn", Result = "aw")]
//[TestCase("cabinet", Result = "i")]
//[TestCase("fresh", Result = "e")]
//[TestCase("shorts", Result = "or")] 