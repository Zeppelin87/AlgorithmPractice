namespace AlgorithmPractice.DynamicProgramming
{
    public static class PaintingHouses
    {
        public const int RED = 0;
        public const int BLUE = 1;
        public const int GREEN = 2;

        public static void Run()
        {
            // DP Steps:
            //  1. Define the state.
            //  2. List out all the state transitions.
            //  3. Implement a recursive solution.
            //  4. Memoize (top down).
            //  5. Tabulation (bottom up).

            int[][] cost = {
                new int[] { 17, 2, 17 },
                new int[] { 16, 16, 5 },
                new int[] { 14, 3, 9 },
            };

            // Recursive Solution.
            //int minCost = MinCost(cost);

            // Memoization (top down) Solution.
            //int minCost1 = MinCost_Memoization(cost);

            // Tabulation (bottom up) Solution.
            int minCost2 = MinCost_Tabulation(cost);
        }

        private static int MinCost(int[][] cost)
        {
            int costRed = MinCost(cost, 0, RED);
            int costBlue = MinCost(cost, 0, BLUE);
            int costGreen = MinCost(cost, 0, GREEN);

            return Math.Min(costRed, Math.Min(costBlue, costGreen));
        }

        private static int MinCost_Memoization(int[][] cost)
        {
            int[,] dp = new int[cost.Length, cost[0].Length];
            for (int i = 0; i < cost.Length; i++)
            {
                for (int j = 0; j < cost[0].Length; j++)
                {
                    dp[i, j] = -1;
                }
            }

            int costRed = MinCost_Memoization(cost, 0, RED, dp);
            int costBlue = MinCost_Memoization(cost, 0, BLUE, dp);
            int costGreen = MinCost_Memoization(cost, 0, GREEN, dp);

            return Math.Min(costRed, Math.Min(costBlue, costGreen));
        }

        private static int MinCost(int[][] cost, int i, int color)
        {
            if (i == cost.Length)
            {
                return 0;
            }

            switch (color)
            {
                case RED:
                    {
                        int costBlue = MinCost(cost, i + 1, BLUE);
                        int costGreen = MinCost(cost, i + 1, GREEN);
                        return cost[i][RED] + Math.Min(costBlue, costGreen);
                    }
                case BLUE:
                    {
                        int costRed = MinCost(cost, i + 1, RED);
                        int costGreen = MinCost(cost, i + 1, GREEN);
                        return cost[i][BLUE] + Math.Min(costRed, costGreen);
                    }
                case GREEN:
                    {
                        int costRed = MinCost(cost, i + 1, RED);
                        int costBlue = MinCost(cost, i + 1, BLUE);
                        return cost[i][GREEN] + Math.Min(costRed, costBlue);
                    }
            }

            return 0;
        }

        private static int MinCost_Memoization(int[][] cost, int i, int color, int[,] dp)
        {
            if (i == cost.Length)
            {
                return 0;
            }

            if (dp[i, color] != -1)
            {
                return dp[i, color];
            }

            switch (color)
            {
                case RED:
                    {
                        int costBlue = MinCost_Memoization(cost, i + 1, BLUE, dp);
                        int costGreen = MinCost_Memoization(cost, i + 1, GREEN, dp);
                        return dp[i, color] = cost[i][RED] + Math.Min(costBlue, costGreen);
                    }
                case BLUE:
                    {
                        int costRed = MinCost_Memoization(cost, i + 1, RED, dp);
                        int costGreen = MinCost_Memoization(cost, i + 1, GREEN, dp);
                        return dp[i, color] = cost[i][BLUE] + Math.Min(costRed, costGreen);
                    }
                case GREEN:
                    {
                        int costRed = MinCost_Memoization(cost, i + 1, RED, dp);
                        int costBlue = MinCost_Memoization(cost, i + 1, BLUE, dp);
                        return dp[i, color] = cost[i][GREEN] + Math.Min(costRed, costBlue);
                    }
            }

            return 0;
        }

        private static int MinCost_Tabulation(int[][] costs)
        {
            int n = costs.Length;
            int[,] dp = new int[costs.Length + 1, costs[0].Length + 1];
            //for (int i = 0; i < costs.Length + 1; i++)
            //{
            //    for (int j = 0; j < costs[0].Length + 1; j++)
            //    {
            //        dp[i, j] = -1;
            //    }
            //}

            if (costs.Length == 0)
            {
                return 0;
            }

            for (int i = 1; i <= n; i++)
            {
                dp[i, RED] = costs[i - 1][RED] + Math.Min(dp[i - 1, BLUE], dp[i - 1, GREEN]);
                dp[i, BLUE] = costs[i - 1][BLUE] + Math.Min(dp[i - 1, RED], dp[i - 1, GREEN]);
                dp[i, GREEN] = costs[i - 1][GREEN] + Math.Min(dp[i - 1, RED], dp[i - 1, BLUE]);
            }

            return Math.Min(dp[n, RED], Math.Min(dp[n, BLUE], dp[n, GREEN]));
        }
    }
}
