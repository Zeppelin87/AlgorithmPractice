namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_ArrayOfProduct
    {
        public static void Run()
        {
            int[] array = { 5, 1, 4, 2 };

            // Time Complexity: O(n^2) -- Quadratic (where 'n' is the size of the input array[]).
            // Space Complexity: O(n) -- Linear.
            var result = Solution_BruteForce(array);

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array[]).
            // Space Complexity: O(n) -- Linear.
            var result2 = Solution_LeftAndRightProdcuts(array);

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array[]).
            // Space Complexity: O(n) -- Linear.
            var result3 = Solution_Clean(array);
        }

        private static int[] Solution_BruteForce(int[] array)
        {
            int[] result = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                int sum = 1;
                for (int j = 0; j < array.Length; j++)
                {
                    if (i != j)
                    {
                        sum *= array[j];
                    }
                }

                result[i] = sum;
            }

            return result;
        }

        private static int[] Solution_LeftAndRightProdcuts(int[] array)
        {
            int[] result = new int[array.Length];
            int[] leftProducts = new int[array.Length];
            int[] rightProducts = new int[array.Length];

            int leftRunningProduct = 1;
            for (int i = 0; i < array.Length; i++)
            {
                leftProducts[i] = leftRunningProduct;
                leftRunningProduct *= array[i];
            }

            int rightRunningProduct = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                rightProducts[i] = rightRunningProduct;
                rightRunningProduct *= array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                result[i] = leftProducts[i] * rightProducts[i];
            }

            return result;
        }

        private static int[] Solution_Clean(int[] array)
        {
            int[] result = new int[array.Length];

            int leftRunningProduct = 1;
            for (int i = 0; i < array.Length; i++)
            {
                result[i] = leftRunningProduct;
                leftRunningProduct *= array[i];
            }

            int rightRunningProduct = 1;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                result[i] *= rightRunningProduct;
                rightRunningProduct *= array[i];
            }

            return result;
        }
    }
}
