namespace AlgorithmPractice.DynamicProgramming
{
    public static class RobHouses
    {
        public static void Run()
        {
            int[] array = { 20, 25, 30, 15, 10 };

            //  1. State:
            //      i - index of last house being robbed.
            //  Cost Func:
            //      maxProfit(i, array);
            //  2. Transitions:
            //   Base Case:
            //      i < 0 => return 0;
            //      i == 0 => return array[i];
            //   Candidates:
            //      maxProf(i, array);
            //   Rob ith House:
            //      maxProf(i - 2, array);
            //   Don't Rob House:
            //      maxProf(i - 1, array);
            //   Optimal Choice:
            //      - choose the max profit option.
            //   Recurrance Relationship:
            //      maxProf(i, array) = Math.Max(maxProf(i - 2, array), maxProf(i - 1, array));
            //  3. Recursive Solution...
            //  4. Memoization (overlapping subproblems):
            //      maxProf(i, array) = Math.Max(maxProf(i - 2, array), maxProf(i - 1, array));
            //      - there is only one parameter that defines state, 'i'.
            //      - we can use an array to cache the results.
            //      - Key => 'i', index of the house.
            //      - Value => max profit that can be acheived by robbing houses index 0 to 'i'.
            //  5. Tabulation (bottom up):
            //      maxProf(i, array) = Math.Max(maxProf(i - 2, array), maxProf(i - 1, array));
            //      dp[i] - stores max profit obtained by robbing houses from o to 'i - 1'.
            //  6. Time Complexity:
            //      Recursive:
            //          - Binary Tree.
            //          - Height of tree = N.
            //          - Number of node = 2^n.
            //          - Time complexity: O(2^n) -- exponential.
            //          - Space complexity: O(1) -- constant.
            //      Memoization (top down):
            //          - one loop that runs from o to 'n'.
            //          - constant time operation inside for loop.
            //          - Time complexity: O(n) -- linear.
            //          - Space complexity: O(n) -- linear (due to cache of size 'n').
            //  7. Reconstruct The Solution:
            //      - record the decision at every index.
            //      - robbed[i] = true => it's beneficial to rob the house at 'i'.
            //      - robbed[i] = false => it's beneficail to NOT rob the house at 'i'.
            //      - robbed[0] = true => base case, if there's only one house then rob it.
            //      Reconstructing:
            //          - we start form the last => 'i' = 'N - 1'.
            //          - we check the decision recorded at robbbed[i].
            //          - if true => house was robbed, 'i' = 'i - 2'.
            //          - if false => skip that house, update 'i' = 'i - 1'.
            //          - repeat this until we hit 'i = 0' or 'i = -1'.

            // Recursive Solution: O(2^n) time compleity | O(1) space complexity.
            //int result = Solution_Recursive(array);

            // Memoization (top down) Solution: O(n) time compleity | O(n) space complexity.
            //int result1 = Solution_Memoization(array);

            // Tabulation (bottom up) Solution: O(n) time compleity | O(n) space complexity.
            //int result2 = Solution_Tabulation(array);

            // Tabulation w/ Reconstruction (bottom up) Solution:
            int result3 = MaxProfit_Tabulation_With_Reconstruction(array);
        }

        private static int Solution_Recursive(int[] array)
        {
            return MaxProfit_Recursive(array, array.Length - 1);
        }

        private static int Solution_Memoization(int[] array)
        {
            int[] cache = new int[array.Length];
            return MaxProfit_Memoization(array, cache, array.Length - 1);
        }

        private static int Solution_Tabulation(int[] array)
        {
            return MaxProfit_Tabulation(array);
        }

        private static int MaxProfit_Recursive(int[] array, int i)
        {
            if (i < 0)
            {
                return 0;
            }
            
            if (i == 0)
            {
                return array[i];
            }

            return Math.Max(array[i] + MaxProfit_Recursive(array, i - 2), MaxProfit_Recursive(array, i - 1));
        }

        private static int MaxProfit_Memoization(int[] array, int[] cache, int i)
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

            int maxProfit = Math.Max(array[i] + MaxProfit_Memoization(array, cache, i - 2), MaxProfit_Memoization(array, cache, i - 1));
            cache[i] = maxProfit;

            return maxProfit;
        }

        private static int MaxProfit_Tabulation(int[] array)
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

        private static int MaxProfit_Tabulation_With_Reconstruction(int[] array)
        {
            int N = array.Length;
            int[] dp = new int[N + 1];
            bool[] robbed = new bool[N];
            
            robbed[0] = true;
            dp[1] = array[0];

            for (int i = 2; i <= N; i++)
            {
                if (array[i - 1] + dp[i - 2] > dp[i - 1])
                {
                    dp[i] = array[i - 1] + dp[i - 2];
                    robbed[i - 1] = true;
                }
                else
                {
                    dp[i] = dp[i - 1];
                    robbed[i - 1] = false;
                }
            }

            int idx = N - 1;
            while (idx >= 0)
            {
                if (robbed[idx])
                {
                    Console.WriteLine($"{idx} {array[idx]}");
                    idx = idx - 2;
                }
                else
                {
                    idx--;
                }
            }

            return dp[N];
        }
    }
}
