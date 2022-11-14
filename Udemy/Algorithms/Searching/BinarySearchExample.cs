namespace AlgorithmPractice.Udemy.Algorithms.Searching
{
    public static class BinarySearchExample
    {
        public static void Run()
        {
            int[] arr = new int[] { 10, 25, 32, 45, 55, 68 };
            int key = 55;

            int result = Search(arr, key);
        }

        private static int Search(int[] arr, int key)
        {
            arr = InsertionSort(arr);

            int lo = 0;
            int hi = arr.Length - 1;
            int middle = (lo + hi) / 2;

            while (lo <= hi)
            {
                if (key > arr[middle])
                {
                    // Search right sub-array.
                    lo = middle + 1;
                }
                else if (key < arr[middle])
                {
                    // Search left sub-arry.
                    hi = middle - 1;
                }
                else if (key == arr[middle])
                {
                    return middle;
                }

                middle = (lo + hi) / 2;
            }

            return -1;
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
