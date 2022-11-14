namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_NumberOfWaysToMakeChange
    {
        public static void Run()
        {
            int n = 10;
            int[] denoms = { 1, 5, 10, 25 };

            // Time Complexity: O(nd) -- (where 'n' is the target amount and 'd' is the number of denominations).
            // Space Complexity: O(n) -- Linear (where 'n' is our target amount).
            var result = Solution(n, denoms);
        }

        private static int Solution(int n, int[] denoms)
        {
            int[] ways = new int[n + 1];
            ways[0] = 1;

            foreach (int denom in denoms)
            {
                for (int amount = 1; amount < n + 1; amount++)
                {
                    if (denom <= amount)
                    {
                        ways[amount] += ways[amount - denom];
                    }
                }
            }

            return ways[n];
        }
    }
}
