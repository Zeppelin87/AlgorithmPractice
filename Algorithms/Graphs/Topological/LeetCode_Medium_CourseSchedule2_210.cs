namespace AlgorithmPractice.Algorithms.Graphs.Topological
{
    public static class LeetCode_Medium_CourseSchedule2_210
    {
        public static void Run()
        {
            int[][] prerequisites = {
                new int[] { 1, 0 },
                new int[] { 2, 0 },
                new int[] { 3, 1 },
                new int[] { 3, 2 },
            };

            int numOfCourses = 4;
            
            // O(v + e) time complexity | O(v) space complexity.
            // Where: 'v' is the number of vertices & 'e' is the number of edges.
            int[] result = Solution(numOfCourses, prerequisites);
        }

        private static int[] Solution(int numCourses, int[][] prerequisites)
        {
            // create adjacencyList.
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
            var topSort = new List<int>();

            for (int node = 0; node < numCourses; node++)
            {
                if (visited[node])
                {
                    continue;
                }

                bool containsCycle = DFS(adjacencyList, visited, inStack, topSort, node);

                if (containsCycle)
                {
                    return new int[] { };
                }
            }

            return topSort.ToArray();
        }

        private static bool DFS(Dictionary<int, List<int>> adjacencyList, bool[] visited, bool[] inStack, List<int> topSort, int node)
        {
            visited[node] = true;
            inStack[node] = true;

            bool containsCycle = false;
            foreach (int neighbor in adjacencyList[node])
            { 
                if (!visited[neighbor])
                {
                    containsCycle = DFS(adjacencyList, visited, inStack, topSort, neighbor);
                }

                if (containsCycle || inStack[neighbor])
                {
                    return true;
                }
            }

            inStack[node] = false;
            topSort.Add(node);

            return false;
        }
    }
}
