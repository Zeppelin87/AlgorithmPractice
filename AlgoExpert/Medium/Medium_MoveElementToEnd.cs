namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MoveElementToEnd
    {
        public static void Run()
        {
            var array = new List<int>() { 3, 3, 3, 3, 3 };
            int toMove = 3;

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array).
            // Space Complexity: O(1) -- Constant.
            var result = Solution_TwoPointers(array, toMove);
        }

        private static List<int> Solution_TwoPointers(List<int> array, int toMove)
        {
            int rightPointer = array.Count - 1;

            for (int i = 0; i < array.Count; i++)
            {
                while (rightPointer >= 0 && array[rightPointer] == toMove)
                {
                    rightPointer--;
                }

                if (i >= rightPointer)
                {
                    break;
                }

                if (array[i] == toMove)
                {
                    int temp = array[i];
                    array[i] = array[rightPointer];
                    array[rightPointer] = temp;
                }

                Console.WriteLine("[{0}]", string.Join(", ", array));
            }

            return array;
        }
    }
}
