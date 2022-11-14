namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_ZigZagTraverse
    {
        public static void Run()
        {
            var array = new List<List<int>>();
            //array.Add(new List<int>() { 1, 3, 4, 10});
            //array.Add(new List<int>() { 2, 5, 9, 11 });
            //array.Add(new List<int>() { 6, 8, 12, 15 });
            //array.Add(new List<int>() { 7, 13, 14, 16 });

            array.Add(new List<int>() { 1 });
            array.Add(new List<int>() { 2 });
            array.Add(new List<int>() { 3 });
            array.Add(new List<int>() { 4 });
            array.Add(new List<int>() { 5 });

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n) -- Linear.
            // Where 'n' is the total size of the input array[].
            var result = Solution(array);
        }

        private static List<int> Solution(List<List<int>> array)
        {
            int row = 0;
            int col = 0;

            var result = new List<int>();

            // Add fist cell, then start.
            result.Add(array[row][col]);

            while (row < array.Count && col < array[0].Count)
            {
                // Go down.
                if (col == 0 && row < array.Count - 1)
                {
                    row++;
                    result.Add(array[row][col]);

                    // Zig up.
                    while (row > 0 && col < array[0].Count - 1)
                    {
                        row--;
                        col++;
                        result.Add(array[row][col]);
                    }
                }
                else if (col == array[0].Count - 1 && row < array.Count - 1)
                {
                    row++;
                    result.Add(array[row][col]);

                    // Zag down.
                    while (col > 0 && row < array.Count - 1)
                    {
                        row++;
                        col--;
                        result.Add(array[row][col]);
                    }
                }

                // Go right.
                if (row == 0 && col < array[0].Count - 1)
                {
                    col++;
                    result.Add(array[row][col]);

                    // Zag down.
                    while (col > 0 && row < array.Count - 1)
                    {
                        row++;
                        col--;
                        result.Add(array[row][col]);
                    }
                }
                else if (row == array.Count - 1 && col < array[0].Count - 1)
                {
                    col++;
                    result.Add(array[row][col]);

                    // Zig up.
                    while (row > 0 && col < array[0].Count - 1)
                    {
                        row--;
                        col++;
                        result.Add(array[row][col]);
                    }
                }


                // On last cell, terminate.
                if (row == array.Count - 1 && col == array[0].Count - 1)
                {
                    break;
                }
            }

            return result;
        }
    }
}
