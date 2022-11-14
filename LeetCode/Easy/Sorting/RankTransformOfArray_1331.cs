namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class RankTransformOfArray_1331
    {
        public static void Run()
        {
            int[] arr = new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 };

            var result = Solution(arr);
        }

        private static int[] Solution(int[] arr)
        {
            int[] temp = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                temp[i] = arr[i];
            }

            Array.Sort(temp);

            var dictionary = new Dictionary<int, int>();
            for (int i = 0; i < temp.Length; i++)
            {
                if (!dictionary.ContainsKey(temp[i]))
                {
                    dictionary.Add(temp[i], dictionary.Count + 1);
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = dictionary[arr[i]];
            }

            return arr;
        }
    }
}
