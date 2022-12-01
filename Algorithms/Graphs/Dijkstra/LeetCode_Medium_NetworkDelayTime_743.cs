namespace AlgorithmPractice.Algorithms.Graphs.Dijkstra
{
    public static class LeetCode_Medium_NetworkDelayTime_743
    {
        public static void Run()
        {
            int[][] times = {
                //new int[] { 2, 1, 1 },
                //new int[] { 2, 3, 1 },
                //new int[] { 3, 4, 1 },

                //new int[] { 1, 2, 1 },

                new int[] { 1, 2, 1 },
                new int[] { 2, 3, 2 },
                new int[] { 1, 3, 1 },
            };

            int n = 3;
            int k = 2;

            // O(n + Elog(n)) time complexity | O(n+E) space complexity.
            // Where: 'n' is the number of nodes & 'E' is the total number of edges.
            //
            // Time Complexity Explanation:
            // Dijkstra's Algorithm takes O(E log(n)).
            // Finding the min time required in the shortestPathMap takes O(n).
            //
            // Space Complexity Explanation:
            // Building the adjacency list for Dijkstra's Algorithm takes O(E) space.
            // Building the shortestPathMap takes O(n) space.
            int result = Solution(times, n, k);
        }

        private static int Solution(int[][] times, int n, int k)
        {
            // Create adjacency list.
            var adjacencyList = new Dictionary<int, List<int[]>>();
            for (int i = 1; i < n + 1; i++)
            {
                adjacencyList.Add(i, new List<int[]>());
            }

            foreach (int[] time in times)
            {
                int src = time[0];
                int dst = time[1];
                int weight = time[2];

                adjacencyList[src].Add(new int[] { dst, weight });
            }

            // Create shortestPathMap & minHeap.
            var shortestPathMap = new Dictionary<int, int>();
            var minHeap = new PriorityQueue<int[], int>();

            minHeap.Enqueue(new int[] { k, 0 }, 0);

            // Iterate thru minHeap.
            while (minHeap.Count > 0)
            {
                int[] current = minHeap.Dequeue();
                int node = current[0];
                int weight = current[1];

                if (shortestPathMap.ContainsKey(node))
                {
                    continue;
                }

                shortestPathMap.Add(node, weight);

                foreach (int[] neighbor in adjacencyList[node])
                {
                    int neighborNode = neighbor[0];
                    int neighborWeight = neighbor[1];

                    int totalWeight = weight + neighborWeight;

                    if (!shortestPathMap.ContainsKey(neighborNode))
                    {
                        minHeap.Enqueue(new int[] { neighborNode, totalWeight }, totalWeight);
                    }
                }
            }

            // return greatest value found in shortestPathMap.
            int longestDelay = 0;
            foreach (var element in shortestPathMap)
            {
                if (element.Value > longestDelay)
                {
                    longestDelay = element.Value;
                }
            }

            return shortestPathMap.Count == n ? longestDelay : -1;
        }
    }
}
