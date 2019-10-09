using Section3CodeChallengesLibrary.NumberChallenges;
using Section3CodeChallengesLibrary.WordChallenges;
using System;

namespace Section3CodeChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Biggest Number");
            Console.ForegroundColor = ConsoleColor.White;

            var numbersToTest = new int[] { 2, 154, 43, 7, 4, 9, 5 };
            int biggest = BiggestNumber.GetSecondBiggestNumberMessy(numbersToTest);
            Console.WriteLine("Second Biggest Number is: " + biggest);

            /*    Console.WriteLine(Words.UppercaseFirst("I"));
                Console.WriteLine(Words.UppercaseFirst("hope"));
                Console.WriteLine(Words.UppercaseFirst("you"));
                Console.WriteLine(Words.UppercaseFirst("had"));
                Console.WriteLine(Words.UppercaseFirst("a"));
                Console.WriteLine(Words.UppercaseFirst("good"));
                Console.WriteLine(Words.UppercaseFirst("weekend"));
                */
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Capitalize Words");
            Console.ForegroundColor = ConsoleColor.White;


            string stringToCap = "i hope you had a good weekend";
            string cappedString = Words.CapitalizeWords(stringToCap);
            Console.WriteLine(cappedString);

            Console.WriteLine(Words.CapitalizeWordsAttempt2(stringToCap));
            Console.WriteLine(Words.CapitalizeWordsAttempt3(stringToCap));

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Count Characters In Sentence");
            Console.ForegroundColor = ConsoleColor.White;

            string charCounts = Words.CountCharactersInSentence("Hello world");
            Console.WriteLine(charCounts);
        }
    }
}
