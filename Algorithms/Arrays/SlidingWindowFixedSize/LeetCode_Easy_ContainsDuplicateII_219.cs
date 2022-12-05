namespace AlgorithmPractice.Algorithms.Arrays.SlidingWindowFixedSize
{
    public static class LeetCode_Easy_ContainsDuplicateII_219
    {
        public static void Run()
        {
            int[] nums = { 1, 2, 3, 1, 2, 3 };
            int k = 2;

            bool result = Solution(nums, k);
        }

        private static bool Solution(int[] nums, int k)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                {
                    return true;
                }

                set.Add(nums[i]);

                if (set.Count > k)
                {
                    set.Remove(nums[i - k]);
                }
            }

            return false;
        }
    }
}
