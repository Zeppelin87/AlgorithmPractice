namespace AlgorithmPractice.Algorithms.Arrays.Kadane
{
    public static class KadanesAlgorithm
    {
        public static void Run()
        {
            int[] arr = { 4, -1, 2, -7, 3, 4 };

            // O(n) time complexity | O(1) space complexity. 
            int result = Solution_Kadanes_Algo(arr);

            // O(n) time complexity | O(1) space complexity.
            int[] result2 = Solution_Kadanes_SlidingWindow(arr);
        }

        private static int Solution_Kadanes_Algo(int[] arr)
        {
            int maxSum = arr[0];
            int currentSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                currentSum = Math.Max(currentSum, 0);
                currentSum += arr[i];
                maxSum = Math.Max(currentSum, maxSum);
            }

            return maxSum;
        }

        private static int[] Solution_Kadanes_SlidingWindow(int[] arr)
        {
            int maxSum = arr[0];
            int currentSum = 0;
            
            int maxL = 0;
            int maxR = 0;
            int L = 0;

            for (int R = 0; R < arr.Length; R++)
            {
                if (currentSum < 0)
                {
                    currentSum = 0;
                    L = R;
                }

                currentSum += arr[R];

                if (currentSum > maxSum)
                {
                    maxSum = currentSum;
                    maxL = L;
                    maxR = R;
                }
            }

            return new int[] { maxL, maxR };
        }
    }
}
