namespace AlgorithmPractice.Algorithms.Graphs.Dijkstra
{
    public static class LeetCode_Medium_PathWithMaxProbability_1514
    {
        public static void Run()
        {
            int[][] edges = {
                //new int[] { 0, 1 },
                //new int[] { 1, 2 },
                //new int[] { 0, 2 },

                //new int[] { 0, 1 },
                //new int[] { 1, 2 },
                //new int[] { 0, 2 },

                //new int[] { 0, 1 },

                new int[] { 1, 4 },
                new int[] { 2, 4 },
                new int[] { 0, 4 },
                new int[] { 0, 3 },
                new int[] { 0, 2 },
                new int[] { 2, 3 },
            };

            int n = 5;
            int start = 3;
            int end = 4;
            double[] succProb = { 0.37, 0.17, 0.93, 0.23, 0.39, 0.04 };

            // O((n + e) * log(e)) time complexity | O(n + e) space compelxity.
            // Where: 'n' is the number of nodes & 'e' is the total number of edges.
            double result = Solution(n, edges, succProb, start, end); 
        }

        private static double Solution(int n, int[][] edges, double[] succProb, int start, int end)
        {
            // Create adjacency list.
            var adjacencyList = new Dictionary<double, List<double[]>>();
            for (double i = 0; i < n + 1; i++)
            {
                adjacencyList.Add(i, new List<double[]>());
            }

            for (int i = 0; i < edges.Length; i++)
            {
                double src = edges[i][0];
                double dst = edges[i][1];
                double probability = succProb[i];

                adjacencyList[src].Add(new double[] { dst, probability });
                adjacencyList[dst].Add(new double[] { src, probability });
            }

            // Create shortestPathMap & PriorityQueue.
            var shortestPathMap = new Dictionary<double, double>();
            var maxHeap = new PriorityQueue<double[], double>(new ProbabilityComparer());

            maxHeap.Enqueue(new double[] { start, 0 }, 0);

            // Iterate thru PriorityQueue.
            while (maxHeap.Count > 0)
            {
                double[] current = maxHeap.Dequeue();
                double node = current[0];
                double prob = current[1];

                if (shortestPathMap.ContainsKey(node))
                {
                    continue;
                }

                shortestPathMap.Add(node, prob);

                foreach (double[] neighbor in adjacencyList[node])
                {
                    double neighborNode = neighbor[0];
                    double neighborProb = neighbor[1];

                    double totalProb = 0;
                    if (prob == 0)
                    {
                        totalProb = neighborProb;
                    }
                    else
                    {
                        totalProb = prob * neighborProb;
                    }

                    if (!shortestPathMap.ContainsKey(neighborNode))
                    {
                        maxHeap.Enqueue(new double[] { neighborNode, totalProb }, totalProb);
                    }
                }
            }

            return shortestPathMap.ContainsKey(end) ? shortestPathMap[end] : 0;
        }
    }

    public class ProbabilityComparer : IComparer<double>
    {
        public int Compare(double x, double y)
        {
            return y.CompareTo(x);
        }
    }
}
