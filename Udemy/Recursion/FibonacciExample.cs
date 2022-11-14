namespace AlgorithmPractice.Udemy.Recursion
{
    public static class FibonacciExample
    {
        public static void Run()
        {
            // Index                [ 0, 1, 2, 3, 4, 5, 6, 7,  8,  9,  10, 11, 12 ]
            // Fibonacci Sequence:  [ 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144]...
            // Rule: The next number is found by adding up the two numbers before it.
            //  i.e.: [0 + 1 = 1], [1 + 1 = 2], [1 + 2 = 3]...

            // Question: Given a number 'n', return the next value of the Fibonacci sequence.
            Console.WriteLine(FibonacciRecursively(10));
            Console.WriteLine(FibonacciRecursivelyEfficient(10, 1, 0));
            Console.WriteLine(FibonacciIteratively(10));
        }

        // Time Complexity: Exponential -- O(2^n)
        private static int FibonacciRecursively(int n)
        {
            if (n < 2)
            {
                return n;
            }

            return FibonacciRecursively(n - 1) + FibonacciRecursively(n - 2);
        }

        private static int FibonacciRecursivelyEfficient(int n, int value, int previous)
        {
            if (n == 0)
            {
                return previous;
            }

            if (n == 1)
            {
                return value;
            }

            return FibonacciRecursivelyEfficient(n - 1, value + previous, value);
        }

        // Time Complexity: Linear -- O(n)
        private static int FibonacciIteratively(int n)
        {
            int[] arr = new int[n + 1];
            arr[0] = 0;
            arr[1] = 1;
            for (int i = 2; i < arr.Length; i++)
            {
                arr[i] = arr[i - 2] + arr[i - 1];
            }

            return arr[n];
        }
    }
}
