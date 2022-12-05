namespace AlgorithmPractice.Algorithms.Arrays.SlidingWindowVariableSize
{
    public static class SlidingWindow_VariableSize_Algorithm
    {
        public static void Run()
        {
            int[] nums = { 4, 2, 2, 3, 3, 3 };

            // O(n) time complexity | O(1) space complexity.
            int result = LongestSubarray(nums);

            int[] arr = { 2, 3, 1, 2, 4, 3 };
            int target = 6;

            // O(n) time complexity | O(1) space complexity.
            int result2 = ShortestSubarray(arr, target);
        }

        private static int LongestSubarray(int[] nums)
        {
            int length = 0;
            int L = 0;

            for (int R = 0; R < nums.Length; R++)
            {
                if (nums[L] != nums[R])
                {
                    L = R;
                }

                length = Math.Max(length, R - L + 1);
            }

            return length;
        }

        private static int ShortestSubarray(int[] arr, int target)
        {
            int L = 0;
            int total = 0;
            int length = int.MaxValue;

            for (int R = 0; R < arr.Length; R++)
            {
                total += arr[R];
                while (total >= target)
                {
                    length = Math.Min(R - L + 1, length);
                    total -= arr[L];
                    L++;
                }
            }

            if (length == int.MaxValue)
            {
                return 0;
            }

            return length;
        }
    }
}
