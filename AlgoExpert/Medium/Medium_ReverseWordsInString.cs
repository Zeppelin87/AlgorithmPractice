namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_ReverseWordsInString
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
            char[] characters = str.ToCharArray();
            ReverseListRange(characters, 0, characters.Length - 1);

            int startOfWord = 0;
            while (startOfWord < characters.Length)
            {
                int endOfWord = startOfWord;
                while (endOfWord < characters.Length && characters[endOfWord] != ' ')
                {
                    endOfWord += 1;
                }

                ReverseListRange(characters, startOfWord, endOfWord - 1);
                startOfWord = endOfWord + 1;
            }

            return new string(characters);
        }

        private static char[] ReverseListRange(char[] list, int start, int end)
        {
            while (start < end)
            {
                char temp = list[start];
                list[start] = list[end];
                list[end] = temp;

                start += 1;
                end -= 1;
            }

            return list;
        }
    }
}
