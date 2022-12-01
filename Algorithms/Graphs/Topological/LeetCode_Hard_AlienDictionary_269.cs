using System.Text;

namespace AlgorithmPractice.Algorithms.Graphs.Topological
{
    public static class LeetCode_Hard_AlienDictionary_269
    {
        public static void Run()
        {
            string[] words = { "wrt", "wrf", "er", "ett", "rftt" };

            // O(c) time complexity | O(1) or O(U + min(U^2, N))
            // Where: 'C' is the total characters (not unique characters) across all words.
            string result = Solution(words);
        }

        private static string Solution(string[] words)
        {
            // Create adjacency list.
            var adjacencyList = new Dictionary<char, List<char>>();
            foreach (string word in words)
            {
                foreach (char c in word)
                {
                    if (!adjacencyList.ContainsKey(c))
                    {
                        adjacencyList.Add(c, new List<char>());
                    }
                }
            }

            for (int i = 0; i < words.Length - 1; i++)
            {
                string word1 = words[i];
                string word2 = words[i + 1];
                int minLength = Math.Min(word1.Length, word2.Length);

                if (word1.Length > word2.Length && word1.StartsWith(word2))
                {
                    return "";
                }

                for (int j = 0; j < minLength; j++)
                {
                    if (word1[j]  != word2[j])
                    {
                        adjacencyList[word1[j]].Add(word2[j]);
                        break;
                    }
                }
            }

            var seen = new Dictionary<char, bool>();
            var topSort = new List<char>();

            foreach (char c in adjacencyList.Keys)
            {
                bool result = DFS(c, adjacencyList, seen, topSort);
                if (!result)
                {
                    return "";
                }
            }

            topSort.Reverse();
            var answer = new StringBuilder();
            foreach (char c in topSort)
            {
                answer.Append(c);
            }

            return answer.ToString();
        }

        private static bool DFS(char c, Dictionary<char, List<char>> adjacencyList, Dictionary<char, bool> seen, List<char> topSort)
        {
            if (seen.ContainsKey(c))
            {
                return seen[c];
            }

            seen.Add(c, false);

            foreach (char next in adjacencyList[c])
            {
                bool result = DFS(next, adjacencyList, seen, topSort);

                if (!result)
                {
                    return false;
                }
            }

            seen[c] = true;
            topSort.Add(c);

            return true;
        }
    }
}
