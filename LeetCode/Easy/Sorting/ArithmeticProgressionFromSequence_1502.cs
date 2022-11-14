namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class ArithmeticProgressionFromSequence_1502
    {
        public static void Run()
        {
            int[] arr = new int[] { 1, 2, 4 };

            var result = Solution(arr);
        }

        private static bool Solution(int[] arr)
        {
            Array.Sort(arr);

            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] - arr[i - 1] != arr[i] - arr[i + 1])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
