namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_SearchInSortedMatrix
    {
        public static void Run()
        {
            int target = 44;
            int[,] matrix = {
                {1, 4, 7, 12, 15, 1000},
                {2, 5, 19, 31, 32, 1001},
                {3, 8, 24, 33, 35, 1002},
                {40, 41, 42, 44, 45, 1003},
                {99, 100, 103, 106, 128, 1004},
            };

            // Time Complexity: O(n + m) -- (where 'n' is the amount of rows and 'm' is the length of columns in the matrix[,]).
            // Space Complexity: O(m).
            var result = Solution_BinarySearch_EachMatrix(matrix, target);

            // Time Complexity: O(n + m) -- (where 'n' is the amount of rows and 'm' is the length of columns in the matrix[,]).
            // Space Complexity: O(1) -- Constant.
            var result2 = Solution_ConstantSpace(matrix, target);
        }

        private static int[] Solution_ConstantSpace(int[,] matrix, int target)
        {
            int row = 0;
            int col = matrix.GetLength(1) - 1;

            while (row < matrix.GetLength(0) && col >= 0)
            {
                if (matrix[row, col] > target)
                {
                    col--;
                }
                else if (matrix[row, col] < target)
                {
                    row++;
                }
                else
                {
                    return new int[] { row, col };
                }
            }

            return new int[] { -1, -1 };
        }

        private static int[] Solution_BinarySearch_EachMatrix(int[,] matrix, int target)
        {
            int colMaxLength = matrix.GetLength(1);
            int[] array = new int[colMaxLength];
            int i = 0;

            int[] result = new int[2];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    array[i++] = matrix[row, col];
                }

                int colIndex = BinarySearch(array, target);

                if (colIndex != int.MinValue)
                {
                    result[0] = row;
                    result[1] = colIndex;

                    return result;
                }

                i = 0;
            }

            return new int[] { -1, -1 };
        }

        private static int BinarySearch(int[] array, int target)
        {
            int lo = 0;
            int hi = array.Length - 1;

            while (lo <= hi)
            {
                int middle = (lo + hi) / 2;

                if (target == array[middle])
                {
                    return middle;
                }
                else if (target > array[middle])
                {
                    lo = middle + 1;
                }
                else if (target < array[middle])
                {
                    hi = middle - 1;
                }
            }

            return int.MinValue;
        }
    }
}
