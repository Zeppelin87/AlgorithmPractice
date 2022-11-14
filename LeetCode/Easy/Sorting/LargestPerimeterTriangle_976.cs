namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class LargestPerimeterTriangle_976
    {
        public static void Run()
        {
            int[] nums = new int[] { 3, 2, 3, 4 };

            var result = Solution(nums);
            var res2 = Solution2(nums);
        }

        private static int Solution(int[] nums)
        {
            // Sum of any two sides should be greater than the third side.
            Array.Sort(nums, (x, y) =>
            {
                return y.CompareTo(x);
            });

            int largestPerimeter = 0;
            for (int i = 0; i < nums.Length - 2; i++)
            {
                int sum1 = nums[i] + nums[i + 1];
                int sum2 = nums[i] + nums[i + 2];
                int sum3 = nums[i + 1] + nums[i + 2];

                if (sum1 > nums[i + 2] && sum2 > nums[i + 1] && sum3 > nums[i])
                {
                    int temp = nums[i] + nums[i + 1] + nums[i + 2];
                    if (temp > largestPerimeter)
                    {
                        largestPerimeter = temp;
                    }
                }
            }


            return largestPerimeter;
        }

        private static int Solution2(int[] nums)
        {
            Array.Sort(nums);

            for (int i = nums.Length - 3; i >= 0; i--)
            {
                if (nums[i] + nums[i + 1] > nums[i + 2])
                {
                    return nums[i] + nums[i + 1] + nums[i + 2];
                }
            }

            return 0;
        }
    }
}
