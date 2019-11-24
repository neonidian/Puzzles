using System;
using System.Collections.Generic;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Binary gap for the number is {0}", solution.CalculateBinaryGap(1033)); //145 - 10010001; 137 - 10001001; 1033 - 10000001001;
        }
    }

    class Solution
    {
        public int CalculateBinaryGap(int decimalNumber)
        {
            string binary = Convert.ToString(decimalNumber, 2);
            int lengthOfBinaryNumber = binary.Length;
            char[] binaryAsArray = binary.ToCharArray();
            List<int> occurencesOfBinaryNumber;
            int binaryGap;

            occurencesOfBinaryNumber = FindOccurencesOfOneInBinaryNumber(lengthOfBinaryNumber, binaryAsArray);
            int lengthOccurenceOfBinaryNumber = occurencesOfBinaryNumber.Count;
            binaryGap = FindBinaryGap(occurencesOfBinaryNumber, lengthOccurenceOfBinaryNumber);
            return binaryGap;
        }

        private int FindBinaryGap(List<int> occurencesOfBinaryNumber, int lengthOccurenceOfBinaryNumber)
        {
            int tempBinaryGap = 0;
            int binaryGapNumber = 0;
            if (lengthOccurenceOfBinaryNumber > 1)
            {
                int temp = 0;
                for (int i = 1; i < lengthOccurenceOfBinaryNumber; i++)
                {
                    temp = occurencesOfBinaryNumber[i] - occurencesOfBinaryNumber[i - 1] - 1;
                    if (temp > tempBinaryGap)
                    {
                        binaryGapNumber = temp;
                        tempBinaryGap = temp;
                    }
                }
            }
            return binaryGapNumber;
        }

        private List<int> FindOccurencesOfOneInBinaryNumber(int lengthOfBinaryNumber, char[] binaryAsArray)
        {
            List<int> occurencesOfBinaryNumber = new List<int>();
            for (int j = 0; j < lengthOfBinaryNumber; j++)
            {
                if (binaryAsArray[j] == '1')
                {
                    occurencesOfBinaryNumber.Add(j);
                }
            }
            return occurencesOfBinaryNumber;
        }
    }
}
