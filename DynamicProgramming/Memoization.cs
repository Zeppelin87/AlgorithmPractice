namespace AlgorithmPractice.DynamicProgramming
{
    public static class Memoization
    {
        public static void Run()
        {
            Recursion_Fundementals recursion_Fundementals = new Recursion_Fundementals();

            // Dynamic Programming (DP) - is mainly used to solve optimization problems.
            //      - at every step, there are multiple decisions that can be made.
            //      - you must figure out which decision to make at each step in order to end up with the optimal solution.
            //
            //  - The first step in writing a DP solution is to come up with the naive recursive solution
            //      - you should know how to use recursion to generate all possible solutions.
            //
            //  - Backtracking is a recursive technique used to exhaustively compute each possible step in order to solve a problem.
            //      - DFS is a classic example of 'Backtracking'.
            //      - Link (Section: 3 Backtracking -> Resources -> .pdf): https://www.udemy.com/course/master-the-art-of-dynamic-programming/



            Memoization_Fibonacci_Examples memoization_Fibonacci_Examples = new Memoization_Fibonacci_Examples();

            // DP = "careful brute force".
            // DP = guessing + recursion + memoization.
            // DP = shortest paths in some DAGs.
            // Time complexity = (time * time per sub problem) ----- treating recursive calls as O(1) due to memoization.

            // 5 "easy" steps to DP:
            //  1. define subproblems.
            //  2. guess (part of solution).
            //  3. relate subproblem solutions.
            //  4. recurse & memoize OR build DP table from bottom-up.
            //  5. solve original problem.
        }
    }

    public class Recursion_Fundementals
    {
        public static void Backtracking_PseudoCode(int[] input, int[] partial, bool[] used)
        {
            if (IsValidSolution(partial))
            {
                ProcessSolution(partial);
                return;
            }

            var candidates = GenerateCandidates(input, partial);

            foreach (int c in candidates)
            {
                AddCandidate(c, input, partial);
                // OR
                used[c] = true;

                Backtracking_PseudoCode(input, partial, used);

                RemoveCandidate(c, input, partial);
                // OR
                used[c] = false;
            }
        }

        #region Helpers

        private static bool IsValidSolution(int[] partial)
        {
            return true;
        }

        private static void ProcessSolution(int[] partial)
        {

        }

        private static int[] GenerateCandidates(int[] input, int[] partial)
        {
            return new int[] { };
        }

        private static void AddCandidate(int c, int[] input, int[] partial)
        {

        }

        private static void RemoveCandidate(int c, int[] input, int[] partial)
        {

        }

        #endregion
    }

    public class Memoization_Fibonacci_Examples
    {
        // Recursively solve for each fibonacci value.
        public static int Recursive_Naive_Fib(int n)
        {
            if (n <= 2)
            {
                return 1;
            }

            int f = Recursive_Naive_Fib(n - 1) + Recursive_Naive_Fib(n - 2);
            return f;
        }

        // Use dynamic programming (recursion + memoization) to re-use solutions to subproblems that help solve the actual problem.
        public static int DP_Memoized_Fib(Dictionary<int, int> memo, int n)
        {
            if (memo.ContainsKey(n))
            {
                return memo[n];
            }
            else if (n <= 2)
            {
                return 1;
            }

            int f = DP_Memoized_Fib(memo, n - 1) + DP_Memoized_Fib(memo, n - 2);
            memo[n] = f;

            return f;
        }

        // Use iteration + DP to start at the bottom and then return the final value (start at fib(0) & end up with / return fib(n)).
        public static int DP_Bottom_Up_Fib(Dictionary<int, int> memo, int n)
        {
            int f = 0;
            for (int i = 0; i < n + 1; i++)
            {
                if (i <= 2)
                {
                    f = 1;
                }

                f = memo[n - 1] + memo[n - 2];
                memo[n] = f;
            }

            return memo[n];
        }
    }
}
