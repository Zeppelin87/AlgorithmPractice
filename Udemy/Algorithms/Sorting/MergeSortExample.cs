namespace AlgorithmPractice.Udemy.Algorithms.Sorting
{
    public static class MergeSortExample
    {
        public static void Run()
        {
            // Merge Sort:
            //  Time Complexity     -- O(n log n)
            //  Space Complexity    -- O(n)

            int[] arr = new int[] { 6, 5, 3, 1, 8, 7, 2, 4 };
            Extensions.SortingExtension.ConsoleLog(arr);

            int[] sortedArray = MergeSort(arr);
            Extensions.SortingExtension.ConsoleLog(sortedArray);
        }

        private static int[] MergeSort(int[] arr)
        {
            int[] left;
            int[] right;
            int[] result = new int[arr.Length];

            // Since this is a recursive algorithm, we need a base case to avoid a stack overflow.
            if (arr.Length <= 1)
            {
                return arr;
            }

            int midPoint = arr.Length / 2;
            left = new int[midPoint];

            if (arr.Length % 2 == 0)
            {
                right = new int[midPoint];
            }
            else
            {
                right = new int[midPoint + 1];
            }

            for (int i = 0; i < midPoint; i++)
            {
                left[i] = arr[i];
            }

            int x = 0;
            for (int i = midPoint; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }

            // Recursively sort the left array.
            left = MergeSort(left);

            // Recursively sort the right array.
            right = MergeSort(right);

            // Merge oupt two sorted arrays.
            result = Merge(left, right);

            return result;
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];

            int leftIndex = 0;
            int rightIndex = 0;
            int resultIndex = 0;

            while (leftIndex < left.Length || rightIndex < right.Length)
            {
                if (leftIndex < left.Length && rightIndex < right.Length)
                {
                    if (left[leftIndex] <= right[rightIndex])
                    {
                        result[resultIndex] = left[leftIndex];
                        leftIndex++;
                        resultIndex++;
                    }
                    else
                    {
                        result[resultIndex] = right[rightIndex];
                        rightIndex++;
                        resultIndex++;
                    }
                }
                else if (leftIndex < left.Length)
                {
                    result[resultIndex] = left[leftIndex];
                    leftIndex++;
                    resultIndex++;
                }
                else if (rightIndex < right.Length)
                {
                    result[resultIndex] = right[rightIndex];
                    rightIndex++;
                    resultIndex++;
                }
            }

            return result;
        }
    }
}
