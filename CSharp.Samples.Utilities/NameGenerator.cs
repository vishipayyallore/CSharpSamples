using System;
using System.Text;

namespace CSharp.Samples.Utilities
{

    public class NameGenerator
    {
        #region Private variables.
        static readonly string[] Consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "sh", "zh", "t", "v", "w", "x" };
        static readonly string[] Vowels = { "a", "e", "i", "o", "u", "ae", "y" };
        static readonly Random RandomObject = new Random();
        static StringBuilder _name;
        #endregion

        #region Methods.
        public static string GenerateName(int length = 8)
        {
            _name = new StringBuilder(100);
            length /= 2;
            GetNamePart(length);
            AddSpaceInName();
            GetNamePart(length);

            return _name.ToString();
        }
        #endregion

        #region Private Methods.
        private static string GetConsonant(bool isUpperCase = false)
        {
            var consonantsLength = Consonants.Length;
            return isUpperCase ? Consonants[RandomObject.Next(consonantsLength)].ToUpper() : Consonants[RandomObject.Next(consonantsLength)];
        }

        private static string GetVowel()
        {
            var vowelsLength = Vowels.Length;
            return Vowels[RandomObject.Next(vowelsLength)];
        }

        private static void AddSpaceInName()
        {
            _name.Append(" ");
        }

        private static void GetFirstPart()
        {
            _name.Append(GetConsonant(true));
            _name.Append(GetVowel());
        }

        private static void GetRemainingName(int length)
        {
            var iCtr = 0;
            while (iCtr <= length)
            {
                _name.Append(GetConsonant());
                _name.Append(GetVowel());
                iCtr += 2;
            }
        }

        private static void GetNamePart(int length)
        {
            GetFirstPart();
            GetRemainingName(length-2);
        }
        #endregion
    }

}