namespace AlgorithmPractice.Udemy.BigO
{
    public static class Exercise2
    {
        // Calculate Big O
        public static void Run()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            AnotherFunChallenge(input);
        }

        public static void AnotherFunChallenge(int[] input)
        {
            int a = 5; // O(1)
            int b = 10; // O(1)
            int c = 50; // O(1)

            for (int i = 0; i < input.Length; i++) // O(n)
            {
                int x = i + 1; // O(n)
                int y = i + 2; // O(n)
                int z = i + 3; // O(n)
            }

            for (int j = 0; j < input.Length; j++) // O(n)
            {
                int p = j * 2; // O(n)
                int q = j * 2; // O(n)
            }

            string whoAmI = "I don't know"; // O(1)

            // Big O Calculation == O(4 + 3n +  2n) == O(4 + 5n) == O(n) 
        }
    }
}
