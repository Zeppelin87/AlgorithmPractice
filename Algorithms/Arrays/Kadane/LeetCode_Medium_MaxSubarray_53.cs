namespace AlgorithmPractice.Algorithms.Arrays.Kadane
{
    public static class LeetCode_Medium_MaxSubarray_53
    {
        public static void Run()
        {
            int[] nums = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };

            // O(n) time complexity | O(1) space complexity.
            int result = Solution(nums);
        }

        private static int Solution(int[] nums)
        {
            int maxSum = nums[0];
            int currentSum = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                currentSum = Math.Max(currentSum, 0);
                currentSum += nums[i];

                maxSum = Math.Max(maxSum, currentSum);
            }

            return maxSum;
        }
    }
}
