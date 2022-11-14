namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MakeTwoArraysEqualByReversingSubArrays_1460
    {
        public static void Run()
        {
            int[] target = new int[] { 1, 2, 2, 3 };
            int[] arr = new int[] { 1, 1, 2, 3 };

            bool canSort = Solution(target, arr);
        }

        private static bool Solution(int[] target, int[] arr)
        {
            // Select any non-empty sub-array, any number of times & reverse it to match target[].
            // Return 'true' if you can make arr[] == target[].
            // Return 'false' of you can't.

            // Steps:
            //  1. Check to see if arr[] CAN match target[].
            if (target.Length != target.Length)
            {
                return false;
            }

            int[] countArr = new int[1001];

            for (int i = 0; i < target.Length; i++)
            {
                countArr[target[i]]++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (countArr[arr[i]] != 0)
                {
                    countArr[arr[i]]--;
                }
                else
                {
                    return false;
                }
            }

            return true;
        }
    }
}
