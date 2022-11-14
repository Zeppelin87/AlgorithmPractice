namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MinNumberOfCoinsForChange
    {
        public static void Run()
        {
            int n = 7;
            int[] denoms = { 1, 5, 10 };

            // Time Complexity: 
            // Space Complexity: 
            var result = Solution(n, denoms);
        }

        private static int Solution(int n, int[] denoms)
        {
            int[] numOfCoins = new int[n + 1];
            Array.Fill(numOfCoins, int.MaxValue);
            numOfCoins[0] = 0;
            int toCompare = 0;

            foreach (int denom in denoms)
            {
                for (int amount = 0; amount < numOfCoins.Length; amount++)
                {
                    if (denom <= amount)
                    {
                        if (numOfCoins[amount - denom] == int.MaxValue)
                        {
                            toCompare = numOfCoins[amount - denom];
                        }
                        else
                        {
                            toCompare = numOfCoins[amount - denom] + 1;
                        }

                        numOfCoins[amount] = Math.Min(numOfCoins[amount], toCompare);
                    }
                }
            }

            return numOfCoins[n] != int.MaxValue ? numOfCoins[n] : -1;
        }
    }
}
