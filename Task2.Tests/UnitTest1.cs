using System;
using NUnit.Framework;
using Task2;
namespace Task2.Tests
{
    [TestFixture]
    public class UnitTest1
    {
        [TestCase("молоко+", "малако")]
        [TestCase("яйцо+", "йайцо")]
        [TestCase("ме+сто", "м'эста")]
        [TestCase("сде+лать", "зд'элат'")]
        [TestCase("я", "йа")]
        [TestCase("я+", "йа")]
        public void TestMethod1(string word, string expected)
        {
            var conv = new Converter();
            var actual = conv.Convert(word);
            Assert.AreEqual(expected,actual);
        }

        [TestCase("МОЛОКО+","МАЛАКО")]
        [TestCase("мОлОКо+","мАлАКо")]
        public void BigLetters(string word, string expected)
        {
            var conv = new Converter();
            var actual = conv.Convert(word);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("молок+о")]
        [TestCase("+молоко")]
        [TestCase("мо+локо+")]
        public void TestIncorrectWord(string word)
        {
            var conv = new Converter();
            Assert.Throws<FormatException>
            (
                () => conv.Convert(word)
            );
        }

        [TestCase(null)]
        public void TestNullString(string word)
        {
            Assert.Throws<Exception>
            (
                () => new Converter()
            );
        }

        [TestCase("юля вика","йул'a")]
        public void TestTwoWords(string word, string expected)
        {
            var conv = new Converter();
            var actual = conv.Convert(word);
            Assert.AreEqual(expected, actual);
        }

        [TestCase("*-1092")]
        [TestCase("молоко+*-1672")]
        public void TestInvalidSimbols(string word)
        {
            var conv = new Converter();
            Assert.Throws<FormatException>
             (
                () => conv.Convert(word)
             );
        }

        [TestCase("b")]
        [TestCase("mother")]
        public void TestNotRussianSimbols(string simbol)
        {
            var conv = new Converter();
           
                Assert.Throws<FormatException>
            (
                () => conv.Convert(simbol)
            );
        }
    }
}
