namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class LongestHarmoniousSubsequence_594
    {
        public static void Run()
        {
            int[] nums = new int[] { 1, 3, 2, 2, 5, 2, 3, 7 };

            var result = Solution(nums);
        }

        private static int Solution(int[] nums)
        {
            // Harmonious == maxValue - minValue == 1;
            Array.Sort(nums);

            int maxHarmoniousValue = 0;
            for (int i = 0; i < nums.Length; i++)
            {

            }

            return maxHarmoniousValue;
        }
    }
}
