namespace AlgorithmPractice.LeetCode.Easy.BinarySearch
{
    public static class IntersectionOfThreeSortedArrays_1213
    {
        public static void Run()
        {
            int[] arr1 = new int[] { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[] { 1, 2, 5, 7, 9 };
            int[] arr3 = new int[] { 1, 3, 4, 5, 8 };

            // Time Complexity: 

            // Space Complexity: 

            var result = Solution(arr1, arr2, arr3);
        }

        private static IList<int> Solution(int[] arr1, int[] arr2, int[] arr3)
        {
            return new List<int>();
        }

        private static int BinarySearch(int[] arr, int key)
        {
            int lo = 0;
            int hi = arr.Length;

            while (lo < hi)
            {
                int middle = (lo + hi) / 2;

                if (key > arr[middle])
                {
                    lo = middle + 1;
                }
                else if (key < arr[middle])
                {
                    hi = middle - 1;
                }
                else if (arr[middle] == key)
                {
                    return middle;
                }
            }

            return -1;
        }
    }
}
