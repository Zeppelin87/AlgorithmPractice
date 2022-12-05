namespace AlgorithmPractice.Algorithms.Arrays.SlidingWindowFixedSize
{
    public static class SlidingWindow_FixedSize_Algorithm
    {
        public static void Run()
        {
            // Detecting duplicates can be optimized w/ hashing.
            // A rolling HashSet (equal to the size of the window 'k') is maintained.

            int[] nums = { 1, 2, 3, 1 };
            int k = 3;

            // O(n) time complexity | O(1) space complexity. 
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
