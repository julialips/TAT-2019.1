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
        [TestCase("МОЛОКО+", "МАЛАКО")]
        public void TestMethod1(string word, string expected)
        {
            var conv = new Converter();
            var actual = conv.Convert(word);
            Assert.AreEqual(expected,actual);
        }

        [TestCase("молок+о")]
        public void TestStressAfterConsonantsBeforeVowels(string word)
        {
            var conv = new Converter();
            Assert.Throws<FormatException>
            (
                () => conv.Convert(word)
            );
        }

        [TestCase("мо+локо+")]
        public void TestTwoStress(string word)
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
            var conv = new Converter();
            Assert.Throws<FormatException>
            (
                () => conv.Convert(word)
            );
        }

        [TestCase("юля вика")]
        public void TesrTwoWords(string word)
        {
            var conv = new Converter();
            Assert.Throws<FormatException>
            (
                () => conv.Convert(word)
            );
        }

        [TestCase("*-1672")]
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
        //тест на два ударения

    }
}
