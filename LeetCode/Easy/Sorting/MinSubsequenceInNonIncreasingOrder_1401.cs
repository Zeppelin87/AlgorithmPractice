namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MinSubsequenceInNonIncreasingOrder_1401
    {
        public static void Run()
        {
            int[] nums = new int[] { 4, 4, 7, 6, 7 };
            Extensions.SortingExtension.ConsoleLog(nums);

            var result = Solution(nums);
        }

        private static int[] Solution(int[] nums)
        {
            nums = InsertionSort(nums);
            Extensions.SortingExtension.ConsoleLog(nums);

            int subTotal = 0;
            int total = 0;
            int counter = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                total += nums[i];
            }

            while (subTotal <= total)
            {
                subTotal += nums[counter];
                total -= nums[counter];
                counter++;
            }

            int[] subsequence = new int[counter];
            for (int i = 0; i < counter; i++)
            {
                subsequence[i] = nums[i];
            }

            return subsequence;
        }

        private static int[] InsertionSort(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                int key = nums[i];
                int j = i - 1;

                while (j >= 0 && nums[j] < key)
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
