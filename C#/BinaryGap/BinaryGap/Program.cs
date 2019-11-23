using System;
using System.Collections.Generic;

namespace BinaryGap
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();
            Console.WriteLine("Binary gap for the number is {0}", solution.solution(1033)); //145 - 10010001; 137 - 10001001; 1033 - 10000001001;
        }
    }

    class Solution
    {
        public int solution(int N)
        {
            string binary = Convert.ToString(N, 2);
            int lengthOfBinaryNumber = binary.Length;
            char[] binaryAsArray = binary.ToCharArray();
            int tempBinaryGap = 0;
            int binaryGap = 0;
            List<int> occurencesOfBinaryNumber = new List<int>();

            // Find the position of the occurences of '1' in the binary number and store the positions in a list
            for (int j = 0; j < lengthOfBinaryNumber; j++)
            {
                if(binaryAsArray[j] == '1')
                {
                    occurencesOfBinaryNumber.Add(j);
                }
            }

            int lengthOccurenceOfBinaryNumber = occurencesOfBinaryNumber.Count;

            // Find the largest binary Gap
            if (lengthOccurenceOfBinaryNumber > 1)
            {
                int temp = 0;
                for (int i = 1; i < lengthOccurenceOfBinaryNumber; i++)
                {
                    temp = occurencesOfBinaryNumber[i] - occurencesOfBinaryNumber[i-1] - 1;
                    if(temp > tempBinaryGap)
                    {
                        binaryGap = temp;
                        tempBinaryGap = temp;
                    }
                }
            }
            return binaryGap;
        }
    }
}
