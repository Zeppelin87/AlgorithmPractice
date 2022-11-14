namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MonotonicArray
    {
        public static void Run()
        {
            int[] array = { -1, -5, -10, -1100, -1100, -1101, -1102, -9001 };

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array).
            // Space Complexity: O(1) -- Constant.
            var result = Solution(array);
        }

        private static bool Solution(int[] array)
        {
            // Monotonic - elements from left to right are:
            //  a) entirely non-increasing.
            //  OR
            //  b) entirely non-decreasing.

            if (array == null || array.Length == 0)
            {
                return true;
            }

            int increase = 0;
            int decrease = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                int firstNum = array[i];
                int secondNum = array[i + 1];

                if (firstNum == secondNum)
                {
                    continue;
                }
                else if (firstNum > secondNum)
                {
                    increase++;
                }
                else if (firstNum < secondNum)
                {
                    decrease++;
                }

                if (increase > 0 && decrease > 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
