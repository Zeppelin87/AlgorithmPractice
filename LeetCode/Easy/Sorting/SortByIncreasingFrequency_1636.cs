namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class SortByIncreasingFrequency_1636
    {
        public static void Run()
        {
            int[] nums = new int[] { 2, 3, 1, 3, 2 };

            var result = Solution(nums);
            var result2 = Solution2(nums);
        }

        private static int[] Solution(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            // O(n)
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], 1);
                }
                else
                {
                    dictionary[nums[i]]++;
                }
            }

            // O(n)
            var sortedDictionary = dictionary.OrderBy(x => x.Value).ThenByDescending(x => x.Key);

            int index = 0;
            int[] result = new int[nums.Length];

            // O(n^2)
            foreach (var item in sortedDictionary)
            {
                for (int i = 0; i < item.Value; i++)
                {
                    result[index++] = item.Key;
                }
            }

            return result;
        }

        private static int[] Solution2(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            // O(n)
            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], 1);
                }
                else
                {
                    dictionary[nums[i]]++;
                }
            }

            // O(n)
            Array.Sort(nums, (x, y) =>
            {
                if (dictionary[x] == dictionary[y])
                {
                    return y.CompareTo(x);
                }

                return dictionary[x].CompareTo(dictionary[y]);
            });

            return nums;
        }
    }
}
