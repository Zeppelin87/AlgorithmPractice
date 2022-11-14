namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_CaesarCipherEncryptor
    {
        public static void Run()
        {
            string str = "xyz";
            int key = 2;

            // O(n) time complexity | O(n) space complexity.
            // Where: 'n' is the length of the string 'str'.
            var result = Solution(str, key);
        }

        private static string Solution(string str, int key)
        {
            char[] newLetters = new char[str.Length];
            int newKey = key % 26;
            string alphabet = "abcdefghijklmnopqrstuvwxyz";

            for (int i = 0; i < str.Length; i++)
            {
                newLetters[i] = GetNewLetter(str[i], newKey, alphabet);
            }

            return new string(newLetters);
        }

        private static char GetNewLetter(char letter, int key, string alphabet)
        {
            int newLetterCode = alphabet.IndexOf(letter) + key;
            return alphabet[newLetterCode % 26];
        }
    }
}
