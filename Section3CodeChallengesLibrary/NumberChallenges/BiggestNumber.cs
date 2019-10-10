using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Section3CodeChallengesLibrary.NumberChallenges
{
    public class BiggestNumber
    {
        public static int GetBiggestNumber(int[] numbers)
        {
            int currentLargestNumber = int.MinValue;

            for (int index = 0; index < numbers.Length; index++)
            {
                if (numbers[index] > currentLargestNumber)
                {
                    currentLargestNumber = numbers[index];
                }
            }

            return currentLargestNumber;
        }

        public static int GetSecondBiggestNumber(int[] numbers)
        {

            Array.Sort(numbers);
            Array.Reverse(numbers);

            return numbers[1];
        }

        public static int GetSecondBiggestNumberMessy(int[] numbers)
        {
            int biggestNumber = GetBiggestNumber(numbers);

            int currentBiggestNumber = int.MinValue;

            foreach(var number in numbers)
            {
                if (number > currentBiggestNumber && number != biggestNumber)
                {
                    currentBiggestNumber = number;
                }
            }

            return currentBiggestNumber;
        }

        public static string SecondBiggestNumber(int[] intList)
        {
            string secondBiggestInt = string.Empty;
            for (int i = 1; i < intList.Length; i++)
            {
                if (intList[i - 1] < intList[i])
                {
                    secondBiggestInt = "Second biggest number = " + intList[i - 1];
                }
            }
            return secondBiggestInt;
        }
    }
}
