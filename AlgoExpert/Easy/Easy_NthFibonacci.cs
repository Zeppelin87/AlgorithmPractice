namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_NthFibonacci
    {
        public static void Run()
        {
            int n = 12;

            //             [1, 2, 3, 4, 5, 6, 7,  8,  9,  10, 11, 12, 13] 
            // Fibonacci = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144]

            // Time Complexity: O(n) - Linear.
            //  - where 'n' is the number of Fibonacci numbers calculated.
            // Space Complexity: O(n) - Linear.
            var result = Solution_BruteForce(n);

            // Time Complexity: O(n^2) -- Exponential.
            // Space Complexity: O(n) -- Linear.
            var result2 = Solution_Recursive(n);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n) -- Linear.
            int[] cache = new int[n];
            var result3 = Solution_Memoization(n, cache);

            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(1) -- Constant.
            var result4 = Solution_WhileLoop(n);
        }

        private static int Solution_BruteForce(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            if (n == 2)
            {
                return 1;
            }

            int[] arr = new int[n];
            arr[0] = 0;
            arr[1] = 1;
            arr[2] = 1;

            for (int i = 3; i < n; i++)
            {
                arr[i] = arr[i - 1] + arr[i - 2];
            }

            return arr[n - 1];
        }

        private static int Solution_Recursive(int n)
        {
            if (n == 1)
            {
                return 0;
            }

            if (n == 2 || n == 3)
            {
                return 1;
            }
            else
            {
                return Solution_Recursive(n - 1) + Solution_Recursive(n - 2);
            }
        }

        private static int Solution_Memoization(int n, int[] cache)
        {
            if (cache[n - 1] != 0)
            {
                return cache[n - 1];
            }

            int result = 0;

            if (n == 1)
            {
                return 0;
            }

            if (n == 2 || n == 3)
            {
                result = 1;
            }
            else
            {
                result = Solution_Memoization(n - 1, cache) + Solution_Memoization(n - 2, cache);
            }

            cache[n - 1] = result;
            return result;
        }

        private static int Solution_WhileLoop(int n)
        {
            int[] lastTwo = new int[] { 0, 1 };
            int counter = 3;

            while (counter <= n)
            {
                int nextFib = lastTwo[0] + lastTwo[1];
                lastTwo[0] = lastTwo[1];
                lastTwo[1] = nextFib;
                counter++;
            }

            return n > 1 ? lastTwo[1] : lastTwo[0];
        }
    }
}
