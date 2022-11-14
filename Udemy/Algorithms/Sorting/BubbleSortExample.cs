namespace AlgorithmPractice.Udemy.Algorithms.Sorting
{
    public static class BubbleSortExample
    {
        public static void Run()
        {
            // Bubble Sort:
            //  Time Complexity     -- O(n^2)
            //  Space Complexity    -- O(1)

            int[] arr = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };
            Extensions.SortingExtension.ConsoleLog(arr);

            int[] sortedArray = BubbleSort(arr);
            Extensions.SortingExtension.ConsoleLog(sortedArray);
        }

        private static int[] BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Extensions.SortingExtension.ConsoleLog(arr);
                for (int j = 0; j < arr.Length - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }

            return arr;
        }
    }
}
