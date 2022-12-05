namespace AlgorithmPractice.Algorithms.Arrays.SlidingWindowVariableSize
{
    public static class LeetCode_Medium_LongestSubstringWithoutRepeatingCharacters_3
    {
        public static void Run()
        {
            string s = "bbbbb";

            // O(n) time complexity | O(min(m, n)) space complexity.
            // Where: 'n' is the length of the input string 's' & 'm' is the size of charset/alphabet.
            int result = Solution(s);
        }

        private static int Solution(string s)
        {
            int answer = 0;
            int n = s.Length;  
            var map = new Dictionary<char, int>();

            for (int R = 0, L = 0; R < n; R++)
            { 
                if (map.ContainsKey(s[R]))
                {
                    L = Math.Max(map[s[R]], L);
                }

                answer = Math.Max(answer, R - L + 1);
                map[s[R]] = R + 1;
            }

            return answer;
        }
    }
}
