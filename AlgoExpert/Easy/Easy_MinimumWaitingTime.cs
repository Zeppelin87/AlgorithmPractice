namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_MinimumWaitingTime
    {
        public static void Run()
        {
            int[] queries = new int[] { 3, 2, 1, 2, 6 };

            // Time Complexity: 
            // Space Complexity: 
            int result = Solution(queries);
        }

        private static int Solution(int[] queries)
        {
            // O(log n)
            Array.Sort(queries);

            // O(n)
            int totalWaitingTime = 0;
            for (int i = 0; i < queries.Length; i++)
            {
                int duration = queries[i];
                int queriesLeft = queries.Length - (i + 1);
                totalWaitingTime += duration * queriesLeft;
            }

            return totalWaitingTime;
        }
    }
}
