namespace AlgorithmPractice.Algorithms.Arrays.SlidingWindowVariableSize
{
    public static class LeetCode_Medium_MinSizeSubarraySum
    {
        public static void Run()
        {
            int target = 7;
            int[] nums = { 2, 3, 1, 2, 4, 3 };

            // O(n) time complexity | O(1) space complexity.
            // Where: 'n' is the length of the input array nums[].
            int result = Solution(target, nums);
        }

        private static int Solution(int target, int[] nums)
        {
            int L = 0;
            int total = 0;
            int length = int.MaxValue;

            for (int R = 0; R < nums.Length; R++)
            {
                total += nums[R];
                while (total >= target)
                {
                    length = Math.Min(length, R - L + 1);
                    total -= nums[L];
                    L++;
                }
            }

            if (length == int.MaxValue)
            {
                return 0;
            }

            return length;
        }
    }
}
