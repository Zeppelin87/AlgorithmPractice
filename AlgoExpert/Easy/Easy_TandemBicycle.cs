namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_TandemBicycle
    {
        public static void Run()
        {
            int[] redShirtSpeeds = new int[] { 5, 5, 3, 9, 2 };
            int[] blueShirtSpeeds = new int[] { 3, 6, 7, 2, 1 };
            bool fastest = false;

            // Time Complexity: O(log n) -- Logarithmic.
            // Space Complexity: O(1) -- Constant.
            var result = Solution(redShirtSpeeds, blueShirtSpeeds, fastest);
        }

        private static int Solution(int[] redShirtSpeeds, int[] blueShirtSpeeds, bool fastest)
        {
            // O(n log n)
            Array.Sort(redShirtSpeeds, (x, y) =>
            {
                return y - x;
            });

            // O(n log n)
            Array.Sort(blueShirtSpeeds, (x, y) =>
            {
                return y - x;
            });

            // O(n)
            int totalSpeed = 0;
            int i = 0;
            int j = 0;
            int count = 0;

            if (fastest)
            {
                while (count < redShirtSpeeds.Length)
                {
                    if (redShirtSpeeds[i] > blueShirtSpeeds[j])
                    {
                        totalSpeed += redShirtSpeeds[i++];
                        count++;
                    }
                    else
                    {
                        totalSpeed += blueShirtSpeeds[j++];
                        count++;
                    }
                }
            }
            else
            {
                while (count < redShirtSpeeds.Length)
                {
                    if (redShirtSpeeds[i] > blueShirtSpeeds[i])
                    {
                        totalSpeed += redShirtSpeeds[i++];
                        count++;
                    }
                    else
                    {
                        totalSpeed += blueShirtSpeeds[i++];
                        count++;
                    }
                }
            }

            return totalSpeed;
        }
    }
}
