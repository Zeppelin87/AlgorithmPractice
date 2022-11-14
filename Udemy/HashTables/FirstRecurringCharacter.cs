using System.Collections;

namespace AlgorithmPractice.Udemy.HashTables
{
    public static class FirstRecurringCharacter
    {
        public static void Run()
        {
            //Google Question
            //Given an array = [2,5,1,2,3,5,1,2,4]:
            //It should return 2

            //Given an array = [2,1,1,2,3,5,1,2,4]:
            //It should return 1

            //Given an array = [2,3,4,5]:
            //It should return undefined

            //Bonus... What if we had this:
            // [2,5,5,2,3,5,1,2,4]
            // return 5 because the pairs are before 2,2

            //int[] array = new int[] { 2, 5, 1, 2, 3, 5, 1, 2, 4 };
            //int[] array = new int[] { 2, 1, 1, 2, 3, 5, 1, 2, 4 };
            //int[] array = new int[] { 2, 3, 4, 5 };
            int[] array = new int[] { 2, 5, 5, 2, 3, 5, 1, 2, 4 };

            var result = FindRecurringCharacter(array);
        }

        private static int FindRecurringCharacter(int[] array)
        {
            var hashTable = new Hashtable();

            for (int i = 0; i < array.Length; i++)
            {
                if (hashTable.ContainsKey(array[i]))
                {
                    return array[i];
                }

                hashTable.Add(array[i], i);
            }

            return -1;
        }
    }
}
