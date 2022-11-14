namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class FindResultantArrayAfterRemovingAnagrams_2273
    {
        public static void Run()
        {
            string[] words = new string[] { "a", "b", "a" };

            var result = Solution(words);
        }

        private static IList<string> Solution(string[] words)
        {
            string prev = "";
            List<string> li = new List<string>();

            for (int i = 0; i < words.Length; i++)
            {
                char[] ch = words[i].ToCharArray();
                Array.Sort(ch);

                string current = new string(ch);

                if (!current.Equals(prev))
                {
                    li.Add(words[i]);
                    prev = current;
                }
            }

            return li;
        }
    }
}
