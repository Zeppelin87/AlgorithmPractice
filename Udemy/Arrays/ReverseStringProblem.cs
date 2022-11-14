namespace AlgorithmPractice.Udemy.Arrays
{
    public static class ReverseStringProblem
    {
        public static void Run()
        {
            // Create a function that reverses a string:
            //  'Hi my name is John' should be:
            //  'nhoJ si eman ym iH'

            string str = "Hi my name is John";
            string reversedString = ReverseString(str);
        }

        public static string ReverseString(string str)
        {
            string result = string.Empty;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                result += str[i];
            }

            return result;
        }
    }
}
