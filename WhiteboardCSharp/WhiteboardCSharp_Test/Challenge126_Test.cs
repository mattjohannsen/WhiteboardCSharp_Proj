using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WhiteboardCSharp;

namespace WhiteboardCSharp_Test
{
    [TestClass]
    public class Challenge126_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string str = "abcd";
            string expected = "A-Bb-Ccc-Dddd";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod2()
        {
            //Arrange
            string str = "RqaEzty";
            string expected = "R-Qq-Aaa-Eeee-Zzzzz-Tttttt-Yyyyyyy";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod3()
        {
            //Arrange
            string str = "cwAt";
            string expected = "C-Ww-Aaa-Tttt";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod4()
        {
            //Arrange
            string str = "VgyCdnQa";
            string expected = "V-Gg-Yyy-Cccc-Ddddd-Nnnnnn-Qqqqqqq-Aaaaaaaa";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod5()
        {
            //Arrange
            string str = "nRBSdNOsMl";
            string expected = "N-Rr-Bbb-Ssss-Ddddd-Nnnnnn-Ooooooo-Ssssssss-Mmmmmmmmm-Llllllllll";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod6()
        {
            //Arrange
            string str = "nuE";
            string expected = "N-Uu-Eee";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod7()
        {
            //Arrange
            string str = "RlDrhZuQaqsoHEfziByObtMxkFCJVe";
            string expected = "R-Ll-Ddd-Rrrr-Hhhhh-Zzzzzz-Uuuuuuu-Qqqqqqqq-Aaaaaaaaa-Qqqqqqqqqq-Sssssssssss-Oooooooooooo-Hhhhhhhhhhhhh-Eeeeeeeeeeeeee-Fffffffffffffff-Zzzzzzzzzzzzzzzz-Iiiiiiiiiiiiiiiii-Bbbbbbbbbbbbbbbbbb-Yyyyyyyyyyyyyyyyyyy-Oooooooooooooooooooo-Bbbbbbbbbbbbbbbbbbbbb-Tttttttttttttttttttttt-Mmmmmmmmmmmmmmmmmmmmmmm-Xxxxxxxxxxxxxxxxxxxxxxxx-Kkkkkkkkkkkkkkkkkkkkkkkkk-Ffffffffffffffffffffffffff-Ccccccccccccccccccccccccccc-Jjjjjjjjjjjjjjjjjjjjjjjjjjjj-Vvvvvvvvvvvvvvvvvvvvvvvvvvvvv-Eeeeeeeeeeeeeeeeeeeeeeeeeeeeee";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod8()
        {
            //Arrange
            string str = "EXpzPFx";
            string expected = "E-Xx-Ppp-Zzzz-Ppppp-Ffffff-Xxxxxxx";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod9()
        {
            //Arrange
            string str = "NU";
            string expected = "N-Uu";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestMethod10()
        {
            //Arrange
            string str = "g";
            string expected = "G";
            //Act
            string actual = Challenge126.Accum(str);
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
