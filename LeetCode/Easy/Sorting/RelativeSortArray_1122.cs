namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public class RelativeSortArray_1122
    {
        public static void Run()
        {
            int[] arr1 = new int[] { 2, 3, 1, 3, 2, 4, 6, 7, 9, 2, 19 };
            int[] arr2 = new int[] { 2, 1, 4, 3, 9, 6 };

            var result = Solution(arr1, arr2);
        }

        private static int[] Solution(int[] arr1, int[] arr2)
        {
            var freq = new Dictionary<int, int>();
            int[] result = new int[arr1.Length];

            // Create a freq Dictionary that contains all values from arr2[].
            for (int i = 0; i < arr2.Length; i++)
            {
                if (!freq.ContainsKey(arr2[i]))
                {
                    freq.Add(arr2[i], 0);
                }
            }

            // Update freq Dictionary w/ values from arr1[].
            // If value in arr1[] is not in freq, add to end of result[]... to be sorted later.
            int last = result.Length - 1;
            for (int i = 0; i < arr1.Length; i++)
            {
                if (freq.ContainsKey(arr1[i]))
                {
                    freq[arr1[i]]++;
                }
                else
                {
                    result[last--] = arr1[i];
                }
            }

            // Add each element from freq Dictionary to result[] in order based on arr2[]
            int count = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                for (int j = 0; j < freq[arr2[i]]; j++)
                {
                    result[count++] = arr2[i];
                }
            }

            // Sort the values at the end of result[] that are not found in arr2[]
            Array.Sort(result, count, result.Length - count);

            return result;
        }
    }

    //public class Comparer : IComparer<int>
    //{
    //    private Dictionary<int, int> dict;
    //    public Comparer(Dictionary<int, int> dict)
    //    {
    //        this.dict = dict;
    //    }

    //    public int Compare(int x, int y)
    //    {
    //        if (!dict.ContainsKey(y) && !dict.ContainsKey(x)) return x - y;
    //        else if (!dict.ContainsKey(y)) return -1;
    //        else if (!dict.ContainsKey(x)) return 1;
    //        else return dict[x] - dict[y];
    //    }
    //}
}
