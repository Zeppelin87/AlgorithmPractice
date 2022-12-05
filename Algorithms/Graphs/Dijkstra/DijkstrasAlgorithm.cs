namespace AlgorithmPractice.Algorithms.Graphs.Dijkstra
{
    public static class DijkstrasAlgorithm
    {
        public static void Run()
        {
            // Dijkstra's (shortest path) Algorithm.
            int[][] edges = {
                //        { src,            dest,        weight }
                new int[] { (int)Nodes.A, (int)Nodes.B, 10 },       // A -> B: 10
                new int[] { (int)Nodes.A, (int)Nodes.C, 3 },        // A -> C: 3
                new int[] { (int)Nodes.B, (int)Nodes.D, 2 },        // B -> D: 2
                new int[] { (int)Nodes.C, (int)Nodes.B, 4 },        // C -> B: 4
                new int[] { (int)Nodes.C, (int)Nodes.D, 8 },        // C -> D: 8
                new int[] { (int)Nodes.C, (int)Nodes.E, 2 },        // C -> E: 2
                new int[] { (int)Nodes.D, (int)Nodes.E, 5 },        // D -> E: 5
            };

            int n = 5;
            int src = (int)Nodes.A;

            var exampleResult = SPath(edges, src, n);

            var result = ShortestPath(edges, n, src);
        }

        public static Dictionary<int, int> ShortestPath(int[][] edges, int n, int src)
        {
            // Convert list of edges into an adjacency list.
            // 'n' = number of nodes.
            var adj = new Dictionary<int, List<int[]>>();
            for (int i = 1; i < n + 1; i++)
            {
                adj.Add(i, new List<int[]>());
            }

            // Append the destination nodes to the adjacency list.
            foreach (int[] edge in edges)
            {
                // s = src, d = dst, w = weight
                int s = edge[0];
                int d = edge[1];
                int w = edge[2];

                adj[s].Add(new int[] { d, w });
            }

            var shortestPathMap = new Dictionary<int, int>(); // Shortest path map foreach node.
            var minHeap = new PriorityQueue<int[], int>();
            
            minHeap.Enqueue(new int[] { 0, src }, 0);

            while (minHeap.Count > 0)
            {
                int[] current = minHeap.Dequeue();
                int currentWeight = current[0]; // "weight" || "cost" to go from 'A to B'
                int currentNode = current[1]; // the node itself.

                // if we've already visted this node (i.e. already calculated the shortest path... skip iteration.
                if (shortestPathMap.ContainsKey(currentNode))
                {
                    continue;
                }

                // Add the shortest path to the given node (i.e. add the shortest path to 'B' from 'A'.
                shortestPathMap.Add(currentNode, currentWeight);

                // After we get the shortest path, iterate thru the neighbors of node 'B'.
                foreach (int[] pair in adj[currentNode])
                {
                    int neighborNode = pair[0];
                    int neighborWeight = pair[1];
                    
                    // if we haven't calculated the shortest path for the given neighbor, 'C', then we push it to the minHeap for processing.
                    if (!shortestPathMap.ContainsKey(neighborNode))
                    {
                        minHeap.Enqueue(new int[] { currentWeight + neighborWeight, neighborNode }, currentWeight + neighborWeight);
                    }
                }
            }

            return shortestPathMap;
        }

        private static Dictionary<int, int> SPath(int[][] edges, int src, int n)
        {
            // Create adjacency list.
            var adjacencyList = new Dictionary<int, List<int[]>>();
            for (int i = 1; i < n + 1; i++)
            {
                adjacencyList.Add(i, new List<int[]>());
            }

            foreach (int[] edge in edges)
            {
                int s = edge[0];
                int dst = edge[1];
                int weight = edge[2];

                adjacencyList[s].Add(new int[] { dst, weight });
            }

            var shortestPathMap = new Dictionary<int, int>();
            var minHeap = new PriorityQueue<int[], int>();
            minHeap.Enqueue(new int[] { src, 0 }, 0);

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

                    if (!shortestPathMap.ContainsKey(neighborNode))
                    {
                        minHeap.Enqueue(new int[] { neighborNode, weight + neighborWeight }, weight + neighborWeight);
                    }
                }
            }

            return shortestPathMap;
        }
    }

    public enum Nodes
    {
        None = 0,
        A = 1,
        B = 2,
        C = 3,
        D = 4,
        E = 5
    }
}
