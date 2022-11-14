namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_SunsetViews
    {
        public static void Run()
        {
            // output = [1, 3, 6, 7]
            //                indices[] { 0, 1, 2, 3, 4, 5, 6, 7 };
            int[] buildings = new int[] { 3, 5, 4, 4, 3, 1, 3, 2 };
            string direction = "WEST";

            // Time Complexity: O(n^2) -- Quadratic (where 'n' is the length of the input array buildings[]).
            // Space Complexity: O(n) -- Linear.
            //var result = Solution_BruteForce_TwoPointer(buildings, direction);

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array buildings[]).
            // Space Complexity: O(n) -- Linear.
            var result2 = Solution(buildings, direction);
        }

        private static List<int> Solution(int[] buildings, string direction)
        {
            int largetst = 0;
            var result = new List<int>();

            if (buildings.Length == 0)
            {
                return result;
            }

            if (direction == "EAST")
            {
                var stack = new Stack<int>();
                for (int i = buildings.Length - 1; i >= 0; i--)
                {
                    if (buildings[i] > largetst)
                    {
                        stack.Push(i);
                        largetst = buildings[i];
                    }
                }

                int n = stack.Count;

                for (int i = 0; i < n; i++)
                {
                    result.Add(stack.Pop());
                }
            }
            else if (direction == "WEST")
            {
                for (int i = 0; i < buildings.Length; i++)
                {
                    if (buildings[i] > largetst)
                    {
                        result.Add(i);
                        largetst = buildings[i];
                    }
                }
            }

            return result;
        }

        private static List<int> Solution_BruteForce_TwoPointer(int[] buildings, string direction)
        {
            if (buildings == null || buildings.Length == 0)
            {
                return new List<int>();
            }

            int i;
            int initialPointer;
            var result = new List<int>();

            if (direction == "EAST")
            {
                i = 0;
                initialPointer = buildings.Length - 1;

                result = CalculateEast(buildings, i, initialPointer);
                result.Sort();
                return result;
            }
            else
            {
                i = buildings.Length - 1;
                initialPointer = 0;

                result = CalculateWest(buildings, i, initialPointer);
                result.Sort();
                return result;
            }
        }

        private static List<int> CalculateEast(int[] buildings, int i, int initialPointer)
        {
            var result = new List<int>();
            int pointer = initialPointer;

            while (i < pointer)
            {
                if (buildings[i] > buildings[pointer] && i + 1 == pointer)
                {
                    result.Add(i);

                    i++;
                    pointer = initialPointer;
                }
                else if (buildings[i] > buildings[pointer])
                {
                    pointer--;
                }
                else
                {
                    i++;
                    pointer = initialPointer;
                }
            }

            result.Add(initialPointer);

            return result;
        }

        private static List<int> CalculateWest(int[] buildings, int i, int initialPointer)
        {
            var result = new List<int>();
            int pointer = initialPointer;

            result.Add(initialPointer);

            while (i > pointer)
            {
                if (buildings[i] > buildings[pointer] && i - 1 == pointer)
                {
                    result.Add(i);

                    i--;
                    pointer = initialPointer;
                }
                else if (buildings[i] > buildings[pointer])
                {
                    pointer++;
                }
                else
                {
                    i--;
                    pointer = initialPointer;
                }
            }

            return result;
        }
    }
}
