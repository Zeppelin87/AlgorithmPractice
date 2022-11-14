namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_LongestPeak
    {
        public static void Run()
        {
            int[] array = { 1, 3, 2 };

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(1) -- Constant.
            var result = Solution(array);
        }

        private static int Solution(int[] array)
        {
            int currentStreak = 0;
            int longestStreak = 0;

            for (int i = 1; i < array.Length - 1; i++)
            {
                bool isPeak = array[i] > array[i - 1] && array[i] > array[i + 1];

                if (isPeak)
                {
                    currentStreak = GetStreak(array, i);

                    if (currentStreak > longestStreak)
                    {
                        longestStreak = currentStreak;
                    }
                }
            }

            return longestStreak;
        }

        private static int GetStreak(int[] array, int i)
        {
            int leftPointer = i;
            int rightPointer = i;

            while (leftPointer > 0 && array[leftPointer] > array[leftPointer - 1])
            {
                leftPointer--;
            }

            while (rightPointer < array.Length - 1 && array[rightPointer] > array[rightPointer + 1])
            {
                rightPointer++;
            }

            return rightPointer - leftPointer + 1;
        }
    }
}
