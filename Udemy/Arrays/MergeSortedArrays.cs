namespace AlgorithmPractice.Udemy.Arrays
{
    public static class MergeSortedArrays
    {
        public static void Run()
        {
            int[] arr1 = new int[] { 0, 3, 4, 31 };
            int[] arr2 = new int[] { 4, 6, 30 };

            int[] mergedArray = Merge(arr1, arr2);
        }

        public static int[] Merge(int[] array1, int[] array2)
        {
            int[] mergedArray = new int[array1.Length + array2.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < array1.Length && j < array2.Length)
            {
                if (array1[i] < array2[j])
                {
                    mergedArray[k++] = array1[i++];
                }
                else
                {
                    mergedArray[k++] = array2[j++];
                }
            }

            while (i < array1.Length)
            {
                mergedArray[k++] = array1[i++];
            }

            while (j < array2.Length)
            {
                mergedArray[k++] = array2[j++];
            }

            return mergedArray;
        }
    }
}
