namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_FirstDuplicateValue
    {
        public static void Run()
        {
            int[] array = { 2, 1, 5, 2, 3, 3, 4 };

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array[]).
            // Space Complexity: O(n) -- Linear.
            var result = Solution_HashSet(array);

            // Time Complexity: 
            // Space Complexity: 
            var result2 = Solution_Best(array);
        }

        private static int Solution_HashSet(int[] array)
        {
            var hashSet = new HashSet<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (!hashSet.Contains(array[i]))
                {
                    hashSet.Add(array[i]);
                }
                else
                {
                    return array[i];
                }
            }

            return -1;
        }

        private static int Solution_Best(int[] array)
        {
            return -1;
        }
    }
}
