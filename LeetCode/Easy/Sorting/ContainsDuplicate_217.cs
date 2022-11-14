namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class ContainsDuplicate_217
    {
        public static void Run()
        {
            int[] nums = new int[] { 1, 2, 3, 1 };
            var result = Solution(nums);
        }

        private static bool Solution(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    return true;
                }

                dictionary.Add(nums[i], 1);
            }

            return false;
        }
    }
}
