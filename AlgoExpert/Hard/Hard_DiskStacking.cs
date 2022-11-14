namespace AlgorithmPractice.AlgoExpert.Hard
{
    public static class Hard_DiskStacking
    {
        public static void Run()
        {
            List<int[]> disks = new List<int[]>()
            {
                new int[] { 2, 1, 2 },
                new int[] { 3, 2, 3 },
                new int[] { 2, 2, 8 },
                new int[] { 2, 3, 4 },
                new int[] { 1, 3, 1 },
                new int[] { 4, 4, 5 },
            };

            // O(n^2) time complexity | O(n) space complexity.
            // Where: 'n' is the size of the input list 'disks'.
            var result = Solution(disks);
        }

        private static List<int[]> Solution(List<int[]> disks)
        {
            disks.Sort((disk1, disk2) => disk1[2].CompareTo(disk2[2]));
            int[] heights = new int[disks.Count];

            for (int i = 0; i < disks.Count; i++)
            {
                heights[i] = disks[i][2];
            }

            int[] sequences = new int[disks.Count];
            for (int i = 0; i < disks.Count; i++)
            {
                sequences[i] = int.MinValue;
            }

            int maxHeightIdx = 0;
            for (int i = 1; i < disks.Count; i++)
            {
                int[] currentDisk = disks[i];

                for (int j = 0; j < i; j++)
                {
                    int[] otherDisk = disks[j];
                    if (AreValidDimensions(otherDisk, currentDisk))
                    {
                        if (heights[i] <= currentDisk[2] + heights[j])
                        {
                            heights[i] = currentDisk[2] + heights[j];
                            sequences[i] = j;
                        }
                    }
                }

                if (heights[i] >= heights[maxHeightIdx])
                {
                    maxHeightIdx = i;
                }
            }

            return BuildSequence(disks, sequences, maxHeightIdx);
        }

        private static bool AreValidDimensions(int[] o, int[] c)
        {
            return o[0] < c[0] && o[1] < c[1] && o[2] < c[2];
        }

        private static List<int[]> BuildSequence(List<int[]> array, int[] sequences, int currentIdx)
        {
            var sequence = new List<int[]>();

            while (currentIdx != int.MinValue)
            {
                sequence.Insert(0, array[currentIdx]);
                currentIdx = sequences[currentIdx];
            }

            return sequence;
        }
    }
}
