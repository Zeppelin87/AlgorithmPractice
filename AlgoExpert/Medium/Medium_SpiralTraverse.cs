namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_SpiralTraverse
    {
        public static void Run()
        {
            int[,] array =
            {
                { 1,  2,   3, 4 },
                { 12, 13, 14, 5 },
                { 11, 16, 15, 6 },
                { 10,  9,  8, 7 },
            };

            // Time Complexity: O(N) -- Linear (where 'N' is the total number of elements in the 'n x m' array[]).
            // Space Complexity: - O(N) -- Linear.
            var result = Solution(array);
        }

        private static List<int> Solution(int[,] array)
        {
            if (array.GetLength(0) == 0)
            {
                return new List<int>();
            }

            var result = new List<int>();
            int startRow = 0;
            int endRow = array.GetLength(0) - 1;
            int startCol = 0;
            int endCol = array.GetLength(1) - 1;


            while (startRow <= endRow && startCol <= endCol)
            {
                for (int col = startCol; col <= endCol; col++)
                {
                    result.Add(array[startRow, col]);
                }

                for (int row = startRow + 1; row <= endRow; row++)
                {
                    result.Add(array[row, endCol]);
                }

                for (int col = endCol - 1; col >= startCol; col--)
                {
                    // Handles edge case when there's a single row in the middle of the matrix.
                    // We don't want to double-count values in this row, which are already accounted for in the 1st for loop above.
                    if (startRow == endRow)
                    {
                        break;
                    }

                    result.Add(array[endRow, col]);
                }

                for (int row = endRow - 1; row > startRow; row--)
                {
                    // Handles edge case when there's a single column in the middle of the matrix.
                    // We don't want to double-count values column, which are already accounted for in the 2nd for loop above.
                    if (startCol == endCol)
                    {
                        break;
                    }

                    result.Add(array[row, startCol]);
                }

                startRow++;
                endRow--;

                startCol++;
                endCol--;
            }

            return result;
        }
    }
}
