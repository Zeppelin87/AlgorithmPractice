namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MultiplyingFoundValuesByTwo_2154
    {
        public static void Run()
        {
            int[] nums = new int[] { 5, 3, 6, 1, 12 };
            int original = 3;

            // Steps:
            //  1. If 'original' is found in nums[], multiply it by two (i.e. set original = 2 * original).
            //  2. Otherwise, stop the process.
            //  3. Repeat this process with the new number as long as you keep find the number.
            //  Return: the final value of 'original'.

            Array.Sort(nums);

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == original)
                {
                    original *= 2;
                }
            }
        }
    }
}
