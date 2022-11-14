namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_WaterArea
    {
        public static void Run()
        {
            int[] array = { 3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3 };

            // O(n) time complexity | O(1) space complexity. 
            // Where: 'n' is the length of the input 'array[]'.
            var result = Solution(array);
        }

        private static int Solution(int[] heights)
        {
            if (heights.Length == 0)
            {
                return 0;
            }

            int leftIdx = 0;
            int rightIdx = heights.Length - 1;
            int leftMax = heights[leftIdx];
            int rightMax = heights[rightIdx];
            int surfaceArea = 0;

            while (leftIdx < rightIdx)
            {
                if (heights[leftIdx] < heights[rightIdx])
                {
                    leftIdx++;
                    leftMax = Math.Max(leftMax, heights[leftIdx]);
                    surfaceArea += leftMax - heights[leftIdx];
                }
                else
                {
                    rightIdx--;
                    rightMax = Math.Max(rightMax, heights[rightIdx]);
                    surfaceArea += rightMax - heights[rightIdx];
                }
            }

            return surfaceArea;
        }
    }
}
