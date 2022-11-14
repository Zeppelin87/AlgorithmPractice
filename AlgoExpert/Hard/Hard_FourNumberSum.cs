namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_FourNumberSum
    {
        public static void Run()
        {
            int target = 16;
            int[] array = new int[] { 7, 6, 4, -1, 1, 2 };

            // Average: O(n^2) time complexity | O(n^2) space complexity.
            // Worst: O(n^3) time complexity | O(n^2) space complexity.
            // Where 'n' is the length of the input array[].
            var result = Solution(array, target);
        }

        private static List<int[]> Solution(int[] array, int targetSum)
        {
            var allPairSums = new Dictionary<int, List<int[]>>();
            var result = new List<int[]>();

            for (int i = 1; i < array.Length - 1; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    int currentSum = array[i] + array[j];
                    int difference = targetSum - currentSum;

                    if (allPairSums.ContainsKey(difference))
                    {
                        foreach (int[] pair in allPairSums[difference])
                        {
                            result.Add(new int[] { pair[0], pair[1], array[i], array[j] });
                        }
                    }
                }

                for (int k = 0; k < i; k++)
                {
                    int currentSum = array[i] + array[k];
                    int[] pair = { array[k], array[i] };

                    if (!allPairSums.ContainsKey(currentSum))
                    {
                        var pairGroup = new List<int[]>();
                        pairGroup.Add(pair);
                        allPairSums.Add(currentSum, pairGroup);
                    }
                    else
                    {
                        allPairSums[currentSum].Add(pair);
                    }
                }
            }

            return result;
        }
    }
}
