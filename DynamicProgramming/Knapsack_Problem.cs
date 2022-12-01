namespace AlgorithmPractice.DynamicProgramming
{
    public static class Knapsack_Problem
    {
        public static void Run()
        {
            int[] weights = { 3, 7, 10, 6 };
            int[] values = { 4, 14, 10, 5 };
            int weight = 20;
            int i = weights.Length - 1;

            // Recursive solution.
            //int result = Knapsack_Recursive_Solution(weights, values, weight, i);

            int[,] dp = new int[weights.Length + 1, weight + 1];
            for (int idx = 0; idx < weights.Length; idx++)
            {
                for (int j = 0; j < weight + 1; j++)
                {
                    dp[idx, j] = -1;
                }
            }

            // Top down (memoization) solution.
            // int res ult2 = Knapsack_Memoization_Solution(weights, values, weight, i, dp);

            // Bottom up (tabulation) solution.
            // If the value of the param passed to the recursive call is LESS than the current value of the param, the for loop should iterate in ascending order (0 to n).
            // Else the for loop should iterate in descending order (n to 0).
            //int result3 = Knapsack_Tabulation_Solution(weights, values, weight);

            // Time Complexity:
            // The recursive algorithm runs in O(c^h): where 'h' is the height of the tree & 'c' is the number of children each node has.
            // Recursive: O(2^n) -- exponential.
            // The goal of DP is to implement a solution that runs in linear O(n) or polynomial O(n^2) || O(n^3) time.
            // Memoization time complexity: O(nw) -- Space Complexity: O(nw).
            // Tabulation time complexity: O(nw) -- Space Complexity: O(nw).

            int result4 = Knapsack_Reconstruct_Tabulation(weights, values, weight);
        }

        private static int Knapsack_Recursive_Solution(int[] weights, int[] values, int weight, int i)
        {
            if (i == -1 || weight == 0)
            {
                return 0;
            }

            if (weights[i] <= weight)
            {
                int include = values[i] + Knapsack_Recursive_Solution(weights, values, weight - weights[i], i - 1);
                int exclude = Knapsack_Recursive_Solution(weights, values, weight, i - 1);

                return Math.Max(include, exclude);
            }
            else
            {
                return Knapsack_Recursive_Solution(weights, values, weight, i - 1);
            }
        }

        private static int Knapsack_Memoization_Solution(int[] weights, int[] values, int weight, int i, int[,] dp)
        {
            if (i == -1 || weight == 0)
            {
                return 0;
            }

            if (dp[i, weight] != -1)
            {
                return dp[i, weight];
            }

            if (weights[i] <= weight)
            {
                int include = values[i] + Knapsack_Memoization_Solution(weights, values, weight - weights[i], i - 1, dp);
                int exclude = Knapsack_Memoization_Solution(weights, values, weight, i - 1, dp);

                dp[i, weight] = Math.Max(include, exclude);
                return dp[i, weight];
            }
            else
            {
                return Knapsack_Memoization_Solution(weights, values, weight, i - 1, dp);
            }
        }

        private static int Knapsack_Tabulation_Solution(int[] weights, int[] values, int weight)
        {
            int N = weights.Length;
            int[,] dp = new int[weight + 1, N + 1];

            for (int i = 1; i <= N; i++)
            {
                for (int w = 1; w <= weight; w++)
                {
                    if (weights[i - 1] <= w)
                    {
                        dp[w, i] = Math.Max(dp[w - weights[i - 1], i - 1] + values[i - 1], dp[w, i - 1]);
                    }
                    else
                    {
                        dp[w, i] = dp[w, i - 1];
                    }
                }
            }

            return dp[weight, N];
        }

        private static int Knapsack_Reconstruct_Tabulation(int[] weights, int[] values, int weight)
        {
            int N = weights.Length;
            int[,] dp = new int[weight + 1, N + 1];
            bool[,] decisions = new bool[weight + 1, N + 1];

            for (int i = 1; i <= N; i++)
            {
                for (int w = 1; w <= weight; w++)
                {
                    if (weights[i - 1] <= w)
                    {
                        decisions[w, i] = true;
                        dp[w, i] = Math.Max(dp[w - weights[i - 1], i - 1] + values[i - 1], dp[w, i - 1]);
                    }
                    else
                    {
                        dp[w, i] = dp[w, i - 1];
                    }
                }
            }

            int idx = weights.Length;
            int weightIdx = weight;

            while (idx >= 0 && weightIdx >= 0)
            {
                bool picked = decisions[weightIdx, idx];
                if (picked)
                {
                    Console.WriteLine($"Picked: {idx - 1}, Weight: {weights[idx - 1]}, Value: {values[idx - 1]}");
                    weightIdx -= weights[idx - 1];
                    idx--;
                }
                else
                {
                    idx--;
                }
            }

            return dp[weight, N]; 
        }
    }
}
