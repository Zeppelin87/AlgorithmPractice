namespace AlgorithmPractice.Algorithms.Arrays.SlidingWindowFixedSize
{
    public static class LeetCode_Medium_NumberOfSubarraysWithSizeK_1343
    {
        public static void Run()
        {
            int[] arr = { 2, 2, 2, 2, 5, 5, 5, 8 };
            int k = 3;
            int threshold = 4;

            int result = Solution(arr, k, threshold);
        }

        private static int Solution(int[] arr, int k, int threshold)
        {
            int sum = 0;
            int result = 0;

            for (int i = 0; i < k - 1; i++)
            {
                sum += arr[i];
            }

            for (int i = k - 1; i < arr.Length; i++)
            {
                sum += arr[i];
                if (sum / k >= threshold)
                {
                    result += 1;
                }

                sum -= arr[i - k + 1];
            }

            return result;
        }
    }
}
