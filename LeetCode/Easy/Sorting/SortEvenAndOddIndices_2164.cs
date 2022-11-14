namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class SortEvenAndOddIndices_2164
    {
        public static void Run()
        {
            int[] nums = new int[] { 5, 39, 33, 5, 12, 27, 20, 45, 14, 25, 32, 33, 30, 30, 9, 14, 44, 15, 21 };
            var result = Solution(nums);
        }

        private static int[] Solution(int[] nums)
        {
            int evenIndex = 0;
            int[] evenIndices = new int[(int)Math.Ceiling((double)nums.Length / 2)];

            int oddIndex = 0;
            int[] oddIndices = new int[nums.Length / 2];

            for (int i = 0; i < nums.Length; i++)
            {
                if (i % 2 == 0)
                {
                    evenIndices[evenIndex++] = nums[i];
                }
                else
                {
                    oddIndices[oddIndex++] = nums[i];
                }
            }

            // Sort evenIndices[] in increasing order.
            Array.Sort(evenIndices);

            // Sort oddIndices[] in decreasing order.
            Array.Sort(oddIndices, (x, y) =>
            {
                return y.CompareTo(x);
            });

            // Merge evenIndices[] & oddIndices[] in sorted order back into nums[]
            int x = 0;
            int j = 0;
            int index = 0;

            while (x < evenIndices.Length && j < oddIndices.Length)
            {
                nums[index++] = evenIndices[x++];
                nums[index++] = oddIndices[j++];
            }

            while (x < evenIndices.Length)
            {
                nums[index++] = evenIndices[x++];
            }

            while (j < oddIndices.Length)
            {
                nums[index++] = oddIndices[j++];
            }

            return nums;
        }
    }
}
