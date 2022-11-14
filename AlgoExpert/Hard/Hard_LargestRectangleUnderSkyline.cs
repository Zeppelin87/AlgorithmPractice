namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_LargestRectangleUnderSkyline
    {
        public static void Run()
        {
            List<int> buildings = new List<int>();

            // 
            // Where: 
            var result = Solution(buildings);
        }

        private static int Solution(List<int> buildings)
        {
            int maxArea = 0;
            for (int pillarIdx = 0; pillarIdx < buildings.Count; pillarIdx++)
            {
                int currentHeight = buildings[pillarIdx];

                int furthestLeft = pillarIdx;
                while (furthestLeft > 0 && buildings[furthestLeft - 1] >= currentHeight)
                {
                    furthestLeft -= 1;
                }

                int furthestRight = pillarIdx;
                while (furthestRight < buildings.Count - 1 && buildings[furthestRight + 1] >= currentHeight)
                {
                    furthestRight += 1;
                }

                int areaWithCurrentBuilding = (furthestRight - furthestLeft + 1) * currentHeight;
                maxArea = Math.Max(areaWithCurrentBuilding, maxArea);
            }

            return maxArea;
        }
    }
}
