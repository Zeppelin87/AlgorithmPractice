namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_IndexEqualsValue
    {
        public static void Run()
        {
            int[] array = { 3, 4, 2, 1, 2, 3, 7, 1, 1, 1, 3 };

            // 
            // Where: 
            var result = Solution(array);
        }

        private static int Solution(int[] array)
        {
            for (int index = 0; index < array.Length; index++)
            {
                int value = array[index];
                if (index == value)
                {
                    return index;
                }
            }

            return -1;
        }
    }
}
