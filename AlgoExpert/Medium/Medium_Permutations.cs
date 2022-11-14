namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_Permutations
    {
        public static void Run()
        {
            var array = new List<int>() { 1, 2, 3 };

            // Upper Bound: O(n^2 *n!) time complexity | O(n * n!) space complexity.
            // Roughly: O(n * n!) time complexity | O(n * n!) space complexity.
            // Where 'n' is the size of the input array[].
            var result = Solution(array);
        }

        private static List<List<int>> Solution(List<int> array)
        {
            var permutations = new List<List<int>>();
            GetPermutations(array, new List<int>(), permutations);
            return permutations;
        }

        private static void GetPermutations(List<int> array, List<int> currentPermutation, List<List<int>> permutations)
        {
            if (array.Count == 0 && currentPermutation.Count > 0)
            {
                permutations.Add(currentPermutation);
            }
            else
            {
                for (int i = 0; i < array.Count; i++)
                {
                    var newArray = new List<int>(array);
                    newArray.RemoveAt(i);
                    var newPermutation = new List<int>(currentPermutation);
                    newPermutation.Add(array[i]);
                    GetPermutations(newArray, newPermutation, permutations);
                }
            }
        }
    }
}
