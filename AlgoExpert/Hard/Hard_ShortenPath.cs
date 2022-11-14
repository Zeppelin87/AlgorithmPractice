namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_ShortenPath
    {
        public static void Run()
        {
            string path = "hey";

            // 
            // Where: 
            var result = Solution(path);
        }

        private static string Solution(string path)
        {
            bool startsWithPath = path[0] == '/';
            string[] tokensArr = path.Split('/');
            List<string> tokensList = new List<string>(tokensArr);
            List<string> filteredTokens = tokensList.FindAll(token => IsImportantToken(token));
            Stack<string> stack = new Stack<string>();

            if (startsWithPath)
            {
                stack.Push("");
            }

            foreach (string token in filteredTokens)
            {
                if (token.Equals(".."))
                {
                    if (stack.Count == 0 || stack.Peek().Equals(".."))
                    {
                        stack.Push(token);
                    }
                    else if (!stack.Peek().Equals(""))
                    {
                        stack.Pop();
                    }
                }
                else
                {
                    stack.Push(token);
                }
            }

            if (stack.Count == 1 && stack.Peek().Equals(""))
            {
                return "/";
            }

            var arr = stack.ToArray();
            Array.Reverse(arr);
            return string.Join("/", arr);
        }

        private static bool IsImportantToken(string token)
        {
            return token.Length > 0 && !token.Equals(".");
        }
    }
}
