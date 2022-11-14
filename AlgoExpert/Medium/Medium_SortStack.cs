namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_SortStack
    {
        public static void Run()
        {
            var stack = new List<int> { -5, 2, -2, 4, 3, 1 };
            //var stack = new List<int> { 3, 4, 5, 1, 2 };
            //var stack = new List<int> { -1, 0, 2, 3, 4, 1, 1, 1 };

            // Time Complexity: 
            // Space Complexity: 
            var result = SortStack(stack);
        }

        private static List<int> SortStack(List<int> stack)
        {
            if (stack.Count == 0)
            {
                return stack;
            }

            int top = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            SortStack(stack);

            InsertInSortedOrder(stack, top);
            return stack;
        }

        private static void InsertInSortedOrder(List<int> stack, int value)
        {
            if (stack.Count == 0 || stack[stack.Count - 1] <= value)
            {
                stack.Add(value);
                return;
            }

            int top = stack[stack.Count - 1];
            stack.RemoveAt(stack.Count - 1);

            InsertInSortedOrder(stack, value);

            stack.Add(top);
        }
    }
}
