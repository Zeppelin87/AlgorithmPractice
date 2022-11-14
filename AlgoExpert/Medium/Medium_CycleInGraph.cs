namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_CycleInGraph
    {
        public const int WHITE = 0;
        public const int GREY = 1;
        public const int BLACK = 3;

        public static void Run()
        {
            //int[][] edges = new int[][] {
            //    new int[] {1, 3},
            //    new int[] {2, 3, 4},
            //    new int[] {0},
            //    new int[] {},
            //    new int[] {2, 5},
            //    new int[] {}
            //};
            int[][] edges = new int[][] {
                new int[] {1, 3},       // 0
                new int[] {2, 3, 4},    // 1
                new int[] {},           // 2
                new int[] {},           // 3
                new int[] {5},          // 4
                new int[] {}            // 5
            };

            // Time Complexity: O(v + e) -- (where 'v' is the number of vertices and 'e' is the number of edges in the graph).
            // Space Complexity: O(v).
            var result = Solution(edges);

            // Time Complexity: O(v + e) -- (where 'v' is the number of vertices and 'e' is the number of edges in the graph).
            // Space Complexity: O(v).
            //var result2 = Solution_ColorNodes(edges);
        }

        private static bool Solution_ColorNodes(int[][] edges)
        {
            int numberOfNodes = edges.Length;
            int[] colors = new int[numberOfNodes];
            Array.Fill(colors, WHITE);

            for (int node = 0; node < numberOfNodes; numberOfNodes++)
            {
                if (colors[node] != WHITE)
                {
                    continue;
                }

                bool containsCycle = TraverseAndColorNodes(edges, node, colors);
                if (containsCycle)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool TraverseAndColorNodes(int[][] edges, int node, int[] colors)
        {
            colors[node] = GREY;
            int[] neighbors = edges[node];

            foreach (int neighbor in neighbors)
            {
                int neighborColor = colors[neighbor];

                if (neighborColor == GREY)
                {
                    return true;
                }

                // Edge is a "Cross Edge" or a "Forward Edge", so we can skip it.
                if (neighborColor == BLACK)
                {
                    continue;
                }

                bool containsCycle = TraverseAndColorNodes(edges, node, colors);
            }

            colors[node] = BLACK;
            return false;
        }

        private static bool Solution(int[][] edges)
        {
            int numberOfNodes = edges.Length;
            bool[] visited = new bool[numberOfNodes];
            bool[] inStack = new bool[numberOfNodes];

            Array.Fill(visited, false);
            Array.Fill(inStack, false);

            for (int node = 0; node < numberOfNodes; node++)
            {
                if (visited[node])
                {
                    continue;
                }

                bool containsCycle = IsNodeInCycle(edges, node, visited, inStack);
                if (containsCycle)
                {
                    return true;
                }
            }

            return false;
        }

        private static bool IsNodeInCycle(int[][] edges, int node, bool[] visited, bool[] inStack)
        {
            visited[node] = true;
            inStack[node] = true;

            bool containsCycle = false;
            int[] neighbors = edges[node];

            foreach (int neighbor in neighbors)
            {
                if (!visited[neighbor])
                {
                    containsCycle = IsNodeInCycle(edges, neighbor, visited, inStack);
                }

                if (containsCycle)
                {
                    return true;
                }
                else if (inStack[neighbor])
                {
                    return true;
                }
            }

            inStack[node] = false;
            return false;
        }
    }
}
