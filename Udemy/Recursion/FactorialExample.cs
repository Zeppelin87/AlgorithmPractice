namespace AlgorithmPractice.Udemy.Recursion
{
    public static class FactorialExample
    {
        public static void Run()
        {
            // Factorial == 5! == 5 * 4 * 3 * 2 * 1;
            Console.WriteLine(FindFactorialRecursively(5));
            Console.WriteLine(FindFactorialIteratively(5));
        }

        private static long FindFactorialRecursively(int number)
        {

            if (number == 1)
            {
                return 1;
            }

            return number * FindFactorialRecursively(number - 1);
        }

        private static long FindFactorialIteratively(int number)
        {
            int sum = 1;
            for (int i = number; i > 0; i--)
            {
                sum *= i;
            }

            return sum;
        }
    }
}
