namespace AlgorithmPractice.Algorithms.Graphs.KahnsTopologicalSort
{
    public static class KahnsAlgorithm
    {
        public static void Run()
        {
            //  Kahn's Algorithm is a topological sorting algorithm.
            //  - keep track of the in-degree of each node (number of edges coming into each node).
            //  - if a node has an in-degree value == 0, we can add that node to the topological sort order. 
            //  - when a node is added to the topSort, decrement that node's dependencies in-degree by 1.

            int[][] edges = {
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 1, 3 },
                new int[] { 3, 5 },
                new int[] { 2, 4 },
                new int[] { 4, 5 },
            };

            int n = 6;

            var result = KahnTopologicalSort(edges, n);
          }

        private static IList<int> KahnTopologicalSort(int[][] edges, int n)
        {
            // create an adjacency list.
            var adjacencyList = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                adjacencyList.Add(i, new List<int>());
            }

            foreach (int[] edge in edges)
            {
                int src = edge[0];
                int dst = edge[1];

                adjacencyList[src].Add(dst);
            }

            // traverse the adjacencyList to compute the in-degree of each vertex.
            var indegree = new int[n];
            for (int node = 0; node < n; node++)
            {
                foreach (int neighbor in adjacencyList[node])
                {
                    indegree[neighbor]++;
                }
            }

            // create a queue & .enqueue() all vertices with an in-degree == 0.
            var queue = new Queue<int>();
            for (int i = 0; i < n; i++)
            {
                if (indegree[i] == 0)
                {
                    queue.Enqueue(i);
                }
            }

            int count = 0;
            var topSort = new List<int>();

            // one-by-one .dequeue() all vertices with an in-degree == 0 from the queue & .enqueue() any adjacent vertex who's in-degree becomes 0.
            while (queue.Count > 0)
            {
                int currentNode = queue.Dequeue();
                topSort.Add(currentNode);

                foreach (int neighbor in adjacencyList[currentNode])
                {
                    // if in-degree becomes 0, add it to the queue.
                    indegree[neighbor] -= 1;
                    
                    if (indegree[neighbor] == 0)
                    {
                        queue.Enqueue(neighbor);
                    }
                }

                count++;
            }

            if (count != n)
            {
                // Cycle has been detected.
            }

            return topSort;
        }
    }
}
