namespace AlgorithmPractice.Udemy.Algorithms.Searching
{
    public static class LinearSearchExample
    {
        public static void Run()
        {
            int[] arr = new int[] { 12, 45, 69, 78, 89, 54 };
            int key = 69;

            int result = Search(arr, key);
        }

        private static int Search(int[] arr, int key)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == key)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
