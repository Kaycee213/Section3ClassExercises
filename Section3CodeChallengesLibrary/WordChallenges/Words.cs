using System;
using System.Collections.Generic;
using System.Text;

namespace Section3CodeChallengesLibrary.WordChallenges
{
    public class Words
    {
        /*
         * Capitalize the first letter of every word in a sentence.
         * “I hope you had a good weekend?” ->  
         * “I Hope You Had A Good Weekend”   
         * 
         */
        public static string CapitalizeWordsAttempt3(string inputString)
        {
            var splitArray = inputString.Split(' ');

            for (int index = 0; index < splitArray.Length; index++)
            {
                var word = splitArray[index];
                var uppercaseWord = UppercaseFirst(word);
                splitArray[index] = uppercaseWord;

            }

            string returnString = string.Empty;

            foreach (var word in splitArray)
            {
                returnString = returnString + word + " ";
            }

            return returnString;
        }

        public static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            char[] a = s.ToCharArray();
            a[0] = char.ToUpper(a[0]);
            return new string(a);
        }

        public static string CapitalizeWordsAttempt2(string inputString)
        {
            var inputCharArray = inputString.ToCharArray();

            for (int index = 0; index < inputCharArray.Length; index++)
            {
                var currentChar = inputCharArray[index];

                if (currentChar == ' ')
                {
                    inputCharArray[index + 1] = char.ToUpper(inputCharArray[index + 1]);
                }

            }

            inputCharArray[0] = char.ToUpper(inputCharArray[0]);



            return new string(inputCharArray);

        }
        public static string CapitalizeWords(string inputString)
        {
            string[] splitList = inputString.Split(' ');

            for (int index = 0; index < splitList.Length; index++)
            {
                string word = splitList[index];

                char[] wordArray = word.ToCharArray();

                char letter = char.ToUpper(wordArray[0]);
                wordArray[0] = letter;

                splitList[index] = new string(wordArray);

            }

            string returnString = string.Empty;

            foreach (var word in splitList)
            {
                returnString = returnString + word + " ";
            }

            return returnString;

        }

        public static string CountCharactersInSentenceV1(string inputString)
        {
            inputString = inputString.ToLower();

            char[] alphabet = new char[] { 'a', 'b', 'c','d',
            'e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};


            int[] counts = new int[26];

            for (int index = 0; index < inputString.Length; index++)
            {
                char letter = inputString[index];

                int letterInt = (int)letter - 97;

                if (letterInt > 0)
                    counts[letterInt]++;

            }

            string returnString = string.Empty;


            for (int index = 0; index < alphabet.Length; index++)
            {

                if (counts[index] > 0)
                    returnString = returnString + "\"" + alphabet[index] + "\" -> " + counts[index] + "  ";

            }


            return returnString;
        }


        public static string CountCharactersInSentenceV2(string inputString)
        {
            Dictionary<char, int> counts = new Dictionary<char, int>();
            inputString = inputString.ToLower();


            for (int index = 0; index < inputString.Length; index++)
            {
                var letter = inputString[index];

                if (!(letter == ' '))
                {

                    if (!counts.ContainsKey(letter))
                    {
                        counts[letter] = 0;
                    }

                    counts[letter]++;

                }
            }

            string returnString = string.Empty;

            foreach (var letter in counts.Keys)
            {
                returnString = returnString + "\"" + letter + "\" -> " + counts[letter] + "  ";
            }


            return returnString;
        }
    }
}
