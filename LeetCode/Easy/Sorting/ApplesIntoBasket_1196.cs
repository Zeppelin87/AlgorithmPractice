namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class ApplesIntoBasket_1196
    {
        public static void Run()
        {
            int[] weight = new int[] { 900, 950, 800, 1000, 700, 800 };
            var result = Solution(weight);
        }

        private static int Solution(int[] weight)
        {
            // O(n log n)
            Array.Sort(weight);

            //int maxWeight = 5000;
            //int total = 0;
            //for (int i = 0; i < weight.Length; i++)
            //{
            //    total += weight[i];

            //    if (total > maxWeight)
            //    {
            //        return i;
            //    }
            //}

            int units = 0;
            int apples = 0;
            for (int i = 0; i < weight.Length && units + weight[i] <= 5000; i++)
            {
                apples++;
                units += weight[i];
            }

            return apples;
        }
    }
}
