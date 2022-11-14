namespace AlgorithmPractice.LeetCode.Medium.Sorting
{
    public static class MinimizeMaximumPairSum_1877
    {
        public static void Run()
        {
            int[] nums = new int[] { 4, 1, 5, 1, 2, 5, 1, 5, 5, 4 };

            // Time Complexity: 

            // Space Complexity: 

            var result = Solution(nums);
        }

        private static int Solution(int[] nums)
        {
            Array.Sort(nums);

            int i = 0;
            int j = nums.Length - 1;

            int max = 0;
            while (i < j)
            {
                max = Math.Max(max, (nums[i++] + nums[j--]));
            }

            return max;
        }
    }
}
