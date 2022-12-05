namespace AlgorithmPractice.Algorithms.Arrays.TwoPointers
{
    public static class LeetCode_Medium_RemoveDuplicatesFromSortedArray2_80
    {
        public static void Run()
        {
            int[] nums = { 1, 1, 1, 2, 2, 3 };

            // O(n) time complexity | O(1) space complexity.
            // Where: 'n' is the length of the input array nums[].
            int result = Solution(nums);
        }

        private static int Solution(int[] nums)
        {
            int L = 1;
            int count = 1;

            for (int R = 1; R < nums.Length; R++)
            {
                if (nums[R] == nums[R - 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count <= 2)
                {
                    nums[L++] = nums[R];
                }
            }

            return L;
        }
    }
}
