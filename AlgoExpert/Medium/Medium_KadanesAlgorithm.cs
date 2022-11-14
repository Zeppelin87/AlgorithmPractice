namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_KadanesAlgorithm
    {
        public static void Run()
        {
            int[] array = { 3, 5, -9, 1, 3, -2, 3, 4, 7, 2, -9, 6, 3, 1, -5, 4 };

            // Time Complexity: 
            // Space Complexity: 
            var result = Solution(array);
        }

        private static int Solution(int[] array)
        {
            int maxEndingHere = array[0];
            int maxSoFar = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                int num = array[i];
                maxEndingHere = Math.Max(num, maxEndingHere + num);
                maxSoFar = Math.Max(maxSoFar, maxEndingHere);
            }

            return maxSoFar;
        }
    }
}
