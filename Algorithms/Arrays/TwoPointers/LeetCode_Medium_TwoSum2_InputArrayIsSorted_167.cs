namespace AlgorithmPractice.Algorithms.Arrays.TwoPointers
{
    public static class LeetCode_Medium_TwoSum2_InputArrayIsSorted_167
    {
        public static void Run()
        {
            int[] number = { 2, 7, 11, 15 };
            int target = 9;

            // O(n) time complexity | O(1) space complexity.
            // Where: 'n' is the size of the input array numbers[].
            int[] result = Solution(number, target);
        }

        private static int[] Solution(int[] numbers, int target)
        {
            int L = 0;
            int R = numbers.Length - 1;

            while (L < R)
            { 
                if (numbers[L] + numbers[R] > target)
                {
                    R--;
                }
                else if (numbers[L] + numbers[R] < target)
                {
                    L++;
                }
                else
                {
                    return new int[] { L + 1, R - 1 };
                }
            }

            return null;
        }
    }
}
