using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge106_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string path = "C:/Projects/pil_tests/ascii/edabit.txt";
            string expected = "edabit.txt";
            //Act
            string actual = Challenge106.GetFilename(path);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string path = "C:/Users/johnsmith/Music/Beethoven_5.mp3";
            string expected = "Beethoven_5.mp3";
            //Act
            string actual = Challenge106.GetFilename(path);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string path = "ffprobe.exe";
            string expected = "ffprobe.exe";
            //Act
            string actual = Challenge106.GetFilename(path);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string path = "Music/Drafts/unfinished2.midi";
            string expected = "unfinished2.midi";
            //Act
            string actual = Challenge106.GetFilename(path);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string path = "C:/Users/chad/OneDrive/Desktop/Atom.lnk";
            string expected = "Atom.lnk";
            //Act
            string actual = Challenge106.GetFilename(path);
            //Assert
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string path = "senoron/OneDrive/Desktop/DDLC-1.1.1-pc/lib/windows-i686/DDLC.exe";
            string expected = "DDLC.exe";
            //Act
            string actual = Challenge106.GetFilename(path);
            //Assert
            Assert.AreEqual(actual, expected);
        }
    }
}
