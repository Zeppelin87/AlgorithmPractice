namespace AlgorithmPractice.Algorithms.Arrays.TwoPointers
{
    public static class LeetCode_Easy_RemoveDuplicatesFromSortedArray_26
    {
        public static void Run()
        {
            int[] nums = { 1, 2 };

            // O(n) time complexity | O(1) space complexity.
            // Where: 'n' is the length of the input array nums[].
            int result = Solution(nums);
        }

        private static int Solution(int[] nums)
        {
            int insertIdx = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i - 1] != nums[i])
                {
                    nums[insertIdx] = nums[i];
                    insertIdx++;
                }
            }

            return insertIdx;
        }
    }
}
