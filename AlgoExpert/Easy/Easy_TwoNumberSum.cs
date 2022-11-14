namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_TwoNumberSum
    {
        public static void Run()
        {
            int[] array = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
            int targetSum = 10;

            // Time Complexity: O(n^2) -- Quadratic.
            // Space Complexity: O(2) -> O(1) -- Constant.
            var result = Solution_BruteForce(array, targetSum);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n) -- Linear.
            var result2 = Solution_HashSet(array, targetSum);

            // Time Complexity: O(n log n) -- Log-Linear.
            // Space Complexity: O(1) -- Constant.
            var result3 = Solution_TwoPointers(array, targetSum);
        }

        private static int[] Solution_BruteForce(int[] array, int targetSum)
        {
            // O(n^2)
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] + array[j] == targetSum)
                    {
                        return new int[2] { array[i], array[j] };
                    }
                }
            }

            return new int[0];
        }

        private static int[] Solution_HashSet(int[] array, int targetSum)
        {
            // O(n)
            var hashSet = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                int potentialMatch = targetSum - array[i];

                if (hashSet.Contains(potentialMatch))
                {
                    return new int[2] { array[i], potentialMatch };
                }
                else
                {
                    hashSet.Add(array[i]);
                }
            }

            return new int[0];
        }

        private static int[] Solution_TwoPointers(int[] array, int targetSum)
        {
            // O(n log n)
            Array.Sort(array);

            int leftPointer = 0;
            int rightPoint = array.Length - 1;

            while (leftPointer < rightPoint)
            {
                if (array[leftPointer] + array[rightPoint] > targetSum)
                {
                    rightPoint--;
                }
                else if (array[leftPointer] + array[rightPoint] < targetSum)
                {
                    leftPointer++;
                }
                else if (array[leftPointer] + array[rightPoint] == targetSum)
                {
                    return new int[2] { array[leftPointer], array[rightPoint] };
                }
            }

            return new int[0];
        }
    }
}
