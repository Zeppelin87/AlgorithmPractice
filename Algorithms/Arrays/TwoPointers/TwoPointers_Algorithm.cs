namespace AlgorithmPractice.Algorithms.Arrays.TwoPointers
{
    public static class TwoPointers_Algorithm
    {
        public static void Run()
        {
            string word = "hannah";

            // Given a string of characters, return true if it's a palindrome.
            // O(n) time complexity | O(1) space complexity.
            bool result = IsPalindrome(word);

            int target = 10;
            int[] nums = { 1, 2, 3, 4, 5, 6 };

            // Given a sorted array of integers, return the indices of two elements (in different positions) that sum up to the 'target' number.
            // O(n) time complexity | O(1) space complexity.
            int[] result2 = TargetSum(nums, target);
        }

        private static bool IsPalindrome(string word)
        {
            int L = 0;
            int R = word.Length - 1;

            while (L < R)
            {
                if (word[L] != word[R])
                {
                    return false;
                }

                L++;
                R--;
            }

            return true;
        }

        private static int[] TargetSum(int[] nums, int target)
        {
            int L = 0;
            int R = nums.Length - 1;

            while (L < R)
            {
                if (nums[L] + nums[R] > target)
                {
                    R--;
                }
                else if (nums[L] + nums[R] < target)
                {
                    L++;
                }
                else
                {
                    return new int[] { L, R };
                }
            }

            return null;
        }
    }
}
