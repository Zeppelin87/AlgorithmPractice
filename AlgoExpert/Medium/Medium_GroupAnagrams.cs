namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_GroupAnagrams
    {
        public static void Run()
        {
            List<string> words = new List<string>();

            // 
            // Where: 
            var result = Solution(words);
        }

        private static List<List<string>> Solution(List<string> words)
        {
            var anagrams = new Dictionary<string, List<string>>();

            foreach (string word in words)
            {
                char[] charArray = word.ToCharArray();
                Array.Sort(charArray);
                string sortedWord = new string(charArray);

                if (anagrams.ContainsKey(sortedWord))
                {
                    anagrams[sortedWord].Add(word);
                }
                else
                {
                    anagrams[sortedWord] = new List<string>() { word };
                }
            }

            return anagrams.Values.ToList();
        }
    }
}
