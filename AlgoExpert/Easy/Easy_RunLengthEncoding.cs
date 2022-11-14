using System.Text;

namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_RunLengthEncoding
    {
        public static void Run()
        {
            string str = "hey";

            // O(n) time complexity | O(n) space complexity.
            // Where: where 'n' is the length of the input string 'str'.
            var result = Solution(str);
        }

        private static string Solution(string str)
        {
            var encodedStringChars = new StringBuilder();
            int currentRunLength = 1;

            for (int i = 1; i < str.Length; i++)
            {
                char currentChar = str[i];
                char previousChar = str[i - 1];

                if ((currentChar != previousChar) || (currentRunLength == 9))
                {
                    encodedStringChars.Append(currentRunLength.ToString());
                    encodedStringChars.Append(previousChar);
                    currentRunLength = 0;
                }

                currentRunLength += 1;
            }

            // Handle the last run.
            encodedStringChars.Append(currentRunLength.ToString());
            encodedStringChars.Append(str[str.Length - 1]);

            return encodedStringChars.ToString();
        }
    }
}
