namespace AlgorithmPractice.LeetCode.Easy.Sorting
{
    public static class MaximumUnitsOnATruck_1710
    {
        public static void Run()
        {
            // boxTypes[i] = [numberOfBoxes, numberOfUnitsPerBox];

            int truckSize = 35;

            int[][] boxTypes = new int[][]
            { 
                //new int[] { 1, 3},
                //new int[] { 2, 2},
                //new int[] { 3, 1}
                new int[] { 1, 3},
                new int[] { 5, 5},
                new int[] { 2, 5},
                new int[] { 4, 2},
                new int[] { 4, 1},
                new int[] { 3, 1},
                new int[] { 2, 2},
                new int[] { 1, 3},
                new int[] { 2, 5},
                new int[] { 3, 2}
            };

            // Steps:
            //  1. Create a PriorityQueue<int[], int[]>() that sorts the int[] arrays by numberOfUnitsPerBox
            PriorityQueue<int[], int[]> priorityQueue = new PriorityQueue<int[], int[]>(new BoxComparer());

            for (int i = 0; i < boxTypes.Length; i++)
            {
                priorityQueue.Enqueue(boxTypes[i], boxTypes[i]);
            }


            int units = 0;
            int boxCount = 0;
            int[] boxType = new int[1];

            while (boxCount < truckSize && priorityQueue.Count > 0)
            {
                boxType = priorityQueue.Dequeue();

                if (truckSize - (boxCount + boxType[0]) >= 0)
                {
                    boxCount += boxType[0];
                    units += boxType[0] * boxType[1];
                }
                else
                {
                    int remainingBoxes = truckSize - boxCount;
                    units += remainingBoxes * boxType[1];
                    break;
                }
            }
        }
    }

    public class BoxComparer : IComparer<int[]>
    {
        public int Compare(int[] x, int[] y)
        {
            return y[1] - x[1];
        }
    }
}
