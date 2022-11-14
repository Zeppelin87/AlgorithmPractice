namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_TournamentWinner
    {
        public static void Run()
        {
            List<List<string>> competitions = new List<List<string>>()
            {
                new List<string>(){ "HTML", "C#" },
                new List<string>(){ "C#", "Python" },
                new List<string>(){ "Python", "HTML" }
            };

            List<int> results = new List<int>() { 0, 0, 1 };

            // Time Complexity: O(n) -- Linear, where 'n' is the number of competitions.
            // Space Complexity: O(k) -- Linear, where 'k' is the number of teams. 
            var result = Solution(competitions, results);
        }

        private static string Solution(List<List<string>> competitions, List<int> results)
        {
            // O(n)
            var dict = new Dictionary<string, int>();
            for (int i = 0; i < competitions.Count; i++)
            {
                if (!dict.ContainsKey(competitions[i][0]))
                {
                    dict.Add(competitions[i][0], 0);
                }

                if (!dict.ContainsKey(competitions[i][1]))
                {
                    dict.Add(competitions[i][1], 0);
                }
            }

            // O(n)
            for (int i = 0; i < competitions.Count; i++)
            {
                if (results[i] == 1)
                {
                    dict[competitions[i][0]]++;
                }
                else if (results[i] == 0)
                {
                    dict[competitions[i][1]]++;
                }
            }

            // O(n)
            int score = -1;
            string winner = "";
            foreach (var item in dict)
            {
                if (item.Value > score)
                {
                    score = item.Value;
                    winner = item.Key;
                }
            }

            return winner;
        }
    }
}
