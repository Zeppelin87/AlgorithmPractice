namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_Powerset
    {
        public static void Run()
        {
            var array = new List<int>() { 1, 2, 3 };

            // Time Complexity: 
            // Space Complexity: 
            var result = Solution(array);
        }

        private static List<List<int>> Solution(List<int> array)
        {
            var subsets = new List<List<int>>();
            subsets.Add(new List<int>());

            foreach (int ele in array)
            {
                int length = subsets.Count;

                for (int i = 0; i < length; i++)
                {
                    List<int> currentSubset = new List<int>(subsets[i]);
                    currentSubset.Add(ele);
                    subsets.Add(currentSubset);
                }
            }

            return subsets;
        }
    }
}
