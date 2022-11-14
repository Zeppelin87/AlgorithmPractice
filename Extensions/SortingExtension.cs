namespace AlgorithmPractice.Extensions
{
    public static class SortingExtension
    {
        public static void ConsoleLog(int[] array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void ConsoleLog(List<int> array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void ConsoleLog(List<int> array, string message)
        {
            Console.WriteLine(message + "[{0}]", string.Join(", ", array));
        }

        public static void ConsoleLog(List<char> array)
        {
            Console.WriteLine("[{0}]", string.Join(", ", array));
        }

        public static void ConsoleLog(int[] array, string message)
        {
            Console.WriteLine(message + "[{0}]", string.Join(", ", array));
        }

        public static void ConsoleLog(List<List<int>> array)
        {
            int[] indexArr = new int[array[0].Count];
            for (int i = 0; i < indexArr.Length; i++)
            {
                indexArr[i] = i;
            }

            Console.WriteLine("i: " + "[{0}]", string.Join(", ", indexArr));
            Console.WriteLine();

            int idx = 0;
            foreach (List<int> arr in array)
            {
                ConsoleLog(arr, $"{idx}: ");
                idx++;
            }
        }

        public static void ConsoleLog(Stack<int> stack)
        {
            int[] arr = new int[stack.Count];

            int idx = 0;
            while (stack.Count > 0)
            {
                arr[idx] = stack.Pop();
                idx++;
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}: {arr[i]}");
            }

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                stack.Push(arr[i]);
            }
        }

        public static void ConsoleLogArrayIndices(int size)
        {
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = i;
            }

            ConsoleLog(array, "Index Ref:     ");
            //Console.WriteLine("--------------");
        }
    }
}
