namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_ValidStartingCity
    {
        public static void Run()
        {
            int[] distances = new int[] { 5, 25, 15, 10, 15 };
            int[] fuel = new int[] { 1, 2, 1, 0, 3 };
            int mpg = 10;

            // Time Complexity: O(n^2) -- Log-Linear (where 'n' is the size of the distances[] array).
            // Space Complexity: O(1).
            //var result = Solution(distances, fuel, mpg);

            // Time Complexity: O(n) -- Linear (where 'n' is the size of the distances[] array).
            // Space Complexity: O(1).
            var result2 = Solution_OneLoop(distances, fuel, mpg);
        }

        private static int Solution_OneLoop(int[] distances, int[] fuel, int mpg)
        {
            int numberOfCities = distances.Length;
            int milesRemaining = 0;

            int startingCityIndex = 0;
            int milesRemainingAtStartingCity = 0;

            for (int i = 1; i < numberOfCities; i++)
            {
                int distanceFromPreviousCity = distances[i - 1];
                int fuelFromPreviousCity = fuel[i - 1];

                milesRemaining += fuelFromPreviousCity * mpg - distanceFromPreviousCity;

                if (milesRemaining < milesRemainingAtStartingCity)
                {
                    milesRemainingAtStartingCity = milesRemaining;
                    startingCityIndex = i;
                }
            }

            return startingCityIndex;
        }

        private static int Solution(int[] distances, int[] fuel, int mpg)
        {
            for (int i = 0; i < fuel.Length; i++)
            {
                fuel[i] *= mpg;
            }

            int startingCity = 0;
            int currentCity = 0;

            for (int i = 0; i < distances.Length; i++)
            {
                int remainingFuel = 0;

                for (int j = 0; j < distances.Length; j++)
                {
                    if (currentCity > distances.Length - 1)
                    {
                        currentCity = 0;
                    }

                    remainingFuel = remainingFuel + fuel[currentCity] - distances[currentCity];

                    if (remainingFuel < 0)
                    {
                        startingCity++;
                        currentCity = startingCity;
                        break;
                    }
                    else if (remainingFuel >= 0 && j == distances.Length - 1)
                    {
                        return startingCity;
                    }

                    currentCity++;
                }
            }

            return startingCity;
        }
    }
}
