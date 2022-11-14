using System.Text;

namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_PalindromeCheck
    {
        public static void Run()
        {
            string str = "abcdcba";

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n) -- Linear.
            var result = Solution_ReverseWithLoop(str);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(1) -- Constant.
            var result2 = Solution_TwoPointers(str);
        }

        private static bool Solution_ReverseWithLoop(string str)
        {
            StringBuilder sb = new StringBuilder(str.Length);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(str[i]);
            }

            string reverse = sb.ToString();

            return str.Equals(reverse);
        }

        private static bool Solution_TwoPointers(string str)
        {
            int leftIndex = 0;
            int rightIndex = str.Length - 1;

            while (leftIndex < rightIndex)
            {
                if (str[leftIndex] != str[rightIndex])
                {
                    return false;
                }

                leftIndex++;
                rightIndex--;
            }

            return true;
        }
    }
}
