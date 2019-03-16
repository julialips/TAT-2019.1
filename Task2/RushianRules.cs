using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Task2
{
    /// <summary>
    /// class contains the methods of searching and displaying phonemes
    /// </summary>
    class RushianRules
    {
       
        private int accent = -1;
        private string simbol = string.Empty;
        private StringBuilder phonemes = new StringBuilder();


        private readonly List<char> vowels = new List<char>
        {
            'а', 'е', 'ё', 'и', 'о', 'у', 'ы', 'э',  'ю', 'я'
        };
        private readonly List<char> consonants = new List<char>
        {
            'б', 'в', 'г', 'д', 'ж', 'з', 'й', 'к', 'л', 'м', 'н', 'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ч', 'ш', 'щ'
        };

        private readonly Dictionary <char, char> vowelBeforeConsonant = new Dictionary<char, char>
        {
            ['е'] = 'э',
            ['ё'] = 'о',
            ['ю'] = 'у',
            ['я'] = 'а',
        };
        private readonly Dictionary <char, string> vowelBeforeVowel = new Dictionary<char, string>
        {
            ['е'] = "йэ",
            ['ё'] = "йо",
            ['ю'] = "йу",
            ['я'] = "йа",    
        };
        private readonly Dictionary <char, char> RingingDeaf = new Dictionary<char, char>
        {
            ['б'] = 'п',
            ['в'] = 'ф',
            ['г'] = 'к',
            ['д'] = 'т',
            ['ж'] = 'ш',
            ['з'] = 'с'
        };


        /// <summary>
        /// constructor our class
        /// </summary>
        /// <param name="line"></param>
        public RushianRules(string line)
        {
            simbol = line;
        }

        public StringBuilder Define()
        {
            if (simbol.Contains('+'))
            {
                accent = simbol.IndexOf('+') - 1;
                simbol = simbol.Remove(simbol.IndexOf('+'), 1);
            }

            for (int i = 0; i < simbol.Length; i++)
            {
                switch (DefineTypeOfSymbol(simbol[i], vowels, consonants))
                {
                    case "vowel":

                        if (i != 0 && DefineTypeOfSymbol(simbol[i - 1], vowels, consonants) ==
                            "consonant" && vowelBeforeConsonant.ContainsKey(simbol[i]))
                        {
                            // Add value to phonemes.
                            phonemes.Append("'" + vowelBeforeConsonant[simbol[i]]);
                            continue;

                        }
                        else if (vowelBeforeVowel.ContainsKey(simbol[i]))
                        {
                            phonemes.Append(vowelBeforeVowel[simbol[i]]);
                            continue;
                        }

                        // Go if dictionaries don't contains this vowel.
                      
                        continue;


                    case "different":
                        // If  'ъ', continue.
                        if (simbol[i] == 'ь')
                        {
                            phonemes.Append("'");
                        }
                        continue;
                }
            }
            return phonemes;
        }

        public string DefineTypeOfSymbol(char simbol, List<char> vowels, List<char> consonants)
        {
            if (vowels.Contains(simbol))
            {
                return "vowel";
            }
            else if (consonants.Contains(simbol))
            {
                return "consonant";
            }
            return "different";
        }

        public void AddOtherLetter(int index, char simbol, int accent, ref StringBuilder phonemes)
        {
            if (simbol == 'о' && index != accent)
            {
                phonemes.Append("а");
                return;
            }
            phonemes.Append(simbol);
        }


        public void PrintPhonemes(StringBuilder phonemes)
        {
            Console.WriteLine( phonemes);
        }

    }
}