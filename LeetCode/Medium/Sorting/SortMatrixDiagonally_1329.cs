namespace AlgorithmPractice.LeetCode.Medium.Sorting
{
    public static class SortMatrixDiagonally_1329
    {
        public static void Run()
        {
            int[][] mat = new int[3][]
            {
                new int[] { 3, 3, 1, 1 },
                new int[] { 2, 2, 1, 2 },
                new int[] { 1, 1, 1, 2 }
            };

            // Time Complexity: O(n * m * log(min(n,m)))

            // Space Complexity: O(n x m)

            var result = Solution_PriorityQueue(mat);
        }

        private static int[][] Solution_PriorityQueue(int[][] mat)
        {
            // We need to:
            //  1. Access each diagonal.
            //  2. Store each diagonal.
            //  3. Sort each diagonal.

            int row = mat.Length;
            int col = mat[0].Length;

            // Create a map to store each diagonal.
            //  - the key for this map if (row - col).
            //  - the value is a list of the values within that diagonal.
            var map = new Dictionary<int, PriorityQueue<int, int>>();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int key = i - j;

                    if (!map.ContainsKey(key))
                    {
                        map.Add(key, new PriorityQueue<int, int>());
                    }

                    map[key].Enqueue(mat[i][j], mat[i][j]);
                }
            }

            // Iterate through the (sorted) PQ of diagonals & populate mat[][] sorted order.
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    int key = i - j;

                    mat[i][j] = map[key].Dequeue();
                }
            }

            return mat;
        }
    }
}
