namespace AlgorithmPractice.Algorithms.Arrays.Kadane
{
    public static class LeetCode_Medium_MaxSumCircularSubarray_918
    {
        public static void Run()
        {
            int[] nums = { 5, -3, 5 };

            // O(n) time complexity | O(1) space complexity.
            // Where: 'n' is the length of the array nums[].
            int result = Solution(nums); 
        }

        private static int Solution(int[] nums)
        {
            int S = 0; // S = sum(A)
            foreach (int x in nums)
            {
                S += x;
            }

            if (nums.Length == 1)
            {
                return S;
            }

            int ans1 = Kadane(nums, 0, nums.Length - 1, 1);
            int ans2 = S + Kadane(nums, 1, nums.Length - 1, -1);
            int ans3 = S + Kadane(nums, 0, nums.Length - 2, -1);

            return Math.Max(ans1, Math.Max(ans2, ans3));
        }

        private static int Kadane(int[] nums, int i, int j, int sign)
        {
            // The max non-empty subarray for array [sign * nums[i], siggn * nums[i + 1], ..., sign * nums[j]]
            int ans = int.MinValue;
            int cur = int.MinValue;
            for (int k = i; k <= j; k++)
            {
                cur = sign * nums[k] + Math.Max(cur, 0);
                ans = Math.Max(ans, cur);
            }

            return ans;
        }
    }
}
