namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MissingNumber_268
    {
        public static void Run()
        {
            int[] nums = new int[] { 0, 1 };
            var result = Solution(nums);
        }

        private static int Solution(int[] nums)
        {
            Array.Sort(nums);

            if (nums[0] != 0)
            {
                return 0;
            }

            if (nums.Length == 1)
            {
                return nums[0] + 1;
            }

            int missingNumber = 0;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i + 1] - nums[i] != 1)
                {
                    return nums[i] + 1;
                }
            }

            return nums[nums.Length - 1] + 1;
        }
    }
}
