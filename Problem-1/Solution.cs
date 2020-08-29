using System;

namespace ProblemSolution
{
    public class Solution
    {
        public bool FindAndPrintTwoNumbersBasic(int expectedSum, int[] input) 
        {
            // initialize a dictionary 
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
    }
}