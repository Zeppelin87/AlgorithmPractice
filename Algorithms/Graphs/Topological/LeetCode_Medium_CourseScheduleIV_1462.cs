namespace AlgorithmPractice.Algorithms.Graphs.Topological
{
    public static class LeetCode_Medium_CourseScheduleIV_1462
    {
        public static void Run()
        {
            int[][] prerequisites = {
                //new int[] { 2, 3 },
                //new int[] { 2, 1 },
                //new int[] { 0, 3 },
                //new int[] { 0, 1 },

                new int[] { 2, 3 },
                new int[] { 2, 1 },
                new int[] { 2, 0 },
                new int[] { 3, 4 },
                new int[] { 3, 6 },
                new int[] { 5, 1 },
                new int[] { 5, 0 },
                new int[] { 1, 4 },
                new int[] { 1, 0 },
                new int[] { 4, 0 },
                new int[] { 0, 6 },
            };

            int[][] queries = {
                new int[] { 3, 0 },
                new int[] { 6, 4 },
                new int[] { 5, 6 },
                new int[] { 2, 6 },
                new int[] { 2, 3 },
                new int[] { 5, 6 },
                new int[] { 4, 0 },
                new int[] { 2, 6 },
                new int[] { 3, 5 },
            };

            int numOfCourses = 7;

            // O((V+E) * V) = O(V^3) time complexity | O(V^2) space complexity.
            // Where: 'v' is the number of vertices & 'e' is the number of edges.
            var result = Solution(numOfCourses, prerequisites, queries);
        }

        private static IList<bool> Solution(int numCourses, int[][] prerequisites, int[][] queries)
        {
            // create adjaceny list.
            var adjacencyList = new Dictionary<int, List<int>>();
            var prereqMap = new Dictionary<int, List<int>>();
            for (int i = 0; i < numCourses; i++)
            {
                adjacencyList.Add(i, new List<int>());
                prereqMap.Add(i, new List<int>());
            }

            foreach (int[] pair in prerequisites)
            {
                int src = pair[0];
                int dst = pair[1];

                adjacencyList[src].Add(dst);
            }

            // create in_degrees totals foreach node in the graph.
            var in_degrees = new int[numCourses];
            for (int i = 0; i < numCourses; i++)
            {
                foreach (int neighbor in adjacencyList[i])
                {
                    in_degrees[neighbor]++;
                }
            }

            var queue = new Queue<int>();
            for (int i = 0; i < numCourses; i++)
            {
                if (in_degrees[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            int count = 0;
            var topSort = new List<int>();
            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();
                topSort.Add(currentNode);

                foreach (int neighbor in adjacencyList[currentNode])
                {
                    prereqMap[neighbor].Add(currentNode);
                    prereqMap[neighbor].AddRange(prereqMap[currentNode].Where(x => !prereqMap[neighbor].Contains(x)));

                    in_degrees[neighbor] -= 1;
                    if (in_degrees[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }

                count++;
            }

            if (count != numCourses)
            {
                // cycle detected.
            }

            var answer = new List<bool>();
            foreach (int[] pair in queries)
            {
                int course1 = pair[0];
                int course2 = pair[1];

                if (prereqMap[course2].Contains(course1))
                {
                    answer.Add(true);
                }
                else
                {
                    answer.Add(false);
                }
            }

            return answer;
        }
    }
}
