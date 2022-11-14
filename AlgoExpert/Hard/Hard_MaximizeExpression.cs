namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_MaximizeExpression
    {
        public static void Run()
        {
            int[] array = { 3, 6, 1, -3, 2, 7 };

            // O(n) time complexity | O(n) space complexity.
            // Where: 'n' is the length fo the input 'array[]'.
            var result = Solution(array);
        }

        private static int Solution(int[] array)
        {
            if (array.Length < 4)
            {
                return 0;
            }

            List<int> maxOfA = new List<int>() { array[0] };
            List<int> maxOfAMinusB = new List<int>() { int.MinValue };
            List<int> maxOfAMinusBPlusC = new List<int>() { int.MinValue, int.MinValue };
            List<int> maxOfAMinusBPlusCMinusD = new List<int>() { int.MinValue, int.MinValue, int.MinValue };

            for (int idx = 1; idx < array.Length; idx++)
            {
                int currentMax = Math.Max(maxOfA[idx - 1], array[idx]);
                maxOfA.Add(currentMax);
            }

            for (int idx = 1; idx < array.Length; idx++)
            {
                int currentMax = Math.Max(maxOfAMinusB[idx - 1], maxOfA[idx - 1] - array[idx]);
                maxOfAMinusB.Add(currentMax);
            }

            for (int idx = 2; idx < array.Length; idx++)
            {
                int currentMax = Math.Max(maxOfAMinusBPlusC[idx - 1], maxOfAMinusB[idx - 1] + array[idx]);
                maxOfAMinusBPlusC.Add(currentMax);
            }

            for (int idx = 3; idx < array.Length; idx++)
            {
                int currentMax = Math.Max(maxOfAMinusBPlusCMinusD[idx - 1], maxOfAMinusBPlusC[idx - 1] - array[idx]);
                maxOfAMinusBPlusCMinusD.Add(currentMax);
            }

            return maxOfAMinusBPlusCMinusD[maxOfAMinusBPlusCMinusD.Count - 1];
        }
    }
}
