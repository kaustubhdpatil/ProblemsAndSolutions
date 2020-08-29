using System;
using ProblemSolution;

namespace Problem_2
{
    class Program
    {
        static int[] ReadInputArray(int size)
        {
            int index = 0;
            int[] input = new int[size];

            while (index < size)
            {
                int nextIndex = index + 1;
                input[index] = nextIndex;
                index = nextIndex;
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

                Solution solution = new Solution();
                DateTime begin = DateTime.Now;
                solution.FindProductAndPrintBasic(input);
                DateTime end = DateTime.Now;
                Console.WriteLine($"Total time Brute force: {end - begin}");

                
                begin = DateTime.Now;
                solution.FindAndPrintProductOptimized(input);
                end = DateTime.Now;
                Console.WriteLine($"Total time Optimized: {end - begin}");
            }
        }
    }
}
