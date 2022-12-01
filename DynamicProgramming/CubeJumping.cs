namespace AlgorithmPractice.DynamicProgramming
{
    public static class CubeJumping
    {
        public static void Run()
        {
            int[] costs = { 0, 20, 30, 40, 25, 15, 20, 28 };
            int x = 3;

            // O(2^n) time complexity | O(1) space complexity.
            int result = Solution_Recursive(costs, x);

            // O(nx) time complexity | O(n) space complexity.
            int result1 = Solution_Memoization(costs, x);

            // O(nx) time complexity | O(n) space complexity.
            int result2 = Solution_Tabulation(costs, x);

            int result3 = Solution_Tabulation_Reconstruction(costs, x);
        }

        private static int Solution_Recursive(int[] costs, int x)
        {
            return MinCost_Recursive(costs, x, costs.Length - 1);
        }

        private static int Solution_Memoization(int[] costs, int x)
        {
            int[] cache = new int[costs.Length];
            return MinCost_Memoization(costs, cache, x, costs.Length - 1);
        }

        private static int MinCost_Recursive(int[] costs, int x, int i)
        {
            if (i == 0)
            {
                return 0;
            }

            int min = int.MaxValue;
            for (int jump = 1; jump <= Math.Min(i, x); jump++)
            {
                min = Math.Min(min, costs[i] + MinCost_Recursive(costs, x, i - jump));
            }

            return min;
        }

        private static int MinCost_Memoization(int[] costs, int[] cache, int x, int i)
        {
            if (i == 0)
            {
                return 0;
            }

            if (cache[i] != 0)
            {
                return cache[i];
            }

            int min = int.MaxValue;
            for (int jump = 1; jump <= Math.Min(i, x); jump++)
            {
                min = Math.Min(min, costs[i] + MinCost_Memoization(costs, cache, x, i - jump));
            }

            cache[i] = min;
            return min;
        }

        private static int Solution_Tabulation(int[] costs, int x)
        {
            int N = costs.Length;
            int[] dp = new int[N];

            for (int i = 1; i < N; i++)
            {
                dp[i] = int.MaxValue;

                for (int jump = 1; jump <= Math.Min(x, i); jump++)
                {
                    dp[i] = Math.Min(dp[i], costs[i] + dp[i - jump]);
                }
            }

            return dp[N - 1];
        }

        private static int Solution_Tabulation_Reconstruction(int[] costs, int x)
        {
            int N = costs.Length;
            int[] dp = new int[N];
            int[] jhump = new int[N];

            dp[0] = 0;

            for (int i = 1; i < N; i++)
            {
                dp[i] = int.MaxValue;

                for (int jump = 1; jump <= Math.Min(x, i); jump++)
                {
                    if (costs[i] + dp[i - jump] < dp[i])
                    {
                        jhump[i] = i - jump;
                        dp[i] = costs[i] + dp[i - jump];
                    }
                }
            }

            int idx = N - 1;
            Console.WriteLine($"{idx} -> ");
            
            while (idx > 0)
            {
                idx = jhump[idx];
                Console.WriteLine($"{idx} -> ");
            }

            return dp[N - 1];
        }
    }
}
