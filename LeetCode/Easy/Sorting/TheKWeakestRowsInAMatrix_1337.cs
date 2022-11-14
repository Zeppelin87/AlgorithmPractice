namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class TheKWeakestRowsInAMatrix_1337
    {
        public static void Run()
        {
            int[][] arr = new int[][]
            {
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 0 },
                new int[] { 1, 0, 0, 0, 0 },
                new int[] { 1, 1, 0, 0, 0 },
                new int[] { 1, 1, 1, 1, 1 }
                //new int[] { 1, 0},
                //new int[] { 0, 0},
                //new int[] { 1, 0}
            };

            int k = 2;

            int[] result = Solution(arr, k);
        }

        private static int[] Solution(int[][] arr, int k)
        {
            int[] weakestRows = new int[k];
            IDictionary<int, int> dictionary = new Dictionary<int, int>();

            var otherDictionary = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var result = BinarySearch(arr[i]);

                int count = 0;
                for (int j = 0; j < arr[i].Length; j++)
                {
                    if (arr[i][j] == 0)
                    {
                        break;
                    }
                    count++;
                }

                if (!dictionary.ContainsKey(i))
                {
                    dictionary.Add(i, count);
                }
                else
                {
                    dictionary[i] += 1;
                }
            }

            var sortedDictionary = dictionary.OrderBy(x => x.Value);

            int x = 0;
            foreach (var pair in sortedDictionary)
            {
                if (x == k)
                {
                    break;
                }
                else
                {
                    weakestRows[x] = pair.Key;
                    x++;
                }
            }

            return weakestRows;
        }

        private static int BinarySearch(int[] arr)
        {
            int low = 0;
            int high = arr.Length;

            while (low < high)
            {
                int middle = low + (high - low) / 2;

                if (arr[middle] == 1)
                {
                    low = middle + 1;
                }
                else
                {
                    high = middle;
                }
            }

            return low;
        }
    }
}
