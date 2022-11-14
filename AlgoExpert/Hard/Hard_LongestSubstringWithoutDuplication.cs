namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_LongestSubstringWithoutDuplication
    {
        public static void Run()
        {
            string str = "hey";

            // 
            // Where: 
            var result = Solution(str);
        }

        private static string Solution(string str)
        {
            var lastSeen = new Dictionary<char, int>();
            int[] longest = { 0, 1 };
            int startIdx = 0;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (lastSeen.ContainsKey(c))
                {
                    startIdx = Math.Max(startIdx, lastSeen[c] + 1);
                }

                if (longest[1] - longest[0] < i + 1 - startIdx)
                {
                    longest = new int[] { startIdx, i + 1 };
                }

                lastSeen[c] = i;
            }

            string result = str.Substring(longest[0], longest[1] - longest[0]);
            return result;
        }
    }
}
