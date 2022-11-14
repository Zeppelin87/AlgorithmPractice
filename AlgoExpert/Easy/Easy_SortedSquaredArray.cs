namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_SortedSquaredArray
    {
        public static void Run()
        {
            int[] array = new int[] { 1, 2, 3, 5, 6, 8, 9 };

            // Time Complexity: O(n log n) -- Log-Linear.
            // Space Complexity: O(n) -- Linear.
            var result = Solution_SortResult(array);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n) -- Linear.
            var result2 = Solution_TwoPointers(array);
        }

        private static int[] Solution_SortResult(int[] array)
        {
            // O(n)
            int[] result = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = (int)Math.Pow(array[i], 2);
            }

            // O(n log n)
            Array.Sort(result);

            return result;
        }

        private static int[] Solution_TwoPointers(int[] array)
        {
            int[] result = new int[array.Length];
            int smallerValueIndex = 0;
            int largerValueIndex = array.Length - 1;

            // O(n)
            for (int i = array.Length - 1; i >= 0; i--)
            {
                int smallerValue = array[smallerValueIndex];
                int largerValue = array[largerValueIndex];

                if (Math.Abs(smallerValue) > Math.Abs(largerValue))
                {
                    result[i] = smallerValue * smallerValue;
                    smallerValueIndex++;
                }
                else
                {
                    result[i] = largerValue * largerValue;
                    largerValueIndex--;
                }
            }

            return result;
        }
    }
}
