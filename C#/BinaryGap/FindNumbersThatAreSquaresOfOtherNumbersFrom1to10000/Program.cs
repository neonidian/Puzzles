using System;
using System.Collections.Generic;
using System.Threading.Channels;

namespace FindNumbersThatAreSquaresOfOtherNumbersFrom1to10000
{
    class Program
    {
        private static short bb = -1280;
        
        static void Main()
        {
            foreach (var findNumbersThatAreSquaresOfOtherNumber in FindNumbersThatAreSquaresOfOtherNumbers())
            {
                Console.WriteLine(findNumbersThatAreSquaresOfOtherNumber);
            }
        }

        static int[] FindNumbersThatAreSquaresOfOtherNumbers()
        {
            int[] arr = new int[100];
            int j = 0;
            
            for (int i = 1; i <= 10000; i++)
            {
                if (i * i <= 10000)
                {
                    arr[j] = i * i;
                    j++;
                }
            }

            return arr;
        }
    }
}
