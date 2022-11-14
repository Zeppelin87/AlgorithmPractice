namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_ValidateSubsequence
    {
        public static void Run()
        {
            List<int> array = new List<int>() { 5, 1, 22, 25, 6, -1, 8, 10 };
            List<int> sequence = new List<int>() { 1, 6, -1, 10 };

            // Time Complexity: O(n + m) -- (?).
            // Space Complexity: O(1) -- Constant.
            var result = Solution_BruteForce(array, sequence);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n) -- Linear.
            var result2 = Solution_Queue(array, sequence);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(1) -- Constant.
            var result3 = Solution_TwoPointers(array, sequence);
        }

        private static bool Solution_BruteForce(List<int> array, List<int> sequence)
        {
            if (sequence.Count > array.Count)
            {
                return false;
            }

            int startingIndex = 0;

            // O(n + m)
            for (int i = 0; i < sequence.Count; i++)
            {
                if (startingIndex > array.Count - 1)
                {
                    return false;
                }

                for (int j = startingIndex; j < array.Count; j++)
                {
                    if (sequence[i] == array[j])
                    {
                        startingIndex = j + 1;
                        break;
                    }

                    if (j == array.Count - 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static bool Solution_Queue(List<int> array, List<int> sequence)
        {
            // O(n)
            var queue = new Queue<int>();
            for (int i = 0; i < array.Count; i++)
            {
                queue.Enqueue(array[i]);
            }

            // O(n)
            int index = 0;
            while (queue.Count > 0 && index < sequence.Count)
            {
                if (sequence[index] == queue.Dequeue())
                {
                    index++;
                }

                if (queue.Count == 0 && index < sequence.Count - 1)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool Solution_TwoPointers(List<int> array, List<int> sequence)
        {
            int arrayIndex = 0;
            int seqIndex = 0;

            while (arrayIndex < array.Count && seqIndex < sequence.Count)
            {
                if (array[arrayIndex] == sequence[seqIndex])
                {
                    seqIndex++;
                }

                arrayIndex++;
            }

            return seqIndex == sequence.Count;
        }
    }
}
