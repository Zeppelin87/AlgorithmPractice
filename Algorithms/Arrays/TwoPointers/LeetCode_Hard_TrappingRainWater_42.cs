using System.ComponentModel;

namespace AlgorithmPractice.Algorithms.Arrays.TwoPointers
{
    public static class LeetCode_Hard_TrappingRainWater_42
    {
        public static void Run()
        {
            int[] height = { 0, 1, 0, 2, 1, 0, 1, 3, 2, 1, 2, 1 };

            // O(n) time complexity | O(1) space complexity.
            // Where: 'n' is the length of the input array height[].
            int result = Solution(height);
        }

        private static int Solution(int[] height)
        {
            int L = 0;
            int R = height.Length - 1;
            int leftMax = 0;
            int rightMax = 0;

            int answer = 0;

            while (L < R)
            {
                if (height[L] < height[R])
                {
                    if (height[L] >= leftMax)
                    {
                        leftMax = height[L];
                    }
                    else
                    {
                        answer += leftMax - height[L];
                    }

                    L++;
                }
                else
                {
                    if (height[R] >= rightMax)
                    {
                        rightMax = height[R];
                    }
                    else
                    {
                        answer += rightMax - height[R];
                    }

                    R--;
                }
            }

            return answer;
        }
    }
}
