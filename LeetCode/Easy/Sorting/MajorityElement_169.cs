namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MajorityElement_169
    {
        public static void Run()
        {
            int[] nums = new int[] { 2, 2, 1, 1, 1, 2, 2 };
            var result = Solution(nums);
        }

        private static int Solution(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

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

            int count = 0;
            int majorityElement = 0;
            foreach (var item in dictionary)
            {
                if (item.Value > count)
                {
                    count = item.Value;
                    majorityElement = item.Key;
                }
            }

            return majorityElement;
        }
    }
}
