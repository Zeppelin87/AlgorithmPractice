namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class SquaresOfSortedArray_977
    {
        public static void Run()
        {
            int[] nums = new int[] { -4, -1, 0, 3, 10 };
            Extensions.SortingExtension.ConsoleLog(nums);

            var result = Solution(nums);
        }

        private static int[] Solution(int[] nums)
        {
            int[] result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                result[i] = (int)Math.Pow((double)nums[i], 2);
            }

            return InsertionSort(result);
        }

        private static int[] InsertionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];
                int j = i - 1;

                while (j >= 0 && nums[j] > key)
                {
                    nums[j + 1] = nums[j];
                    j--;
                }

                nums[j + 1] = key;
            }

            return nums;
        }
    }
}
