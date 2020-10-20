using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge119_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int num = 3;
            string expected = "yes";
            //Act
            string actual = Challenge119.IsPrime(primes, num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int num = 4;
            string expected = "no";
            //Act
            string actual = Challenge119.IsPrime(primes, num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int num = 67;
            string expected = "yes";
            //Act
            string actual = Challenge119.IsPrime(primes, num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            int[] primes = { 2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41, 43, 47, 53, 59, 61, 67, 71, 73, 79, 83, 89, 97 };
            int num = 36;
            string expected = "no";
            //Act
            string actual = Challenge119.IsPrime(primes, num);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
