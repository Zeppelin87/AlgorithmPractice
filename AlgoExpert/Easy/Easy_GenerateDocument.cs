namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_GenerateDocument
    {
        public static void Run()
        {
            string characters = "chars";
            string document = "docs";

            // O(n + m) time complexity | O(c) space complexity.
            // Where: 
            var result = Solution(characters, document);
        }

        private static bool Solution(string characters, string document)
        {
            var characterCounts = new Dictionary<char, int>();

            for (int idx = 0; idx < characters.Length; idx++)
            {
                char character = characters[idx];
                characterCounts[character] = characterCounts.GetValueOrDefault(character, 0) + 1;
            }

            for (int idx = 0; idx < document.Length; idx++)
            {
                char character = document[idx];
                if (!characterCounts.ContainsKey(character) || characterCounts[character] == 0)
                {
                    return false;
                }

                characterCounts[character] = characterCounts[character] - 1;
            }

            return true;
        }
    }
}
