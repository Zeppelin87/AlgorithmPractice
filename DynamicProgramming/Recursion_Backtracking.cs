using System;

namespace AlgorithmPractice.DynamicProgramming
{
    public static class Recursion_Backtracking
    {
        public static void Run()
        {
            // Question: Given an input array and an integer ‘K’ which is atmost the size of the
            //  array, generate all the ways we can choose K integers from the array. 

            // Example:
            //      input: [3, 2, 5, 8]
            //      k: 3
            //
            //  Output:
            //      [3, 2, 5]
            //      [3, 2, 8]
            //      [3, 5, 8]
            //      [2, 5, 8]     

            int[] input = { 3, 2, 5, 8 };
            int k = 3;

            //Solution(input, k);
            //Solution_Alternative(input, k);



            // output:
            //  [1, 1, 6]
            //  [1, 2, 5]
            //  [1, 7]
            //  [2, 6]

            int[] targetSumInput = { 10, 1, 2, 7, 6, 1, 5 };
            int target = 8;
            var targetSum = new Recursion_Backtracking_Target_Sum();
            targetSum.TargetSum_Solution(targetSumInput, target);


            // output:
            // "god"
            // "gdo"
            // "dog"
            // "dgo"
            // "ogd"
            // "odg"

            string word = "god";
            targetSum.Anagram_Solution(word);
        }

        private static void Solution(int[] input, int k)
        {
            Combination(input, new HashSet<int>(), k, 0);
        }

        private static void Solution_Alternative(int[] input, int k)
        {
            Combination_Alternative(input, new HashSet<int>(), 0, k);
        }

        private static void Combination(int[] input, HashSet<int> set, int k, int start)
        {
            if (set.Count == k)
            {
                Console.WriteLine("[{0}]", string.Join(", ", set));
                return;
            }

            if (start == input.Length)
            {
                return;
            }

            for (int i = start; i < input.Length; i++)
            {
                set.Add(input[i]);
                Combination(input, set, k, i + 1);
                set.Remove(input[i]);
            }
        }

        private static void Combination_Alternative(int[] input, HashSet<int> set, int i, int k)
        {
            if (set.Count == k)
            {
                Console.WriteLine("[{0}]", string.Join(", ", set));
                return;
            }

            if (i == input.Length)
            {
                return;
            }

            set.Add(input[i]);
            Combination_Alternative(input, set, i + 1, k);
            set.Remove(input[i]);
            Combination_Alternative(input, set, i + 1, k);
        }
    }

    public class Recursion_Backtracking_Target_Sum
    {
        public void TargetSum_Solution(int[] input, int target)
        {
            Array.Sort(input);
            GenerateTargetSumSets(input, new List<int>(), target, 0, 0);
        }

        private void GenerateTargetSumSets(int[] input, List<int> set, int target, int sum, int start)
        {
            if (sum == target)
            {
                Console.WriteLine("[{0}]", string.Join(", ", set));
                return;
            }

            for (int i = start; i < input.Length; i++)
            {
                int c = input[i];
                if (sum + c > target || i > start && input[i] == input[i - 1])
                {
                    continue;
                }

                set.Add(c);
                GenerateTargetSumSets(input, set, target, sum + c, i + 1);
                set.RemoveAt(set.Count - 1);
            }
        }

        public void Anagram_Solution(string input)
        {
            char[] inputArray = input.ToCharArray();
            Array.Sort(inputArray);
            Anagrams(inputArray, new char[input.Length], new bool[input.Length], 0);
        }

        private void Anagrams(char[] input, char[] anagram, bool[] used, int index)
        {
            if (index == input.Length)
            {
                Console.WriteLine("[{0}]", string.Join(", ", anagram));
                return;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (!used[i] && !(i > 0 && input[i] == input[i - 1] && !used[i - 1]))
                {
                    used[i] = true;
                    anagram[index] = input[i];
                    Anagrams(input, anagram, used, index + 1);
                    used[i] = false;
                }
            }
        }
    }
}
