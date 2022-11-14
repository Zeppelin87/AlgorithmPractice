namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_BinarySearch
    {
        public static void Run()
        {
            int[] array = new int[] { 0, 1, 21, 33, 45, 45, 61, 71, 72, 73 };
            int target = 33;

            // Time Complexity: O(log n) -- Logarithmic.
            // Space Complexity: O(1) -- Constant.
            var result = BinarySearch(array, target);

            // Time Complexity: O(log n) -- Logarithmic.
            // Space Complexity: O(log n) -- Logarithmic.
            var result2 = RecursiveBinarySearch(array, target, 0, array.Length - 1);
        }

        private static int BinarySearch(int[] array, int target)
        {
            int lo = 0;
            int hi = array.Length - 1;

            while (lo <= hi)
            {
                int middle = (lo + hi) / 2;

                if (target > array[middle])
                {
                    lo = middle + 1;
                }
                else if (target < array[middle])
                {
                    hi = middle - 1;
                }
                else if (target == array[middle])
                {
                    return middle;
                }
            }

            return -1;
        }

        private static int RecursiveBinarySearch(int[] array, int target, int lo, int hi)
        {
            while (lo <= hi)
            {
                int middle = (lo + hi) / 2;

                if (target == array[middle])
                {
                    return middle;
                }
                else if (target > array[middle])
                {
                    return RecursiveBinarySearch(array, target, middle + 1, hi);
                }
                else if (target < array[middle])
                {
                    return RecursiveBinarySearch(array, target, lo, middle - 1);
                }
            }

            return -1;
        }
    }
}
