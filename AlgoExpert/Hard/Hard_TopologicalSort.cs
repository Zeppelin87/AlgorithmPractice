namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_TopologicalSort
    {
        public static void Run()
        {
            List<int> jobs = new List<int>() { 1, 2, 3, 4 };
            List<int[]> deps = new List<int[]>()
            {
                new int[] { 1, 2 },
                new int[] { 1, 3 },
                new int[] { 3, 2 },
                new int[] { 4, 2 },
                new int[] { 4, 3 },
            };

            // O(j + d) time complexity | O(j + d) space complexity.
            // Where: 'j' is the length of the input array jobs[] & 'd' is the size of the input array dpes[].
            var result = Solution(jobs, deps);
        }

        private static List<int> Solution(List<int> jobs, List<int[]> deps)
        {
            JobGraph jobGraph = CreateJobGraph(jobs, deps);
            return GetOrderedJobs(jobGraph);
        }

        private static JobGraph CreateJobGraph(List<int> jobs, List<int[]> deps)
        {
            var graph = new JobGraph(jobs);
            foreach (int[] dep in deps)
            {
                graph.AddDep(dep[0], dep[1]);
            }

            return graph;
        }

        private static List<int> GetOrderedJobs(JobGraph graph)
        {
            var orderedJobs = new List<int>();
            var nodesWithNotPrereqs = new List<JobNode>();
            foreach (JobNode node in graph.nodes)
            {
                if (node.NumOfPrereqs == 0)
                {
                    nodesWithNotPrereqs.Add(node);
                }
            }

            while (nodesWithNotPrereqs.Count > 0)
            {
                JobNode node = nodesWithNotPrereqs[nodesWithNotPrereqs.Count - 1];
                nodesWithNotPrereqs.RemoveAt(nodesWithNotPrereqs.Count - 1);
                orderedJobs.Add(node.Job);
                RemoveDeps(node, nodesWithNotPrereqs);
            }

            bool graphHasEdges = false;
            foreach (JobNode node in graph.nodes)
            {
                if (node.NumOfPrereqs > 0)
                {
                    graphHasEdges = true;
                }
            }

            return graphHasEdges ? new List<int>() : orderedJobs;
        }

        private static void RemoveDeps(JobNode node, List<JobNode> nodesWithNoPrereqs)
        {
            while (node.Deps.Count > 0)
            {
                JobNode dep = node.Deps[node.Deps.Count - 1];
                node.Deps.RemoveAt(node.Deps.Count - 1);
                dep.NumOfPrereqs--;
                if (dep.NumOfPrereqs == 0)
                {
                    nodesWithNoPrereqs.Add(dep);
                }
            }
        }
    }

    public class JobGraph
    {
        public List<JobNode> nodes;
        public Dictionary<int, JobNode> graph;

        public JobGraph(List<int> jobs)
        {
            nodes = new List<JobNode>();
            graph = new Dictionary<int, JobNode>();
            foreach (int job in jobs)
            {
                AddNode(job);
            }
        }

        public void AddDep(int job, int dep)
        {
            JobNode jobNode = GetNode(job);
            JobNode depNode = GetNode(dep);

            jobNode.Deps.Add(depNode);
            depNode.NumOfPrereqs++;
        }

        public void AddNode(int job)
        {
            graph.Add(job, new JobNode(job));
            nodes.Add(graph[job]);
        }

        public JobNode GetNode(int job)
        {
            if (!graph.ContainsKey(job))
            {
                AddNode(job);
            }

            return graph[job];
        }
    }

    public class JobNode
    {
        public int Job;
        public List<JobNode> Deps;
        public int NumOfPrereqs;

        public JobNode(int job)
        {
            this.Job = job;
            Deps = new List<JobNode>();
            NumOfPrereqs = 0;
        }
    }
}
