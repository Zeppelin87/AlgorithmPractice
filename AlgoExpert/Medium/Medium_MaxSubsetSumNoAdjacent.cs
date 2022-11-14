using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MaxSubsetSumNoAdjacent
    {
        public static void Run()
        {
            int[] array = { 75, 105, 120, 75, 90, 135 };

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the array[]).
            // Space Complexity: O(n) -- Linear.
            var result = Solution(array);

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the array[]).
            // Space Complexity: O(1) -- Constant.
            var result2 = Solution_Constant_Space(array);
        }

        private static int Solution_Constant_Space(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }

            if (array.Length == 1)
            {
                return array[0];
            }

            int first = array[0];
            int second = Math.Max(array[0], array[1]);
            for (int i = 2; i < array.Length; i++)
            {
                int temp = second;
                second = Math.Max(second, first + array[i]);
                first = temp;
            }

            return second;
        }

        private static int Solution(int[] array)
        {
            if (array.Length == 0)
            {
                return 0;
            }
            else if (array.Length == 1)
            {
                return array[0];
            }

            int[] maxSums = new int[array.Length];

            maxSums[0] = array[0];
            maxSums[1] = Math.Max(array[0], array[1]);

            for (int i = 2; i < array.Length; i++)
            {
                maxSums[i] = Math.Max(maxSums[i - 1], maxSums[i - 2] + array[i]);
            }

            return maxSums[array.Length - 1];
        }
    }
}
