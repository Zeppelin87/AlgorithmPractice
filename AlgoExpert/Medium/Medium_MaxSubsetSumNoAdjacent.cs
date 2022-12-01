namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MaxSubsetSumNoAdjacent
    {
        public static void Run()
        {
            int[] array = { 75, 105, 120, 75, 90, 135 };

            // O(^2) time complexity | O(n^2) space complexity.
            var result = Solution_Recursive(array, array.Length - 1);

            // O(n) time complexity | O(n) space complexity.
            var result2 = Solution_Memoization(array, new int[array.Length], array.Length - 1);

            // O(n) time complexity | O(n) space complexity.
            var result3 = Solution_Tabulation(array);
        }

        private static int Solution_Recursive(int[] array, int i)
        {
            if (i < 0)
            {
                return 0;
            }

            if (i == 0)
            {
                return array[i];
            }

            return Math.Max(array[i] + Solution_Recursive(array, i - 2), Solution_Recursive(array, i - 1));
        }

        private static int Solution_Memoization(int[] array, int[] cache, int i)
        {
            if (i < 0)
            {
                return 0;
            }

            if (i == 0)
            {
                return array[i];
            }

            if (cache[i] != 0)
            {
                return cache[i];
            }

            int maxSum = Math.Max(array[i] + Solution_Memoization(array, cache, i - 2), Solution_Memoization(array, cache, i - 1));
            cache[i] = maxSum;

            return maxSum;
        }

        private static int Solution_Tabulation(int[] array)
        {
            int N = array.Length;
            int[] dp = new int[N + 1];
            dp[1] = array[0];

            for (int i = 2; i <= N; i++)
            {
                dp[i] = Math.Max(array[i - 1] + dp[i - 2], dp[i - 1]);
            }

            return dp[N];
        }
    }
}
