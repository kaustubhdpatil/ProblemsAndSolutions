using System;
using System.Collections.Generic;

namespace ProblemSolution
{
    public class Solution
    {
        public bool FindAndPrintTwoNumbersBasic(int expectedSum, int[] input) 
        {
            for (int i = 0; i < input.Length; i++) 
            {
                int diff = expectedSum - input[i];

                for (int j = i + 1; j < input.Length; j++)
                {
                    if (diff == input[j])
                    {
                        // Found the result 
                        return true;
                    }
                }
            }

            return false;
        }

        public bool FindAndPrintTwoNumbersOptimized(int expectedSum, int[] input) 
        {
            // initialize a hashset that will track the diff
            // and check if the difference exists then return 
            ISet<int> set = new HashSet<int>();

            for (int i = 0; i < input.Length; i++) 
            {
                int diff = expectedSum - input[i];

                if (set.Contains(input[i]))
                {
                    return true;
                }
                else
                {
                    set.Add(diff);
                }
            }

            return false;
        }
    }
}