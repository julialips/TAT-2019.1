﻿using System;
using System.Collections.Generic;

namespace Task2
{
    /// <summary>
    /// Class , with contains methods to convert input word to phonemes
    /// </summary>
    public class Converter
    {
        private const string YOT_LETTER = "й";
        private const string APOSTROPHE_SIGN = "'";

        private string word;

        private readonly List<char> softingVowels = new List<char> { 'е', 'ё', 'и', 'я', 'ю' };
        private readonly List<char> softVowels = new List<char> { 'е', 'ё', 'я', 'ю' };
        private readonly List<char> hardVowels = new List<char> { 'а', 'о', 'у', 'ы', 'э' };
        private readonly List<char> softConsonants = new List<char> { 'б', 'в', 'г', 'д', 'з', 'к', 'л', 'м',
            'н', 'п', 'р', 'с', 'т', 'ф', 'х' };
        private readonly List<char> hardSoftSigns = new List<char> { 'ь', 'ъ' };
        private readonly List<char> stress = new List<char> { '+' };
        private readonly List<char> voicelessСonsonants = new List<char> { 'б', 'в', 'д', 'з', 'ж', 'г' };
        private readonly List<char> deafСonsonants = new List<char> { 'с', 'к', 'п', 'ф', 'т', 'ш' };
       
        private readonly Dictionary<char, char> dictVowels = new Dictionary<char, char>();
        private readonly Dictionary<char, char> dictСonsonants = new Dictionary<char, char>();
        private readonly Dictionary<char, char> dictСonsonantsToVoicing = new Dictionary<char, char>();

        /// <summary>
        /// method,which add simbols in dictionary 
        /// </summary>
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
            dictСonsonantsToVoicing.Add('п', 'б');
            dictСonsonantsToVoicing.Add('ф', 'в');
            dictСonsonantsToVoicing.Add('т', 'д');
            dictСonsonantsToVoicing.Add('с', 'з');
            dictСonsonantsToVoicing.Add('ш', 'ж');
            dictСonsonantsToVoicing.Add('к', 'г');
        }

        /// <summary>
        /// method, which voicing deaf consonants before voiceless consonants
        /// </summary>
        /// <returns> word </returns>
        private string VoicingDeafConsonantsBeforeVoicelessConsonants()
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (deafСonsonants.Contains(word[i]) && voicelessСonsonants.Contains(word[i + 1]))
                {
                        word = ReplaceOneLetter(word, i, dictСonsonantsToVoicing[word[i]]);
                }
            }
            return word;
        }

            /// <summary>
            /// method, witch deafen voice consonant
            /// </summary>
            /// <returns></returns>
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

        /// <summary>
        /// universal method for replasing simbol char
        /// </summary>
        /// <param name="str"></param>
        /// <param name="index"></param>
        /// <param name="replaceLetter"></param>
        /// <returns></returns>
        private string ReplaceOneLetter(string str, int index, char replaceLetter)
        {
            var str1 = str.Substring(0, index);
            var str2 = str.Substring(index, 1);
            var str3 = str.Substring(index + 1);
            str2 = str2.Replace(str2[0], replaceLetter);
            return str1 + str2 + str3;
        }

        /// <summary>
        /// universal method for replasing simbol type string
        /// </summary>
        /// <param name="str"> string witch we cut </param>
        /// <param name="index"> from this index</param>
        /// <param name="replaceLetter"> letter on witch replace</param>
        /// <returns></returns>        
        private string ReplaceOneLetter(string str, int index, string replaceLetter)
        {
            var str1 = str.Substring(0, index);
            var str2 = str.Substring(index, 1);
            var str3 = str.Substring(index + 1);
            str2 = str2.Replace(str2[0].ToString(), replaceLetter);
            return str1 + str2 + str3;
        }

        /// <summary>
        /// method, witch convert first soft vowels 
        /// and two vowel in pair of 2 soft vowels
        /// </summary>
        /// <returns></returns>
        private string FirstLetter()
        {
            if (softVowels.Contains(word[0]))
            {
                word = YOT_LETTER + ReplaceOneLetter(word, 0, dictVowels[word[0]]);
            }
            return word;
        }

        /// <summary>
        /// method for converting unstress O to A
        /// </summary>
        /// <returns></returns>
        private string ConvertOtoA()
        {
            word = word.Replace('о', 'а');
            word = word.Replace("а+", "о+");
            word = word.Replace("+", string.Empty);
            return word;
        }

        /// <summary>
        /// this method for softing consonants before vowels by '
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// method ,witch convert word after hard vowels before soft vowels 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// method ,witch convert word after Ь,Ъ letters 
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// method for converting hard and soft signs to '
        /// </summary>
        /// <returns></returns>
        private string SoftingLast()
        {
            if (hardSoftSigns.Contains(word[word.Length - 1]))
            {
                word = ReplaceOneLetter(word, word.Length - 1, APOSTROPHE_SIGN);
            }
            return word;
        }

        /// <summary>
        /// method which checking validation our word
        /// </summary>
        /// <returns> word or exeption </returns>
        private string Validation()
        {
            string invalidSimbols = ".,#@!&*%$1234567890/-";
            for (int i = 0; i < word.Length; i++)
            {
                if (invalidSimbols.Contains(word.Substring(i, 1)))
                {
                    throw new FormatException();
                }
            }
            return word;
        }

        /// <summary>
        /// method, which check english simbols , and if found, thow exception
        /// </summary>
        /// <returns> word </returns>
        private string ValidationEnglishSimbols()
        {    
            string english = "abcdifjgklmnprstuyfhsqweozxv";
            for (int i = 0; i < word.Length; i++)
            {
                if (english.Contains(word.Substring(i, 1)))
                {
                    throw new FormatException();
                }
            }
            return word;
        }

        /// <summary>
        /// method ,which throw exeption,when it finds plus(stress) after consonants
        /// </summary>
        /// <returns> word </returns>
        private string CheckPlusAfterConsonants()
        {
            for (int i = 0; i < word.Length; i++)
            { 
                if (softConsonants.Contains(word[i]) && stress.Contains(word[i + 1]))
                {
                    throw new FormatException();
                }
            }
           return word;
        }

        /// <summary>
        /// Method, which check two or more stress and throw new exception
        /// </summary>
        /// <returns> word </returns>
        private string CheckTwoPlus()
        {
            string plus = "++";
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (plus.Contains(word.Substring(i, 1)))
                {
                    count++;
                }
                if (count > 1)
                {
                    throw new FormatException();
                }
            }
           return word;
        }
            /// <summary>
            /// one big method, consist al little methods for converting
            /// </summary>
            /// <param name="word"></param>
            /// <returns></returns>
            public string Convert(string word)
        {
            this.word = word;
            Validation();
            ValidationEnglishSimbols();
            CheckPlusAfterConsonants();
            CheckTwoPlus();
            VoicingDeafConsonantsBeforeVoicelessConsonants();
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



