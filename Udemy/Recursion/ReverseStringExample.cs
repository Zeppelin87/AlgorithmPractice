using System.Text;

namespace AlgorithmPractice.Udemy.Recursion
{
    public static class ReverseStringExample
    {
        public static void Run()
        {
            Console.WriteLine(ReverseStringRecursively("123456"));
            Console.WriteLine(ReverseStringIteratively("123456"));
        }

        private static string ReverseStringRecursively(string str)
        {
            if (str.Length == 0)
            {
                return string.Empty;
            }

            return ReverseStringRecursively(str.Substring(1)) + str[0];
        }

        private static string ReverseStringIteratively(string str)
        {
            var result = new StringBuilder();

            for (int i = 0; i < str.Length; i++)
            {
                result.Append(str[str.Length - 1 - i]);
            }

            return result.ToString();
        }
    }
}
