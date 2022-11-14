namespace AlgorithmPractice.Udemy.BigO
{
    public static class Exercise1
    {
        // Calculate Big O 
        public static void Run()
        {
            int[] input = new int[] { 1, 2, 3, 4, 5 };
            FunChallenge(input);
        }

        public static void FunChallenge(int[] input)
        {
            int a = 50; // O(1)
            a = 50 + 3; // O(1)

            for (int i = 0; i < input.Length; i++) // O(n)
            {
                AnotherFunction(); // O(n)
                bool stranger = true; // O(n)
                a++; // O(n)
            }
        }

        public static void AnotherFunction()
        {
            // unknown
        }

        // Big O Calculation == O(2 + 3n) == O(n)
    }
}
