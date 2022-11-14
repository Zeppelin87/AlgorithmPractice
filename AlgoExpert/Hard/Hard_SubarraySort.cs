namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_SubarraySort
    {
        public static void Run()
        {
            //                        { 0, 1, 2, 3, 4,  5,  6,  7, 8, 9, 10, 11, 12 };
            //int[] array = new int[] { 1, 2, 4, 7, 10, 11, 7, 12, 6, 7, 16, 18, 19 };

            //                      { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9,  10 };
            int[] array = new int[] { 1, 2, 3, 4, 5, 6, 8, 7, 9, 10, 11 };
            // output = [3, 9];

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array[]).
            // Space Complexity: O(1) -- Constant.
            var result = Solution(array);

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array[]).
            // Space Complexity: O(1) -- Constant.
            var result2 = Solution_Linear(array);
        }

        private static int[] Solution_Linear(int[] array)
        {
            int minOutOfOrder = int.MaxValue;
            int maxOutOfOrder = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                int num = array[i];
                if (IsOutOfOrder(array, i, num))
                {
                    minOutOfOrder = Math.Min(minOutOfOrder, num);
                    maxOutOfOrder = Math.Max(maxOutOfOrder, num);
                }
            }

            if (minOutOfOrder == int.MaxValue)
            {
                return new int[] { -1, -1 };
            }

            int subarrayLeftIdx = 0;
            while (minOutOfOrder >= array[subarrayLeftIdx])
            {
                subarrayLeftIdx++;
            }

            int subarrayRightIdx = array.Length - 1;
            while (maxOutOfOrder <= array[subarrayRightIdx])
            {
                subarrayRightIdx--;
            }

            return new int[] { subarrayLeftIdx, subarrayRightIdx };
        }

        private static bool IsOutOfOrder(int[] array, int i, int num)
        {
            if (i == 0)
            {
                return num > array[i + 1];
            }

            if (i == array.Length - 1)
            {
                return num < array[i - 1];
            }

            return num > array[i + 1] || num < array[i - 1];
        }

        private static int[] Solution(int[] array)
        {
            bool isSorted = IsSorted(array);

            if (isSorted)
            {
                return new int[] { -1, -1 };
            }

            //int startingIndex = GetStartingIndex(array);
            // Find the first peak from the left.
            int idx = 1;
            int j = idx - 1;
            int peakFromLeft = 0;

            while (j < array.Length && array[idx] > array[j])
            {
                peakFromLeft = idx;

                idx++;
                j++;
            }

            int startingIndex = GetStartingIndex(array, peakFromLeft);

            idx = array.Length - 1;
            j = idx - 1;
            int peakFromRight = startingIndex;

            // Find the first peak from the right.
            while (j > startingIndex)
            {
                if (array[j] > array[idx])
                {
                    peakFromRight = j;
                    break;
                }

                idx--;
                j--;
            }

            int endingIndex = peakFromRight;
            if (peakFromRight < peakFromLeft)
            {
                endingIndex = startingIndex + 1;
            }
            else
            {
                endingIndex = GetEndingIndex(array, peakFromRight, startingIndex);
            }

            return new int[] { startingIndex, endingIndex };
        }

        private static bool IsSorted(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        private static int GetStartingIndex(int[] array, int peakFromLeft)
        {
            // Scan array[peakFromLeft...n] to find a smaller value than array[peakFromLeft].
            int smallestValue = array[peakFromLeft];
            for (int i = peakFromLeft; i < array.Length; i++)
            {
                if (array[i] < smallestValue)
                {
                    smallestValue = array[i];
                }
            }

            // 'startingIndex' is = 'peakFromLeft' || 'i' of 'smallestValue' between array[0... peakFromLeft]. 
            int startingIndex = peakFromLeft;
            for (int i = peakFromLeft; i >= 0; i--)
            {
                if (smallestValue == array[i])
                {
                    startingIndex = i + 1;
                    break;
                }
                else if (smallestValue > array[i])
                {
                    startingIndex = i + 1;
                    break;
                }
                else
                {
                    startingIndex = i;
                }
            }

            return startingIndex;
        }

        private static int GetEndingIndex(int[] array, int peakFromRight, int startingIndex)
        {
            // 'endingIndex' == right most index 'i' that is smaller than 'array[peakFromRight]'.
            int endingIndex = peakFromRight;
            for (int i = peakFromRight + 1; i < array.Length; i++)
            {
                if (array[peakFromRight] > array[i])
                {
                    endingIndex = i;
                }
            }

            return endingIndex;
        }
    }
}
