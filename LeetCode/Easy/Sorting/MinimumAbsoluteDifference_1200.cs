namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public class MinimumAbsoluteDifference_1200
    {
        public static void Run()
        {
            int[] arr = new int[] { 1, 3, 6, 10, 15 };
            var result = Solution(arr);
            var result2 = Solution2(arr);
        }

        private static IList<IList<int>> Solution(int[] arr)
        {
            Array.Sort(arr);
            int minAbsoluteDifference = Math.Abs(arr[0] - arr[arr.Length - 1]);

            // O(n)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int currentDistance = Math.Abs(arr[i] - arr[i + 1]);

                if (currentDistance < minAbsoluteDifference)
                {
                    minAbsoluteDifference = currentDistance;
                }
            }

            IList<IList<int>> result = new List<IList<int>>();

            // O(n)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                if (Math.Abs(arr[i] - arr[i + 1]) == minAbsoluteDifference)
                {
                    result.Add(new List<int>() { arr[i], arr[i + 1] });
                }
            }

            return result;
        }

        private static IList<IList<int>> Solution2(int[] arr)
        {
            Array.Sort(arr);
            int min_value = Math.Abs(arr[0] - arr[arr.Length - 1]);
            IList<IList<int>> result = new List<IList<int>>();

            // O(n)
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int diff = Math.Abs(arr[i] - arr[i + 1]);

                if (diff <= min_value)
                {
                    if (diff < min_value)
                    {
                        min_value = diff;
                        result.Clear();
                    }

                    result.Add(new List<int>() { arr[i], arr[i + 1] });
                }

                if (diff < min_value)
                {
                    min_value = diff;
                }
            }

            return result;
        }
    }
}
