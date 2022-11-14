namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_RemoveIslands
    {
        public static void Run()
        {
            int[][] matrix = new int[][] {
                new int[] {1, 0, 0, 0, 0, 0},
                new int[] {0, 1, 0, 1, 1, 1},
                new int[] {0, 0, 1, 0, 1, 0},
                new int[] {1, 1, 0, 0, 1, 0},
                new int[] {1, 0, 1, 1, 0, 0},
                new int[] {1, 0, 0, 0, 0, 1},
            };

            // Time Complexity: O(wh) -- (where 'w' is the width of the matrix and 'h' is the height of the matrix).
            // Space Complexity: O(wh).
            var result = Solution(matrix);
        }

        private static int[][] Solution(int[][] matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine("[{0}]", string.Join(", ", row));
            }

            Console.WriteLine();
            Console.WriteLine("---");
            Console.WriteLine();

            bool[][] visited = new bool[matrix.GetLength(0)][];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                visited[i] = new bool[matrix[i].Length];
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    bool rowIsBorder = row == 0 || row == matrix.Length - 1;
                    bool colIsBorder = col == 0 || col == matrix[row].Length - 1;
                    bool isBorder = rowIsBorder || colIsBorder;

                    if (!isBorder)
                    {
                        continue;
                    }

                    if (matrix[row][col] != 1)
                    {
                        continue;
                    }

                    ChangeOnesConnectedToBordersToTwos(matrix, row, col);
                }
            }

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    int color = matrix[row][col];
                    if (color == 1)
                    {
                        matrix[row][col] = 0;
                    }
                    else if (color == 2)
                    {
                        matrix[row][col] = 1;
                    }
                }
            }

            foreach (var row in matrix)
            {
                Console.WriteLine("[{0}]", string.Join(", ", row));
            }

            return matrix;
        }

        private static void ChangeOnesConnectedToBordersToTwos(int[][] matrix, int startRow, int startCol)
        {
            var stack = new Stack<int[]>();
            stack.Push(new int[] { startRow, startCol });

            while (stack.Count > 0)
            {
                var current = stack.Pop();
                int currentRow = current[0];
                int currentCol = current[1];

                matrix[currentRow][currentCol] = 2;

                var neighbors = GetNeighbors(matrix, currentRow, currentCol);
                foreach (var neighbor in neighbors)
                {
                    int row = neighbor[0];
                    int col = neighbor[1];

                    if (matrix[row][col] != 1)
                    {
                        continue;
                    }

                    stack.Push(neighbor);
                }
            }
        }

        private static List<int[]> GetNeighbors(int[][] matrix, int row, int col)
        {
            int numRows = matrix.Length;
            int numCols = matrix[row].Length;
            var neighbors = new List<int[]>();

            if (row - 1 >= 0)
            {
                neighbors.Add(new int[] { row - 1, col }); // Up.
            }

            if (row + 1 < numRows)
            {
                neighbors.Add(new int[] { row + 1, col }); // Down.
            }

            if (col - 1 >= 0)
            {
                neighbors.Add(new int[] { row, col - 1 }); // Left.
            }

            if (col + 1 < numCols)
            {
                neighbors.Add(new int[] { row, col + 1 }); // Left.
            }

            return neighbors;
        }
    }
}
