namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_MergeOverlappingIntervals
    {
        public static void Run()
        {
            int[][] intervals = new int[][] {
                //new int[] {1,2},
                //new int[] {3,5},
                //new int[] {4,7},
                //new int[] {6,8},
                //new int[] {9,10},
                //new int[] {1, 10},
                //new int[] {10, 20},
                //new int[] {20, 30},
                //new int[] {30, 40},
                //new int[] {40, 50},
                //new int[] {50, 60},
                //new int[] {60, 70},
                //new int[] {70, 80},
                //new int[] {80, 90},
                //new int[] {90, 100},
                new int[] {89, 90},
                new int[] {-10, 20},
                new int[] {-50, 0},
                new int[] {70, 90},
                new int[] {90, 91},
                new int[] {90, 95},
                //new int[] {43, 49},
                //new int[] {9, 12},
                //new int[] {12, 54},
                //new int[] {45, 90},
                //new int[] {91, 93},
                //new int[] { 100, 105},
                //new int[] { 1, 104}
            };

            // Time Complexity: O(n log(n)) -- Linear (where 'n' is the input size of intervals[]).
            // Space Complexity: O(n) -- Linear.
            //var result = Solution(intervals);

            // Time Complexity: O(n log(n)) -- Linear (where 'n' is the input size of intervals[]).
            // Space Complexity: O(n) -- Linear.
            var result2 = Solution_Two(intervals);
        }

        private static int[][] Solution_Two(int[][] intervals)
        {
            int[][] sortedIntervals = intervals.Clone() as int[][];

            Array.Sort(sortedIntervals, (x, y) =>
            {
                return x[0].CompareTo(y[0]);
            });

            List<int[]> mergedIntervals = new List<int[]>();
            int[] currentInterval = sortedIntervals[0];
            mergedIntervals.Add(currentInterval);

            foreach (var nextInterval in sortedIntervals)
            {
                int currentIntervalEnd = currentInterval[1];
                int nextIntervalStart = nextInterval[0];
                int nextIntervalEnd = nextInterval[1];

                if (currentIntervalEnd >= nextIntervalStart)
                {
                    currentInterval[1] = Math.Max(currentIntervalEnd, nextIntervalEnd);
                }
                else
                {
                    currentInterval = nextInterval;
                    mergedIntervals.Add(currentInterval);
                }
            }

            return mergedIntervals.ToArray();
        }

        private static int[][] Solution(int[][] intervals)
        {
            intervals = intervals.ToArray();

            Array.Sort(intervals, (x, y) =>
            {
                return x[0].CompareTo(y[0]);
            });

            var result = new List<int[]>();
            for (int i = 0; i < intervals.Length - 1; i++)
            {
                if (intervals[i][0] <= intervals[i + 1][0] && intervals[i][1] >= intervals[i + 1][0] && intervals[i][1] >= intervals[i + 1][1])
                {
                    intervals[i + 1][0] = intervals[i][0];
                    intervals[i + 1][1] = intervals[i][1];
                    continue;
                }

                bool overLapping = intervals[i][1] >= intervals[i + 1][0] && intervals[i][1] <= intervals[i + 1][1];

                if (i == intervals.Length - 2)
                {
                    if (overLapping)
                    {
                        intervals[i + 1][0] = intervals[i][0];
                        result.Add(new int[] { intervals[i + 1][0], intervals[i + 1][1] });
                    }
                    else if (!overLapping)
                    {
                        result.Add(new int[] { intervals[i][0], intervals[i][1] });
                        result.Add(new int[] { intervals[i + 1][0], intervals[i + 1][1] });
                    }
                }
                else
                {
                    if (overLapping)
                    {
                        intervals[i + 1][0] = intervals[i][0];
                    }
                    else if (!overLapping)
                    {
                        result.Add(new int[] { intervals[i][0], intervals[i][1] });
                    }
                }
            }

            if (result.Count == 0)
            {
                result.Add(new int[] { intervals[intervals.Length - 1][0], intervals[intervals.Length - 1][1] });
            }

            return result.ToArray();
        }
    }
}
