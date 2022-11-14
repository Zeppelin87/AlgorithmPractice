namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_MinNumberOfJumps
    {
        public static void Run()
        {
            int[] array = { 3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3 };

            // O(n) time complexity | O(1) space complexity.
            // Where: 'n' is the size of the input 'array[]'.
            var result = Solution(array);
        }

        private static int Solution(int[] array)
        {
            if (array.Length == 1)
            {
                return 0;
            }

            int jumps = 0;
            int maxReach = array[0];
            int steps = array[0];

            for (int i = 1; i < array.Length - 1; i++)
            {
                maxReach = Math.Max(maxReach, i + array[i]);
                steps--;

                if (steps == 0)
                {
                    jumps++;
                    steps = maxReach - i;
                }
            }

            return jumps + 1;
        }
    }
}
