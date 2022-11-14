namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class ValidAnagram_242
    {
        public static void Run()
        {
            string s = "a";
            string t = "ab";

            var result = Solution(s, t);
        }

        private static bool Solution(string s, string t)
        {
            if (s.Length != t.Length)
            {
                return false;
            }

            // Sort s.
            char[] sChar = s.ToCharArray();
            Array.Sort(sChar);

            // Sort t.
            char[] tChar = t.ToCharArray();
            Array.Sort(tChar);

            for (int i = 0; i < s.Length; i++)
            {
                if (sChar[i] != tChar[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
