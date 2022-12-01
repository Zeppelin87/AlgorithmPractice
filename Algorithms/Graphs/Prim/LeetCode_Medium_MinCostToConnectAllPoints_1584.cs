namespace AlgorithmPractice.Algorithms.Graphs.Prim
{
    public static class LeetCode_Medium_MinCostToConnectAllPoints_1584
    {
        public static void Run()
        {
            int[][] points = { 
                new int[] { 0, 0 },
                new int[] { 2, 2 },
                new int[] { 3, 10 },
                new int[] { 5, 2 },
                new int[] { 7, 0 },
            };

            // O(n^2 * log(n)) time complexity | O(N^2) space complexity.
            // Where: 'n' is the number of edges.
            int result = Solution(points);
        }

        private static int Solution(int[][] points)
        {
            // Create adjacency list.
            int N = points.Length;
            var adjacencyList = new Dictionary<int, List<int[]>>();
            for (int i = 0; i < N; i++)
            {
                adjacencyList.Add(i, new List<int[]>());
            }

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    int n1 = i;
                    int n2 = j;
                    int weight = Math.Abs(points[i][0] - points[j][0]) + Math.Abs(points[i][1] - points[j][1]);

                    adjacencyList[n1].Add(new int[] { n2, weight });
                    adjacencyList[n2].Add(new int[] { n1, weight });
                }
            }

            // Create minHeap, visited & mst.
            var minHeap = new PriorityQueue<int[], int>();
            foreach (int[] pair in adjacencyList[0])
            {
                int node = pair[0];
                int weight = pair[1];

                minHeap.Enqueue(new int[] { 0, node, weight }, weight);
            }

            var visited = new HashSet<int>();
            visited.Add(0);

            var mst = new List<int[]>();

            while (visited.Count < N)
            {
                int[] current = minHeap.Dequeue();
                int n1 = current[0];
                int n2 = current[1];
                int w = current[2];

                if (visited.Contains(n2))
                {
                    continue;
                }

                visited.Add(n2);
                mst.Add(new int[] { n1, n2, w });

                foreach (int[] neighbor in adjacencyList[n2])
                {
                    int neighborNode = neighbor[0];
                    int neighborWeight = neighbor[1];

                    if (!visited.Contains(neighborNode))
                    {
                        minHeap.Enqueue(new int[] { n2, neighborNode, neighborWeight }, neighborWeight);
                    }
                }
            }

            int total = 0;
            foreach (var item in mst)
            {
                total += item[2];
            }

            return total;
        }
    }
}
