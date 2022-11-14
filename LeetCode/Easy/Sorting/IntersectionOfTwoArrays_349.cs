namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class IntersectionOfTwoArrays_349
    {
        public static void Run()
        {
            int[] nums1 = new[] { 4, 9, 5 };
            int[] nums2 = new[] { 9, 4, 9, 8, 4 };

            int[] result = Solution(nums1, nums2);
        }

        private static int[] Solution(int[] nums1, int[] nums2)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!dictionary.ContainsKey(nums1[i]))
                {
                    dictionary.Add(nums1[i], 1);
                }
            }

            int size = 0;
            for (int i = 0; i < nums2.Length; i++)
            {
                if (dictionary.ContainsKey(nums2[i]) && dictionary[nums2[i]] == 1)
                {
                    dictionary[nums2[i]]++;
                    size++;
                }
            }

            int x = 0;
            int[] result = new int[size];

            foreach (var item in dictionary)
            {
                if (item.Value > 1)
                {
                    result[x++] = item.Key;
                }
            }

            return result;
        }
    }
}
