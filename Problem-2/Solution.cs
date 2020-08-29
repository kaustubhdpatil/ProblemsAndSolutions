using System;

namespace ProblemSolution
{
    public class Solution
    {
        public void FindProductAndPrintBasic(int[] input)
        {
            Console.Write("[");

            for (int i = 0; i < input.Length; i++)
            {
                long product = 1;

                for (int j = 0; j < input.Length; j++)
                {
                    product *= j != i ? input[j] : 1;
                }

                Console.Write(product);
                string appendComma = (i < input.Length - 1) ? ", " : string.Empty;
                Console.Write(appendComma);
            }

            Console.Write("]");
            Console.WriteLine();
        }

        public void FindAndPrintProductOptimized(int[] input)
        {
            long product = 1;

            for (int i = 0; i < input.Length; i++)
            {
                product *= input[i];
            }

            Console.Write("[");

            for (int i = 0; i < input.Length; i++)
            {
                Console.Write($"{product / input[i]}");
                
                string appendComma = (i < input.Length - 1) ? ", " : string.Empty;
                Console.Write(appendComma);
            }
            
            Console.Write("]");
            Console.WriteLine();
        }
    }
}