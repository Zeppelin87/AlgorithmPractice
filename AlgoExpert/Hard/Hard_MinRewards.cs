namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_MinRewards
    {
        public static void Run()
        {
            int[] scores = new int[] { 8, 4, 2, 1, 3, 6, 7, 9, 5 };

            // Time Complexity: O(n^2) -- Quadratic (where 'n' is the length of the input array scores[]).
            // Space Complexity: O(n) -- Linear.
            //var result = Solution(scores);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n) -- Linear.
            // Where 'n' is the length of the input array scores[].
            var result2 = Solution_LocalMin(scores);

            // Time Complexity: 
            // Space Complexity: 
            var result3 = Solution_Linear(scores);
        }

        private static int Solution_Linear(int[] scores)
        {
            int[] rewards = new int[scores.Length];
            Array.Fill(rewards, 1);

            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > scores[i - 1])
                {
                    rewards[i] = rewards[i - 1] + 1;
                }
            }

            for (int i = scores.Length - 2; i >= 0; i--)
            {
                if (scores[i] > scores[i + 1])
                {
                    rewards[i] = Math.Max(rewards[i], rewards[i + 1] + 1);
                }
            }

            return rewards.Sum();
        }

        private static int Solution_LocalMin(int[] scores)
        {
            // Write your code here.
            return -1;
        }

        private static int Solution(int[] scores)
        {
            if (scores.Length == 0)
            {
                return 0;
            }

            var rewards = new int[scores.Length];
            Array.Fill(rewards, 1);

            for (int i = 1; i < scores.Length; i++)
            {
                int j = i - 1;
                if (scores[i] > scores[i - 1])
                {
                    rewards[i] += rewards[i - 1];
                }
                else
                {
                    while (j >= 0 && scores[j] > scores[j + 1])
                    {
                        rewards[j] = Math.Max(rewards[j], rewards[j + 1] + 1);
                    }
                }
            }

            return rewards.Sum();
        }
    }
}
