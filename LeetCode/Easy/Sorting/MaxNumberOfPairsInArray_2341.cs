namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MaxNumberOfPairsInArray_2341
    {
        public static void Run()
        {
            int[] nums = new int[] { 1, 3, 2, 1, 3, 2, 2 };
            Extensions.SortingExtension.ConsoleLog(nums);

            var result = Solution(nums);
        }

        private static int[] Solution(int[] nums)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (!dictionary.ContainsKey(nums[i]))
                {
                    dictionary.Add(nums[i], 1);
                }
                else
                {
                    dictionary[nums[i]]++;
                }
            }

            int[] answer = new int[2];
            int temp1 = 0;
            int temp2 = 0;
            foreach (var x in dictionary)
            {
                temp1 += x.Value / 2;
                temp2 += x.Value % 2;
            }

            answer[0] = temp1;
            answer[1] = temp2;
            return answer;
        }

        private static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = key;
            }

            return arr;
        }
    }
}
