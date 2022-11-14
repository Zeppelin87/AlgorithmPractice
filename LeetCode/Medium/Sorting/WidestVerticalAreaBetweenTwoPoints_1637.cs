namespace AlgorithmPractice.LeetCode.Medium.Sorting
{
    public static class WidestVerticalAreaBetweenTwoPoints_1637
    {
        public static void Run()
        {
            int[][] points = new int[6][]
            {
                //new int[] { 8, 7 },
                //new int[] { 9, 9 },
                //new int[] { 7, 4 },
                //new int[] { 9, 7 }
                new int[] { 3, 1 },
                new int[] { 9, 0 },
                new int[] { 1, 0 },
                new int[] { 1, 4 },
                new int[] { 5, 3 },
                new int[] { 8, 8 }
            };

            // Time Complexity: O(n log n)

            // Space Complexity: O(n)

            var result = Solution_FirstTry(points);
        }

        private static int Solution_FirstTry(int[][] points)
        {
            // Widest vertical area.
            //  - Find the greatest difference in x-distance between any two adjacent points in a graph.

            // Space: O(n)
            int[] xAxis = new int[points.Length];

            // Time: O(n)
            for (int i = 0; i < points.Length; i++)
            {
                xAxis[i] = points[i][0];
            }

            // O(n log n)
            Array.Sort(xAxis);

            int temp = 0;
            int result = 0;

            // O(n)
            for (int i = 0; i < xAxis.Length - 1; i++)
            {
                temp = Math.Abs(xAxis[i] - xAxis[i + 1]);

                if (temp > result)
                {
                    result = temp;
                }
            }

            return result;
        }
    }
}
