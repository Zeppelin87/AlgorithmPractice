namespace AlgorithmPractice.DynamicProgramming
{
    public static class LongestIncreasingSubsequence
    {
        public static void Run()
        {
            int[] array = { 5, 2, 3, 6, 8 };

            // Longest Increase Subsequence of array[]: [2, 3, 6, 8];

            //  1. State:
            //      Params:
            //          'i' - index of last element.
            //      Cost Function:
            //          lis(arr, i) - longest increasing subsequence in the arr[] ending at index 'i'.
            //  2. Transitions:
            //      Base Case:
            //          'i' = 0 => return 1;

            // O(2^n) time complexity | O(1) space complexity.
            int result = Solution_Recursive(array, array.Length - 1);

            // O(n^2) time complexity | O(n) space complexity.
            int result1 = Solution_Memoization(array, array.Length - 1);

            // O(n^2) time complexity | O(n) space complexity.
            int result2 = Solution_Tabulation(array);
        }

        private static int Solution_Recursive(int[] array, int i)
        {
            if (i == 0)
            {
                return 1;
            }

            int max = 1;
            for (int j = 0; j < i; j++)
            {
                int lis = Solution_Recursive(array, j);
                if (array[i] > array[j])
                {
                    lis += 1;
                }

                max = Math.Max(max, lis);
            }

            return max;
        }

        private static int Solution_Memoization(int[] array, int i)
        {
            int[] cache = new int[array.Length];
            return LIS_Memoization(array, cache, i);
        }

        private static int LIS_Memoization(int[] array, int[] cache, int i)
        {
            if (i == 0)
            {
                return 1;
            }

            if (cache[i] != 0)
            {
                return cache[i];
            }

            int max = 1;
            for (int j = 0; j < i; j++)
            {
                int lis = LIS_Memoization(array, cache, j);
                if (array[i] > array[j])
                {
                    lis += 1;
                }

                max = Math.Max(max, lis);
            }

            cache[i] = max;
            return max;
        }

        private static int Solution_Tabulation(int[] array)
        {
            int N = array.Length;
            int[] dp = new int[N];
            dp[0] = 1;

            for (int i = 1; i < N; i++)
            {
                dp[i] = 1;
                for (int j = 0; j < i; j++)
                {
                    int lis = dp[j];
                    if (array[i] > array[j])
                    {
                        lis += 1;
                    }

                    dp[i] = Math.Max(dp[i], lis);
                }
            }

            return dp[N - 1];
        }
    }
}
