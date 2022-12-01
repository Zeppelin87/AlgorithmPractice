namespace AlgorithmPractice.LeetCode.TwoSigma
{
    public static class Medium_MaxProductOfSplitBinaryTree_1339
    {
        private static IList<int> allSums = new List<int>();

        public static void Run()
        {
            //int[] root = { 1, 2, 3, 4, 5, 6 };
            var root = new TreeNodeForMaxProductSplit(1);
            root.left = new TreeNodeForMaxProductSplit(2);
            root.left.left = new TreeNodeForMaxProductSplit(4);
            root.left.right = new TreeNodeForMaxProductSplit(5);
            root.right = new TreeNodeForMaxProductSplit(3);
            root.right.left = new TreeNodeForMaxProductSplit(6);

            // 
            // Where: 
            var result = Solution(root);
        }

        private static int Solution(TreeNodeForMaxProductSplit root)
        {
            long treeSum = CalculateSumOf(root);
            long max = 0;

            foreach (var subTreeSum1 in allSums)
            {
                max = Math.Max(max, subTreeSum1 * (treeSum - subTreeSum1));
            }

            return (int)max % 1000000007;
        }

        private static int CalculateSumOf(TreeNodeForMaxProductSplit node)
        {
            if (node == null)
            {
                return 0;
            }

            int leftSum = CalculateSumOf(node.left);
            int rightSum = CalculateSumOf(node.right);

            int total = node.val + leftSum + rightSum;
            allSums.Add(total);

            return total;
        }
    }

    public class TreeNodeForMaxProductSplit
    {
        public int val;
        public TreeNodeForMaxProductSplit left;
        public TreeNodeForMaxProductSplit right;

        public TreeNodeForMaxProductSplit(int val = 0, TreeNodeForMaxProductSplit left = null, TreeNodeForMaxProductSplit right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
