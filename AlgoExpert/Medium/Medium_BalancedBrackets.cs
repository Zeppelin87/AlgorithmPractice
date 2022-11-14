namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_BalancedBrackets
    {
        public static void Run()
        {
            string str = "([])(){}(())()()";

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input string).
            // Space Complexity: O(n) -- Linear.
            var result = Solution(str);
        }

        private static bool Solution(string str)
        {
            var stack = new Stack<char>();
            char previous = '-';
            var bracketCharacters = new List<char>() { '(', ')', '[', ']', '{', '}' };

            for (int i = 0; i < str.Length; i++)
            {
                if (!bracketCharacters.Contains(str[i]))
                {
                    continue;
                }

                if (IsOpenBracket(str[i]))
                {
                    stack.Push(str[i]);
                }
                else if (stack.Count <= 0)
                {
                    return false;
                }
                else
                {
                    previous = stack.Pop();

                    if (!IsMatchingBracket(str[i], previous))
                    {
                        return false;
                    }
                }
            }

            return stack.Count == 0;
        }

        private static bool IsOpenBracket(char character)
        {
            if (character == '(' || character == '[' || character == '{')
            {
                return true;
            }

            return false;
        }

        private static bool IsMatchingBracket(char current, char previous)
        {
            if (current == ')')
            {
                return previous == '(';
            }
            else if (current == ']')
            {
                return previous == '[';
            }
            else if (current == '}')
            {
                return previous == '{';
            }

            return true;
        }
    }
}
