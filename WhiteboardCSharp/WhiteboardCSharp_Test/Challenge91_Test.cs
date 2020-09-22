using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge91_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "4556364607935616";
            string expected = "############5616";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "64607935616";
            string expected = "#######5616";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "1";
            string expected = "1";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "";
            string expected = "";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "tBy>L/cMe+?<j:6n;C~H";
            string expected = "################;C~H";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "12";
            string expected = "12";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "8Ikhlf6yoxPOwi5cB014eWbRumj7vJ";
            string expected = "##########################j7vJ";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "123";
            string expected = "123";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string str = ")E$aCU=e\"_";
            string expected = "######=e\"_";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string str = "2673951408";
            string expected = "######1408";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod11()
        {
            //Arrange
            string str = "1234";
            string expected = "1234";

            //Act
            string actual = Challenge91.Maskify(str);

            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
