namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_ThreeNumberSort
    {
        public static void Run()
        {
            var array = new int[] { 1, 0, 0, -1, -1, 0, 1, 1 };
            var order = new int[] { 0, 1, -1 };

            // Time Complexity: O(n + m) -- (where 'n' is the length of array[] and 'm' is the length of order[]).
            // Space Complexity: O(1) -- Constant.
            //var result = Solution_BruteForce(array, order);

            // Time Complexity: O(n) -- Linear (where 'n' is the size of the input array[]).
            // Space Complexity: O(1) -- Constant.
            var result2 = Solution_ThreePointer(array, order);
        }

        private static int[] Solution_ThreePointer(int[] array, int[] order)
        {
            int firstValue = order[0];
            int secondValue = order[1];

            // Keep track of the indices where the values are stored.
            int firstIdx = 0;
            int secondIdx = 0;
            int thirdIdx = array.Length - 1;

            while (secondIdx <= thirdIdx)
            {
                int value = array[secondIdx];

                if (value == firstValue)
                {
                    Swap(array, firstIdx, secondIdx);
                    firstIdx++;
                    secondIdx++;
                }
                else if (value == secondValue)
                {
                    secondIdx++;
                }
                else
                {
                    Swap(array, secondIdx, thirdIdx);
                    thirdIdx--;
                }
            }

            return array;
        }

        private static int[] Solution_BruteForce(int[] array, int[] order)
        {
            int sortedThru = 0;
            for (int i = 0; i < order.Length; i++)
            {
                sortedThru = SortArrayBasedOnKey(array, order[i], sortedThru);
            }

            return array;
        }

        private static int SortArrayBasedOnKey(int[] array, int key, int sortedThru)
        {
            if (sortedThru >= array.Length - 1)
            {
                return sortedThru;
            }

            while (sortedThru <= array.Length - 1 && array[sortedThru] == key)
            {
                sortedThru++;
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (sortedThru >= i || sortedThru >= array.Length - 1)
                {
                    break;
                }

                if (array[i] == key)
                {
                    Swap(array, i, sortedThru);
                }

                while (array[sortedThru] == key)
                {
                    sortedThru++;
                }
            }

            return sortedThru;
        }

        private static void Swap(int[] array, int i, int j)
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
