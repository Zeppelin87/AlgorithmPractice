using AlgorithmPractice.Extensions;

namespace AlgorithmPractice.Technique
{
    public static class Arrays
    {
        public static void Run()
        {
            //                      { 0, 1, 2, 3, 4,  5 };
            int[] array = new int[] { 1, 2, 3, 6, 9, 12 };
            SortingExtension.ConsoleLog(array);
            Log("\n");

            ///
            // Notes:
            //
            //  - Use a 'for loop' when: loop should execute 'n' times.
            //      - Ex: iterate from arr[0...n-1].
            //
            //  - Use a 'while loop' when: you don't know, ahead of time, how many times the loop should run... (break on a condition).
            //      Ex:
            //      while (i < arr.Length - 1)
            //      {
            //          if (arr[i] == x)
            //          {
            //              result.Add(i);
            //              break;
            //          }
            //              
            //         i++;
            //      }
            /// 

            // i < array.Length: 
            //      - 'i' stops at the last index, 5. 
            //      - 'i' will never be larger than 5.

            // 'i' < array.Length == 'last index' + 1.
            // 'i' < array.Length - 1 == 'last index' of array[].

            // for (int i = 0; i < array.Length): 'i' is <= 'last' index'.
            // for (int i = 0; i < array.Length - 1); 'i' is <= 'last' index - 1. 

            Log("Iterate: 'for loop': arr[0...n-1].");
            for (int i = 0; i < array.Length; i++)
            {
                Log(array[i]);

                if (i == array.Length - 1) Log("--- \n");
            }

            Log("Iterate: 'for loop': arr[n-1...0].");
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Log(array[i]);

                if (i == 0) Log("--- \n");
            }

            Log("Iterate: 'while loop' '0' to 'last'.");
            While_Loop_Start_0(array);

            Log("Iterate: 'while loop' 'last' to '0'.");
            While_Loop_Right_to_Left(array);

            Log("Compare: 'i' greater than 'previous'.");
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    Log($"{array[i]} > {array[i - 1]}");
                }

                if (i == array.Length - 1) Log("--- \n");
            }

            Log("Compare: 'i' less than 'next'.");
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    Log($"{array[i]} < {array[i + 1]}");
                }

                if (i == array.Length - 2) Log("--- \n");
            }

            Log("Iterate: validate 'i' is between... 'previous' < 'i' > 'next'");
            for (int i = 1; i < array.Length - 1; i++)
            {
                if (array[i] > array[i - 1] &&
                    array[i] < array[i + 1])
                {
                    Log($"{array[i + 1]} < {array[i]} < {array[i + 1]} ");
                }

                if (i == array.Length - 2) Log("--- \n");
            }

            Log("Iterate: circular index");
            Iterate_Circular_Index(array);
        }

        private static void While_Loop_Start_0(int[] array)
        {
            int i = 0;
            while (i < array.Length)
            {
                Console.WriteLine(array[i]);
                i++;

                if (i == array.Length) Log("--- \n");
            }
        }

        private static void While_Loop_Right_to_Left(int[] array)
        {
            int i = array.Length - 1;
            while (i >= 0)
            {
                Log(array[i]);
                i--;
            }

            if (i == -1) Log("--- \n");
        }

        private static void Iterate_Circular_Index(int[] array)
        {
            int idx = 0;
            int counter = 0;
            while (counter < 2 * array.Length)
            {
                idx = idx % array.Length;

                Log(array[idx]);

                idx++;
                counter++;
            }

            if (counter == 2 * array.Length) Log("--- \n");
        }

        // TODO:
        // Find Peak (fromLeft & fromRight).
        // Sort array (ascending & descending).
        // 2 pointers. 
        // 3 pointers.

        private static void Log(int i)
        {
            Console.WriteLine(i);
        }

        private static void Log(string str = "")
        {
            Console.WriteLine(str);
        }

        //private static int[] GetArray()
        //{
        //    //               { 0,  1,  2, 3,  4,  5 };
        //    return new int[] { 2,  5,  6, 9, 12, 15 };
        //}
    }
}
