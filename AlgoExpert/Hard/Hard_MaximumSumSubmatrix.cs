namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_MaximumSumSubmatrix
    {
        public static void Run()
        {
            int[,] matrix = {
                { 2, 4 },
                { 5, 6 },
                { -3, 2 },
            };

            int size = 2;

            // O(w * h) time complexity | O(w * h) space complexity.
            // Where: 'w' is the width of the martix[,] & 'h' is the height of the matrix[,].
            var result = Solution(matrix, size);
        }

        private static int Solution(int[,] matrix, int size)
        {
            int[,] sums = CreateSumMatrix(matrix);
            int maxSubMatrixSum = int.MinValue;

            for (int row = size - 1; row < matrix.GetLength(0); row++)
            {
                for (int col = size - 1; col < matrix.GetLength(1); col++)
                {
                    int total = sums[row, col];

                    bool touchesTopBorder = (row - size < 0);
                    if (!touchesTopBorder)
                    {
                        total -= sums[row - size, col];
                    }

                    bool touchesLeftBorder = (col - size < 0);
                    if (!touchesLeftBorder)
                    {
                        total -= sums[row, col - size];
                    }

                    bool touchesTopOrLeftBorder = (touchesTopBorder || touchesLeftBorder);
                    if (!touchesTopOrLeftBorder)
                    {
                        total += sums[row - size, col - size];
                    }

                    maxSubMatrixSum = Math.Max(maxSubMatrixSum, total);
                }
            }

            return maxSubMatrixSum;
        }

        private static int[,] CreateSumMatrix(int[,] matrix)
        {
            int[,] sums = new int[matrix.GetLength(0), matrix.GetLength(1)];
            sums[0, 0] = matrix[0, 0];

            // Fill the first row.
            for (int idx = 1; idx < matrix.GetLength(1); idx++)
            {
                sums[0, idx] = sums[0, idx - 1] + matrix[0, idx];
            }

            // Fill in the first column.
            for (int idx = 1; idx < matrix.GetLength(0); idx++)
            {
                sums[idx, 0] = sums[idx - 1, 0] + matrix[idx, 0];
            }

            // Fill in the rest of the matrix.
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    sums[row, col] = sums[row - 1, col] + sums[row, col - 1] - sums[row - 1, col - 1] + matrix[row, col];
                }
            }

            return sums;
        }
    }
}
