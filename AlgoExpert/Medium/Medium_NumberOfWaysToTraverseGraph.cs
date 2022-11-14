namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_NumberOfWaysToTraverseGraph
    {
        public static void Run()
        {
            int width = 4;
            int height = 3;

            // Time Complexity: 
            // Space Complexity: 
            var result = Solution(width, height);
        }

        private static int Solution(int width, int height)
        {
            if (width == 1 || height == 1)
            {
                return 1;
            }

            return Solution(width - 1, height) + Solution(width, height - 1);
        }
    }
}
