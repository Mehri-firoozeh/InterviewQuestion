using System;
using System.Collections.Generic;

namespace CheckSubArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new int[]{ 3,4,-7,3,1,3,1,-4,-2,-2};

            List<int[]> output = SumZeroSubArray(input);

            foreach (var item in output)
            {
                Console.WriteLine();
                for (int i = 0; i < item.Length; i++)
                {
                    Console.Write($"{item[i]},");
                }
            }
            Console.ReadKey();
        }

        private static List<int[]> SumZeroSubArray(int[] input)
        {
            var output = new List<int[]>();
            var subArraysBoundry = new List<int[]>();
            for (int i = 0; i < input.Length; i++)
            {
                var sum = input[i];
                for (int j = i+1; j < input.Length; j++)
                {
                    sum = sum + input[j]; 
                    if (sum == 0)
                    {
                        subArraysBoundry.Add(new int[] {i, j});
                    }
                }
            }

            foreach (var item in subArraysBoundry)
            {
                var arrayOut = new int[item[1] - item[0]+1];
                for (int i = 0, j = item[0]; j <= item[1]; i++,j++)
                {
                    arrayOut[i] = input[j];
                }
                output.Add(arrayOut);
               
            }

            return output;
        }
    }
}
