namespace AlgorithmPractice.LeetCode.Medium.Sorting
{
    public static class MaxNumberOfCoins_1516
    {
        public static void Run()
        {
            int[] piles = new int[] { 2, 4, 5 };
            Extensions.SortingExtension.ConsoleLog(piles);

            var result = Solution(piles);
        }

        private static int Solution(int[] piles)
        {
            Array.Sort(piles);

            int total = 0;

            for (int i = piles.Length / 3; i < piles.Length; i += 2)
            {
                total += piles[i];
            }

            return total;
        }

        private static int[] InsertionSort(int[] piles)
        {
            for (int i = 0; i < piles.Length; i++)
            {
                int key = piles[i];
                int j = i - 1;

                while (j >= 0 && piles[j] < key)
                {
                    piles[j + 1] = piles[j];
                    j--;
                }

                piles[j + 1] = key;
            }

            return piles;
        }
    }
}
