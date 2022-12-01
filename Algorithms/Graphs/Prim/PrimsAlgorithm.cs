namespace AlgorithmPractice.Algorithms.Graphs.Prim
{
    public static class PrimsAlgorithm
    {
        /// <summary>
        /// Prim's (minimum spanning tree) Algorithm.
        /// </summary>
        public static void Run()
        {
            //          { src, dst, weight }
            int[][] edges = {
                new int[] { 1, 2, 10 },
                new int[] { 1, 3, 3 },
                new int[] { 3, 2, 4 },
                new int[] { 3, 4, 4 },
                new int[] { 3, 5, 4 },
                new int[] { 2, 4, 1 },
                new int[] { 4, 5, 2 },
            };

            int n = 5;

            List<int[]> result = MinimumSpanningTree(edges, n);

            var result2 = MinST(edges, n);
        }

        private static List<int[]> MinimumSpanningTree(int[][] edges, int n)
        {
            // Create adjacency list.
            var adjacencyList = new Dictionary<int, List<int[]>>();
            for (int i = 1; i < n + 1; i++)
            {
                adjacencyList.Add(i, new List<int[]>());
            }

            foreach (int[] edge in edges)
            {
                int src = edge[0];
                int dst = edge[1];
                int weight = edge[2];

                adjacencyList[src].Add(new int[] { dst, weight });
                adjacencyList[dst].Add(new int[] { src, weight });
            }

            // Initialize the minHeap by choosing a single node.
            // (in this case 1) and pushing all it's neighbors.  
            var minHeap = new PriorityQueue<int[], int>();

            foreach (int[] neighbor in adjacencyList[1])
            {
                int node = neighbor[0];
                int weight = neighbor[1];
                minHeap.Enqueue(new int[] { 1, node, weight }, weight);
            }

            var mst = new List<int[]>();
            var visited = new HashSet<int>();
            visited.Add(1);

            while (visited.Count < n)
            {
                int[] current = minHeap.Dequeue();
                int node1 = current[0];
                int node2 = current[1];

                if (visited.Contains(node2))
                {
                    continue;
                }

                mst.Add(new int[] { node1, node2 });
                visited.Add(node2);

                foreach (int[] neighbor in adjacencyList[node2])
                {
                    int neighborNode = neighbor[0];
                    int neighborWeight = neighbor[1];

                    if (!visited.Contains(neighborNode))
                    {
                        minHeap.Enqueue(new int[] { node2, neighborNode, neighborWeight }, neighborWeight);
                    }
                }
            }

            return mst;
        }

        private static List<int[]> MinST(int[][] edges, int n)
        {
            // Create adjacency list.
            var adjacencyList = new Dictionary<int, List<int[]>>();
            for (int i = 1; i < n + 1; i++)
            {
                adjacencyList.Add(i, new List<int[]>());
            }

            foreach (int[] edge in edges)
            {
                int src = edge[0];
                int dst = edge[1];
                int weight = edge[2];

                adjacencyList[src].Add(new int[] { dst, weight });
                adjacencyList[dst].Add(new int[] { src, weight });
            }

            // Create MinHeap, Visited & mst.
            var mst = new List<int[]>();
            var minHeap = new PriorityQueue<int[], int>();
            foreach (int[] neighbor in adjacencyList[1])
            {
                int node = neighbor[0];
                int weight = neighbor[1];

                minHeap.Enqueue(new int[] { 1, node, weight }, weight);
            }

            var visited = new HashSet<int>();
            visited.Add(1);

            // Iterate thru while (vis.Count < n)
            while (visited.Count < n)
            {
                int[] current = minHeap.Dequeue();
                int n1 = current[0];
                int n2 = current[1];

                if (visited.Contains(n2))
                {
                    continue;
                }

                visited.Add(n2);
                mst.Add(new int[] { n1, n2 });

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

            return mst;
        }
    }
}
