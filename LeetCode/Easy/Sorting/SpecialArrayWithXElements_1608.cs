namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class SpecialArrayWithXElements_1608
    {
        public static void Run()
        {
            int[] nums = new int[] { 0, 4, 3, 0, 4 };
            var result = Solution(nums);
        }

        private static int Solution(int[] nums)
        {
            Array.Sort(nums);
            int max = nums.Length;

            for (int i = 1; i <= max; i++)
            {
                int specialCount = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i <= nums[j])
                    {
                        specialCount++;
                    }
                }

                if (i == specialCount)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
