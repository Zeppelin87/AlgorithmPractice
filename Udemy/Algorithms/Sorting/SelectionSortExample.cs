namespace AlgorithmPractice.Udemy.Algorithms.Sorting
{
    public static class SelectionSortExample
    {
        public static void Run()
        {
            // Selection Sort:
            //  Time Complexity     -- O(n^2)
            //  Space Complexity    -- O(1)

            int[] arr = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };
            Extensions.SortingExtension.ConsoleLog(arr);

            int[] sortedArray = SelectionSort(arr);
            Extensions.SortingExtension.ConsoleLog(sortedArray);
        }

        private static int[] SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int min = i;
                int temp = arr[i];

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }

                //swap
                arr[i] = arr[min];
                arr[min] = temp;
            }

            return arr;
        }
    }
}
