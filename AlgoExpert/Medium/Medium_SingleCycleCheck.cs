namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_SingleCycleCheck
    {
        public static void Run()
        {
            int[] array = { 2, 3, 1, -4, -4, 2 };

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array[]).
            // Space Complexity: O(1) -- Constant.
            var result = Solution(array);
        }

        private static bool Solution(int[] array)
        {
            int numberOfElementsVisited = 0;
            int currentIndex = 0;

            while (numberOfElementsVisited < array.Length)
            {
                if (numberOfElementsVisited > 0 & currentIndex == 0)
                {
                    return false;
                }

                numberOfElementsVisited++;
                currentIndex = GetNextId(array, currentIndex);
            }

            return currentIndex == 0;
        }

        private static int GetNextId(int[] array, int currentIndex)
        {
            int jump = array[currentIndex];
            int nextIndex = (currentIndex + jump) % array.Length;
            return nextIndex >= 0 ? nextIndex : nextIndex + array.Length;
        }
    }
}
