namespace AlgorithmPractice.Udemy.Algorithms.Sorting
{
    public static class QuickSortExample
    {
        public static void Run()
        {
            // Quick Sort:
            //  Time Complexity     -- O(n log n)
            //  Space Complexity    -- O(log n) / O(1)

            int[] arr = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };
            Extensions.SortingExtension.ConsoleLog(arr);

            int[] sortedArray = QuickSort(arr, 0, arr.Length - 1);
            Extensions.SortingExtension.ConsoleLog(sortedArray);
        }

        private static int[] QuickSort(int[] arr, int leftIndex, int rightIndex)
        {
            int i = leftIndex;
            int j = rightIndex;
            int pivot = arr[leftIndex];

            while (i <= j)
            {
                // From leftIndex, find value greater than pivot.
                while (pivot > arr[i])
                {
                    i++;
                }

                // From rightIndex, find value less than pivot.
                while (arr[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                    Swap(arr, i, j);
                    i++;
                    j--;
                }
            }

            if (leftIndex < j)
            {
                QuickSort(arr, leftIndex, j);
            }

            if (i < rightIndex)
            {
                QuickSort(arr, i, rightIndex);
            }

            return arr;
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
