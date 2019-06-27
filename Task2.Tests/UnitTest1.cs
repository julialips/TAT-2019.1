using System;
using NUnit.Framework;

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
        [TestCase("прст", "прст")]
        [TestCase("аа", "аа")]
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
        public void TestIncorrectPressWord(string word)
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
        public void TestInvalidSimbolsFormatException(string word)
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
