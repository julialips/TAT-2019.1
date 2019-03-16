using System;
using System.Collections.Generic;

namespace Task2
{
    /// <summary>
    /// Class , with contains methods to convert input word to phonemes
    /// </summary>
    class Converter
    {
        private const string YOT_LETTER = "й";
        private const string APOSTROPHE_SIGN = "'";

        private string word;

        private readonly List<char> softingVowels = new List<char> { 'е', 'ё', 'и', 'я', 'ю' };
        private readonly List<char> softVowels = new List<char> { 'е', 'ё', 'я', 'ю' };
        private readonly List<char> hardVowels = new List<char> { 'а', 'о', 'у', 'ы', 'э' };
        private readonly List<char> softConsonants = new List<char> { 'б', 'в', 'г', 'д', 'з', 'к', 'л', 'м', 'н',
            'п', 'р', 'с', 'т', 'ф', 'х' };
        private readonly List<char> hardSoftSigns = new List<char> { 'ь', 'ъ' };
        private readonly List<char> voicelessСonsonants = new List<char> { 'б', 'в', 'д', 'з', 'ж', 'г' };
        //private readonly List<char> sonants = new List<char> { 'б', 'в', 'д', 'з', 'ж', 'г' };
        private readonly Dictionary<char, char> dictVowels = new Dictionary<char, char>();
        private readonly Dictionary<char, char> dictСonsonants = new Dictionary<char, char>();

        public Converter()
        {
            dictVowels.Add('е', 'э');
            dictVowels.Add('ё', 'о');
            dictVowels.Add('я', 'а');
            dictVowels.Add('ю', 'у');
            dictСonsonants.Add('б', 'п');
            dictСonsonants.Add('в', 'ф');
            dictСonsonants.Add('д', 'т');
            dictСonsonants.Add('з', 'с');
            dictСonsonants.Add('ж', 'ш');
            dictСonsonants.Add('г', 'к');
        }

        private string ReplaceOneLetter(string str, int index, char replaceLetter)
        {
            var str1 = str.Substring(0, index);
            var str2 = str.Substring(index, 1);
            var str3 = str.Substring(index + 1);
            str2 = str2.Replace(str2[0], replaceLetter);
            return str1 + str2 + str3;
        }
        private string ReplaceOneLetter(string str, int index, string replaceLetter)
        {
            var str1 = str.Substring(0, index);
            var str2 = str.Substring(index, 1);
            var str3 = str.Substring(index + 1);
            str2 = str2.Replace(str2[0].ToString(), replaceLetter);
            return str1 + str2 + str3;
        }

        private string FirstLetter()
        {
            if (softVowels.Contains(word[0]))
            {
                word = YOT_LETTER + ReplaceOneLetter(word, 0, dictVowels[word[0]]);
            }
            return word;
        }
        private string ConvertOtoA()
        {
            word = word.Replace('о', 'а');
            word = word.Replace("а+", "о+");
            word = word.Replace("+", string.Empty);
            return word;
        }
        private string Softing()
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (softingVowels.Contains(word[i]) && softConsonants.Contains(word[i - 1]))
                {
                    word = word.Insert(word.IndexOf((word[i]), i), APOSTROPHE_SIGN);
                    i++;
                    word = ReplaceOneLetter(word, i, dictVowels[word[i]]);
                }
            }
            return word;
        }
        private string VowelAfterVowel()
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (softingVowels.Contains(word[i]) && hardVowels.Contains(word[i - 1]))
                {
                    word = ReplaceOneLetter(word, i, YOT_LETTER + dictVowels[word[i]]);
                }
            }
            return word;
        }
        private string VowelAfterSoftHardSign()
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (softingVowels.Contains(word[i]) && hardSoftSigns.Contains(word[i - 1]))
                {
                    word = ReplaceOneLetter(word, i - 1, APOSTROPHE_SIGN);
                    word = ReplaceOneLetter(word, i, YOT_LETTER + dictVowels[word[i]]);
                }
            }
            return word;
        }
        private string Voicing()
        {
            for (int i = 1; i < word.Length; i++)
            {
                if (voicelessСonsonants.Contains(word[i]) && hardVowels.Contains(word[i - 1]))
                {
                    word = ReplaceOneLetter(word, i, dictСonsonants[word[i]]);
                }
            }
            return word;
        }
        private string SoftingLast()
        {
            if (hardSoftSigns.Contains(word[word.Length - 1]))
            {
                word = ReplaceOneLetter(word, word.Length - 1, APOSTROPHE_SIGN);
            }
            return word;
        }

        public string Convert(string word)
        {
            this.word = word;
            FirstLetter();
            ConvertOtoA();
            Softing();
            VowelAfterVowel();
            Voicing();
            VowelAfterSoftHardSign();
            SoftingLast();
            return this.word;
        }
    }
}



