namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class RelativeRanks_506
    {
        public static void Run()
        {
            int[] score = new int[] { 10, 3, 8, 9, 4 };

            var result = Solution(score);
        }

        private static string[] Solution(int[] score)
        {
            int[] temp = new int[score.Length];

            for (int i = 0; i < score.Length; i++)
            {
                temp[i] = score[i];
            }

            Array.Sort(temp, (x, y) =>
            {
                return y - x;
            });

            var dictionary = new Dictionary<int, string>();
            string first = "Gold Medal";
            string second = "Silver Medal";
            string third = "Bronze Medal";

            for (int i = 0; i < temp.Length; i++)
            {
                string placement = "";

                if (dictionary.Count == 0)
                {
                    placement = first;
                }
                else if (dictionary.Count == 1)
                {
                    placement = second;
                }
                else if (dictionary.Count == 2)
                {
                    placement = third;
                }
                else
                {
                    var num = Array.IndexOf(temp, temp[i]) + 1;
                    placement = num.ToString();
                }

                if (!dictionary.ContainsKey(temp[i]))
                {
                    dictionary.Add(temp[i], placement);
                }
            }

            string[] result = new string[score.Length];
            for (int i = 0; i < score.Length; i++)
            {
                result[i] = dictionary[score[i]];
            }

            return result;
        }
    }
}
