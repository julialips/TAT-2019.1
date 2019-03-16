using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

namespace Task2
{
    class RushianRules
    {
       
        private int accent = -2;
        private string simbol = string.Empty;
        private StringBuilder phonemes = new StringBuilder();


        private readonly List<char> vowelsSoft = new List<char>()
            {
                'и', 'е', 'ё', 'ю', 'я'
            };

        private readonly List<char> vowelsHard = new List<char>()
            {
                'а', 'о', 'э', 'ы', 'у'
            };

        private readonly List<char> consonantsHard = new List<char>()
            {
               'б', 'в', 'г', 'д', 'ж', 'з','к', 'л', 'м', 'н',
               'п', 'р', 'с', 'т', 'ф', 'х', 'ц', 'ш'
            };

        private readonly List<char> consonantsSoft = new List<char>()
            {
                'ц', 'щ', 'й'
            };

        private readonly List<char> consonantsDeaf = new List<char>()
            {
               'к', 'п', 'с', 'т', 'ф', 'х', 'ц', 'ш', 'щ'
            };

        private readonly List<char> consonantsVoiced = new List<char>()
            {
               'б', 'в', 'г', 'д', 'ж', 'з', 'л', 'м', 'н',
                'р', 'й'
            };

        private readonly Dictionary <char, char> vowelBeforeConsonant = new Dictionary<char, char>
        {
            ['ю'] = 'у',
            ['я'] = 'а',
            ['ё'] = 'о',
            ['е'] = 'э'
        };
        private readonly Dictionary <char, string> vowelBeforeVowel = new Dictionary<char, string>
        {
            ['ю'] = "йу",
            ['я'] = "йа",
            ['ё'] = "йо",
            ['е'] = "йэ"
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

    

        public RushianRules(string line)
        {
            simbol = line;
        }

        public StringBuilder RushianRules()
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

                        if (i != 0 && DefineTypeOfSimbol(simbol[i - 1], vowels, consonants) ==
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
            Console.WriteLine(simbol + " -> " + phonemes);
        }

    }
}