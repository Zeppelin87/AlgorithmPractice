namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_FindThreeLargestNumbers
    {
        public static void Run()
        {
            int[] array = new int[] { 141, 1, 17, -7, -17, -27, 18, 541, 8, 7, 7 };

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(1) -- constant.
            var result = Solution(array);
        }

        private static int[] Solution(int[] array)
        {
            int first = int.MinValue;
            int second = int.MinValue;
            int third = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > third)
                {
                    first = second;
                    second = third;
                    third = array[i];
                }
                else if (array[i] > second)
                {
                    first = second;
                    second = array[i];
                }
                else if (array[i] > first)
                {
                    first = array[i];
                }
            }

            return new int[] { first, second, third };
        }
    }
}
