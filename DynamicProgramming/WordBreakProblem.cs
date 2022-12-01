namespace AlgorithmPractice.DynamicProgramming
{
    public static class WordBreakProblem
    {
        public static void Run()
        {
            string s = "pineapplepenapple";
            string[] dict = { "apple", "pen", "applepen", "pine", "pineapple" };

            int result = Solution_Recursive(s, dict);

            int result1 = Solution_Memoization(s, dict);

            int result2 = Solution_Tabulation(s, dict);

            int result3 = Solution_Tabulation_Reconstruction(s, dict);
        }

        private static int Solution_Recursive(string s, string[] dict)
        {
            return -1;
        }

        private static int Solution_Memoization(string s, string[] dict)
        {
            return -1;
        }

        private static int Solution_Tabulation(string s, string[] dict)
        {
            return -1;
        }

        private static int Solution_Tabulation_Reconstruction(string s, string[] dict)
        {
            return -1;
        }
    }
}
