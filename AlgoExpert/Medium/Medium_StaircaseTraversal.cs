namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_StaircaseTraversal
    {
        public static void Run()
        {
            int height = 3;
            int maxSteps = 5;

            // 
            // Where: 
            var result = Solution(height, maxSteps);
        }

        private static int Solution(int height, int maxSteps)
        {
            return NumberOfWaysToTop(height, maxSteps);
        }

        private static int NumberOfWaysToTop(int height, int maxSteps)
        {
            if (height <= 1)
            {
                return 1;
            }

            int numberOfWays = 0;
            for (int step = 1; step < Math.Min(maxSteps, height) + 1; step++)
            {
                numberOfWays += NumberOfWaysToTop(height - step, maxSteps);
            }

            return numberOfWays;
        }
    }
}
