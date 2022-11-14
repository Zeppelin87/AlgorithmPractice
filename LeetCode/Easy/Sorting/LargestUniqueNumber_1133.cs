namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class LargestUniqueNumber_1133
    {
        public static void Run()
        {
            int[] nums = new int[] { 5, 7, 3, 9, 4, 9, 8, 3, 1 };
            var result = Solution(nums);
        }

        private static int Solution(int[] nums)
        {
            var sortedDict = new SortedDictionary<int, int>(new DictionaryComparer());

            for (int i = 0; i < nums.Length; i++)
            {
                if (!sortedDict.ContainsKey(nums[i]))
                {
                    sortedDict.Add(nums[i], 1);
                }
                else
                {
                    sortedDict[nums[i]]++;
                }
            }

            foreach (var item in sortedDict)
            {
                if (item.Value == 1)
                {
                    return item.Key;
                }
            }

            return -1;
        }
    }

    public class DictionaryComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}
