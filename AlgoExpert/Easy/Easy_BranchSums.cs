namespace AlgorithmPractice.AlgoExpert.Easy
{
    public static class Easy_BranchSums
    {
        public static void Run()
        {
            // Time Complexity: O(n) -- Linear.
            // Space Complexity: O(n) - Linear.
        }

        //private static List<int> Solution_BranchSums(BinaryTree root)
        //{
        //var sums = new List<int>();
        //CalculateBranchSums(root, 0, sums);

        //return sums;
        //}

        //private static void CalculateBranchSums(BinaryTree node, int runningSum, List<int> sums)
        //{
        //if (node == null)
        //{
        //    return;
        //}

        //int newRunningSum = runningSum + node.value;
        //if (node.left == null && node.right == null)
        //{
        //    sums.Add(newRunningSum);
        //    return;
        //}

        //CalculateBranchSums(node.left, newRunningSum, sums);
        //CalculateBranchSums(node.right, newRunningSum, sums);
        //}
    }

    //public class BinaryTree
    //{
    //    public int value { get; set; }
    //    public BinaryTree left { get; set; }
    //    public BinaryTree right { get; set; }

    //    public BinaryTree(int value)
    //    {
    //        this.value = value;
    //        this.left = null;
    //        this.right = null;
    //    }
    //}
}
