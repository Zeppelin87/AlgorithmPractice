namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_TaskAssignment
    {
        public static void Run()
        {
            var k = 3;
            List<int> tasks = new List<int> { 1, 3, 5, 3, 1, 4 };

            // Time Complexity: O(n log(n)) -- Log-Linear (where 'n' is the size of the input array tasks[]).
            // Space Complexity: O(n) -- Linear.
            var result = Solution(k, tasks);
        }

        private static List<List<int>> Solution(int k, List<int> tasks)
        {
            var pairedTasks = new List<List<int>>();
            var taskDurationsToIndices = GetTaskDurationsToIndices(tasks);

            List<int> sortedTasks = tasks;
            sortedTasks.Sort();

            for (int i = 0; i < k; i++)
            {
                int taskDuration1 = sortedTasks[i];
                List<int> indicesWithTask1Duration = taskDurationsToIndices[taskDuration1];
                int task1Index = indicesWithTask1Duration[indicesWithTask1Duration.Count - 1];
                indicesWithTask1Duration.RemoveAt(indicesWithTask1Duration.Count - 1);

                int task2SortedIndex = tasks.Count - 1 - i;
                int task2Duration = sortedTasks[task2SortedIndex];
                List<int> indicesWithTask2Duration = taskDurationsToIndices[task2Duration];
                int task2Index = indicesWithTask2Duration[indicesWithTask2Duration.Count - 1];
                indicesWithTask2Duration.RemoveAt(indicesWithTask2Duration.Count - 1);

                var pairedTask = new List<int>();
                pairedTask.Add(task1Index);
                pairedTask.Add(task2Index);
                pairedTasks.Add(pairedTask);
            }

            return pairedTasks;
        }

        private static Dictionary<int, List<int>> GetTaskDurationsToIndices(List<int> tasks)
        {
            var taskDurationsToIndices = new Dictionary<int, List<int>>();

            for (int i = 0; i < tasks.Count; i++)
            {
                int taskDuration = tasks[i];

                if (!taskDurationsToIndices.ContainsKey(taskDuration))
                {
                    var temp = new List<int>();
                    temp.Add(i);
                    taskDurationsToIndices[taskDuration] = temp;
                }
                else
                {
                    taskDurationsToIndices[taskDuration].Add(i);
                }
            }

            return taskDurationsToIndices;
        }
    }
}
