namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MatrixCellsInDistanceOrder_1030
    {
        public static void Run()
        {
            int rows = 1;
            int cols = 2;
            int rCenter = 0;
            int cCenter = 0;

            var result = Solution(rows, cols, rCenter, cCenter);
        }

        private static int[][] Solution(int rows, int cols, int rCenter, int cCenter)
        {
            // 1. Create matrix.
            int[,] matrix = new int[rows, cols];

            // 2. Calculate the distance between two cells (r1, c1) and (r2, c2) == |r1 - r2| + |c1 - c2|
            var priortiyQueue = new PriorityQueue<int[], int>();

            // O(n)
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    int distance = Math.Abs(rCenter - row) + Math.Abs(cCenter - col);
                    priortiyQueue.Enqueue(new int[] { row, col }, distance);
                }
            }

            int count = 0;
            int[][] answer = new int[matrix.Length][];

            // O(n)
            while (priortiyQueue.Count > 0)
            {
                answer[count++] = priortiyQueue.Dequeue();
            }


            return answer;
        }
    }
}
