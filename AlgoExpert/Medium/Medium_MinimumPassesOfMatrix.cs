namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MinimumPassesOfMatrix
    {
        public static void Run()
        {
            int[][] matrix = new int[][] {
                new int[] { 0, -1, -3, 2, 0 },
                new int[] { 1, -2, -5, -1, -3 },
                new int[] { 3, 0, 0, -4, -1 },
            };

            // Time Complexity: O(w * h) -- (where 'w' is the width of the matrix and 'h' is the height of the matrix).
            // Space Complexity: O(w * h).
            var result = Solution(matrix);
        }

        private static int Solution(int[][] matrix)
        {
            int passes = ConvertNegatives(matrix);
            return (!ContainsNegative(matrix)) ? passes - 1 : -1;
        }

        private static int ConvertNegatives(int[][] matrix)
        {
            var queue = GetAllPositivePositions(matrix);

            int passes = 0;

            while (queue.Count > 0)
            {
                int currentSize = queue.Count;

                while (currentSize > 0)
                {
                    int[] vals = queue[0];
                    queue.RemoveAt(0);
                    int currentRow = vals[0];
                    int currentCol = vals[1];

                    var adjacentPositions = GetAdjacentPositions(matrix, currentRow, currentCol);

                    foreach (var position in adjacentPositions)
                    {
                        int row = position[0];
                        int col = position[1];

                        int value = matrix[row][col];

                        if (value < 0)
                        {
                            matrix[row][col] *= -1;
                            queue.Add(new int[] { row, col });
                        }
                    }

                    currentSize -= 1;
                }

                passes += 1;
            }

            return passes;
        }

        private static List<int[]> GetAllPositivePositions(int[][] matrix)
        {
            var positivePositions = new List<int[]>();

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    int value = matrix[row][col];
                    if (value > 0)
                    {
                        positivePositions.Add(new int[] { row, col });
                    }
                }
            }

            return positivePositions;
        }

        private static List<int[]> GetAdjacentPositions(int[][] matrix, int row, int col)
        {
            var adjacentPositions = new List<int[]>();

            if (row > 0)
            {
                adjacentPositions.Add(new int[] { row - 1, col });
            }

            if (row < matrix.Length - 1)
            {
                adjacentPositions.Add(new int[] { row + 1, col });
            }

            if (col > 0)
            {
                adjacentPositions.Add(new int[] { row, col - 1 });
            }

            if (col < matrix[0].Length - 1)
            {
                adjacentPositions.Add(new int[] { row, col + 1 });
            }

            return adjacentPositions;
        }

        private static bool ContainsNegative(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                foreach (var value in row)
                {
                    if (value < 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
