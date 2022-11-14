namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_RiverSizes
    {
        public static void Run()
        {
            int[,] matrix = {
                {1, 0, 0, 1, 0},
                {1, 0, 1, 0, 0},
                {0, 0, 1, 0, 1},
                {1, 0, 1, 0, 1},
                {1, 0, 1, 1, 0},
            };

            // Time Complexity: O(wh) -- (where 'w' is the width of the matrix & 'h' is the height of the matrix).
            // Space Complexity: O(wh)
            var result = Solution(matrix);
        }

        private static List<int> Solution(int[,] matrix)
        {
            var rivers = new List<int>();
            var visited = new bool[matrix.GetLength(0), matrix.GetLength(1)];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (visited[row, col])
                    {
                        continue;
                    }

                    TraverseNode(matrix, row, col, rivers, visited);
                }
            }

            return rivers;
        }

        private static void TraverseNode(int[,] matrix, int row, int col, List<int> rivers, bool[,] visited)
        {
            int currentRiverSize = 0;
            var nodesToExplore = new Stack<int[]>();
            nodesToExplore.Push(new int[] { row, col });

            while (nodesToExplore.Count != 0)
            {
                var node = nodesToExplore.Pop();
                row = node[0];
                col = node[1];

                if (visited[row, col])
                {
                    continue;
                }

                visited[row, col] = true;

                if (matrix[row, col] == 0)
                {
                    continue;
                }

                currentRiverSize++;
                var unvisitedNeighbors = GetUnvisitedNeighbors(matrix, row, col);

                foreach (var neighbor in unvisitedNeighbors)
                {
                    nodesToExplore.Push(neighbor);
                }
            }

            if (currentRiverSize > 0)
            {
                rivers.Add(currentRiverSize);
            }
        }

        private static List<int[]> GetUnvisitedNeighbors(int[,] matrix, int row, int col)
        {
            var unvisitedNeighbors = new List<int[]>();

            // Add left.
            if (col > 0 && matrix[row, col - 1] != 2)
            {
                unvisitedNeighbors.Add(new int[] { row, col - 1 });
            }

            // Add right.
            if (col < matrix.GetLength(1) - 1 && matrix[row, col + 1] != 2)
            {
                unvisitedNeighbors.Add(new int[] { row, col + 1 });
            }

            // Add up.
            if (row > 0 && matrix[row - 1, col] != 2)
            {
                unvisitedNeighbors.Add(new int[] { row - 1, col });
            }

            // Add down.
            if (row < matrix.GetLength(0) - 1 && matrix[row + 1, col] != 2)
            {
                unvisitedNeighbors.Add(new int[] { row + 1, col });
            }

            return unvisitedNeighbors;
        }
    }
}
