namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_SmallestDifference
    {
        public static void Run()
        {
            int[] arrayOne = { -1, 5, 10, 20, 28, 3 };
            int[] arrayTwo = { 26, 134, 135, 15, 17 };

            // Time Complexity: O(n^2) -- Quadratic.
            // Space Complexity: O(1) -- Constant.
            var result = Solution_BruteForce(arrayOne, arrayTwo);

            // Time Complexity: O(n log(n) + m log(m)) -- Log-Linear.
            // Space Complexity: O(1) -- Constant.
            var result2 = Solution_BinarySearch(arrayOne, arrayTwo);

            // Time Complexity: O(n log(n) + m log(m)) -- Log-Linear.
            // Space Complexity: O(1) -- Constant.
            var result3 = Solution(arrayOne, arrayTwo);
        }

        private static int[] Solution(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int indexOne = 0;
            int indexTwo = 0;
            int smallest = int.MaxValue;
            int current = int.MaxValue;
            int[] result = new int[2];

            while (indexOne < arrayOne.Length && indexTwo < arrayTwo.Length)
            {
                int firstNum = arrayOne[indexOne];
                int secondNum = arrayTwo[indexTwo];

                if (firstNum < secondNum)
                {
                    current = secondNum - firstNum;
                    indexOne++;
                }
                else if (firstNum > secondNum)
                {
                    current = firstNum - secondNum;
                    indexTwo++;
                }
                else
                {
                    return new int[] { firstNum, secondNum };
                }

                if (current < smallest)
                {
                    smallest = current;
                    result = new int[] { firstNum, secondNum };
                }
            }

            return result;
        }

        private static int[] Solution_BinarySearch(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            int[] result = new int[2];
            int temp = 0;
            int closest = int.MaxValue;

            for (int i = 0; i < arrayOne.Length; i++)
            {
                var value = BinarySearch_FindClosest(arrayTwo, arrayOne[i]);

                if (arrayOne[i] < 0 && value > 0)
                {
                    temp = Math.Abs(arrayOne[i] + value);
                }
                else if (arrayOne[i] > 0 && value < 0)
                {
                    temp = arrayOne[i] + Math.Abs(value);
                }
                else if (arrayOne[i] > 0 && value > 0)
                {
                    temp = Math.Abs(arrayOne[i] - value);
                }
                else if (arrayOne[i] < 0 && value < 0)
                {
                    temp = Math.Abs(arrayOne[i] - value);
                }

                if (temp < closest)
                {
                    closest = temp;
                    result[0] = arrayOne[i];
                    result[1] = value;
                }
            }

            return result;
        }

        private static int[] Solution_BruteForce(int[] arrayOne, int[] arrayTwo)
        {
            Array.Sort(arrayOne);
            Array.Sort(arrayTwo);

            // O(n + k).
            int[] result = new int[2];
            int temp = 0;
            int closest = int.MaxValue;
            for (int i = 0; i < arrayOne.Length; i++)
            {
                for (int j = 0; j < arrayTwo.Length; j++)
                {
                    if (arrayOne[i] < 0 && arrayTwo[j] > 0)
                    {
                        temp = Math.Abs(arrayOne[i]) + arrayTwo[j];
                    }
                    else if (arrayOne[i] > 0 && arrayTwo[j] < 0)
                    {
                        temp = arrayOne[i] + Math.Abs(arrayTwo[j]);
                    }
                    else if (arrayOne[i] > 0 && arrayTwo[j] > 0)
                    {
                        temp = Math.Abs(arrayOne[i] - arrayTwo[j]);
                    }
                    else if (arrayOne[i] < 0 && arrayTwo[j] < 0)
                    {
                        temp = Math.Abs(arrayOne[i] - arrayTwo[j]);
                    }

                    if (temp < closest)
                    {
                        closest = temp;
                        result[0] = arrayOne[i];
                        result[1] = arrayTwo[j];
                    }
                }
            }

            return result;
        }

        private static int BinarySearch_FindClosest(int[] arr, int target)
        {

            if (target <= arr[0])
            {
                return arr[0];
            }

            if (target >= arr[arr.Length - 1])
            {
                return arr[arr.Length - 1];
            }

            int lo = 0;
            int hi = arr.Length - 1;
            int middle = 0;

            while (lo <= hi)
            {
                middle = (lo + hi) / 2;

                if (target == arr[middle])
                {
                    return arr[middle];
                }
                else if (target > arr[middle])
                {
                    // Target > arr[middle] && Target < arr[middle + 1] -> find closer between 'middle and middle + 1'
                    if (middle < arr.Length - 1 && target < arr[middle + 1])
                    {
                        return GetClosest(arr[middle], arr[middle + 1], target);
                    }

                    lo = middle + 1;
                }
                else if (target < arr[middle])
                {
                    // Target < arr[middle] && Target > arr[middle - 1] -> find closer betwen 'middle and middle -1'
                    if (middle > 0 && target > arr[middle - 1])
                    {
                        return GetClosest(arr[middle - 1], arr[middle], target);
                    }

                    hi = middle - 1;
                }
            }

            return arr[middle];
        }

        private static int GetClosest(int val1, int val2, int target)
        {
            if (target - val1 >= val2 - target)
            {
                return val2;
            }
            else
            {
                return val1;
            }
        }
    }
}
