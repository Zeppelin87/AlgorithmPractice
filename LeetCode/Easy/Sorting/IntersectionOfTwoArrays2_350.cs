namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class IntersectionOfTwoArrays2_350
    {
        public static void Run()
        {
            //int[] nums1 = new int[] { 1, 2, 2, 1 };
            //int[] nums2 = new int[] { 2 };

            //int[] nums1 = new int[] { 3, 1, 2 };
            //int[] nums2 = new int[] { 1, 1 };

            int[] nums1 = new int[] { 4, 9, 5 };
            int[] nums2 = new int[] { 9, 4, 9, 8, 4 };

            var result = Solution(nums1, nums2);
            var result2 = Intersect(nums1, nums2);
        }

        private static int[] Solution(int[] nums1, int[] nums2)
        {
            List<int> one = nums1.ToList();
            List<int> two = nums2.ToList();
            List<int> result = new List<int>();

            for (int i = 0; i < one.Count; i++)
            {
                for (int j = 0; j < two.Count; j++)
                {
                    if (one[i] == two[j])
                    {
                        result.Add(one[i]);
                        two.Remove(one[i]);
                        break;
                    }
                }
            }

            return result.ToArray();
        }

        private static int[] Intersect(int[] nums1, int[] nums2)
        {
            if (nums1.Length > nums2.Length)
            {
                return Intersect(nums2, nums1);
            }

            var dict = new Dictionary<int, int>();
            var res = new List<int>();

            for (int i = 0; i < nums1.Length; i++)
            {
                if (!dict.ContainsKey(nums1[i]))
                {
                    dict.Add(nums1[i], 1);
                }
                else
                {
                    dict[nums1[i]]++;
                }
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                if (dict.ContainsKey(nums2[i]) && dict[nums2[i]] > 0)
                {
                    dict[nums2[i]]--;
                    res.Add(nums2[i]);
                }
            }

            return res.ToArray();
        }
    }
}
