namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_ClassPhotos
    {
        public static void Run()
        {
            var redShirtHeights = new List<int>() { 1, 1, 1, 1, 1, 1, 1, 1 };
            var blueShirtHeights = new List<int>() { 5, 6, 7, 2, 3, 1, 2, 3 };

            // Time Complexity: O(n log n) -- Log-Linear.
            // Space Complextiy: O(1) -- Constant.
            var result = Solution(redShirtHeights, blueShirtHeights);
        }

        private static bool Solution(List<int> redShirtHeights, List<int> blueShirtHeights)
        {
            // O(n log n)
            redShirtHeights.Sort();

            // O(n log n)
            blueShirtHeights.Sort();

            // Calc tallest.
            int redTallest = redShirtHeights[redShirtHeights.Count - 1];
            int blueTallest = blueShirtHeights[blueShirtHeights.Count - 1];

            if (redTallest == blueTallest)
            {
                return false;
            }

            // Pass correct order into 'CanTakePicture()'.
            bool canTakePicture = false;
            if (redTallest > blueTallest)
            {
                canTakePicture = CanTakePicture(redShirtHeights, blueShirtHeights);
            }
            else
            {
                canTakePicture = CanTakePicture(blueShirtHeights, redShirtHeights);
            }

            return canTakePicture;
        }

        private static bool CanTakePicture(List<int> array1, List<int> array2)
        {
            // O(n).
            for (int i = 0; i < array1.Count; i++)
            {
                if (array1[i] <= array2[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
