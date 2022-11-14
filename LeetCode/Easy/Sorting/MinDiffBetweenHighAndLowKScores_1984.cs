namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MinDiffBetweenHighAndLowKScores_1984
    {
        public static void Run()
        {
            int[] nums = new int[] { 87063, 61094, 44530, 21297, 95857, 93551, 9918 };
            int k = 6;

            var result = Solution(nums, k);
        }

        private static int Solution(int[] nums, int k)
        {
            Array.Sort(nums);

            int minDiff = int.MaxValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (i + k - 1 >= nums.Length)
                {
                    break;
                }

                minDiff = Math.Min(minDiff, nums[i + k - 1] - nums[i]);
            }

            return minDiff;
        }
    }
}
