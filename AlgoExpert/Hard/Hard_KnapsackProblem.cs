namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_KnapsackProblem
    {
        public static void Run()
        {
            int[,] items = {
                { 1, 2 },
                { 4, 3 },
                { 5, 6 },
                { 6, 7 },
            };

            int capactiy = 10;

            // O(nc) time complexity | O(nc) space complexity.
            // Where: 'n' is the length of the matrix 'items[,]' & 'c' is the width of the matrix 'items[,]'.
            var result = Solution(items, capactiy);
        }

        private static List<List<int>> Solution(int[,] items, int capacity)
        {
            int[,] knapsackValues = new int[items.GetLength(0) + 1, capacity + 1];

            for (int i = 1; i < items.GetLength(0) + 1; i++)
            {
                int currentWeight = items[i - 1, 1];
                int currentValue = items[i - 1, 0];

                for (int c = 0; c < capacity + 1; c++)
                {
                    if (currentWeight > c)
                    {
                        knapsackValues[i, c] = knapsackValues[i - 1, c];
                    }
                    else
                    {
                        knapsackValues[i, c] = Math.Max(knapsackValues[i - 1, c], knapsackValues[i - 1, c - currentWeight] + currentValue);
                    }
                }
            }

            return GetKnapsackItems(knapsackValues, items, knapsackValues[items.GetLength(0), capacity]);
        }

        private static List<List<int>> GetKnapsackItems(int[,] knapsackValues, int[,] items, int weight)
        {
            var sequence = new List<List<int>>();
            var totalWeight = new List<int>();

            totalWeight.Add(weight);
            sequence.Add(totalWeight);
            sequence.Add(new List<int>());

            int i = knapsackValues.GetLength(0) - 1;
            int c = knapsackValues.GetLength(1) - 1;

            while (i > 0)
            {
                if (knapsackValues[i, c] == knapsackValues[i - 1, c])
                {
                    i--;
                }
                else
                {
                    sequence[1].Insert(0, i - 1);
                    c -= items[i - 1, 1];
                    i--;
                }

                if (c == 0)
                {
                    break;
                }
            }

            return sequence;
        }
    }
}
