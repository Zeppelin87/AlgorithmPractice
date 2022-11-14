namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class TwoSumLessThanK_1099
    {
        public static void Run()
        {
            int[] nums = new int[] { 34, 23, 1, 24, 75, 33, 54, 8 };
            int k = 60;
            var result = Solution(nums, k);
        }

        private static int Solution(int[] nums, int k)
        {
            int sum = -1;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] < k && nums[i] + nums[j] > sum)
                    {
                        sum = nums[i] + nums[j];
                    }
                }
            }

            return sum;
        }
    }
}
