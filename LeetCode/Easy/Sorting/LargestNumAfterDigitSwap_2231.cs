namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class LargestNumAfterDigitSwap_2231
    {
        public static void Run()
        {
            int num = 1234;

            var result = Solution(num);
        }

        private static int Solution(int num)
        {
            char[] a = num.ToString().ToCharArray();

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] > a[i] && (a[j] - a[i]) % 2 == 0)
                    {
                        char temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }

            return Int32.Parse(new String(a));
        }
    }
}
