namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_NonConstructibleChange
    {
        public static void Run()
        {
            int[] coins = new int[] { 5, 7, 1, 1, 2, 3, 22 };

            // Time Complexity: O(n log n) -- Log-Linear.
            // Space Complexity: O(1) -- Constant.
            var result = Solution(coins);
        }

        private static int Solution(int[] coins)
        {
            // O(n log n)
            Array.Sort(coins);

            // O(n)
            int currentChangeCreated = 0;
            for (int i = 0; i < coins.Length; i++)
            {
                if (coins[i] > currentChangeCreated + 1)
                {
                    return currentChangeCreated + 1;
                }

                currentChangeCreated += coins[i];
            }


            return currentChangeCreated + 1;
        }
    }
}
