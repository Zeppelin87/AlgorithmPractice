namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_MaxSumIncreasingSubsequence
    {
        public static void Run()
        {
            int[] array = { 10, 70, 20, 30, 50, 11, 30 };

            // O(n^2) time complexity | O(n) space complexity.
            // Where: 'n' is the size of the input 'array[]'.
            var result = Solution(array);
        }

        private static List<List<int>> Solution(int[] array)
        {
            int[] sequences = new int[array.Length];
            Array.Fill(sequences, Int32.MinValue);

            int[] sums = (int[])array.Clone();
            int maxSumIdx = 0;

            for (int i = 0; i < array.Length; i++)
            {
                int currentNum = array[i];

                for (int j = 0; j < i; j++)
                {
                    int otherNum = array[j];
                    if (otherNum < currentNum && sums[j] + currentNum >= sums[i])
                    {
                        sums[i] = sums[j] + currentNum;
                        sequences[i] = j;
                    }
                }

                if (sums[i] >= sums[maxSumIdx])
                {
                    maxSumIdx = i;
                }
            }

            return BuildSequence(array, sequences, maxSumIdx, sums[maxSumIdx]);
        }

        private static List<List<int>> BuildSequence(int[] array, int[] sequences, int currentIdx, int sums)
        {
            var sequence = new List<List<int>>();

            sequence.Add(new List<int>());
            sequence.Add(new List<int>());
            sequence[0].Add(sums);

            while (currentIdx != Int32.MinValue)
            {
                sequence[1].Insert(0, array[currentIdx]);
                currentIdx = sequences[currentIdx];
            }

            return sequence;
        }
    }
}
