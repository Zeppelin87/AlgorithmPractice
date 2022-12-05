namespace AlgorithmPractice.Algorithms.Arrays.TwoPointers
{
    public static class LeetCode_Easy_ValidPalindrome_125
    {
        public static void Run()
        {
            string s = "A man, a plan, a canal: Panama";

            // O(n) time complexity | O(1) space complexity.
            // Where: 'n' is the length of the input string 's'.
            bool result = Solution(s);
        }

        private static bool Solution(string s)
        {
            int L = 0;
            int R = s.Length - 1;
            s = s.ToLower();

            while (L < R)
            {
                while (L < R && !char.IsLetterOrDigit(s[L]))
                {
                    L++;
                }

                while (L < R && !char.IsLetterOrDigit(s[R]))
                {
                    R--;
                }

                if (s[L] != s[R])
                {
                    return false;
                }

                L++;
                R--;
            }

            return true;
        }
    }
}
