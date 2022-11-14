namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MinCostOfBuyingCandies_2144
    {
        public static void Run()
        {
            int[] cost = new int[] { 1, 2, 3 };
            var result = Solution(cost);
        }

        private static int Solution(int[] cost)
        {
            // O(n log n)
            Array.Sort(cost, (x, y) =>
            {
                return y - x;
            });

            int total = 0;
            int skip = 1;
            for (int i = 0; i < cost.Length; i++)
            {
                if (i == 0 || skip % 3 != 0)
                {
                    total += cost[i];
                }

                skip++;
            }

            return total;
        }
    }
}
