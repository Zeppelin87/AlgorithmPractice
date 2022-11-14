namespace AlgorithmPractice.Udemy.Algorithms.Sorting
{
    public static class InsertionSortExample
    {
        public static void Run()
        {
            // Insertion Sort:
            //  Time Complexity     -- O(n^2)
            //  Space Complexity    -- O(1)

            int[] arr = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };
            Extensions.SortingExtension.ConsoleLog(arr);

            int[] sortedArray = InsertionSort(arr);
            Extensions.SortingExtension.ConsoleLog(sortedArray);
        }

        private static int[] InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }

            return arr;
        }
    }
}
