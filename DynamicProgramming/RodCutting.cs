namespace AlgorithmPractice.DynamicProgramming
{
    public static class RodCutting
    {
        public static void Run()
        {
            int[] prices = { 1, 5, 8, 9, 10, 14, 17, 20, 24, 30 };
            int length = 6;

            // O(2^n) time complexity | O(1) space complexity.
            var result = Solution_Recursive(prices, length);

            // O(n^2) time complexity | O(n) space complexity.
            var result2 = Solution_Memoization(prices, length);

            // O(n^2) time complexity | O(n) space complexity.
            var result3 = Solution_Tabulation(prices, length);

            var result4 = Solution_Tabulation_With_Reconstruction(prices, length);
        }

        private static int Solution_Recursive(int[] prices, int length)
        {
            return MaxProfit_Recursive(prices, length);
        }

        private static int Solution_Memoization(int[] prices, int length)
        {
            int[] cache = new int[length + 1];
            Array.Fill(cache, -1);

            return MaxProfit_Memoization(prices, cache, length);
        }

        private static int MaxProfit_Recursive(int[] prices, int length)
        {
            if (length == 0)
            {
                return 0;
            }

            int max = int.MinValue;
            for (int i = 0; i < length; i++)
            {
                max = Math.Max(max, prices[i] + MaxProfit_Recursive(prices, length - i - 1));
            }

            return max;
        }

        private static int MaxProfit_Memoization(int[] prices, int[] cache, int length)
        {
            if (length == 0)
            {
                return 0;
            }

            if (cache[length] != -1)
            {
                return cache[length];
            }

            int max = int.MinValue;
            for (int i = 0; i < length; i++)
            {
                max = Math.Max(max, prices[i] + MaxProfit_Memoization(prices, cache, length - i - 1));
            }

            cache[length] = max;
            return cache[length];
        }

        private static int Solution_Tabulation(int[] prices, int length)
        {
            int[] dp = new int[length + 1];

            for (int l = 1; l <= length; l++)
            {
                dp[l] = int.MinValue;

                for (int i = 0; i < l; i++)
                {
                    dp[l] = Math.Max(dp[l], prices[i] + dp[l - i - 1]);
                }
            }

            return dp[length];
        }

        private static int Solution_Tabulation_With_Reconstruction(int[] prices, int length)
        {
            int[] dp = new int[length + 1];
            int[] cuts = new int[length + 1];

            for (int l = 1; l <= length; l++)
            {
                dp[l] = int.MinValue;
                int cut = -1;

                for (int i = 0; i < l; i++)
                {
                    if (prices[i] + dp[l - i - 1] > dp[l])
                    {
                        dp[l] = prices[i] + dp[l - i - 1];
                        cut = i + 1;
                    }
                }

                cuts[l] = cut;
            }

            int lIdx = length;
            int cutX = cuts[length];
            while (cutX != 0)
            {
                Console.WriteLine($"{cutX} ");
                lIdx = lIdx - cutX;
                cutX = cuts[lIdx];
            }

            return dp[length];
        }
    }
}
