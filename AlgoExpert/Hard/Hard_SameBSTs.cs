namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_SameBSTs
    {
        public static void Run()
        {
            var arrayOne = new List<int>() { 10, 15, 8, 12, 94, 81, 5, 2, 11 };
            var arrayTwo = new List<int>() { 10, 8, 5, 15, 2, 12, 11, 94, 81 };

            // Time Complexity: O(n^2) -- Quadratic.
            // Space Complexity: O(n^2) -- Quadratic.
            // Where 'n' is the number of nodes in each array.
            var result = Solution_Recursion(arrayOne, arrayTwo);
        }

        private static bool Solution_Recursion(List<int> arrayOne, List<int> arrayTwo)
        {
            int root = arrayOne[0];

            if (arrayOne.Count != arrayTwo.Count)
            {
                return false;
            }

            if (arrayTwo[0] != root)
            {
                return false;
            }

            return ValidateBST(arrayOne, arrayTwo);
        }

        private static bool ValidateBST(List<int> arrayOne, List<int> arrayTwo)
        {
            if (arrayOne.Count == 0 && arrayTwo.Count == 0)
            {
                return true;
            }

            if (arrayOne.Count != arrayTwo.Count)
            {
                return false;
            }

            if (arrayOne[0] != arrayTwo[0])
            {
                return false;
            }

            List<int> rightOne = GetRightChildren(arrayOne);
            List<int> rightTwo = GetRightChildren(arrayTwo);

            List<int> leftOne = GetLeftChildren(arrayOne);
            List<int> leftTwo = GetLeftChildren(arrayTwo);

            return ValidateBST(rightOne, rightTwo) && ValidateBST(leftOne, leftTwo);
        }

        private static List<int> GetRightChildren(List<int> arr)
        {
            var result = new List<int>();
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] >= arr[0])
                {
                    result.Add(arr[i]);
                }
            }

            return result;
        }

        private static List<int> GetLeftChildren(List<int> arr)
        {
            var result = new List<int>();
            for (int i = 1; i < arr.Count; i++)
            {
                if (arr[i] < arr[0])
                {
                    result.Add(arr[i]);
                }
            }

            return result;
        }
    }
}
