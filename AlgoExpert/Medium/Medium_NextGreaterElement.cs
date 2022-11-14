namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_NextGreaterElement
    {
        public static void Run()
        {
            int[] array = new int[] { 2, 5, -3, -4, 6, 7, 2 };

            // Time Complexity: O(n^2) -- Quadratic (where 'n' is the length of the input array[]).
            // Space Complexity: O(n) -- Linear.
            var result = Solution_TwoPointer(array);

            ModulusExample();

            // Time Complexity: O(n) -- Linear (where 'n' is the length of the input array[]).
            // Space Complexity: O(n) -- Linear.
            var result2 = Solution_Using_Stack(array);
        }

        private static int[] Solution_Using_Stack(int[] array)
        {
            int[] result = new int[array.Length];
            var stack = new Stack<int>();

            Array.Fill(result, -1);

            for (int i = 0; i < 2 * array.Length; i++)
            {
                int circularIndex = i % array.Length;

                while (stack.Count > 0 && array[circularIndex] > array[stack.Peek()])
                {
                    int top = stack.Pop();
                    result[top] = array[circularIndex];
                }

                stack.Push(circularIndex);
            }

            return result;
        }

        private static int[] Solution_TwoPointer(int[] array)
        {
            if (array.Length == 0)
            {
                return new int[] { };
            }

            if (array.Length == 1)
            {
                return new int[] { -1 };
            }

            int[] result = new int[array.Length];

            int i = 0;
            int j = i + 1;
            int counter = 1;

            while (counter < array.Length && i < array.Length)
            {
                if (j > array.Length - 1)
                {
                    j = 0;
                }

                if (array[j] > array[i])
                {
                    result[i] = array[j];
                    i++;
                    j = i + 1;
                    counter = 1;
                    continue;
                }
                else
                {
                    result[i] = -1;
                }

                j++;
                counter++;

                if (counter >= array.Length)
                {
                    i++;
                    j = i + 1;
                    counter = 1;
                }
            }


            return result;
        }

        private static void ModulusExample()
        {
            int n = 7;
            int remainder = 0;

            for (int i = 0; i < 2 * n; i++)
            {
                remainder = i % n;
                Console.WriteLine($"{i} % {n} = {remainder}");
            }
        }
    }
}
