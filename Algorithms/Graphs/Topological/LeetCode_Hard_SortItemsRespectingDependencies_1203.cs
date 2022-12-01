namespace AlgorithmPractice.Algorithms.Graphs.Topological
{
    public static class LeetCode_Hard_SortItemsRespectingDependencies_1203
    {
        public static void Run()
        {
            int n = 8;
            int m = 2;
            int[] group = { -1, -1, 1, 0, 0, 1, 0, -1 };
            var beforeItems = new List<IList<int>>()
            { 
                new List<int>() { },
                new List<int>() { 6 },
                new List<int>() { 5 },
                new List<int>() { 6 },
                new List<int>() { 3, 6 },
                new List<int>() { },
                new List<int>() { },
                new List<int>() { },
            };

            // 
            // Where: 
            int[] result = Solution(n, m, group, beforeItems);
        }

        private static int[] Solution(int n, int m, int[] group, IList<IList<int>> beforeItems)
        {
            // Create group adj list.
            var groupAdjList = new Dictionary<int, List<int>>();
            var groupMap = new Dictionary<int, List<int>>();
            for (int i = -1; i < m; i++)
            {
                groupAdjList.Add(i, new List<int>());
                groupMap.Add(i, new List<int>());
            }

            // populate group adj list.
            for (int i = 0; i < group.Length; i++)
            {
                int currentGroup = group[i];
                IList<int> items = beforeItems[i];

                if (items.Count == 0)
                {
                    continue;
                }

                foreach (int item in items)
                {
                    int beforeGroup = group[item];

                    if (beforeGroup != currentGroup && !groupAdjList[beforeGroup].Contains(currentGroup))
                    {
                        groupAdjList[beforeGroup].Add(currentGroup);
                    }
                }
            }

            // DFS for group order.
            // (Reverse) groupTopSort & now you have the ordering of groups.

            // Create groupMap.
            for (int i = 0; i < group.Length; i++)
            {
                groupMap[group[i]].Add(i);
            }

            // Create item(s) adjList & DFS
            foreach (var pair in groupMap)
            {
                int currentGroup = pair.Key;
                var adjList = new Dictionary<int, List<int>>();

                foreach (int item in pair.Value)
                {
                    adjList.Add(item, new List<int>());
                    IList<int> beforeItemsForItem = beforeItems[item];

                    if (beforeItemsForItem.Count == 0)
                    {
                        continue;
                    }

                    foreach (int dst in beforeItemsForItem)
                    {
                        if (currentGroup == group[dst])
                        {
                            adjList[item].Add(dst);
                        }
                    }
                }

                //DFS(adjList);
                // Reverse DFS
            }


            return new int[] { };
        }
    }
}
