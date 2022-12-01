namespace AlgorithmPractice.Algorithms.Graphs.Topological
{
    public static class LeetCode_Medium_CourseSchedule_207
    {
        public static void Run()
        {
            int[][] prerequisites = {
                new int[] { 1, 0 },
                new int[] { 0, 1 },
            };

            int numOfCourses = 2;

            // O(v + e) time complexity | O(v) space complexity.
            // Where: 'v' is the number of vertices & 'e' is the number of edges.
            bool result = Solution(numOfCourses, prerequisites);
        }

        private static bool Solution(int numCourses, int[][] prerequisites)
        {
            var adjacencyList = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                adjacencyList.Add(i, new List<int>());
            }

            foreach (int[] pair in prerequisites)
            {
                int src = pair[0];
                int dst = pair[1];

                adjacencyList[src].Add(dst);
            }

            var visited = new bool[numCourses];
            var inStack = new bool[numCourses];

            for (int node = 0; node < numCourses; node++)
            {
                if (visited[node])
                {
                    continue;
                }
                bool containsCycle = HasCycle(adjacencyList, visited, inStack, node);

                if (containsCycle)
                {
                    return false;
                }
            }

            return true;
        }

        private static bool HasCycle(Dictionary<int, List<int>> adjacencyList, bool[] visited, bool[] inStack, int node)
        {
            visited[node] = true;
            inStack[node] = true;

            bool containsCycle = false;
            foreach (int neighbor in adjacencyList[node])
            {
                if (!visited[neighbor])
                {
                    containsCycle = HasCycle(adjacencyList, visited, inStack, neighbor);
                }

                if (containsCycle || inStack[neighbor])
                {
                    return true;
                }
            }

            inStack[node] = false;
            return false;
        }
    }
}
