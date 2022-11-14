namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_ProductSum
    {
        public static void Run()
        {
            var array = new List<object>()
            {
                5,
                2,
                new List<object>()
                {
                    7,
                    -1
                },
                3,
                new List<object>()
                {
                    6,
                    new List<object>()
                    {
                        -13,
                        8
                    },
                    4,
                },
            };

            int depth = 1;

            // Time Complexity: O(n) -- Linear (where 'n' is the number of values in the array).
            // Space Complexity: O(d) -- (where 'd' is the greatest depth of "special" arrays in the array.
            var result = Solution(array, depth);
        }

        private static int Solution(List<object> array, int depth)
        {
            int levelSum = 0;
            int productSum = 0;

            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] is int)
                {
                    levelSum += (int)array[i];
                }
                else if (array[i] is List<object>)
                {
                    levelSum += Solution((List<object>)array[i], depth + 1);
                }
            }

            productSum += levelSum * depth;
            return productSum;
        }
    }
}
