namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_LargestRange
    {
        public static void Run()
        {
            //                      { 0,  1, 2, 3,  4, 5, 6, 7,  8, 9, 10, 11 };
            int[] array = new int[] { 1, 1, 1, 3, 4 };
            // output = [3, 9];

            // Time Complexity: O(n log(n)) -- Log-Linear (where 'n' is the length of the input array[]).
            // Space Complexity: O(log(n)) -- Logarithmic.
            var result = Solution_SortArray(array);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n) -- Linear.
            // Where 'n' is the length of the input array[].
            var result2 = Solution_Linear(array);
        }

        private static int[] Solution_Linear(int[] array)
        {
            int[] bestRange = new int[2];
            int longestLength = 0;
            var nums = new HashSet<int>();

            foreach (int num in array)
            {
                nums.Add(num);
            }

            foreach (int num in array)
            {
                if (!nums.Contains(num))
                {
                    continue;
                }

                nums.Remove(num);

                int currentLength = 1;
                int left = num - 1;
                int right = num + 1;

                while (nums.Contains(left))
                {
                    nums.Remove(left);
                    currentLength++;
                    left--;
                }

                while (nums.Contains(right))
                {
                    nums.Remove(right);
                    currentLength++;
                    right++;
                }

                if (currentLength > longestLength)
                {
                    longestLength = currentLength;
                    bestRange = new int[] { left + 1, right - 1 };
                }
            }

            return bestRange;
        }

        private static int[] Solution_SortArray(int[] array)
        {
            if (array.Length == 0)
            {
                return new int[] { };
            }

            if (array.Length == 1)
            {
                return new int[] { array[0], array[0] };
            }

            // O(n log(n))
            Array.Sort(array);
            Extensions.SortingExtension.ConsoleLog(array);

            int startIdx = 0;
            int currentRange = 1;
            int maxRange = 1;
            int[] result = new int[2];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == array[i - 1])
                {
                    currentRange++;
                    continue;
                }

                if (InRange(array, i))
                {
                    currentRange++;

                    if (currentRange > maxRange)
                    {
                        maxRange = currentRange;

                        startIdx = i - (currentRange - 1);
                        result[0] = array[startIdx];
                        result[1] = array[i];
                    }
                }
                else
                {
                    currentRange = 1;
                }
            }

            return result;
        }

        private static bool InRange(int[] array, int i)
        {
            return array[i] - array[i - 1] == 1;
        }
    }
}
