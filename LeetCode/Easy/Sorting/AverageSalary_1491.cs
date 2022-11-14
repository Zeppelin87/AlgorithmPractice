namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class AverageSalary_1491
    {
        public static void Run()
        {
            int[] salary = new int[] { 4000, 3000, 1000, 2000 };
            var result = Solution(salary);
        }

        private static double Solution(int[] salary)
        {
            Array.Sort(salary);

            double total = 0;
            int numOfSalaries = salary.Length - 2;
            for (int i = 1; i < salary.Length - 1; i++)
            {
                total += salary[i];
            }

            double avg = total / numOfSalaries;

            return avg;
        }
    }
}
