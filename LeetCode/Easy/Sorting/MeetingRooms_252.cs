namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MeetingRooms_252
    {
        public static void Run()
        {
            int[][] intervals = new int[3][]
            {
                //new int[] { 0, 30},
                //new int[] { 5, 10},
                //new int[] { 15, 20 }
                //new int[] { 0, 30},
                //new int[] { 60, 240},
                //new int[] { 90, 120 }
                //new int[] { 9, 10},
                //new int[] { 4, 9},
                //new int[] { 4, 17 }
                new int[] { 6, 10},
                new int[] { 13, 14},
                new int[] { 12, 14 }
                //new int[] { 7, 10},
                //new int[] { 2, 4 }
            };

            var result = Solution(intervals);
        }

        private static bool Solution(int[][] intervals)
        {
            // If meeting1 && meeting2 start at the same time -> return false;
            // If meeting2 starts before meeeting1 ends -> return false;

            for (int i = 0; i < intervals.Length; i++)
            {
                int start = intervals[i][0];
                int end = intervals[i][1];

                for (int j = i + 1; j < intervals.Length; j++)
                {
                    int meeting2Start = intervals[j][0];
                    int meeting2End = intervals[j][1];

                    if (start >= meeting2Start && start < meeting2End)
                    {
                        return false;
                    }
                    else if (meeting2Start >= start && meeting2Start < end)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
