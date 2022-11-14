namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_FirstNonRepeatingCharacter
    {
        public static void Run()
        {
            string str = "hey";

            // O(n) time complexity | O(1) space complexity.
            // Where: 
            var result = Solution(str);
        }

        private static int Solution(string str)
        {
            var characterFrequencies = new Dictionary<char, int>();

            for (int idx = 0; idx < str.Length; idx++)
            {
                char character = str[idx];
                characterFrequencies[character] = characterFrequencies.GetValueOrDefault(character, 0) + 1;
            }

            for (int idx = 0; idx < str.Length; idx++)
            {
                char character = str[idx];
                if (characterFrequencies[character] == 1)
                {
                    return idx;
                }
            }

            return -1;
        }
    }
}
