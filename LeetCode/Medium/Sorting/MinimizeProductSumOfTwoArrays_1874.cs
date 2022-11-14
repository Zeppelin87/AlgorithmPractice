namespace AlgorithmPractice.LeetCode.Medium.Sorting
{
    public class MinimizeProductSumOfTwoArrays_1874
    {
        public static void Run()
        {
            int[] nums1 = new int[] { 5, 3, 4, 2 };
            int[] nums2 = new int[] { 4, 2, 2, 5 };

            // Time Complexity: O(n log n)
            //  - each sort of nums1 & nums2 takes O(n log n) time.
            //  - we then iterate over nums1[] & nums2[], which takes O(n) time.
            //  - so the overall time complexity is O(n log n).

            // Space Complexity: O(n).
            //  - extra space is used to sort nums1[] & nums2[] in place.

            var result = Solution_SortBothArrays(nums1, nums2);

            // Time Complexity: O(n log n)
            //  - creating the nums2[] max heap takes O(n log n).
            //  - pushing each element onto the heap takes O(n) w/ the heapify method.
            //  - popping each element from the PQ takes O(n log n) time to pop 'n' elements.
            //  - so the overall time complexity is O(n log n).

            // Space Complexity: O(n)
            //  - initializing the PQ to store elements from nums2[] takes O(n) space.
            //  - extra space is used to sort nums1[] in place, which is O(n).
            //  - so the overall space complexity == O(n).

            var res2 = Solution_PriorityQueue(nums1, nums2);

            // NOTE: We could use 'counting sort' due to the '1 <= nums1[i], nums2[i] <= 100' constraint.
            // Time Complexity: O(n + k)
            // Space Complexity: O(k)
        }

        private static int Solution_SortBothArrays(int[] nums1, int[] nums2)
        {
            // O(n log n)
            Array.Sort(nums1);
            // O(n log n)
            Array.Sort(nums2, (x, y) =>
            {
                return y - x;
            });

            int sum = 0;

            // O(n)
            for (int i = 0; i < nums1.Length; i++)
            {
                sum += nums1[i] * nums2[i];
            }

            return sum; // Total Time Complexity: O(n log n)
        }

        private static int Solution_PriorityQueue(int[] nums1, int[] nums2)
        {
            // Sort nums1[]: O(n log n).
            Array.Sort(nums1);

            // Keep nums2[] as is, but store all elements from nums2[] in a PriorityQueue.
            //  - this allows us to get the elements from nums2[] in sorted order without actually 'sorting' nums2[].
            var priorityQueue = new PriorityQueue<int, int>(new NumsComparer());

            // O(n)
            for (int i = 0; i < nums2.Length; i++)
            {
                priorityQueue.Enqueue(nums2[i], nums2[i]);
            }

            int sum = 0;

            // O(n)
            for (int i = 0; i < nums1.Length; i++)
            {
                sum += nums1[i] * priorityQueue.Dequeue();
            }

            return sum;
        }
    }

    public class NumsComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return y - x;
        }
    }
}
