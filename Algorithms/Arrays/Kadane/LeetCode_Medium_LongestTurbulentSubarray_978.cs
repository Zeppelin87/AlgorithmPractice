namespace AlgorithmPractice.Algorithms.Arrays.Kadane
{
    public static class LeetCode_Medium_LongestTurbulentSubarray_978
    {
        public static void Run()
        {
            int[] arr = { 4, 8, 12, 16 };

            // O(n) time complexity | O(1) constant time.
            // Where: 'n' is the length of the input array arr[].
            int result = Solution(arr);
        }

        private static int Solution(int[] arr)
        {
            int N = arr.Length;
            int answer = 1;
            int anchor = 0;

            for (int i = 1; i < N; i++)
            {
                int c = arr[i - 1].CompareTo(arr[i]);
                
                if (c == 0)
                {
                    anchor = i;
                }
                else if (i == N - 1 || c * arr[i].CompareTo(arr[i + 1]) != -1 )
                {
                    answer = Math.Max(answer, i - anchor + 1);
                    anchor = i;
                }
            }

            return answer;
        }
    }
}
