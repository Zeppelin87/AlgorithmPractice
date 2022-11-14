namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class HeightChecker_1051
    {
        public static void Run()
        {
            int[] heights = new int[] { 1, 1, 4, 2, 1, 3 };

            // Find all indices where heights[i] != expected[i]

            int[] expected = new int[heights.Length];

            for (int i = 0; i < expected.Length; i++)
            {
                expected[i] = heights[i];
            }

            Array.Sort(expected);

            int count = 0;
            for (int i = 0; i < heights.Length; i++)
            {
                if (heights[i] != expected[i])
                {
                    count++;
                }
            }
        }
    }
}
