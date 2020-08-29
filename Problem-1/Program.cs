using System;
using ProblemSolution;

namespace Problem_1
{
    class Program
    {
        private static int[] ReadInputArray(int size)
        {
            int index = 0;
            Console.WriteLine("Enter array values in each line");
            int[] input = new int[size];

            while (index < size)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    input[index] = value;
                    index += 1;
                }
            }

            return input;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Problem 1");
            Console.WriteLine("Enter the size of the input array");
            int.TryParse(Console.ReadLine(), out int size);

            if (size > 0) 
            {
                int[] input = ReadInputArray(size);

                Console.WriteLine("Enter the sum value");
                int.TryParse(Console.ReadLine(), out int expectedSum);

                Solution solution = new Solution();
                bool result = solution.FindAndPrintTwoNumbersBasic(expectedSum, input);
                Console.WriteLine($"Result is: {result}");
            }
        }
    }
}
