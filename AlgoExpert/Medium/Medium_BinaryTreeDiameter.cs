namespace AlgorithmPractice.AlgoExpert.Medium
{
    public static class Medium_BinaryTreeDiameter
    {
        public static void Run()
        {
            //var root = new BinaryTree(1);
            //root.left = new BinaryTree(3);
            //root.left.left = new BinaryTree(7);
            //root.left.left.left = new BinaryTree(8);
            //root.left.left.left.left = new BinaryTree(9);
            //root.left.right = new BinaryTree(4);
            //root.left.right.right = new BinaryTree(5);
            //root.left.right.right.right = new BinaryTree(6);
            //root.right = new BinaryTree(2);

            //// Time Complexity: O(n) -- Linear (where 'n' is the number of nodes int he BinaryTree).
            //// Space Complexity: O(h) -- where 'h' is the height of the BinaryTree.
            //var result = Solution(root);
        }

        //private static int Solution(BinaryTree tree)
        //{
        //    return CalculateDiameter(tree).diameter;
        //}

        //private static TreeInfo CalculateDiameter(BinaryTree tree)
        //{
        //    if (tree == null)
        //    {
        //        return new TreeInfo(0, 0);
        //    }

        //    TreeInfo leftTreeInfo = CalculateDiameter(tree.left);
        //    TreeInfo rightTreeInfo = CalculateDiameter(tree.right);

        //    int longestPathThroughRoot = leftTreeInfo.height + rightTreeInfo.height;
        //    int maxDiameterSoFar = Math.Max(leftTreeInfo.diameter, rightTreeInfo.diameter);
        //    int currentDiameter = Math.Max(longestPathThroughRoot, maxDiameterSoFar);
        //    int currentHeight = 1 + Math.Max(leftTreeInfo.height, rightTreeInfo.height);

        //    return new TreeInfo(currentDiameter, currentHeight);
        //}
    }

    //public class BinaryTree
    //{
    //    public int value;
    //    public BinaryTree left;
    //    public BinaryTree right;

    //    public BinaryTree(int value)
    //    {
    //        this.value = value;
    //    }
    //}

    //public class TreeInfo
    //{
    //    public int diameter;
    //    public int height;

    //    public TreeInfo(int diameter, int height)
    //    {
    //        this.diameter = diameter;
    //        this.height = height;
    //    }
    //}
}
