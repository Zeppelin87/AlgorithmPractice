namespace AlgorithmPractice.Algorithms.Graphs.Topological
{
    public static class TopologicalSort
    {
        public static void Run()
        {
            // Topological Sort (aka ordering):
            //  - each edge must be directed.
            //  - guarantees source node comes before destination node in the ordering.
            //  - graph must be directed & acyclic.
            //  - graph does NOT need to be connected.
            int[][] edges = { 
                new int[] { 0, 1 },
                new int[] { 0, 2 },
                new int[] { 1, 3 },
                new int[] { 3, 5 },
                new int[] { 2, 4 },
                new int[] { 4, 5 },
            };

            int n = 6;

            var result = TopSort(edges, n);
            Log(result);

            var result2 = TopSort_CycleDetection(edges, n);
            Log(result2);
        }

        private static List<int> TopSort(int[][] edges, int n) 
        {
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

            var topSort = new List<int>();
            var visited = new HashSet<int>();
            for (int node = 0; node < n; node++)
            {
                DFS(node, adjacencyList, visited, topSort);
            }

            topSort.Reverse();
            return topSort;
        }

        private static void DFS(int node, Dictionary<int, List<int>> adjacencyList, HashSet<int> visited, List<int> topSort)
        {
            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);
            
            foreach (int neighbor in adjacencyList[node])
            {
                DFS(neighbor, adjacencyList, visited, topSort);
            }

            topSort.Add(node);
            return;
        }

        private static List<int> TopSort_CycleDetection(int[][] edges, int n)
        {
            // create adjacency list.
            var adj = new Dictionary<int, List<int>>();
            for (int i = 0; i < n; i++)
            {
                adj.Add(i, new List<int>());
            }

            foreach (int[] edge in edges)
            {
                int src = edge[0];
                int dst = edge[1];

                adj[src].Add(dst);
            }

            var visited = new bool[n];
            var inStack = new bool[n];
            var topSort = new List<int>();

            for (int node = 0; node < n; node++)
            {
                if (visited[node])
                {
                    continue;
                }

                bool containsCycle = IsNodeInCycle(adj, visited, inStack, topSort, node);
                if (containsCycle)
                {
                    return new List<int>();
                }

            }

            topSort.Reverse();
            return topSort;
        }

        private static bool IsNodeInCycle(Dictionary<int, List<int>> adj, bool[] visited, bool[] inStack, List<int> topSort, int node)
        {
            visited[node] = true;
            inStack[node] = true;

            bool containsCycle = false;
            foreach (int neighbor in adj[node])
            {
                if (!visited[neighbor])
                {
                    containsCycle = IsNodeInCycle(adj, visited, inStack, topSort, neighbor);
                }

                if (containsCycle || inStack[neighbor])
                {
                    return true;
                }
            }

            topSort.Add(node);
            inStack[node] = false;

            return false;
        }

        private static void Log(List<int> result)
        {
            var array = new List<string>();
            
            foreach (int num in result)
            {
                string letter = ConvertNumToLetter(num);
                array.Add(letter);
            }

            Extensions.SortingExtension.ConsoleLog(array);
        }

        private static string ConvertNumToLetter(int num)
        {
            switch (num)
            {
                case 0:
                    return "A";
                case 1:
                    return "B";
                case 2:
                    return "C";
                case 3:
                    return "D";
                case 4:
                    return "E";
                case 5:
                    return "F";
            }

            return "?";
        }
    }
}
