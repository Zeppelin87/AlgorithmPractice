namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class HighFive_1086
    {
        public static void Run()
        {
            int[][] items = new int[][]
            {
                new int[] { 5, 91 },
                new int[] { 5, 92 },
                new int[] { 3, 93 },
                new int[] { 3, 97 },
                new int[] { 5, 60 },
                new int[] { 3, 77 },
                new int[] { 5, 65 },
                new int[] { 5, 87 },
                new int[] { 5, 100 },
                new int[] { 3, 100 },
                new int[] { 3, 76 }
            };

            var dictionary = new SortedDictionary<int, PriorityQueue<int[], int[]>>();

            for (int i = 0; i < items.Length; i++)
            {
                int id = items[i][0];

                if (!dictionary.ContainsKey(id))
                {
                    dictionary[id] = new PriorityQueue<int[], int[]>(new ItemComparer());
                }

                dictionary[id].Enqueue(items[i], items[i]);
            }

            int K = 5;
            List<int[]> solution = new List<int[]>();

            int[] keys = dictionary.Keys.ToArray();
            Array.Sort(keys);

            foreach (int key in keys)
            {
                int sum = 0;
                for (int i = 0; i < K; i++)
                {
                    sum += dictionary[key].Dequeue()[1];
                }

                solution.Add(new int[] { key, sum / 5 });
            }
        }
    }

    public class ItemComparer : IComparer<int[]>
    {
        public int Compare(int[]? x, int[]? y)
        {
            // Items with higher id go first
            if (x[0] != y[0])
            {
                return x[0] - y[0];
            }

            // If id(s) are the same, item with higher score goes first.
            return y[1] - x[1];
        }
    }
}
