using System;

namespace ProblemSolution
{
    public class Solution
    {
        private void PrintResult(long[] result, long? product)
        {
            Console.Write("[");

            for (int i = 0; i < result.Length; i++)
            {
                long value = product.HasValue 
                    ? (product.GetValueOrDefault() / result[i]) 
                    : result[i];
                Console.Write($"{value}");
                
                string appendComma = (i < result.Length - 1) ? ", " : string.Empty;
                Console.Write(appendComma);
            }
            
            Console.Write("]");
            Console.WriteLine();
        }

        public void FindProductAndPrintBasic(long[] input)
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

        public void FindAndPrintProductOptimized(long[] input)
        {
            long product = 1;

            for (int i = 0; i < input.Length; i++)
            {
                product *= input[i];
            }

            this.PrintResult(input, product);
        }

        public void FindProductWithoutDivision(long[] input)
        {
            long[] result = new long[input.Length];

            // Set to 1 as it should begin from the left
            // most end of the array. And there are no elements
            // to the left of the first element in the array
            long product = 1;

            // the variable product has the actual product of
            // all the elements to the left of i
            for (int i = 0; i < input.Length; i++)
            {
                result[i] = product;
                product *= input[i];
            }

            // Reset to 1 as it should begin from the right
            // most end of the array. And there are no elements
            // to the right of the last element in the array
            product = 1;

            // the variable product has the actual product of
            // all the elements to the right of i
            for (int i = input.Length - 1; i >= 0; i--)
            {
                result[i] *= product;
                product *= input[i];
            }

            this.PrintResult(result, null);
        }
    }
}