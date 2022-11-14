namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_ThreeNumberSum
    {
        public static void Run()
        {
            int[] array = new int[] { 12, 3, 1, 2, -6, 5, -8, 6 };
            int targetSum = 0;

            // Time Complexity: O(n^2) -- Quadratic.
            // Space Complexity: O(n) -- Linear.
            var result = Solution_BruteForce(array, targetSum);
        }

        private static List<int[]> Solution_BruteForce(int[] array, int targetSum)
        {
            // O(n log n)
            Array.Sort(array);

            var result = new List<int[]>();

            // O(n^2)
            int currentSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int leftPointer = i + 1;
                int rightPointer = array.Length - 1;

                while (leftPointer < rightPointer)
                {
                    currentSum = array[i] + array[leftPointer] + array[rightPointer];

                    if (currentSum > targetSum)
                    {
                        // Move rightPointer to the left b/c guarantees smaller 'currentSum'.
                        rightPointer--;
                    }
                    else if (currentSum < targetSum)
                    {
                        // Move leftPointer to the right b/c guarantees larger 'currentSum'.
                        leftPointer++;
                    }
                    else if (currentSum == targetSum)
                    {
                        // 1. Add the 3 numbers to 'result'.
                        // 2. Move leftPoint++ & rightPointer--;
                        //  - only time we move both pointers at the same time.
                        result.Add(new int[] { array[i], array[leftPointer], array[rightPointer] });
                        leftPointer++;
                        rightPointer--;
                    }
                }
            }

            return result; // [[-8, 2, 6], [-8, 3, 5], [-6, 1, 5]]
        }
    }
}
