namespace AlgorithmPractice.Algorithms.Arrays.TwoPointers
{
    public static class LeetCode_Medium_ContainerWithMostWater_11
    {
        public static void Run()
        {
            int[] height = { 1, 8, 6, 2, 5, 4, 8, 3, 7 };

            // O(n) time complexity | O(1) space complexity.
            // Where: 'n' is the length of the input array height[].
            int result = Solution(height);
        }

        private static int Solution(int[] height)
        {
            int L = 0;
            int R = height.Length - 1;
            int maxWater = 0;

            while (L < R)
            {
                maxWater = Math.Max(maxWater, Math.Min(height[R], height[L]) * (R - L));

                if (height[L] == height[R] || height[L] < height[R])
                {
                    L++;
                }
                else if (height[L] > height[R])
                {
                    R--;
                }
            }

            return maxWater;
        }
    }
}
